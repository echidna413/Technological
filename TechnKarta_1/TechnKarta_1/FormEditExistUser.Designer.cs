namespace TechnKarta_1
{
    partial class FormEditExistUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditExistUser));
            this.label2 = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelnewRole = new System.Windows.Forms.Label();
            this.buttonEndAdd = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.LabelAdd = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCurrentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 180);
            this.label2.TabIndex = 41;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(68, 448);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(255, 20);
            this.labelOptions.TabIndex = 40;
            this.labelOptions.Text = "(admin или user или dismissed)";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRole.Location = new System.Drawing.Point(438, 420);
            this.textBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(404, 34);
            this.textBoxRole.TabIndex = 39;
            // 
            // labelnewRole
            // 
            this.labelnewRole.AutoSize = true;
            this.labelnewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnewRole.Location = new System.Drawing.Point(67, 419);
            this.labelnewRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnewRole.Name = "labelnewRole";
            this.labelnewRole.Size = new System.Drawing.Size(77, 29);
            this.labelnewRole.TabIndex = 38;
            this.labelnewRole.Text = "Роль:";
            // 
            // buttonEndAdd
            // 
            this.buttonEndAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEndAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndAdd.Location = new System.Drawing.Point(715, 478);
            this.buttonEndAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEndAdd.Name = "buttonEndAdd";
            this.buttonEndAdd.Size = new System.Drawing.Size(127, 49);
            this.buttonEndAdd.TabIndex = 37;
            this.buttonEndAdd.Text = "Подтвердить";
            this.buttonEndAdd.UseVisualStyleBackColor = false;
            this.buttonEndAdd.Click += new System.EventHandler(this.buttonEndAdd_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(438, 349);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(404, 34);
            this.textBoxPass.TabIndex = 36;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(438, 279);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(404, 34);
            this.textBoxName.TabIndex = 35;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(67, 354);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(105, 29);
            this.labelPass.TabIndex = 34;
            this.labelPass.Text = "Пароль:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(67, 278);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(240, 29);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Имя пользователя:";
            // 
            // LabelAdd
            // 
            this.LabelAdd.AutoSize = true;
            this.LabelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdd.Location = new System.Drawing.Point(229, 88);
            this.LabelAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAdd.Name = "LabelAdd";
            this.LabelAdd.Size = new System.Drawing.Size(474, 36);
            this.LabelAdd.TabIndex = 32;
            this.LabelAdd.Text = "Редактировать пользователя";
            this.LabelAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(790, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 39);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem,
            this.EditUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.AddUserToolStripMenuItem.Text = "Добавить пользователя";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // EditUser
            // 
            this.EditUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(336, 24);
            this.EditUser.Text = "Редактировать существующего пользователя";
            // 
            // textBoxCurrentName
            // 
            this.textBoxCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurrentName.Location = new System.Drawing.Point(438, 207);
            this.textBoxCurrentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCurrentName.Name = "textBoxCurrentName";
            this.textBoxCurrentName.Size = new System.Drawing.Size(404, 34);
            this.textBoxCurrentName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Текущее имя пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(114, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "Введите имя текующего пользователя, а затем новые данные, которые необходимо изме" +
    "нить. \r\nОстальные поля можно оставить пустыми.";
            // 
            // FormEditExistUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 737);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCurrentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.labelnewRole);
            this.Controls.Add(this.buttonEndAdd);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LabelAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditExistUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать пользователей";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label labelnewRole;
        private System.Windows.Forms.Button buttonEndAdd;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label LabelAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditUser;
        private System.Windows.Forms.TextBox textBoxCurrentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}