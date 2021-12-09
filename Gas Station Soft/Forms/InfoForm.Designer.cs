namespace Gas_Station_Soft
{
    partial class InfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.total_oilLabel = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // total_oilLabel
            // 
            this.total_oilLabel.AutoSize = true;
            this.total_oilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_oilLabel.Location = new System.Drawing.Point(570, 12);
            this.total_oilLabel.Name = "total_oilLabel";
            this.total_oilLabel.Size = new System.Drawing.Size(130, 16);
            this.total_oilLabel.TabIndex = 1;
            this.total_oilLabel.Text = "Топлива осталось:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(575, 35);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(22, 13);
            this.label92.TabIndex = 2;
            this.label92.Text = "92:";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(575, 57);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(22, 13);
            this.label95.TabIndex = 3;
            this.label95.Text = "95:";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(575, 79);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(26, 13);
            this.labelDT.TabIndex = 4;
            this.labelDT.Text = "ДТ:";
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyLabel.Location = new System.Drawing.Point(13, 13);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(131, 16);
            this.historyLabel.TabIndex = 5;
            this.historyLabel.Text = "История заправок:";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.total_oilLabel);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(727, 489);
            this.MinimumSize = new System.Drawing.Size(727, 489);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label total_oilLabel;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.Label historyLabel;
    }
}