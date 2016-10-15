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
            this.Rheum_checkBox = new System.Windows.Forms.CheckBox();
            this.FeverTemperature_checkBox = new System.Windows.Forms.CheckBox();
            this.JointPain_checkBox = new System.Windows.Forms.CheckBox();
            this.ASoreThroatPain_checkBox = new System.Windows.Forms.CheckBox();
            this.SoreThroat_checkBox = new System.Windows.Forms.CheckBox();
            this.NotSay_checkBox = new System.Windows.Forms.CheckBox();
            this.Cough_checkBox = new System.Windows.Forms.CheckBox();
            this.RattlingInLungs_checkBox = new System.Windows.Forms.CheckBox();
            this.PainInLungs_checkBox = new System.Windows.Forms.CheckBox();
            this.Sputum_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Rheum_checkBox
            // 
            this.Rheum_checkBox.AutoSize = true;
            this.Rheum_checkBox.Location = new System.Drawing.Point(13, 35);
            this.Rheum_checkBox.Name = "Rheum_checkBox";
            this.Rheum_checkBox.Size = new System.Drawing.Size(60, 17);
            this.Rheum_checkBox.TabIndex = 0;
            this.Rheum_checkBox.Text = "Rheum";
            this.Rheum_checkBox.UseVisualStyleBackColor = true;
            this.Rheum_checkBox.CheckedChanged += new System.EventHandler(this.Rheum_checkBox_CheckedChanged);
            // 
            // FeverTemperature_checkBox
            // 
            this.FeverTemperature_checkBox.AutoSize = true;
            this.FeverTemperature_checkBox.Location = new System.Drawing.Point(13, 59);
            this.FeverTemperature_checkBox.Name = "FeverTemperature_checkBox";
            this.FeverTemperature_checkBox.Size = new System.Drawing.Size(112, 17);
            this.FeverTemperature_checkBox.TabIndex = 1;
            this.FeverTemperature_checkBox.Text = "Fever temperature";
            this.FeverTemperature_checkBox.UseVisualStyleBackColor = true;
            this.FeverTemperature_checkBox.CheckedChanged += new System.EventHandler(this.FeverTemperature_checkBox_CheckedChanged);
            // 
            // JointPain_checkBox
            // 
            this.JointPain_checkBox.AutoSize = true;
            this.JointPain_checkBox.Location = new System.Drawing.Point(13, 83);
            this.JointPain_checkBox.Name = "JointPain_checkBox";
            this.JointPain_checkBox.Size = new System.Drawing.Size(71, 17);
            this.JointPain_checkBox.TabIndex = 2;
            this.JointPain_checkBox.Text = "Joint pain";
            this.JointPain_checkBox.UseVisualStyleBackColor = true;
            this.JointPain_checkBox.CheckedChanged += new System.EventHandler(this.JointPain_checkBox_CheckedChanged);
            // 
            // ASoreThroatPain_checkBox
            // 
            this.ASoreThroatPain_checkBox.AutoSize = true;
            this.ASoreThroatPain_checkBox.Location = new System.Drawing.Point(13, 107);
            this.ASoreThroatPain_checkBox.Name = "ASoreThroatPain_checkBox";
            this.ASoreThroatPain_checkBox.Size = new System.Drawing.Size(107, 17);
            this.ASoreThroatPain_checkBox.TabIndex = 3;
            this.ASoreThroatPain_checkBox.Text = "ASoreThroatPain";
            this.ASoreThroatPain_checkBox.UseVisualStyleBackColor = true;
            this.ASoreThroatPain_checkBox.CheckedChanged += new System.EventHandler(this.ASoreThroatPain_checkBox_CheckedChanged);
            // 
            // SoreThroat_checkBox
            // 
            this.SoreThroat_checkBox.AutoSize = true;
            this.SoreThroat_checkBox.Location = new System.Drawing.Point(13, 131);
            this.SoreThroat_checkBox.Name = "SoreThroat_checkBox";
            this.SoreThroat_checkBox.Size = new System.Drawing.Size(79, 17);
            this.SoreThroat_checkBox.TabIndex = 4;
            this.SoreThroat_checkBox.Text = "SoreThroat";
            this.SoreThroat_checkBox.UseVisualStyleBackColor = true;
            this.SoreThroat_checkBox.CheckedChanged += new System.EventHandler(this.SoreThroat_checkBox_CheckedChanged);
            // 
            // NotSay_checkBox
            // 
            this.NotSay_checkBox.AutoSize = true;
            this.NotSay_checkBox.Location = new System.Drawing.Point(13, 155);
            this.NotSay_checkBox.Name = "NotSay_checkBox";
            this.NotSay_checkBox.Size = new System.Drawing.Size(61, 17);
            this.NotSay_checkBox.TabIndex = 5;
            this.NotSay_checkBox.Text = "NotSay";
            this.NotSay_checkBox.UseVisualStyleBackColor = true;
            this.NotSay_checkBox.CheckedChanged += new System.EventHandler(this.NotSay_checkBox_CheckedChanged);
            // 
            // Cough_checkBox
            // 
            this.Cough_checkBox.AutoSize = true;
            this.Cough_checkBox.Location = new System.Drawing.Point(13, 179);
            this.Cough_checkBox.Name = "Cough_checkBox";
            this.Cough_checkBox.Size = new System.Drawing.Size(57, 17);
            this.Cough_checkBox.TabIndex = 6;
            this.Cough_checkBox.Text = "Cough";
            this.Cough_checkBox.UseVisualStyleBackColor = true;
            this.Cough_checkBox.CheckedChanged += new System.EventHandler(this.Cough_checkBox_CheckedChanged);
            // 
            // RattlingInLungs_checkBox
            // 
            this.RattlingInLungs_checkBox.AutoSize = true;
            this.RattlingInLungs_checkBox.Location = new System.Drawing.Point(13, 203);
            this.RattlingInLungs_checkBox.Name = "RattlingInLungs_checkBox";
            this.RattlingInLungs_checkBox.Size = new System.Drawing.Size(100, 17);
            this.RattlingInLungs_checkBox.TabIndex = 7;
            this.RattlingInLungs_checkBox.Text = "RattlingInLungs";
            this.RattlingInLungs_checkBox.UseVisualStyleBackColor = true;
            this.RattlingInLungs_checkBox.CheckedChanged += new System.EventHandler(this.RattlingInLungs_checkBox_CheckedChanged);
            // 
            // PainInLungs_checkBox
            // 
            this.PainInLungs_checkBox.AutoSize = true;
            this.PainInLungs_checkBox.Location = new System.Drawing.Point(13, 227);
            this.PainInLungs_checkBox.Name = "PainInLungs_checkBox";
            this.PainInLungs_checkBox.Size = new System.Drawing.Size(85, 17);
            this.PainInLungs_checkBox.TabIndex = 8;
            this.PainInLungs_checkBox.Text = "PainInLungs";
            this.PainInLungs_checkBox.UseVisualStyleBackColor = true;
            this.PainInLungs_checkBox.CheckedChanged += new System.EventHandler(this.PainInLungs_checkBox_CheckedChanged);
            // 
            // Sputum_checkBox
            // 
            this.Sputum_checkBox.AutoSize = true;
            this.Sputum_checkBox.Location = new System.Drawing.Point(13, 250);
            this.Sputum_checkBox.Name = "Sputum_checkBox";
            this.Sputum_checkBox.Size = new System.Drawing.Size(62, 17);
            this.Sputum_checkBox.TabIndex = 9;
            this.Sputum_checkBox.Text = "Sputum";
            this.Sputum_checkBox.UseVisualStyleBackColor = true;
            this.Sputum_checkBox.CheckedChanged += new System.EventHandler(this.Sputum_checkBox_CheckedChanged);
            // 
            // Diagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.Sputum_checkBox);
            this.Controls.Add(this.PainInLungs_checkBox);
            this.Controls.Add(this.RattlingInLungs_checkBox);
            this.Controls.Add(this.Cough_checkBox);
            this.Controls.Add(this.NotSay_checkBox);
            this.Controls.Add(this.SoreThroat_checkBox);
            this.Controls.Add(this.ASoreThroatPain_checkBox);
            this.Controls.Add(this.JointPain_checkBox);
            this.Controls.Add(this.FeverTemperature_checkBox);
            this.Controls.Add(this.Rheum_checkBox);
            this.Name = "Diagnostic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Diagnostic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Rheum_checkBox;
        private System.Windows.Forms.CheckBox FeverTemperature_checkBox;
        private System.Windows.Forms.CheckBox JointPain_checkBox;
        private System.Windows.Forms.CheckBox ASoreThroatPain_checkBox;
        private System.Windows.Forms.CheckBox SoreThroat_checkBox;
        private System.Windows.Forms.CheckBox NotSay_checkBox;
        private System.Windows.Forms.CheckBox Cough_checkBox;
        private System.Windows.Forms.CheckBox RattlingInLungs_checkBox;
        private System.Windows.Forms.CheckBox PainInLungs_checkBox;
        private System.Windows.Forms.CheckBox Sputum_checkBox;
    }
}