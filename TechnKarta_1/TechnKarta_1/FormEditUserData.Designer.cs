namespace TechnKarta_1
{
    partial class FormEditUserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUserData));
            this.buttonBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEndAdd = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.LabelAdd = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelnewRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(664, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 39);
            this.buttonBack.TabIndex = 12;
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
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 13;
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
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // buttonEndAdd
            // 
            this.buttonEndAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEndAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndAdd.Location = new System.Drawing.Point(647, 395);
            this.buttonEndAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEndAdd.Name = "buttonEndAdd";
            this.buttonEndAdd.Size = new System.Drawing.Size(132, 49);
            this.buttonEndAdd.TabIndex = 25;
            this.buttonEndAdd.Text = "Подтвердить";
            this.buttonEndAdd.UseVisualStyleBackColor = false;
            this.buttonEndAdd.Click += new System.EventHandler(this.buttonEndAdd_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(375, 255);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(404, 34);
            this.textBoxPass.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(375, 185);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(404, 34);
            this.textBoxName.TabIndex = 23;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(19, 264);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(105, 29);
            this.labelPass.TabIndex = 22;
            this.labelPass.Text = "Пароль:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(19, 188);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(240, 29);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Имя пользователя:";
            // 
            // LabelAdd
            // 
            this.LabelAdd.AutoSize = true;
            this.LabelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdd.Location = new System.Drawing.Point(215, 95);
            this.LabelAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAdd.Name = "LabelAdd";
            this.LabelAdd.Size = new System.Drawing.Size(392, 36);
            this.LabelAdd.TabIndex = 20;
            this.LabelAdd.Text = "Добавить пользователя";
            this.LabelAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(20, 358);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(255, 20);
            this.labelOptions.TabIndex = 28;
            this.labelOptions.Text = "(admin или user или dismissed)";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRole.Location = new System.Drawing.Point(375, 326);
            this.textBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(404, 34);
            this.textBoxRole.TabIndex = 27;
            // 
            // labelnewRole
            // 
            this.labelnewRole.AutoSize = true;
            this.labelnewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnewRole.Location = new System.Drawing.Point(19, 329);
            this.labelnewRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnewRole.Name = "labelnewRole";
            this.labelnewRole.Size = new System.Drawing.Size(77, 29);
            this.labelnewRole.TabIndex = 26;
            this.labelnewRole.Text = "Роль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 180);
            this.label2.TabIndex = 29;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FormEditUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 653);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditUserData_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditUser;
        private System.Windows.Forms.Button buttonEndAdd;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label LabelAdd;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label labelnewRole;
        private System.Windows.Forms.Label label2;
    }
}