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
        /// 
        private void SetTextLocale(bool ENG_loc)
        {
            if(ENG_loc)
            {
                this.SymptomeEdit.Text = Local.Local_ENG.SymCostSet_button_name;
                this.SeenDatabase.Text = Local.Local_ENG.SeenDB_button_name;
                this.Diagnostic.Text = Local.Local_ENG.Diagnostic_button_name;
                this.Local_button.Text = Local.Local_ENG.Local_button_name;
                this.Text = Local.Local_ENG.ProgName;
                this.groupBox.Text = Local.Local_RU.ProgNameFull;
            }
            else
            {
                this.SymptomeEdit.Text = Local.Local_RU.SymCostSet_button_name;
                this.SeenDatabase.Text = Local.Local_RU.SeenDB_button_name;
                this.Diagnostic.Text = Local.Local_RU.Diagnostic_button_name;
                this.Local_button.Text = Local.Local_RU.Local_button_name;
                this.Text = Local.Local_RU.ProgName;
                this.groupBox.Text = Local.Local_RU.ProgNameFull;
            }
        }  

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SymptomeEdit = new System.Windows.Forms.Button();
            this.SeenDatabase = new System.Windows.Forms.Button();
            this.Diagnostic = new System.Windows.Forms.Button();
            this.Local_button = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SymptomeEdit
            // 
            this.SymptomeEdit.Location = new System.Drawing.Point(6, 19);
            this.SymptomeEdit.Name = "SymptomeEdit";
            this.SymptomeEdit.Size = new System.Drawing.Size(151, 23);
            this.SymptomeEdit.TabIndex = 0;
            this.SymptomeEdit.UseVisualStyleBackColor = true;
            this.SymptomeEdit.Click += new System.EventHandler(this.SymptomeEdit_Click);
            // 
            // SeenDatabase
            // 
            this.SeenDatabase.Location = new System.Drawing.Point(6, 48);
            this.SeenDatabase.Name = "SeenDatabase";
            this.SeenDatabase.Size = new System.Drawing.Size(151, 23);
            this.SeenDatabase.TabIndex = 1;
            this.SeenDatabase.UseVisualStyleBackColor = true;
            this.SeenDatabase.Click += new System.EventHandler(this.SeenDatabase_Click);
            // 
            // Diagnostic
            // 
            this.Diagnostic.Location = new System.Drawing.Point(6, 77);
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.Size = new System.Drawing.Size(151, 23);
            this.Diagnostic.TabIndex = 2;
            this.Diagnostic.UseVisualStyleBackColor = true;
            this.Diagnostic.Click += new System.EventHandler(this.Diagnostic_Click);
            // 
            // Local_button
            // 
            this.Local_button.Location = new System.Drawing.Point(131, 131);
            this.Local_button.Name = "Local_button";
            this.Local_button.Size = new System.Drawing.Size(49, 23);
            this.Local_button.TabIndex = 3;
            this.Local_button.UseVisualStyleBackColor = true;
            this.Local_button.Click += new System.EventHandler(this.Local_button_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.SymptomeEdit);
            this.groupBox.Controls.Add(this.SeenDatabase);
            this.groupBox.Controls.Add(this.Diagnostic);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(168, 113);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 5;
            this.label.Text = "";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 166);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Local_button);
            this.Name = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatForm_FormClosed);
            this.Load += new System.EventHandler(this.StatForm_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SymptomeEdit;
        private System.Windows.Forms.Button SeenDatabase;
        private System.Windows.Forms.Button Diagnostic;
        private System.Windows.Forms.Button Local_button;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
    }
}

