namespace UI
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.ResultView1 = new System.Windows.Forms.DataGridView();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info_label1 = new System.Windows.Forms.Label();
            this.info_label2 = new System.Windows.Forms.Label();
            this.ResultView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultAndTimeLanel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultView1
            // 
            this.ResultView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Power,
            this.N});
            this.ResultView1.Location = new System.Drawing.Point(12, 82);
            this.ResultView1.Name = "ResultView1";
            this.ResultView1.RowHeadersWidth = 51;
            this.ResultView1.RowTemplate.Height = 24;
            this.ResultView1.Size = new System.Drawing.Size(249, 477);
            this.ResultView1.TabIndex = 0;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.MinimumWidth = 6;
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            this.Power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Power.Width = 65;
            // 
            // N
            // 
            this.N.HeaderText = "Count";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.N.Width = 65;
            // 
            // info_label1
            // 
            this.info_label1.Location = new System.Drawing.Point(12, 9);
            this.info_label1.Name = "info_label1";
            this.info_label1.Size = new System.Drawing.Size(249, 70);
            this.info_label1.TabIndex = 2;
            this.info_label1.Text = "Вектор кол-ва полных подграфов мощности от 2 до (N-1) для графа 1";
            this.info_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_label2
            // 
            this.info_label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.info_label2.Location = new System.Drawing.Point(510, 9);
            this.info_label2.Name = "info_label2";
            this.info_label2.Size = new System.Drawing.Size(249, 70);
            this.info_label2.TabIndex = 3;
            this.info_label2.Text = "Вектор кол-ва полных подграфов мощности от 2 до (N-1) для графа 2";
            this.info_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultView2
            // 
            this.ResultView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ResultView2.Location = new System.Drawing.Point(513, 82);
            this.ResultView2.Name = "ResultView2";
            this.ResultView2.RowHeadersWidth = 51;
            this.ResultView2.RowTemplate.Height = 24;
            this.ResultView2.Size = new System.Drawing.Size(246, 477);
            this.ResultView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Power";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Count";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // ResultAndTimeLanel
            // 
            this.ResultAndTimeLanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultAndTimeLanel.Location = new System.Drawing.Point(267, 113);
            this.ResultAndTimeLanel.Name = "ResultAndTimeLanel";
            this.ResultAndTimeLanel.Size = new System.Drawing.Size(240, 51);
            this.ResultAndTimeLanel.TabIndex = 5;
            this.ResultAndTimeLanel.Text = "Result and Time";
            this.ResultAndTimeLanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 571);
            this.Controls.Add(this.ResultAndTimeLanel);
            this.Controls.Add(this.ResultView2);
            this.Controls.Add(this.info_label2);
            this.Controls.Add(this.info_label1);
            this.Controls.Add(this.ResultView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(788, 618);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты сравнений";
            ((System.ComponentModel.ISupportInitialize)(this.ResultView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultView1;
        private System.Windows.Forms.Label info_label1;
        private System.Windows.Forms.Label info_label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridView ResultView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label ResultAndTimeLanel;
    }
}