namespace FormaRegistr
{
    partial class FormChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChooser));
            this.label1 = new System.Windows.Forms.Label();
            this.Vvod_dannyh = new System.Windows.Forms.Button();
            this.Import_export = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие:";
            // 
            // Vvod_dannyh
            // 
            this.Vvod_dannyh.BackColor = System.Drawing.Color.SteelBlue;
            this.Vvod_dannyh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvod_dannyh.ForeColor = System.Drawing.Color.White;
            this.Vvod_dannyh.Location = new System.Drawing.Point(181, 148);
            this.Vvod_dannyh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Vvod_dannyh.Name = "Vvod_dannyh";
            this.Vvod_dannyh.Size = new System.Drawing.Size(301, 71);
            this.Vvod_dannyh.TabIndex = 1;
            this.Vvod_dannyh.Text = "Внести данные в базу";
            this.Vvod_dannyh.UseVisualStyleBackColor = false;
            this.Vvod_dannyh.Click += new System.EventHandler(this.Vvod_dannyh_Click);
            // 
            // Import_export
            // 
            this.Import_export.BackColor = System.Drawing.Color.SteelBlue;
            this.Import_export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Import_export.ForeColor = System.Drawing.Color.White;
            this.Import_export.Location = new System.Drawing.Point(181, 246);
            this.Import_export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Import_export.Name = "Import_export";
            this.Import_export.Size = new System.Drawing.Size(301, 71);
            this.Import_export.TabIndex = 2;
            this.Import_export.Text = "Импорт/Эспорт данных в базу";
            this.Import_export.UseVisualStyleBackColor = false;
            this.Import_export.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(577, 15);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.SteelBlue;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(181, 348);
            this.Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(301, 71);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(688, 468);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Import_export);
            this.Controls.Add(this.Vvod_dannyh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vvod_dannyh;
        private System.Windows.Forms.Button Import_export;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Settings;
    }
}