namespace TechnKarta_1
{
    partial class FormChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoice));
            this.LabelChoice = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelChoice
            // 
            this.LabelChoice.AutoSize = true;
            this.LabelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChoice.Location = new System.Drawing.Point(194, 88);
            this.LabelChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChoice.Name = "LabelChoice";
            this.LabelChoice.Size = new System.Drawing.Size(318, 36);
            this.LabelChoice.TabIndex = 1;
            this.LabelChoice.Text = "Выберите действие";
            this.LabelChoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(579, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 39);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddData
            // 
            this.buttonAddData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddData.Location = new System.Drawing.Point(28, 157);
            this.buttonAddData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(313, 76);
            this.buttonAddData.TabIndex = 10;
            this.buttonAddData.Text = "Технологическая карта";
            this.buttonAddData.UseVisualStyleBackColor = false;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImport.Location = new System.Drawing.Point(28, 363);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(313, 76);
            this.buttonImport.TabIndex = 11;
            this.buttonImport.Text = "Импорт данных из файла .csv на проверку";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(199, 470);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(313, 76);
            this.buttonSettings.TabIndex = 12;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(381, 363);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(315, 76);
            this.buttonExport.TabIndex = 13;
            this.buttonExport.Text = "Экспорт данных в файл";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDetails
            // 
            this.buttonDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDetails.Location = new System.Drawing.Point(28, 253);
            this.buttonDetails.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(313, 76);
            this.buttonDetails.TabIndex = 14;
            this.buttonDetails.Text = "Детали";
            this.buttonDetails.UseVisualStyleBackColor = false;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(381, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Оборудование";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(381, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 76);
            this.button2.TabIndex = 16;
            this.button2.Text = "Заготовки";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.LabelChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelChoice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}