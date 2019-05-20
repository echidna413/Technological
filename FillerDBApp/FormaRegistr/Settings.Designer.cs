namespace FormaRegistr
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.ControlUsers = new System.Windows.Forms.Button();
            this.SettingsDB = new System.Windows.Forms.Button();
            this.SettingsSpravoch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(243, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите действие:";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(697, 15);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ControlUsers
            // 
            this.ControlUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.ControlUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlUsers.ForeColor = System.Drawing.Color.White;
            this.ControlUsers.Location = new System.Drawing.Point(249, 128);
            this.ControlUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlUsers.Name = "ControlUsers";
            this.ControlUsers.Size = new System.Drawing.Size(269, 79);
            this.ControlUsers.TabIndex = 6;
            this.ControlUsers.Text = "Управление пользователями";
            this.ControlUsers.UseVisualStyleBackColor = false;
            this.ControlUsers.Click += new System.EventHandler(this.ControlUsers_Click);
            // 
            // SettingsDB
            // 
            this.SettingsDB.BackColor = System.Drawing.Color.SteelBlue;
            this.SettingsDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsDB.ForeColor = System.Drawing.Color.White;
            this.SettingsDB.Location = new System.Drawing.Point(249, 249);
            this.SettingsDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsDB.Name = "SettingsDB";
            this.SettingsDB.Size = new System.Drawing.Size(269, 79);
            this.SettingsDB.TabIndex = 7;
            this.SettingsDB.Text = "Нстройки БД";
            this.SettingsDB.UseVisualStyleBackColor = false;
            this.SettingsDB.Click += new System.EventHandler(this.SettingsDB_Click);
            // 
            // SettingsSpravoch
            // 
            this.SettingsSpravoch.BackColor = System.Drawing.Color.SteelBlue;
            this.SettingsSpravoch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsSpravoch.ForeColor = System.Drawing.Color.White;
            this.SettingsSpravoch.Location = new System.Drawing.Point(249, 380);
            this.SettingsSpravoch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsSpravoch.Name = "SettingsSpravoch";
            this.SettingsSpravoch.Size = new System.Drawing.Size(269, 79);
            this.SettingsSpravoch.TabIndex = 8;
            this.SettingsSpravoch.Text = "Настройки справочников";
            this.SettingsSpravoch.UseVisualStyleBackColor = false;
            this.SettingsSpravoch.Click += new System.EventHandler(this.SettingsSpravoch_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(808, 503);
            this.Controls.Add(this.SettingsSpravoch);
            this.Controls.Add(this.SettingsDB);
            this.Controls.Add(this.ControlUsers);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ControlUsers;
        private System.Windows.Forms.Button SettingsDB;
        private System.Windows.Forms.Button SettingsSpravoch;
    }
}