namespace TechnKarta_1
{
    partial class FormEditBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBooks));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kodOborudov = new System.Windows.Forms.ToolStripMenuItem();
            this.kodPrisposob = new System.Windows.Forms.ToolStripMenuItem();
            this.kodTechnPer = new System.Windows.Forms.ToolStripMenuItem();
            this.kodObrPov = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kodOborudov,
            this.kodPrisposob,
            this.kodTechnPer,
            this.kodObrPov});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kodOborudov
            // 
            this.kodOborudov.Name = "kodOborudov";
            this.kodOborudov.Size = new System.Drawing.Size(164, 24);
            this.kodOborudov.Text = "Коды оборудования";
            // 
            // kodPrisposob
            // 
            this.kodPrisposob.Name = "kodPrisposob";
            this.kodPrisposob.Size = new System.Drawing.Size(182, 24);
            this.kodPrisposob.Text = "Коды приспособлений";
            // 
            // kodTechnPer
            // 
            this.kodTechnPer.Name = "kodTechnPer";
            this.kodTechnPer.Size = new System.Drawing.Size(258, 24);
            this.kodTechnPer.Text = "Коды технологических переходов";
            // 
            // kodObrPov
            // 
            this.kodObrPov.Name = "kodObrPov";
            this.kodObrPov.Size = new System.Drawing.Size(286, 24);
            this.kodObrPov.Text = "Коды обрабатываемых поверхностей";
            // 
            // FormEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 619);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование справочников";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kodOborudov;
        private System.Windows.Forms.ToolStripMenuItem kodPrisposob;
        private System.Windows.Forms.ToolStripMenuItem kodTechnPer;
        private System.Windows.Forms.ToolStripMenuItem kodObrPov;
    }
}