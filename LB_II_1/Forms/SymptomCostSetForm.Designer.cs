namespace LB_II_1.Forms
{
    partial class SymptomCostSetForm
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


        private void SetTextLocale(bool ENG_loc)
        {
            GetButton.Enabled = false;
            SetButton.Enabled = false;
            
            this.dataGridView.RowHeadersWidth = 130;
            dataGridView.RowCount = 11;
            dataGridView.ColumnCount = 1;
            dataGridView.Rows[0].HeaderCell.Value = "ID";
            dataGridView.Columns[0].Width = 67;
            this.dataGridView.Size = new System.Drawing.Size(199, 265);
            if (ENG_loc)
            {
                this.Text = Local.Local_ENG.ProgName + ": " + Local.Local_ENG.SymCostSet_button_name;
                dataGridView.Rows[1].HeaderCell.Value = Local.Local_ENG.Rheum;
                dataGridView.Rows[2].HeaderCell.Value = Local.Local_ENG.Cough;
                dataGridView.Rows[3].HeaderCell.Value = Local.Local_ENG.ASoreThroatPain;
                dataGridView.Rows[4].HeaderCell.Value = Local.Local_ENG.FeverTemperature;
                dataGridView.Rows[5].HeaderCell.Value = Local.Local_ENG.JointPain;
                dataGridView.Rows[6].HeaderCell.Value = Local.Local_ENG.SoreThroat;
                dataGridView.Rows[7].HeaderCell.Value = Local.Local_ENG.Sputum;
                dataGridView.Rows[8].HeaderCell.Value = Local.Local_ENG.RattlingInLungs;
                dataGridView.Rows[9].HeaderCell.Value = Local.Local_ENG.PainInLungs;
                dataGridView.Rows[10].HeaderCell.Value = Local.Local_ENG.NotSay;
                dataGridView.Columns[0].HeaderText = Local.Local_ENG.Pne;//*
                GetButton.Text = Local.Local_ENG.GET_B;
                SetButton.Text = Local.Local_ENG.SET_B;
                this.DeseareComboBox.Items.AddRange(new object[] { Local.Local_ENG.Pne, Local.Local_ENG.Ang, Local.Local_ENG.Flu, Local.Local_ENG.Pha, Local.Local_ENG.Bro });
            }
            else
            {
                this.Text = Local.Local_RU.ProgName + ": " + Local.Local_RU.SymCostSet_button_name;
                GetButton.Text = Local.Local_RU.GET_B;
                SetButton.Text = Local.Local_RU.SET_B;
                dataGridView.Rows[1].HeaderCell.Value = Local.Local_RU.Rheum;
                dataGridView.Rows[2].HeaderCell.Value = Local.Local_RU.Cough;
                dataGridView.Rows[3].HeaderCell.Value = Local.Local_RU.ASoreThroatPain;
                dataGridView.Rows[4].HeaderCell.Value = Local.Local_RU.FeverTemperature;
                dataGridView.Rows[5].HeaderCell.Value = Local.Local_RU.JointPain;
                dataGridView.Rows[6].HeaderCell.Value = Local.Local_RU.SoreThroat;
                dataGridView.Rows[7].HeaderCell.Value = Local.Local_RU.Sputum;
                dataGridView.Rows[8].HeaderCell.Value = Local.Local_RU.RattlingInLungs;
                dataGridView.Rows[9].HeaderCell.Value = Local.Local_RU.PainInLungs;
                dataGridView.Rows[10].HeaderCell.Value = Local.Local_RU.NotSay;
                dataGridView.Columns[0].HeaderText = Local.Local_RU.Pne;//*
                this.DeseareComboBox.Items.AddRange(new object[] {Local.Local_RU.Pne, Local.Local_RU.Ang,Local.Local_RU.Flu,Local.Local_RU.Pha,Local.Local_RU.Bro});
            }
            DeseareComboBox.SelectedIndex = 0;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DeseareComboBox = new System.Windows.Forms.ComboBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.SupperRootCheckBox = new System.Windows.Forms.CheckBox();
            this.AUTOSET_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(199, 265);
            this.dataGridView.TabIndex = 0;
            // 
            // DeseareComboBox
            // 
            this.DeseareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeseareComboBox.FormattingEnabled = true;
            this.DeseareComboBox.Location = new System.Drawing.Point(219, 13);
            this.DeseareComboBox.Name = "DeseareComboBox";
            this.DeseareComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeseareComboBox.TabIndex = 1;
            this.DeseareComboBox.SelectedIndexChanged += new System.EventHandler(this.DeseareComboBox_SelectedIndexChanged);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(265, 220);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "button1";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(265, 249);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 3;
            this.SetButton.Text = "button1";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // SupperRootCheckBox
            // 
            this.SupperRootCheckBox.AutoSize = true;
            this.SupperRootCheckBox.Location = new System.Drawing.Point(244, 239);
            this.SupperRootCheckBox.Name = "SupperRootCheckBox";
            this.SupperRootCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SupperRootCheckBox.TabIndex = 4;
            this.SupperRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // AUTOSET_button
            // 
            this.AUTOSET_button.Location = new System.Drawing.Point(265, 191);
            this.AUTOSET_button.Name = "AUTOSET_button";
            this.AUTOSET_button.Size = new System.Drawing.Size(75, 23);
            this.AUTOSET_button.TabIndex = 5;
            this.AUTOSET_button.Text = "AUTOSET";
            this.AUTOSET_button.UseVisualStyleBackColor = true;
            this.AUTOSET_button.Click += new System.EventHandler(this.AUTOSET_button_Click);
            // 
            // SymptomCostSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 284);
            this.Controls.Add(this.AUTOSET_button);
            this.Controls.Add(this.SupperRootCheckBox);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.DeseareComboBox);
            this.Controls.Add(this.dataGridView);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "SymptomCostSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SymptomCostSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox DeseareComboBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.CheckBox SupperRootCheckBox;
        private System.Windows.Forms.Button AUTOSET_button;
    }
}