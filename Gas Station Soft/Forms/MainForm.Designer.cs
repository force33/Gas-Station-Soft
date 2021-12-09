namespace Gas_Station_Soft
{
    partial class mainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.oilButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oilButton
            // 
            this.oilButton.Location = new System.Drawing.Point(265, 60);
            this.oilButton.Name = "oilButton";
            this.oilButton.Size = new System.Drawing.Size(271, 55);
            this.oilButton.TabIndex = 0;
            this.oilButton.Text = "Рассчет топлива";
            this.oilButton.UseVisualStyleBackColor = true;
            this.oilButton.Click += new System.EventHandler(this.oilButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(265, 151);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(271, 55);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "Информация";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(265, 242);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(271, 55);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Заказ топлива";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(265, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(271, 55);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Закрыть кассу";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logTB
            // 
            this.logTB.Location = new System.Drawing.Point(351, 169);
            this.logTB.Name = "logTB";
            this.logTB.Size = new System.Drawing.Size(100, 20);
            this.logTB.TabIndex = 4;
            this.logTB.Text = "login";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(351, 229);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(100, 20);
            this.passTB.TabIndex = 5;
            this.passTB.Text = "password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(364, 274);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.oilButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oilButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button loginButton;
    }
}

