namespace Golov_
{
    partial class MainForm
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
            this.TextLabel1 = new System.Windows.Forms.Label();
            this.TextLabel2 = new System.Windows.Forms.Label();
            this.TextLabel3 = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.panelCaptch = new System.Windows.Forms.Panel();
            this.pictureBoxCaptch4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch1 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.panelCaptch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLabel1
            // 
            this.TextLabel1.AutoSize = true;
            this.TextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel1.Location = new System.Drawing.Point(310, 47);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.Size = new System.Drawing.Size(204, 36);
            this.TextLabel1.TabIndex = 0;
            this.TextLabel1.Text = "Авторизация";
            // 
            // TextLabel2
            // 
            this.TextLabel2.AutoSize = true;
            this.TextLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel2.Location = new System.Drawing.Point(190, 159);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.Size = new System.Drawing.Size(82, 29);
            this.TextLabel2.TabIndex = 1;
            this.TextLabel2.Text = "Логин";
            // 
            // TextLabel3
            // 
            this.TextLabel3.AutoSize = true;
            this.TextLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel3.Location = new System.Drawing.Point(190, 224);
            this.TextLabel3.Name = "TextLabel3";
            this.TextLabel3.Size = new System.Drawing.Size(96, 29);
            this.TextLabel3.TabIndex = 2;
            this.TextLabel3.Text = "Пароль";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(386, 159);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(224, 28);
            this.TextBoxLogin.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(386, 224);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(224, 28);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(316, 314);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(185, 73);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Вход";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // panelCaptch
            // 
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch4);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch3);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch2);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch1);
            this.panelCaptch.Controls.Add(this.NextButton);
            this.panelCaptch.Controls.Add(this.ReadyButton);
            this.panelCaptch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaptch.Location = new System.Drawing.Point(0, 0);
            this.panelCaptch.Name = "panelCaptch";
            this.panelCaptch.Size = new System.Drawing.Size(800, 450);
            this.panelCaptch.TabIndex = 6;
            // 
            // pictureBoxCaptch4
            // 
            this.pictureBoxCaptch4.Location = new System.Drawing.Point(380, 147);
            this.pictureBoxCaptch4.Name = "pictureBoxCaptch4";
            this.pictureBoxCaptch4.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch4.TabIndex = 5;
            this.pictureBoxCaptch4.TabStop = false;
            // 
            // pictureBoxCaptch3
            // 
            this.pictureBoxCaptch3.Location = new System.Drawing.Point(280, 147);
            this.pictureBoxCaptch3.Name = "pictureBoxCaptch3";
            this.pictureBoxCaptch3.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch3.TabIndex = 4;
            this.pictureBoxCaptch3.TabStop = false;
            // 
            // pictureBoxCaptch2
            // 
            this.pictureBoxCaptch2.Location = new System.Drawing.Point(380, 47);
            this.pictureBoxCaptch2.Name = "pictureBoxCaptch2";
            this.pictureBoxCaptch2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch2.TabIndex = 3;
            this.pictureBoxCaptch2.TabStop = false;
            // 
            // pictureBoxCaptch1
            // 
            this.pictureBoxCaptch1.Location = new System.Drawing.Point(280, 47);
            this.pictureBoxCaptch1.Name = "pictureBoxCaptch1";
            this.pictureBoxCaptch1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch1.TabIndex = 2;
            this.pictureBoxCaptch1.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(428, 314);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(120, 51);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ReadyButton
            // 
            this.ReadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyButton.Location = new System.Drawing.Point(196, 314);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(114, 51);
            this.ReadyButton.TabIndex = 0;
            this.ReadyButton.Text = "Готово";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCaptch);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextLabel3);
            this.Controls.Add(this.TextLabel2);
            this.Controls.Add(this.TextLabel1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelCaptch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabel1;
        private System.Windows.Forms.Label TextLabel2;
        private System.Windows.Forms.Label TextLabel3;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Panel panelCaptch;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.PictureBox pictureBoxCaptch4;
        private System.Windows.Forms.PictureBox pictureBoxCaptch3;
        private System.Windows.Forms.PictureBox pictureBoxCaptch2;
        private System.Windows.Forms.PictureBox pictureBoxCaptch1;
    }
}

