using System;
using System.Drawing;
using System.Windows.Forms;
using EasyTabs;
using CefSharp.WinForms;
using CefSharp;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using VideoLibrary;
using System.Collections.Generic;


namespace Delta_beta
{
    public partial class frmBrowser : Form
    {
        //サイトのタイトルを記憶
        public static string title;

        public static string url;


        private static string[] adblockScripts = new string[4]{@"function removeElementsByTagNameLoose(tagName){let tags=document.getElementsByTagName('*');tagName=tagName.toUpperCase();for(let i=0;i<tags.length;i++)tags[i].tagName.includes(tagName)&&tags[i].remove()}function removeElementsByIdNameLoose(idName){let tags=document.getElementsByTagName('*');for(let i=0;i<tags.length;i++)tags[i].id.includes(idName)&&tags[i].remove()}function removeElementsByClassNameLoose(className){let tags=document.getElementsByTagName('*');for(let i=0;i<tags.length;i++)'string'==typeof tags[i].className&&tags[i].className.includes(className)&&tags[i].remove()}function removeElementsByAHrefLoose(href){let tags=document.getElementsByTagName('a');for(let i=0;i<tags.length;i++)tags[i].href.includes(href)&&tags[i].remove()}function removeElementsByImgSrcLoose(src){let tags=document.getElementsByTagName('img');for(let i=0;i<tags.length;i++)tags[i].src.includes(src)&&tags[i].remove()}function removeElementsByScriptSrcLoose(src){let tags=document.getElementsByTagName('script');for(let i=0;i<tags.length;i++)tags[i].src.includes(src)&&tags[i].remove()}function removeElementsByLinkHrefLoose(href){let tags=document.getElementsByTagName('link');for(let i=0;i<tags.length;i++)tags[i].href.includes(href)&&tags[i].remove()}function adblock(){let list=['ads','-ad-','_ad_','promote','ytag','gpt','AdImage','doubleclick.net','facebook-jssdk','ydn','rd.ane.yahoo.co.jp'];for(let i=0;i<list.length;i++)removeElementsByScriptSrcLoose(list[i]),removeElementsByClassNameLoose(list[i]),removeElementsByIdNameLoose(list[i]),removeElementsByTagNameLoose(list[i]),removeElementsByAHrefLoose(list[i]),removeElementsByLinkHrefLoose(list[i]),removeElementsByImgSrcLoose(list[i])}adblock(),setInterval(adblock,1000);",
                                             @"function deleteAd(){let e=document.querySelectorAll('iframe, div'),d=[];for(i=0;i<e.length;i++)d.push(e[i].id),(d[i].includes('google_ads_iframe_')||d[i].includes('yads'))&&e[i].remove()}document.addEventListener('DOMContentLoaded',function(){deleteAd()}),setInterval(deleteAd,100);",
                                             @"let list=`[id*='gpt'], [id='lrec'],[id*='octopus_ad'],[id='my-adsLDRB'],[id*='strm-ad'],[id*='ydn'],[src*='yads'],[src*='ydn'],[src*='yimg.jp/images/advertising'],[src*='doubleclick.net'],[src*='yads'],[src*='googleadservices.com'],[src*='google-analytics.com'],[src*='adservice.google.co.jp'],[src*='connect.facebook.net'],[src*='tpc.googlesyndication.com'],[src*='googletagmanager.com'],[src*='ads.nicovideo.jp'],[src*='amazon-adsystem.com'],[href*='rd.ane.yahoo.co.jp'],[class*='yads'],[class*='ytp-ad-image-overlay'],[class*='taxel_ad_article'],[class='adsenseArea'],[class*='gn-nad'],[class*='b_ad'],.logly-lift-ad:not(.logly-lift-article),[title *= 'Ad Content'],[title = 'Advertisement'],[aria-label *= '広告']`,
                                                   ytlist=`ytd-player-legacy-desktop-watch-ads-renderer,ytd-compact-promoted-item-renderer,ytd-promoted-sparkles-web-renderer,ytd-display-ad-renderer,ytp-ad-overlay-slot`;
                                               function adblock(e){try{if(window.location.href.includes('youtube.com')){let e=document.getElementsByClassName('ytp-ad-skip-button-text')[0];e&&e.click();let n=d.querySelectorAll(ytlist);for(i in n)n[i].remove()}else if(window.location.href.includes('nicovideo.jp')){let e=document.getElementsByTagName('video');null==e[1]||''!=e[1].src&&(e[1].src='')}let n=document.querySelectorAll(e);for(i in n)n[i].remove()}catch(e){}}adblock(list),setInterval(adblock(list),1000);",
                                               ""};
        public static string adblockScript = adblockScripts[2];

