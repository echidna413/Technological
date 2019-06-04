namespace FormaRegistr
{
    partial class ChooseSpravoch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSpravoch));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SpravKodOborud = new System.Windows.Forms.Button();
            this.SpravKodTechn = new System.Windows.Forms.Button();
            this.SpravKodObrabPov = new System.Windows.Forms.Button();
            this.SpravPrisposob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите справочник:";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(583, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SpravKodOborud
            // 
            this.SpravKodOborud.BackColor = System.Drawing.Color.SteelBlue;
            this.SpravKodOborud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravKodOborud.ForeColor = System.Drawing.Color.White;
            this.SpravKodOborud.Location = new System.Drawing.Point(177, 130);
            this.SpravKodOborud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpravKodOborud.Name = "SpravKodOborud";
            this.SpravKodOborud.Size = new System.Drawing.Size(301, 71);
            this.SpravKodOborud.TabIndex = 5;
            this.SpravKodOborud.Text = "Коды оборудования";
            this.SpravKodOborud.UseVisualStyleBackColor = false;
            this.SpravKodOborud.Click += new System.EventHandler(this.SpravKodOborud_Click);
            // 
            // SpravKodTechn
            // 
            this.SpravKodTechn.BackColor = System.Drawing.Color.SteelBlue;
            this.SpravKodTechn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravKodTechn.ForeColor = System.Drawing.Color.White;
            this.SpravKodTechn.Location = new System.Drawing.Point(177, 226);
            this.SpravKodTechn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpravKodTechn.Name = "SpravKodTechn";
            this.SpravKodTechn.Size = new System.Drawing.Size(301, 71);
            this.SpravKodTechn.TabIndex = 6;
            this.SpravKodTechn.Text = "Коды технологического перехода";
            this.SpravKodTechn.UseVisualStyleBackColor = false;
            this.SpravKodTechn.Click += new System.EventHandler(this.SpravKodTechn_Click);
            // 
            // SpravKodObrabPov
            // 
            this.SpravKodObrabPov.BackColor = System.Drawing.Color.SteelBlue;
            this.SpravKodObrabPov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravKodObrabPov.ForeColor = System.Drawing.Color.White;
            this.SpravKodObrabPov.Location = new System.Drawing.Point(177, 320);
            this.SpravKodObrabPov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpravKodObrabPov.Name = "SpravKodObrabPov";
            this.SpravKodObrabPov.Size = new System.Drawing.Size(301, 71);
            this.SpravKodObrabPov.TabIndex = 7;
            this.SpravKodObrabPov.Text = "Коды обрабатывающей поверхности";
            this.SpravKodObrabPov.UseVisualStyleBackColor = false;
            this.SpravKodObrabPov.Click += new System.EventHandler(this.SpravKodObrabPov_Click);
            // 
            // SpravPrisposob
            // 
            this.SpravPrisposob.BackColor = System.Drawing.Color.SteelBlue;
            this.SpravPrisposob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravPrisposob.ForeColor = System.Drawing.Color.White;
            this.SpravPrisposob.Location = new System.Drawing.Point(177, 414);
            this.SpravPrisposob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpravPrisposob.Name = "SpravPrisposob";
            this.SpravPrisposob.Size = new System.Drawing.Size(301, 71);
            this.SpravPrisposob.TabIndex = 8;
            this.SpravPrisposob.Text = "Коды приспособлений";
            this.SpravPrisposob.UseVisualStyleBackColor = false;
            this.SpravPrisposob.Click += new System.EventHandler(this.SpravPrisposob_Click);
            // 
            // ChooseSpravoch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(693, 538);
            this.Controls.Add(this.SpravPrisposob);
            this.Controls.Add(this.SpravKodObrabPov);
            this.Controls.Add(this.SpravKodTechn);
            this.Controls.Add(this.SpravKodOborud);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseSpravoch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseSpravoch";
            this.Load += new System.EventHandler(this.ChooseSpravoch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SpravKodOborud;
        private System.Windows.Forms.Button SpravKodTechn;
        private System.Windows.Forms.Button SpravKodObrabPov;
        private System.Windows.Forms.Button SpravPrisposob;
    }
}