namespace Gas_Station_Soft
{
    partial class OrderForm
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
            this.randCostLabel = new System.Windows.Forms.Label();
            this.randCostLabel2 = new System.Windows.Forms.Label();
            this.randCostLabel3 = new System.Windows.Forms.Label();
            this.oilAmountTB1 = new System.Windows.Forms.TextBox();
            this.oilAmountTB2 = new System.Windows.Forms.TextBox();
            this.oilAmountTB3 = new System.Windows.Forms.TextBox();
            this.summCost1 = new System.Windows.Forms.Label();
            this.summCost2 = new System.Windows.Forms.Label();
            this.summCost3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderStartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // randCostLabel
            // 
            this.randCostLabel.AutoSize = true;
            this.randCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randCostLabel.Location = new System.Drawing.Point(8, 51);
            this.randCostLabel.Name = "randCostLabel";
            this.randCostLabel.Size = new System.Drawing.Size(13, 13);
            this.randCostLabel.TabIndex = 0;
            this.randCostLabel.Text = "1";
            // 
            // randCostLabel2
            // 
            this.randCostLabel2.AutoSize = true;
            this.randCostLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randCostLabel2.Location = new System.Drawing.Point(137, 51);
            this.randCostLabel2.Name = "randCostLabel2";
            this.randCostLabel2.Size = new System.Drawing.Size(13, 13);
            this.randCostLabel2.TabIndex = 1;
            this.randCostLabel2.Text = "2";
            // 
            // randCostLabel3
            // 
            this.randCostLabel3.AutoSize = true;
            this.randCostLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randCostLabel3.Location = new System.Drawing.Point(267, 51);
            this.randCostLabel3.Name = "randCostLabel3";
            this.randCostLabel3.Size = new System.Drawing.Size(13, 13);
            this.randCostLabel3.TabIndex = 2;
            this.randCostLabel3.Text = "3";
            // 
            // oilAmountTB1
            // 
            this.oilAmountTB1.Location = new System.Drawing.Point(11, 28);
            this.oilAmountTB1.Name = "oilAmountTB1";
            this.oilAmountTB1.Size = new System.Drawing.Size(107, 20);
            this.oilAmountTB1.TabIndex = 3;
            this.oilAmountTB1.TextChanged += new System.EventHandler(this.oilAmountTB1_TextChanged);
            this.oilAmountTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oilAmountTB1_KeyPress);
            // 
            // oilAmountTB2
            // 
            this.oilAmountTB2.Location = new System.Drawing.Point(140, 28);
            this.oilAmountTB2.Name = "oilAmountTB2";
            this.oilAmountTB2.Size = new System.Drawing.Size(106, 20);
            this.oilAmountTB2.TabIndex = 4;
            this.oilAmountTB2.TextChanged += new System.EventHandler(this.oilAmountTB2_TextChanged);
            this.oilAmountTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oilAmountTB2_KeyPress);
            // 
            // oilAmountTB3
            // 
            this.oilAmountTB3.Location = new System.Drawing.Point(270, 28);
            this.oilAmountTB3.Name = "oilAmountTB3";
            this.oilAmountTB3.Size = new System.Drawing.Size(106, 20);
            this.oilAmountTB3.TabIndex = 5;
            this.oilAmountTB3.TextChanged += new System.EventHandler(this.oilAmountTB3_TextChanged);
            this.oilAmountTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oilAmountTB3_KeyPress);
            // 
            // summCost1
            // 
            this.summCost1.AutoSize = true;
            this.summCost1.Location = new System.Drawing.Point(8, 68);
            this.summCost1.Name = "summCost1";
            this.summCost1.Size = new System.Drawing.Size(53, 13);
            this.summCost1.TabIndex = 6;
            this.summCost1.Text = "Сумма: 0";
            // 
            // summCost2
            // 
            this.summCost2.AutoSize = true;
            this.summCost2.Location = new System.Drawing.Point(137, 68);
            this.summCost2.Name = "summCost2";
            this.summCost2.Size = new System.Drawing.Size(53, 13);
            this.summCost2.TabIndex = 7;
            this.summCost2.Text = "Сумма: 0";
            // 
            // summCost3
            // 
            this.summCost3.AutoSize = true;
            this.summCost3.Location = new System.Drawing.Point(267, 68);
            this.summCost3.Name = "summCost3";
            this.summCost3.Size = new System.Drawing.Size(53, 13);
            this.summCost3.TabIndex = 8;
            this.summCost3.Text = "Сумма: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество литров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество литров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество литров";
            // 
            // orderStartButton
            // 
            this.orderStartButton.Location = new System.Drawing.Point(155, 104);
            this.orderStartButton.Name = "orderStartButton";
            this.orderStartButton.Size = new System.Drawing.Size(75, 23);
            this.orderStartButton.TabIndex = 12;
            this.orderStartButton.Text = "Заказать";
            this.orderStartButton.UseVisualStyleBackColor = true;
            this.orderStartButton.Click += new System.EventHandler(this.orderStartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 139);
            this.Controls.Add(this.orderStartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summCost3);
            this.Controls.Add(this.summCost2);
            this.Controls.Add(this.summCost1);
            this.Controls.Add(this.oilAmountTB3);
            this.Controls.Add(this.oilAmountTB2);
            this.Controls.Add(this.oilAmountTB1);
            this.Controls.Add(this.randCostLabel3);
            this.Controls.Add(this.randCostLabel2);
            this.Controls.Add(this.randCostLabel);
            this.MaximumSize = new System.Drawing.Size(404, 178);
            this.MinimumSize = new System.Drawing.Size(404, 178);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randCostLabel;
        private System.Windows.Forms.Label randCostLabel2;
        private System.Windows.Forms.Label randCostLabel3;
        private System.Windows.Forms.TextBox oilAmountTB1;
        private System.Windows.Forms.TextBox oilAmountTB2;
        private System.Windows.Forms.TextBox oilAmountTB3;
        private System.Windows.Forms.Label summCost1;
        private System.Windows.Forms.Label summCost2;
        private System.Windows.Forms.Label summCost3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderStartButton;
        private System.Windows.Forms.Timer timer1;
    }
}