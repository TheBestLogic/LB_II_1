namespace LB_II_1.Forms
{
    partial class SeenDatabaseForm
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
            dataGridView.RowCount = 11;
            dataGridView.ColumnCount = 5;
            dataGridView.Rows[0].HeaderCell.Value = "ID";
            dataGridView.Columns[0].Width = 67;
            dataGridView.Columns[1].Width = 67;
            dataGridView.Columns[2].Width = 67;
            dataGridView.Columns[3].Width = 67;
            dataGridView.Columns[4].Width = 67;
            this.dataGridView.AllowUserToResizeColumns = false;
            if (ENG_loc)
            {
                this.Text = Local.Local_ENG.ProgName + ": " + Local.Local_ENG.SeenDB_button_name;
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
                dataGridView.Columns[0].HeaderText = Local.Local_ENG.Pne;
                dataGridView.Columns[1].HeaderText = Local.Local_ENG.Ang;
                dataGridView.Columns[2].HeaderText = Local.Local_ENG.Flu;
                dataGridView.Columns[3].HeaderText = Local.Local_ENG.Pha;
                dataGridView.Columns[4].HeaderText = Local.Local_ENG.Bro;
            }
            else
            {
                this.Text = Local.Local_RU.ProgName + ": " + Local.Local_RU.SeenDB_button_name;
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
                dataGridView.Columns[0].HeaderText = Local.Local_RU.Pne;
                dataGridView.Columns[1].HeaderText = Local.Local_RU.Ang;
                dataGridView.Columns[2].HeaderText = Local.Local_RU.Flu;
                dataGridView.Columns[3].HeaderText = Local.Local_RU.Pha;
                dataGridView.Columns[4].HeaderText = Local.Local_RU.Bro;
            }
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersWidth = 130;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(467, 262);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // SeenDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(482, 301);
            this.Name = "SeenDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SeenDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}