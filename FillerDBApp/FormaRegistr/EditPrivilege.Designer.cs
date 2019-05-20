namespace FormaRegistr
{
    partial class EditPrivilege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPrivilege));
            this.Exit = new System.Windows.Forms.Button();
            this.EditRole = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(489, 13);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditRole
            // 
            this.EditRole.BackColor = System.Drawing.Color.SteelBlue;
            this.EditRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRole.ForeColor = System.Drawing.Color.White;
            this.EditRole.Location = new System.Drawing.Point(413, 313);
            this.EditRole.Margin = new System.Windows.Forms.Padding(4);
            this.EditRole.Name = "EditRole";
            this.EditRole.Size = new System.Drawing.Size(171, 57);
            this.EditRole.TabIndex = 10;
            this.EditRole.Text = "Изменить";
            this.EditRole.UseVisualStyleBackColor = false;
            this.EditRole.Click += new System.EventHandler(this.EditRole_Click);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(225, 164);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(348, 30);
            this.UserName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Новая роль:";
            // 
            // UserRole
            // 
            this.UserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRole.Location = new System.Drawing.Point(225, 218);
            this.UserRole.Margin = new System.Windows.Forms.Padding(4);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(348, 30);
            this.UserRole.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(182, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Изменение роли:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "(admin or user or dismissed)";
            // 
            // EditPrivilege
            // 
            this.AcceptButton = this.EditRole;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(597, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.EditRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPrivilege";
            this.Load += new System.EventHandler(this.EditPrivilege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EditRole;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}