        public static string classiLoginScript = @"if(location.href=='https://auth.classi.jp/students'){let input_id = document.getElementById('classi_id');input_id.value = '"+Properties.Settings.Default.classi_id+"';let input_password = document.getElementById('password');input_password.value = '"+Properties.Settings.Default.classi_password+"';let enter_button = document.getElementsByClassName('pen-mod-btn')[0];enter_button.click();}";

        //フォーカス時にテキストを全選択するためのフラグ
        public static bool text_selct = false;

        //デフォルトで表示させるページ
        private static string homepage = "http://gatolife.starfree.jp/browser-page/index.html";

        private static string defaul_page = "gatolife.starfree.jp/";

        //デフォルトブラウザー
        private static string default_engine = "https://www.google.com/search?q=";

        //YouTubeの動画であるか判断するための文字列
        public static string youtube_video_url = "youtube.com/watch?v=";

        //YouTubeの動画のURLの種類を判別するための配列
        private static string[] pattern = new string[] { "https://www.youtube.com/watch?v=", "https://youtu.be/", "https://m.youtube.com/watch?v=" };

        //何度も通知しないようにするためのフラグ
        private static bool ad_flag = false;

        //広告のプロジェクトに参加しているクリエイターのサイトのURL
        private static string ad_page = "http://www.fhs.kanagawa-u.ac.jp/";

        //拡大率の段階（拡大率をまとめた配列の要素番号）
        public static int zoom_index = 7;

        public static bool deleteTabFlag = false;


        /// <summary>
        /// CefSharpのWebViewのインスタンス
        /// </summary>
        public ChromiumWebBrowser WebBrowser;

        public frmBrowser()
        {
            InitializeComponent();

            

            // CefSharpのWebViewを作成する。
            WebBrowser = new ChromiumWebBrowser(homepage);


            // コントロールを追加する。
            webViewContainer.Controls.Add(WebBrowser);
            WebBrowser.Dock = DockStyle.Fill;

            //---ブラウザの設定諸々-----------------------------------------------------------------///

            // javascriptを有効にする。（書かなくても有効です）
            WebBrowser.BrowserSettings.Javascript = CefState.Enabled;
            // document.execCommandでのcopy&pasteを有効にする。
            WebBrowser.BrowserSettings.JavascriptDomPaste = CefState.Enabled;

            // localStorageを有効にする。
            WebBrowser.BrowserSettings.LocalStorage = CefState.Enabled;
            //日本語に設定
            WebBrowser.BrowserSettings.AcceptLanguageList = "ja,en - US; q = 0.9,en; q = 0.8";
            WebBrowser.TitleChanged += Browser_TitleChanged;

            
            //--------------------------------------------------------------------------------------///


            

            //---ハンドラの設定---------------------------------------------------------------------///

            // キーボードハンドラを設定する
            WebBrowser.KeyboardHandler = new Handlers.KeyboardHandler();

            // ディスプレイハンドラを設定する
            WebBrowser.DisplayHandler = new Handlers.DisplayHandler();

            // リクエストハンドラを設定する
            WebBrowser.RequestHandler = new Handlers.RequestHandler();

            //WebBrowser.ResourceRequestHandlerFactory=new Handlers.ResourceRequestHandlerFactory();

            //ダウンロードハンドラを設定する
            WebBrowser.DownloadHandler = new Handlers.DownloadHandler();

            WebBrowser.LoadHandler = new Handlers.LoadHandler();

            
            //--------------------------------------------------------------------------------------/// 

            timer1.Start();

            
        }




