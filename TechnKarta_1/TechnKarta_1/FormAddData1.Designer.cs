namespace TechnKarta_1
{
    partial class FormAddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddData));
            this.buttonBack = new System.Windows.Forms.Button();
            this.LabelChoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOborudov = new System.Windows.Forms.ComboBox();
            this.comboBoxPrisposob = new System.Windows.Forms.ComboBox();
            this.comboBoxTechnPer = new System.Windows.Forms.ComboBox();
            this.comboBoxObrPov = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(672, 13);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 39);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // LabelChoice
            // 
            this.LabelChoice.AutoSize = true;
            this.LabelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChoice.Location = new System.Drawing.Point(125, 94);
            this.LabelChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChoice.Name = "LabelChoice";
            this.LabelChoice.Size = new System.Drawing.Size(548, 87);
            this.LabelChoice.TabIndex = 11;
            this.LabelChoice.Text = "Вы можете выбрать значения для любого \r\nиз первых четырёх столбцов, \r\nчтобы увиде" +
    "ть уже существующие данные";
            this.LabelChoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Этот этап можно пропустить";
            // 
            // comboBoxOborudov
            // 
            this.comboBoxOborudov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOborudov.FormattingEnabled = true;
            this.comboBoxOborudov.ItemHeight = 25;
            this.comboBoxOborudov.Items.AddRange(new object[] {
            "16К20",
            "16Л21",
            "16Д22",
            "16п20"});
            this.comboBoxOborudov.Location = new System.Drawing.Point(430, 243);
            this.comboBoxOborudov.Name = "comboBoxOborudov";
            this.comboBoxOborudov.Size = new System.Drawing.Size(205, 33);
            this.comboBoxOborudov.TabIndex = 13;
            // 
            // comboBoxPrisposob
            // 
            this.comboBoxPrisposob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPrisposob.FormattingEnabled = true;
            this.comboBoxPrisposob.ItemHeight = 25;
            this.comboBoxPrisposob.Items.AddRange(new object[] {
            "7100-0007",
            "7100-0008"});
            this.comboBoxPrisposob.Location = new System.Drawing.Point(430, 311);
            this.comboBoxPrisposob.Name = "comboBoxPrisposob";
            this.comboBoxPrisposob.Size = new System.Drawing.Size(205, 33);
            this.comboBoxPrisposob.TabIndex = 14;
            // 
            // comboBoxTechnPer
            // 
            this.comboBoxTechnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTechnPer.FormattingEnabled = true;
            this.comboBoxTechnPer.ItemHeight = 25;
            this.comboBoxTechnPer.Items.AddRange(new object[] {
            "1 Точение черновое",
            "2 Точение получистовое",
            "3 Точение чистовое",
            "4 Точение тонкое",
            "5 Шлифование предварительное",
            "6 Шлифование чистовое",
            "7 Шлифование тонкое",
            "8 Суперфиниширование, притирка",
            "9 Обкатывание, алмазное выглаживание",
            "10 Растачивание черновое",
            "11 Растачивание получистовое",
            "12 Растачивание чистовое",
            "13 Растачивание тонкое",
            "14 Сверление и рассверливание",
            "15 Термообработка",
            "17 Фрезерование"});
            this.comboBoxTechnPer.Location = new System.Drawing.Point(430, 378);
            this.comboBoxTechnPer.Name = "comboBoxTechnPer";
            this.comboBoxTechnPer.Size = new System.Drawing.Size(205, 33);
            this.comboBoxTechnPer.TabIndex = 15;
            // 
            // comboBoxObrPov
            // 
            this.comboBoxObrPov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxObrPov.FormattingEnabled = true;
            this.comboBoxObrPov.ItemHeight = 25;
            this.comboBoxObrPov.Items.AddRange(new object[] {
            "9111",
            "131",
            "9121",
            "121",
            "9321",
            "9211",
            "211",
            "9411",
            "411",
            "512",
            "521",
            "9521",
            "651",
            "111",
            "9611",
            "611",
            "421",
            "9311",
            "9312",
            "311",
            "9221",
            "9113",
            "221",
            "9641",
            "9112",
            "9114",
            "543",
            "9542",
            "542",
            "9532",
            "532"});
            this.comboBoxObrPov.Location = new System.Drawing.Point(430, 458);
            this.comboBoxObrPov.Name = "comboBoxObrPov";
            this.comboBoxObrPov.Size = new System.Drawing.Size(205, 33);
            this.comboBoxObrPov.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Код оборудования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Код приспособления";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 50);
            this.label4.TabIndex = 19;
            this.label4.Text = "Код технологического \r\nперехода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(135, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 50);
            this.label5.TabIndex = 20;
            this.label5.Text = "Код обрабатываемой\r\nповерхности";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(672, 557);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(115, 39);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxObrPov);
            this.Controls.Add(this.comboBoxTechnPer);
            this.Controls.Add(this.comboBoxPrisposob);
            this.Controls.Add(this.comboBoxOborudov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelChoice);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новых данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label LabelChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOborudov;
        private System.Windows.Forms.ComboBox comboBoxPrisposob;
        private System.Windows.Forms.ComboBox comboBoxTechnPer;
        private System.Windows.Forms.ComboBox comboBoxObrPov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNext;
    }
}