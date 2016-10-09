namespace LB_II_1
{
    partial class StartForm
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
            this.SymptomeEdit = new System.Windows.Forms.Button();
            this.SeenDatabase = new System.Windows.Forms.Button();
            this.Diagnostic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SymptomeEdit
            // 
            this.SymptomeEdit.Location = new System.Drawing.Point(13, 13);
            this.SymptomeEdit.Name = "SymptomeEdit";
            this.SymptomeEdit.Size = new System.Drawing.Size(75, 23);
            this.SymptomeEdit.TabIndex = 0;
            this.SymptomeEdit.Text = "button1";
            this.SymptomeEdit.UseVisualStyleBackColor = true;
            this.SymptomeEdit.Click += new System.EventHandler(this.SymptomeEdit_Click);
            // 
            // SeenDatabase
            // 
            this.SeenDatabase.Location = new System.Drawing.Point(13, 42);
            this.SeenDatabase.Name = "SeenDatabase";
            this.SeenDatabase.Size = new System.Drawing.Size(75, 23);
            this.SeenDatabase.TabIndex = 1;
            this.SeenDatabase.Text = "button2";
            this.SeenDatabase.UseVisualStyleBackColor = true;
            this.SeenDatabase.Click += new System.EventHandler(this.SeenDatabase_Click);
            // 
            // Diagnostic
            // 
            this.Diagnostic.Location = new System.Drawing.Point(13, 72);
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.Size = new System.Drawing.Size(75, 23);
            this.Diagnostic.TabIndex = 2;
            this.Diagnostic.Text = "button3";
            this.Diagnostic.UseVisualStyleBackColor = true;
            this.Diagnostic.Click += new System.EventHandler(this.Diagnostic_Click);
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Diagnostic);
            this.Controls.Add(this.SeenDatabase);
            this.Controls.Add(this.SymptomeEdit);
            this.Name = "StatForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatForm_FormClosed);
            this.Load += new System.EventHandler(this.StatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SymptomeEdit;
        private System.Windows.Forms.Button SeenDatabase;
        private System.Windows.Forms.Button Diagnostic;
    }
}