        //---タブの処理-----------------------------------------------------------------------------///
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }

        }

        //------------------------------------------------------------------------------------------///

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            title = e.Title; // メンバー変数に設定
            Invoke(new Action(() => Text = title)); // Form1のタイトルバーに設定
        }


        public static frmBrowser getMainFrame(IBrowser browser)
        {
            // browserのウィンドウハンドル
            IntPtr hWnd = browser.GetHost().GetWindowHandle();

            // browserの親コントロール(webViewContainer)
            Control container = Control.FromHandle(GetParent(hWnd));

            if (container != null && container.TopLevelControl is frmBrowser)
            {
                // コントロールのトップレベルのコントロールを取得して返却する
                return (frmBrowser)container.TopLevelControl;
            }
            else
            {
                return null;
            }
        }
        // Win32のGetParent
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        private static extern IntPtr GetParent(IntPtr hWnd);



        //---左向きの矢印のアイコンのボタンをクリックすると、ブラウザバックされる-------------------///
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoBack)
            {
                // 戻る
                WebBrowser.Back();

            }
        }
        //------------------------------------------------------------------------------------------///

        //---右向きの矢印のアイコンのボタンをクリックすると、ブラウザフォーワードされる-------------///
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoForward)
            {
                // 進む
                WebBrowser.Forward();
            }
        }
        //------------------------------------------------------------------------------------------///

        //---リロードの矢印アイコンのボタンをクリックすると、ブラウザリロードされる-----------------///
        private void reloadBtn_Click(object sender, EventArgs e)
        {
            // 更新する
            WebBrowser.Reload();
        }
        //------------------------------------------------------------------------------------------///


        //---アドレスバーにURLを入力した後、Enterキーを押した後の処理。-----------------------------///
        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // アドレスバーに入力があれば、ロードする
                if (!String.IsNullOrEmpty(addressBar.Text))
                {
                    //addressBar.Text = addressBar.Text.Trim();
                    // アドレスバーに入力されているURLをロードする。
                    if (IsUrl(addressBar.Text))
                    {
                        WebBrowser.Load(addressBar.Text);
                    }
                    else
                    {
                        WebBrowser.Load(default_engine + addressBar.Text);
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------------///


        //---一定時間ごとに更新する事項-------------------------------------------------------------///
        private void timer1_Tick(object sender, EventArgs e)
        {

            //---アドレスバーがフォーカスされたときの処理--------------------------------------------------///
            if (addressBar.Focused)
            {
                borderPanel.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (!addressBar.Focused)
            {
                borderPanel.BackColor = Color.FromArgb(224, 224, 224);
            }
            //---------------------------------------------------------------------------------------------///


            //---アドレスバーのurlと現在アクセスしているサイトが異なっており、かつアドレスバーのフォーカス-///
            //---がないとき、の処理------------------------------------------------------------------------///
            if (addressBar.Text != WebBrowser.Address && addressBar.Focused == false)
            {
               displaySiteInformation();
            }


            //---アドレスバーに表示されているurlを判別-----------------------------------------------------///
            if (addressBar.Text.Contains(youtube_video_url))
            { 
                downloadBtn.Enabled = true;
                downloadBtn.Visible = true;
                anonymousBtn.Enabled = true;
                anonymousBtn.Visible = true;
            }
            else if (!addressBar.Text.Contains(youtube_video_url))
            {
                downloadBtn.Enabled = false;
                downloadBtn.Visible = false;
                anonymousBtn.Enabled = false;
                anonymousBtn.Visible = false;
            }

            if (addressBar.Text == ad_page)
            {
                tipBtn.Enabled = true;
                tipBtn.Visible = true;
                if (!ad_flag)
                {
                    ad_flag = true;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Proのすべてが目を覚ます。";
                    notifyIcon1.BalloonTipText = "13インチMacBook ProがApple M1チップを搭載。" +
                        "その速さとパワーは信じられないほどです。" +
                        "CPU性能は最大2.8倍。" +
                        "グラフィックス処理速度は最大5倍。" +
                        "Appleで最も先進的なNeural Engineにより、" +
                        "機械学習の速さは最大11倍。" +
                        "バッテリー駆動時間は、" +
                        "どんなMacよりも長い最大20時間。" +
                        "Appleで最も人気が高いプロ向けノートブックが、" +
                        "スケールの違う能力を手に入れました。";
                    notifyIcon1.ShowBalloonTip(3000);
                }
            }
            else if (addressBar.Text != ad_page)
            {
                tipBtn.Enabled = false;
                tipBtn.Visible = false;
            }

            //---------------------------------------------------------------------------------------------///

            changeWindowSize();

            if (zoom_index != 7)
            {
                testBox.Visible = true;
            }
            else if (zoom_index == 7)
            {
                testBox.Visible = false;
            }
        }
        //------------------------------------------------------------------------------------------///


        //---YouTubeのアイコンのあるボタン（ブックマークのつもり）をクリックすると------------------///
        //---youtube.comにジャンプ------------------------------------------------------------------///
        private void YouTubeBtn_Click(object sender, EventArgs e)
        {
            WebBrowser.Load("youtube.com");
        }
        //------------------------------------------------------------------------------------------///


        //---ダウンロードのアイコンのボタンをクリックすると、---------------------------------------///
        //videolibraryを用いてYouTubeの動画をダウンロード-------------------------------------------///
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            downloadYouTube();
            //url=addressBar.Text.Trim();
            //DownloadYouTube downloadYouTube=new DownloadYouTube();
            //downloadYouTube.Show();

        }
        //------------------------------------------------------------------------------------------///

        private void downloadYouTube()
        {
            if (addressBar.Text.Contains(youtube_video_url))
            {
                
                var video = YouTube.Default.GetVideo(addressBar.Text.Trim());
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = video.FullName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, video.GetBytes());
                }
            }
        }
        


        //---アドレスバーをクリックした際にテキストを全選択状態にする-------------------------------///
        private void addressBar_Click(object sender, EventArgs e)
        {
            if (text_selct)
            {
                text_selct = false;
            }
            else if (!text_selct)
            {
                text_selct = true;
                addressBar.SelectAll();
            }
        }
        //------------------------------------------------------------------------------------------///


        //---目に斜線が引かれたアイコンのボタンをクリックすると、-----------------------------------///
        //nocookieのYoutubeの動画のURLにアクセス----------------------------------------------------///
        private void anonymousBtn_Click(object sender, EventArgs e)
        {
            addressBar.Text = change_to_nocookie_url(get_video_id(addressBar.Text));
            WebBrowser.Load(addressBar.Text);
        }
        //------------------------------------------------------------------------------------------///


        //---Youtubeの動画から、動画のIDを抽出する--------------------------------------------------///
        public string get_video_id(string src)
        {

            if (src.Contains(pattern[0]))
            {
                src = src.Replace(pattern[0], "").Trim();

            }
            else if (src.Contains(pattern[1]))
            {
                src = src.Replace(pattern[1], "").Trim();

            }
            else if (src.Contains(pattern[2]))
            {
                src = src.Replace(pattern[2], "").Trim();

            }
            if (src.Contains("&list="))
            {
                src = src.Replace("&list=", "?list=").Trim();
            }
            return src;
        }
        //------------------------------------------------------------------------------------------///


        //---Youtubeの動画のIDを使って、nocookieの動画のURLを取得する-------------------------------///
        public string change_to_nocookie_url(string id)
        {
            id = "https://www.youtube-nocookie.com/embed/" + id;
            return id;
        }
        //------------------------------------------------------------------------------------------///

        public static bool IsUrl(string URL)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(URL);
        }


        //---白の星型のアイコンのボタンをクリックすると、-------------------------------------------///
        //---黒の星型のアイコンのボタンに変化する。-------------------------------------------------///
        //---ブックマーク用のボタン。---------------------------------------------------------------///
        private void starBtn_Click(object sender, EventArgs e)
        {
            //if (starBtn.Image == Properties.Resources.star)
            //{
            starBtn.Image = Properties.Resources.star__1_;
            //}
            //else if (starBtn.Image == global::Delta_beta.Properties.Resources.star__1_)
            //{
            //    starBtn.Image = global::Delta_beta.Properties.Resources.star;
            //}

            ///---何故か表示されている画像に応じて処理を変えることができない---------------///

        }
        //------------------------------------------------------------------------------------------///


        //---広告の通知をクリックすると、広告を出した会社のサイトに誘導する-------------------------///
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            WebBrowser.Load("https://www.apple.com/jp/macbook-pro-13/");
        }
        //----------------------------------------------------------------- -------------------------///

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(downloadBtn, "この動画をダウンロード");
            toolTip1.SetToolTip(anonymousBtn, "この動画を匿名で視聴");
            toolTip1.SetToolTip(tipBtn, "このクリエイターを支援する");
            toolTip1.SetToolTip(starBtn, "ブックマーク");
            toolTip1.SetToolTip(settingBtn, "設定");
        } 

        public void changeWindowSize()
        {
            switch (zoom_index)
            {
                case 0:
                    testBox.Text = "25%";
                    break;
                case 1:
                    testBox.Text = "33%";
                    break;
                case 2:
                    testBox.Text = "50%";
                    break;
                case 3:
                    testBox.Text = "67%";
                    break;
                case 4:
                    testBox.Text = "75%";
                    break;
                case 5:
                    testBox.Text = "80%";
                    break;
                case 6:
                    testBox.Text = "90%";
                    break;
                case 7:
                    testBox.Text = "100%";
                    break;
                case 8:
                    testBox.Text = "110%";
                    break;
                case 9:
                    testBox.Text = "125%";
                    break;
                case 10:
                    testBox.Text = "175%";
                    break;
                case 11:
                    testBox.Text = "200%";
                    break;
                case 12:
                    testBox.Text = "250%";
                    break;
                case 13:
                    testBox.Text = "300%";
                    break;
                case 14:
                    testBox.Text = "400%";
                    break;
                case 15:
                    testBox.Text = "500%";
                    break;

                default:
                    testBox.Text = "100%";
                    break;
            }
        }
        public void displaySiteInformation()
        {
            if (!WebBrowser.Address.Contains(defaul_page))
            {
                addressBar.Text = WebBrowser.Address;
                if (addressBar.Text.Contains("https://") || WebBrowser.Address == homepage)
                {
                    pictureBox1.Image = Properties.Resources.カギアイコン__2_;
                }
                else if (!addressBar.Text.Contains("https://"))
                {
                    pictureBox1.Image = Properties.Resources.注意マークのフリーアイコン;
                }
            }
            else if (WebBrowser.Address.Contains(defaul_page))
            {
                addressBar.Text = "";

            }
        }
        public void updateAddressBar(String url)
        {
            this.addressBar.Text = url;
        }

        public void updateFavicon(String path, String mimeType)
        {
            try
            {
                // MIME-Typeに応じて、Iconオブジェクトを作成する。
                Icon icon = null;
                switch (mimeType.ToLower())
                {
                    // pngとgifの場合
                    case "image/png":
                    case "image/gif":
                        Bitmap bitmap = new Bitmap(Image.FromFile(path));
                        icon = Icon.FromHandle(bitmap.GetHicon());
                        break;
                    // iconの場合
                    case "image/vnd.microsoft.icon":
                    case "image/x-icon":
                        icon = Icon.ExtractAssociatedIcon(path);
                        break;
                    default:
                        break;
                }

                // ファビコンを表示する
                if (icon != null)
                {
                    this.Icon = icon;
                }

                // FVICONファイルを削除する。
                System.IO.File.Delete(path);
            }
            catch
            {
            }
        }
        public List<String> Favicons { get; } = new List<string>();

        private void borderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            //setting setting = new setting();
            //setting.Show();
            if (!settingPanel.Visible)
            {
                settingPanel.Enabled = true;
                settingPanel.Visible = true;
            }
            else if (settingPanel.Visible)
            {
                settingPanel.Enabled = false;
                settingPanel.Visible = false;
            }
            
        }

        private void adfreeCheckedChanged(object sender, EventArgs e)
        {
            if (strongBlockRadio.Checked)
            {
                adblockScript = adblockScripts[0];
            }
            else if (weakBlockRadio.Checked)
            {
                adblockScript = adblockScripts[1];
            }
            else if (weakBlockRadio.Checked)
            {
                adblockScript = adblockScripts[2];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwords passwords = new passwords();
            passwords.Show();
        }

        private void ClassiBtn_Click(object sender, EventArgs e)
        {
            WebBrowser.Load("https://auth.classi.jp/students");
        }
    }
}
