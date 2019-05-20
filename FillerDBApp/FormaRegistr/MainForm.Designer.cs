namespace FormaRegistr
{
    partial class Entrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Авторизация:";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(207, 118);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(262, 26);
            this.UserName.TabIndex = 3;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // UserPassword
            // 
            this.UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPassword.Location = new System.Drawing.Point(207, 182);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(262, 26);
            this.UserPassword.TabIndex = 4;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.SteelBlue;
            this.Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(341, 277);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(128, 46);
            this.Input.TabIndex = 5;
            this.Input.Text = "Войти";
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(402, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(67, 36);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Entrance
            // 
            this.AcceptButton = this.Input;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Entrance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Button Exit;
    }
}

