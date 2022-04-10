using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using Delta_beta;
using EasyTabs;

namespace Delta_beta.Handlers
{

    //　キーボード処理
    class KeyboardHandler : IKeyboardHandler
    {

        // ZoomLevelの定義
        private static readonly List<double> ZOOM_LEVLES = new List<double>
        { -7.604, -6.081, -3.802, -2.197, -1.578, -1.224, -0.578, 0, 0.523, 1.224, 3.069, 3.802, 5.026, 6.026, 7.604, 8.827 };

        bool IKeyboardHandler.OnKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            return false;
        }

        bool IKeyboardHandler.OnPreKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            ///---ブラウザ拡大・縮小の処理。---------------------------------------------------------------------------------------///

            if (type == KeyType.RawKeyDown)
            {
                // Ctrl + NumberPad_Add
                // Ctrl + Add
                if ((windowsKeyCode == (int)Keys.Add && (modifiers == (CefEventFlags.ControlDown | CefEventFlags.IsKeyPad))) ||
                    (windowsKeyCode == (int)Keys.Oemplus && (modifiers == (CefEventFlags.ControlDown | CefEventFlags.ShiftDown))))
                {
                    // 現在のZoomLevelを取得する
                    browser.GetZoomLevelAsync().ContinueWith((t) =>
                    {
                        // 現在のZoomLevelの次に大きなZoomLevelを求めて設定する
                        frmBrowser.zoom_index = ZOOM_LEVLES.IndexOf(t.Result);
                        frmBrowser.zoom_index = Math.Min(++frmBrowser.zoom_index, ZOOM_LEVLES.Count - 1);
                        browser.SetZoomLevel(ZOOM_LEVLES[frmBrowser.zoom_index]);
                    });
                    return true;
                }
                // Ctrl + NumberPad_Minus
                // Ctrl + Minus
                else if ((windowsKeyCode == (int)Keys.Subtract && (modifiers == (CefEventFlags.ControlDown | CefEventFlags.IsKeyPad))) ||
                    (windowsKeyCode == (int)Keys.OemMinus && (modifiers == (CefEventFlags.ControlDown | CefEventFlags.ShiftDown))))
                {
                    // 現在のZoomLevelを取得する
                    browser.GetZoomLevelAsync().ContinueWith((t) =>
                    {
                        // 現在のZoomLevelの次に小さいZoomLevelを求めて設定する
                        frmBrowser.zoom_index = ZOOM_LEVLES.IndexOf(t.Result);
                        frmBrowser.zoom_index = Math.Max(--frmBrowser.zoom_index, 0);
                        browser.SetZoomLevel(ZOOM_LEVLES[frmBrowser.zoom_index]);
                    });
                    return true;
                }
                // Ctrl + NumberPad_0
                // Ctrl + 0
                else if ((windowsKeyCode == (int)Keys.D0 && modifiers == CefEventFlags.ControlDown) ||
                    (windowsKeyCode == (int)Keys.NumPad0 && modifiers == (CefEventFlags.ControlDown | CefEventFlags.IsKeyPad)))
                {
                    // 100%の倍率に戻す
                    frmBrowser.zoom_index = 7;
                    browser.SetZoomLevel(ZOOM_LEVLES[frmBrowser.zoom_index]);
                    return true;
                }
            }

            ///---ブラウザに表示されている画面を印刷----------------------------------------------///
            // CTRL＋[P]
            if (windowsKeyCode == (int)Keys.P && modifiers == CefEventFlags.ControlDown)
            {
                // 印刷する
                browser.Print();
                return true;
            }

            if (windowsKeyCode == (int)Keys.S && modifiers == CefEventFlags.ControlDown)
            {
                //browser.PrintToPdfAsync();
            }

            ///---ブラウザバック・フォーワード・リロードのキーボードイベント----------------------///
            if (type == KeyType.RawKeyDown)
            {
                // VK_F12キー押下
                if (windowsKeyCode == (int)Keys.I && modifiers == (CefEventFlags.ControlDown|CefEventFlags.ShiftDown))
                {
                    // 開発者ツールを表示する
                    
                    browser.ShowDevTools();
                    return true;
                }
            }

            if (type == KeyType.RawKeyDown)
            {
                // ALT+VK_LEFT
                if (windowsKeyCode == (int)Keys.Left && modifiers == CefEventFlags.AltDown)
                {
                    if (browser.CanGoBack)
                    {
                        //Console.WriteLine("success");
                        // 戻る
                        browser.GoBack();
                        return true;
                    }
                }
                // ALT+VK_RIHGT
                else if (windowsKeyCode == (int)Keys.Right && modifiers == CefEventFlags.AltDown)
                {
                    if (browser.CanGoForward)
                    {
                        // 進む
                        browser.GoForward();
                        return true;
                    }
                }
                if (windowsKeyCode == (int)Keys.R && modifiers == CefEventFlags.ControlDown)
                {
                    // リロードする
                    browser.Reload();
                    return true;
                }

                if (windowsKeyCode == (int)Keys.Q && modifiers == CefEventFlags.ControlDown)
                {
                    //Cef.Shutdown();
                }

                if (windowsKeyCode == (int)Keys.O && modifiers == CefEventFlags.ControlDown)
                {
                    script script = new script();
                    script.Show();
                }

                if (windowsKeyCode == (int)Keys.N && modifiers == CefEventFlags.ControlDown)
                {
                    AppContainer container = new AppContainer();
                    //container.Tabs.Add(
                    //    new TitleBarTab(container)
                    //    {
                    //        Content = new frmBrowser
                    //        {
                    //            Text = "New Tab",

                    //        }
                    //    }
                    //);

                    

                    container.CreateControl();

                    
                    //container.SelectedTabIndex = 0;

                    TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
                    applicationContext.Start(container);
                    Application.Run(applicationContext);

                    return true;
                }
                if (windowsKeyCode == (int)Keys.W && modifiers == CefEventFlags.ControlDown)
                {
                    //Application.Exit();
                }

                // (省略)
                
            }

            

            return false;

        }

        
    }

}
