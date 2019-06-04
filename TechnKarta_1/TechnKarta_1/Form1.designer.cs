namespace TechnKarta_1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.validate_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.reset_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadFile_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.loadHeader_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1184, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_toolStripLabel,
            this.toolStripLabel1,
            this.validate_toolStripLabel,
            this.reset_toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open_toolStripLabel
            // 
            this.open_toolStripLabel.Name = "open_toolStripLabel";
            this.open_toolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.open_toolStripLabel.Text = "Open";
            this.open_toolStripLabel.Click += new System.EventHandler(this.open_toolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // validate_toolStripLabel
            // 
            this.validate_toolStripLabel.Name = "validate_toolStripLabel";
            this.validate_toolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.validate_toolStripLabel.Text = "Validate";
            this.validate_toolStripLabel.Click += new System.EventHandler(this.validate_toolStripLabel_Click);
            // 
            // reset_toolStripLabel
            // 
            this.reset_toolStripLabel.Name = "reset_toolStripLabel";
            this.reset_toolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.reset_toolStripLabel.Text = "Reset";
            this.reset_toolStripLabel.Click += new System.EventHandler(this.reset_toolStripLabel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Microsoft Excel Files(*.xls;*.xlsx;*.ods;*.xlsb;*.xlsm)|*.xls;*.xlsx;*.xlsb;*.ods" +
    ";*.xlsm|All files|*.*";
            this.openFileDialog1.Title = "Excel File Dialog";
            // 
            // loadFile_backgroundWorker
            // 
            this.loadFile_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadFile_backgroundWorker_DoWork);
            this.loadFile_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadFile_backgroundWorker_RunWorkerCompleted);
            // 
            // loadHeader_backgroundWorker
            // 
            this.loadHeader_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadHeader_backgroundWorker_DoWork);
            this.loadHeader_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadHeader_backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel open_toolStripLabel;
        private System.Windows.Forms.ToolStripLabel validate_toolStripLabel;
        private System.ComponentModel.BackgroundWorker loadFile_backgroundWorker;
        private System.ComponentModel.BackgroundWorker loadHeader_backgroundWorker;
        private System.Windows.Forms.ToolStripLabel reset_toolStripLabel;
    }
}

