namespace FormaRegistr
{
    partial class ControlUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsers));
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewUser = new System.Windows.Forms.Button();
            this.EditPrivilege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(457, 13);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите действие:";
            // 
            // AddNewUser
            // 
            this.AddNewUser.BackColor = System.Drawing.Color.SteelBlue;
            this.AddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewUser.ForeColor = System.Drawing.Color.White;
            this.AddNewUser.Location = new System.Drawing.Point(119, 161);
            this.AddNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(301, 71);
            this.AddNewUser.TabIndex = 9;
            this.AddNewUser.Text = "Добавить пользователя";
            this.AddNewUser.UseVisualStyleBackColor = false;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // EditPrivilege
            // 
            this.EditPrivilege.BackColor = System.Drawing.Color.SteelBlue;
            this.EditPrivilege.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPrivilege.ForeColor = System.Drawing.Color.White;
            this.EditPrivilege.Location = new System.Drawing.Point(119, 256);
            this.EditPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.EditPrivilege.Name = "EditPrivilege";
            this.EditPrivilege.Size = new System.Drawing.Size(301, 71);
            this.EditPrivilege.TabIndex = 10;
            this.EditPrivilege.Text = "Редактировать привилегии";
            this.EditPrivilege.UseVisualStyleBackColor = false;
            this.EditPrivilege.Click += new System.EventHandler(this.EditPrivilege_Click);
            // 
            // ControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(565, 455);
            this.Controls.Add(this.EditPrivilege);
            this.Controls.Add(this.AddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlUsers";
            this.Load += new System.EventHandler(this.ControlUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewUser;
        private System.Windows.Forms.Button EditPrivilege;
    }
}