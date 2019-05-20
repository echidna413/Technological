namespace TechnKarta_1
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.LabelChoice = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSettingsDB = new System.Windows.Forms.Button();
            this.buttonSettingsUser = new System.Windows.Forms.Button();
            this.buttonSettingsBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelChoice
            // 
            this.LabelChoice.AutoSize = true;
            this.LabelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChoice.Location = new System.Drawing.Point(198, 89);
            this.LabelChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChoice.Name = "LabelChoice";
            this.LabelChoice.Size = new System.Drawing.Size(318, 36);
            this.LabelChoice.TabIndex = 15;
            this.LabelChoice.Text = "Выберите действие";
            this.LabelChoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(580, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 39);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSettingsDB
            // 
            this.buttonSettingsDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettingsDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettingsDB.Location = new System.Drawing.Point(184, 260);
            this.buttonSettingsDB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettingsDB.Name = "buttonSettingsDB";
            this.buttonSettingsDB.Size = new System.Drawing.Size(341, 76);
            this.buttonSettingsDB.TabIndex = 17;
            this.buttonSettingsDB.Text = "Настройки БД";
            this.buttonSettingsDB.UseVisualStyleBackColor = false;
            // 
            // buttonSettingsUser
            // 
            this.buttonSettingsUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettingsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettingsUser.Location = new System.Drawing.Point(184, 160);
            this.buttonSettingsUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettingsUser.Name = "buttonSettingsUser";
            this.buttonSettingsUser.Size = new System.Drawing.Size(341, 76);
            this.buttonSettingsUser.TabIndex = 16;
            this.buttonSettingsUser.Text = "Управление пользователями";
            this.buttonSettingsUser.UseVisualStyleBackColor = false;
            this.buttonSettingsUser.Click += new System.EventHandler(this.buttonSettingsUser_Click);
            // 
            // buttonSettingsBooks
            // 
            this.buttonSettingsBooks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettingsBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettingsBooks.Location = new System.Drawing.Point(184, 355);
            this.buttonSettingsBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettingsBooks.Name = "buttonSettingsBooks";
            this.buttonSettingsBooks.Size = new System.Drawing.Size(341, 76);
            this.buttonSettingsBooks.TabIndex = 18;
            this.buttonSettingsBooks.Text = "Настройки справочников";
            this.buttonSettingsBooks.UseVisualStyleBackColor = false;
            this.buttonSettingsBooks.Click += new System.EventHandler(this.buttonSettingsBooks_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 516);
            this.Controls.Add(this.buttonSettingsBooks);
            this.Controls.Add(this.buttonSettingsDB);
            this.Controls.Add(this.buttonSettingsUser);
            this.Controls.Add(this.LabelChoice);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelChoice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSettingsDB;
        private System.Windows.Forms.Button buttonSettingsUser;
        private System.Windows.Forms.Button buttonSettingsBooks;
    }
}