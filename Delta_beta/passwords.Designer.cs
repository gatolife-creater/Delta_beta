
namespace Delta_beta
{
    partial class passwords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwords));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassiIdtextBox = new System.Windows.Forms.TextBox();
            this.ClassiPasswordtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // ClassiIdtextBox
            // 
            this.ClassiIdtextBox.Location = new System.Drawing.Point(301, 55);
            this.ClassiIdtextBox.Name = "ClassiIdtextBox";
            this.ClassiIdtextBox.Size = new System.Drawing.Size(181, 19);
            this.ClassiIdtextBox.TabIndex = 3;
            // 
            // ClassiPasswordtextBox
            // 
            this.ClassiPasswordtextBox.Location = new System.Drawing.Point(301, 109);
            this.ClassiPasswordtextBox.Name = "ClassiPasswordtextBox";
            this.ClassiPasswordtextBox.PasswordChar = '●';
            this.ClassiPasswordtextBox.Size = new System.Drawing.Size(181, 19);
            this.ClassiPasswordtextBox.TabIndex = 4;
            // 
            // passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassiPasswordtextBox);
            this.Controls.Add(this.ClassiIdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "passwords";
            this.Text = "Passwords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.passwords_FormClosing);
            this.Load += new System.EventHandler(this.passwords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClassiIdtextBox;
        private System.Windows.Forms.TextBox ClassiPasswordtextBox;
    }
}