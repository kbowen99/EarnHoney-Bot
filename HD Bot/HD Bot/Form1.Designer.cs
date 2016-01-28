namespace HD_Bot
{
    partial class Frm_Honey
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
            this.components = new System.ComponentModel.Container();
            this.Tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.Web_Browser = new System.Windows.Forms.WebBrowser();
            this.txt_Refresh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tmr_Refresh
            // 
            this.Tmr_Refresh.Enabled = true;
            this.Tmr_Refresh.Interval = 1800000;
            this.Tmr_Refresh.Tick += new System.EventHandler(this.Tmr_Refresh_Tick);
            // 
            // Web_Browser
            // 
            this.Web_Browser.Location = new System.Drawing.Point(12, 38);
            this.Web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_Browser.Name = "Web_Browser";
            this.Web_Browser.ScriptErrorsSuppressed = true;
            this.Web_Browser.Size = new System.Drawing.Size(1135, 353);
            this.Web_Browser.TabIndex = 0;
            // 
            // txt_Refresh
            // 
            this.txt_Refresh.Location = new System.Drawing.Point(12, 12);
            this.txt_Refresh.Name = "txt_Refresh";
            this.txt_Refresh.Size = new System.Drawing.Size(1135, 20);
            this.txt_Refresh.TabIndex = 1;
            // 
            // Frm_Honey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 403);
            this.Controls.Add(this.txt_Refresh);
            this.Controls.Add(this.Web_Browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Honey";
            this.Text = "EarnHoney Bot";
            this.Load += new System.EventHandler(this.Frm_Honey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr_Refresh;
        private System.Windows.Forms.WebBrowser Web_Browser;
        private System.Windows.Forms.TextBox txt_Refresh;
    }
}

