namespace LB_II_1.Forms
{
    partial class Diagnostic
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
        /// 
        private void SetTextLocale(bool ENG_loc)
        {
            if (ENG_loc)
            {
                this.Text = Local.Local_ENG.ProgName + ": " + Local.Local_ENG.Diagnostic_button_name;
            }
            else
            {
                this.Text = Local.Local_RU.ProgName + ": " + Local.Local_RU.Diagnostic_button_name;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Diagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Diagnostic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Diagnostic";
            this.ResumeLayout(false);

        }

        #endregion
    }
}