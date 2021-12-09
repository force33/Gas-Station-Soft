namespace Gas_Station_Soft
{
    partial class OilForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.summLabel = new System.Windows.Forms.Label();
            this.literLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.summTB = new System.Windows.Forms.TextBox();
            this.literTB = new System.Windows.Forms.TextBox();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costTB);
            this.groupBox1.Controls.Add(this.costLabel);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.summLabel);
            this.groupBox1.Controls.Add(this.literLabel);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.summTB);
            this.groupBox1.Controls.Add(this.literTB);
            this.groupBox1.Controls.Add(this.rB3);
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(286, 209);
            this.groupBox1.MinimumSize = new System.Drawing.Size(286, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // costTB
            // 
            this.costTB.Location = new System.Drawing.Point(130, 112);
            this.costTB.Name = "costTB";
            this.costTB.ReadOnly = true;
            this.costTB.Size = new System.Drawing.Size(133, 20);
            this.costTB.TabIndex = 10;
            this.costTB.TextChanged += new System.EventHandler(this.costTB_TextChanged_1);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(88, 115);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(36, 13);
            this.costLabel.TabIndex = 9;
            this.costLabel.Text = "Цена:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Колонка 1",
            "Колонка 2",
            "Колонка 3",
            "Колонка 4"});
            this.comboBox.Location = new System.Drawing.Point(20, 19);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(243, 21);
            this.comboBox.TabIndex = 8;
            // 
            // summLabel
            // 
            this.summLabel.AutoSize = true;
            this.summLabel.Location = new System.Drawing.Point(80, 143);
            this.summLabel.Name = "summLabel";
            this.summLabel.Size = new System.Drawing.Size(44, 13);
            this.summLabel.TabIndex = 7;
            this.summLabel.Text = "Сумма:";
            // 
            // literLabel
            // 
            this.literLabel.AutoSize = true;
            this.literLabel.Location = new System.Drawing.Point(17, 87);
            this.literLabel.Name = "literLabel";
            this.literLabel.Size = new System.Drawing.Size(107, 13);
            this.literLabel.TabIndex = 6;
            this.literLabel.Text = "Количество литров:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(104, 180);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // summTB
            // 
            this.summTB.Location = new System.Drawing.Point(130, 140);
            this.summTB.Name = "summTB";
            this.summTB.Size = new System.Drawing.Size(133, 20);
            this.summTB.TabIndex = 4;
            this.summTB.TextChanged += new System.EventHandler(this.summTB_TextChanged);
            this.summTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTB_KeyPress);
            this.summTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.summTB_KeyUp);
            // 
            // literTB
            // 
            this.literTB.Location = new System.Drawing.Point(130, 84);
            this.literTB.Name = "literTB";
            this.literTB.Size = new System.Drawing.Size(133, 20);
            this.literTB.TabIndex = 3;
            this.literTB.TextChanged += new System.EventHandler(this.literTB_TextChanged);
            this.literTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.literTB_KeyPress);
            this.literTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.literTB_KeyUp);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(222, 53);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(41, 17);
            this.rB3.TabIndex = 2;
            this.rB3.TabStop = true;
            this.rB3.Text = "ДТ";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.Click += new System.EventHandler(this.rB3_Click);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(130, 53);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(37, 17);
            this.rB2.TabIndex = 1;
            this.rB2.TabStop = true;
            this.rB2.Text = "95";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.Click += new System.EventHandler(this.rB2_Click);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(28, 53);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(37, 17);
            this.rB1.TabIndex = 0;
            this.rB1.TabStop = true;
            this.rB1.Text = "92";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.Click += new System.EventHandler(this.rB1_Click);
            // 
            // OilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "OilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заправка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OilForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label summLabel;
        private System.Windows.Forms.Label literLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox summTB;
        private System.Windows.Forms.TextBox literTB;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label costLabel;
    }
}