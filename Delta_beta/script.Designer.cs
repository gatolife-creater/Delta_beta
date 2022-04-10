namespace Delta_beta
{
    partial class script
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scriptBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scriptBox
            // 
            this.scriptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.scriptBox.Location = new System.Drawing.Point(52, 65);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(694, 373);
            this.scriptBox.TabIndex = 0;
            this.scriptBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "JavaScript should be here";
            // 
            // script
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scriptBox);
            this.Name = "script";
            this.Text = "script";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.script_FormClosing);
            this.Load += new System.EventHandler(this.script_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox scriptBox;
        private System.Windows.Forms.Label label1;
    }
}