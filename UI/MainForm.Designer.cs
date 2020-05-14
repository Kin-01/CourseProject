namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_res = new System.Windows.Forms.Button();
            this.button_load1 = new System.Windows.Forms.Button();
            this.button_load2 = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Graph_Zone2 = new System.Windows.Forms.PictureBox();
            this.button_top2 = new System.Windows.Forms.Button();
            this.button_rib2 = new System.Windows.Forms.Button();
            this.button_delete2 = new System.Windows.Forms.Button();
            this.button_clear2 = new System.Windows.Forms.Button();
            this.GroupOfGraph2 = new System.Windows.Forms.GroupBox();
            this.numericrandom2 = new System.Windows.Forms.NumericUpDown();
            this.button_random2 = new System.Windows.Forms.Button();
            this.button_save1 = new System.Windows.Forms.Button();
            this.button_save2 = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.LoadInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusSaveLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupOfGraph1 = new System.Windows.Forms.GroupBox();
            this.numericrandom1 = new System.Windows.Forms.NumericUpDown();
            this.button_random1 = new System.Windows.Forms.Button();
            this.Graph_Zone1 = new System.Windows.Forms.PictureBox();
            this.button_top1 = new System.Windows.Forms.Button();
            this.button_rib1 = new System.Windows.Forms.Button();
            this.button_delete1 = new System.Windows.Forms.Button();
            this.button_clear1 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.InfoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LastResultStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressEqual = new System.Windows.Forms.ProgressBar();
            this.TimeToResult = new System.Windows.Forms.Timer(this.components);
            this.array1 = new System.Windows.Forms.RichTextBox();
            this.array2 = new System.Windows.Forms.RichTextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Zone2)).BeginInit();
            this.GroupOfGraph2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericrandom2)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.GroupOfGraph1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericrandom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Zone1)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(480, 111);
            this.button_res.Margin = new System.Windows.Forms.Padding(2);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(115, 42);
            this.button_res.TabIndex = 2;
            this.button_res.Text = "Compare";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.IsGraphsEqual);
            // 
            // button_load1
            // 
            this.button_load1.Location = new System.Drawing.Point(9, 533);
            this.button_load1.Margin = new System.Windows.Forms.Padding(2);
            this.button_load1.Name = "button_load1";
            this.button_load1.Size = new System.Drawing.Size(55, 33);
            this.button_load1.TabIndex = 0;
            this.button_load1.Text = "Load";
            this.button_load1.UseVisualStyleBackColor = true;
            this.button_load1.Click += new System.EventHandler(this.LoadGraph1);
            // 
            // button_load2
            // 
            this.button_load2.Location = new System.Drawing.Point(602, 533);
            this.button_load2.Margin = new System.Windows.Forms.Padding(2);
            this.button_load2.Name = "button_load2";
            this.button_load2.Size = new System.Drawing.Size(55, 33);
            this.button_load2.TabIndex = 1;
            this.button_load2.Text = "Load";
            this.button_load2.UseVisualStyleBackColor = true;
            this.button_load2.Click += new System.EventHandler(this.LoadGraph2);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenGraphDialog";
            // 
            // Graph_Zone2
            // 
            this.Graph_Zone2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Graph_Zone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Graph_Zone2.Location = new System.Drawing.Point(54, 18);
            this.Graph_Zone2.Margin = new System.Windows.Forms.Padding(2);
            this.Graph_Zone2.Name = "Graph_Zone2";
            this.Graph_Zone2.Size = new System.Drawing.Size(400, 400);
            this.Graph_Zone2.TabIndex = 11;
            this.Graph_Zone2.TabStop = false;
            this.Graph_Zone2.Paint += new System.Windows.Forms.PaintEventHandler(this.Refresh_Graph2);
            this.Graph_Zone2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoAction2);
            // 
            // button_top2
            // 
            this.button_top2.BackColor = System.Drawing.Color.LawnGreen;
            this.button_top2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_top2.Location = new System.Drawing.Point(12, 285);
            this.button_top2.Margin = new System.Windows.Forms.Padding(2);
            this.button_top2.Name = "button_top2";
            this.button_top2.Size = new System.Drawing.Size(38, 41);
            this.button_top2.TabIndex = 12;
            this.button_top2.Text = "TOP";
            this.button_top2.UseVisualStyleBackColor = false;
            this.button_top2.Click += new System.EventHandler(this.Choose_Top2);
            // 
            // button_rib2
            // 
            this.button_rib2.BackColor = System.Drawing.Color.White;
            this.button_rib2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rib2.Location = new System.Drawing.Point(12, 331);
            this.button_rib2.Margin = new System.Windows.Forms.Padding(2);
            this.button_rib2.Name = "button_rib2";
            this.button_rib2.Size = new System.Drawing.Size(38, 41);
            this.button_rib2.TabIndex = 13;
            this.button_rib2.Text = "RIB";
            this.button_rib2.UseVisualStyleBackColor = false;
            this.button_rib2.Click += new System.EventHandler(this.Choose_Rib2);
            // 
            // button_delete2
            // 
            this.button_delete2.BackColor = System.Drawing.Color.White;
            this.button_delete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete2.Location = new System.Drawing.Point(12, 377);
            this.button_delete2.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete2.Name = "button_delete2";
            this.button_delete2.Size = new System.Drawing.Size(38, 41);
            this.button_delete2.TabIndex = 14;
            this.button_delete2.Text = "DEL";
            this.button_delete2.UseVisualStyleBackColor = false;
            this.button_delete2.Click += new System.EventHandler(this.Choose_Del2);
            // 
            // button_clear2
            // 
            this.button_clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear2.Location = new System.Drawing.Point(12, 240);
            this.button_clear2.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear2.Name = "button_clear2";
            this.button_clear2.Size = new System.Drawing.Size(38, 41);
            this.button_clear2.TabIndex = 15;
            this.button_clear2.Text = "CL";
            this.button_clear2.UseVisualStyleBackColor = true;
            this.button_clear2.Click += new System.EventHandler(this.Clear_Graph2);
            // 
            // GroupOfGraph2
            // 
            this.GroupOfGraph2.Controls.Add(this.numericrandom2);
            this.GroupOfGraph2.Controls.Add(this.button_random2);
            this.GroupOfGraph2.Controls.Add(this.Graph_Zone2);
            this.GroupOfGraph2.Controls.Add(this.button_top2);
            this.GroupOfGraph2.Controls.Add(this.button_rib2);
            this.GroupOfGraph2.Controls.Add(this.button_delete2);
            this.GroupOfGraph2.Controls.Add(this.button_clear2);
            this.GroupOfGraph2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupOfGraph2.Location = new System.Drawing.Point(602, 41);
            this.GroupOfGraph2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupOfGraph2.Name = "GroupOfGraph2";
            this.GroupOfGraph2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupOfGraph2.Size = new System.Drawing.Size(464, 429);
            this.GroupOfGraph2.TabIndex = 16;
            this.GroupOfGraph2.TabStop = false;
            // 
            // numericrandom2
            // 
            this.numericrandom2.Location = new System.Drawing.Point(12, 63);
            this.numericrandom2.Margin = new System.Windows.Forms.Padding(2);
            this.numericrandom2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericrandom2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericrandom2.Name = "numericrandom2";
            this.numericrandom2.Size = new System.Drawing.Size(38, 21);
            this.numericrandom2.TabIndex = 18;
            this.numericrandom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericrandom2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button_random2
            // 
            this.button_random2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_random2.Location = new System.Drawing.Point(12, 18);
            this.button_random2.Margin = new System.Windows.Forms.Padding(2);
            this.button_random2.Name = "button_random2";
            this.button_random2.Size = new System.Drawing.Size(38, 41);
            this.button_random2.TabIndex = 17;
            this.button_random2.Text = "RND";
            this.button_random2.UseVisualStyleBackColor = false;
            this.button_random2.Click += new System.EventHandler(this.Random_Graph2);
            // 
            // button_save1
            // 
            this.button_save1.Location = new System.Drawing.Point(68, 533);
            this.button_save1.Margin = new System.Windows.Forms.Padding(2);
            this.button_save1.Name = "button_save1";
            this.button_save1.Size = new System.Drawing.Size(55, 33);
            this.button_save1.TabIndex = 17;
            this.button_save1.Text = "Save";
            this.button_save1.UseVisualStyleBackColor = true;
            this.button_save1.Click += new System.EventHandler(this.SaveGraph1);
            // 
            // button_save2
            // 
            this.button_save2.Location = new System.Drawing.Point(665, 533);
            this.button_save2.Margin = new System.Windows.Forms.Padding(2);
            this.button_save2.Name = "button_save2";
            this.button_save2.Size = new System.Drawing.Size(55, 33);
            this.button_save2.TabIndex = 18;
            this.button_save2.Text = "Save";
            this.button_save2.UseVisualStyleBackColor = true;
            this.button_save2.Click += new System.EventHandler(this.SaveGraph2);
            // 
            // LoadInfoTimer
            // 
            this.LoadInfoTimer.Interval = 3000;
            this.LoadInfoTimer.Tick += new System.EventHandler(this.LoadSatusOff);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 16);
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = false;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.Status,
            this.StatusSaveLoad});
            this.StatusBar.Location = new System.Drawing.Point(0, 576);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusBar.Size = new System.Drawing.Size(1117, 21);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "status";
            // 
            // StatusSaveLoad
            // 
            this.StatusSaveLoad.ForeColor = System.Drawing.Color.Green;
            this.StatusSaveLoad.Name = "StatusSaveLoad";
            this.StatusSaveLoad.Size = new System.Drawing.Size(89, 16);
            this.StatusSaveLoad.Text = "StatusSaveLoad";
            // 
            // GroupOfGraph1
            // 
            this.GroupOfGraph1.Controls.Add(this.numericrandom1);
            this.GroupOfGraph1.Controls.Add(this.button_random1);
            this.GroupOfGraph1.Controls.Add(this.Graph_Zone1);
            this.GroupOfGraph1.Controls.Add(this.button_top1);
            this.GroupOfGraph1.Controls.Add(this.button_rib1);
            this.GroupOfGraph1.Controls.Add(this.button_delete1);
            this.GroupOfGraph1.Controls.Add(this.button_clear1);
            this.GroupOfGraph1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupOfGraph1.Location = new System.Drawing.Point(9, 41);
            this.GroupOfGraph1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupOfGraph1.Name = "GroupOfGraph1";
            this.GroupOfGraph1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupOfGraph1.Size = new System.Drawing.Size(464, 429);
            this.GroupOfGraph1.TabIndex = 19;
            this.GroupOfGraph1.TabStop = false;
            // 
            // numericrandom1
            // 
            this.numericrandom1.Location = new System.Drawing.Point(12, 64);
            this.numericrandom1.Margin = new System.Windows.Forms.Padding(2);
            this.numericrandom1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericrandom1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericrandom1.Name = "numericrandom1";
            this.numericrandom1.Size = new System.Drawing.Size(38, 21);
            this.numericrandom1.TabIndex = 17;
            this.numericrandom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericrandom1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button_random1
            // 
            this.button_random1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_random1.Location = new System.Drawing.Point(12, 18);
            this.button_random1.Margin = new System.Windows.Forms.Padding(2);
            this.button_random1.Name = "button_random1";
            this.button_random1.Size = new System.Drawing.Size(38, 41);
            this.button_random1.TabIndex = 16;
            this.button_random1.Text = "RND";
            this.button_random1.UseVisualStyleBackColor = false;
            this.button_random1.Click += new System.EventHandler(this.Random_Graph1);
            // 
            // Graph_Zone1
            // 
            this.Graph_Zone1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Graph_Zone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Graph_Zone1.Location = new System.Drawing.Point(54, 18);
            this.Graph_Zone1.Margin = new System.Windows.Forms.Padding(2);
            this.Graph_Zone1.Name = "Graph_Zone1";
            this.Graph_Zone1.Size = new System.Drawing.Size(400, 400);
            this.Graph_Zone1.TabIndex = 11;
            this.Graph_Zone1.TabStop = false;
            this.Graph_Zone1.Paint += new System.Windows.Forms.PaintEventHandler(this.Refresh_Graph1);
            this.Graph_Zone1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoAction1);
            // 
            // button_top1
            // 
            this.button_top1.BackColor = System.Drawing.Color.LawnGreen;
            this.button_top1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_top1.Location = new System.Drawing.Point(12, 285);
            this.button_top1.Margin = new System.Windows.Forms.Padding(2);
            this.button_top1.Name = "button_top1";
            this.button_top1.Size = new System.Drawing.Size(38, 41);
            this.button_top1.TabIndex = 12;
            this.button_top1.Text = "TOP";
            this.button_top1.UseVisualStyleBackColor = false;
            this.button_top1.Click += new System.EventHandler(this.Choose_Top1);
            // 
            // button_rib1
            // 
            this.button_rib1.BackColor = System.Drawing.Color.White;
            this.button_rib1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rib1.Location = new System.Drawing.Point(12, 331);
            this.button_rib1.Margin = new System.Windows.Forms.Padding(2);
            this.button_rib1.Name = "button_rib1";
            this.button_rib1.Size = new System.Drawing.Size(38, 41);
            this.button_rib1.TabIndex = 13;
            this.button_rib1.Text = "RIB";
            this.button_rib1.UseVisualStyleBackColor = false;
            this.button_rib1.Click += new System.EventHandler(this.Choose_Rib1);
            // 
            // button_delete1
            // 
            this.button_delete1.BackColor = System.Drawing.Color.White;
            this.button_delete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete1.Location = new System.Drawing.Point(12, 377);
            this.button_delete1.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete1.Name = "button_delete1";
            this.button_delete1.Size = new System.Drawing.Size(38, 41);
            this.button_delete1.TabIndex = 14;
            this.button_delete1.Text = "DEL";
            this.button_delete1.UseVisualStyleBackColor = false;
            this.button_delete1.Click += new System.EventHandler(this.Choose_Del1);
            // 
            // button_clear1
            // 
            this.button_clear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear1.Location = new System.Drawing.Point(12, 240);
            this.button_clear1.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear1.Name = "button_clear1";
            this.button_clear1.Size = new System.Drawing.Size(38, 41);
            this.button_clear1.TabIndex = 15;
            this.button_clear1.Text = "CL";
            this.button_clear1.UseVisualStyleBackColor = true;
            this.button_clear1.Click += new System.EventHandler(this.Clear_Graph1);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoStrip,
            this.LastResultStrip});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1117, 24);
            this.MainMenu.TabIndex = 22;
            this.MainMenu.Text = "menuStrip1";
            // 
            // InfoStrip
            // 
            this.InfoStrip.Name = "InfoStrip";
            this.InfoStrip.Size = new System.Drawing.Size(40, 20);
            this.InfoStrip.Text = "Info";
            this.InfoStrip.Click += new System.EventHandler(this.ShowAboutWindow);
            // 
            // LastResultStrip
            // 
            this.LastResultStrip.Enabled = false;
            this.LastResultStrip.Name = "LastResultStrip";
            this.LastResultStrip.Size = new System.Drawing.Size(133, 20);
            this.LastResultStrip.Text = "Last Successful Result";
            this.LastResultStrip.Click += new System.EventHandler(this.ShowLastSuccessfulResult);
            // 
            // ResultStatusTimer
            // 
            this.ResultStatusTimer.Interval = 3000;
            this.ResultStatusTimer.Tick += new System.EventHandler(this.ResultStatusOff);
            // 
            // ProgressEqual
            // 
            this.ProgressEqual.Location = new System.Drawing.Point(480, 159);
            this.ProgressEqual.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressEqual.Name = "ProgressEqual";
            this.ProgressEqual.Size = new System.Drawing.Size(115, 19);
            this.ProgressEqual.TabIndex = 23;
            // 
            // array1
            // 
            this.array1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.array1.Location = new System.Drawing.Point(9, 482);
            this.array1.Margin = new System.Windows.Forms.Padding(2);
            this.array1.Name = "array1";
            this.array1.ReadOnly = true;
            this.array1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.array1.Size = new System.Drawing.Size(464, 37);
            this.array1.TabIndex = 25;
            this.array1.Text = "";
            this.array1.WordWrap = false;
            // 
            // array2
            // 
            this.array2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.array2.Location = new System.Drawing.Point(602, 482);
            this.array2.Margin = new System.Windows.Forms.Padding(2);
            this.array2.Name = "array2";
            this.array2.ReadOnly = true;
            this.array2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.array2.Size = new System.Drawing.Size(464, 37);
            this.array2.TabIndex = 26;
            this.array2.Text = "";
            this.array2.WordWrap = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(477, 180);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(118, 19);
            this.ResultLabel.TabIndex = 27;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1117, 597);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.array2);
            this.Controls.Add(this.array1);
            this.Controls.Add(this.ProgressEqual);
            this.Controls.Add(this.GroupOfGraph1);
            this.Controls.Add(this.button_save2);
            this.Controls.Add(this.button_save1);
            this.Controls.Add(this.GroupOfGraph2);
            this.Controls.Add(this.button_load2);
            this.Controls.Add(this.button_load1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.button_res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение графов";
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Zone2)).EndInit();
            this.GroupOfGraph2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericrandom2)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.GroupOfGraph1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericrandom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Zone1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_load1;
        private System.Windows.Forms.Button button_load2;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.PictureBox Graph_Zone2;
        private System.Windows.Forms.Button button_top2;
        private System.Windows.Forms.Button button_rib2;
        private System.Windows.Forms.Button button_delete2;
        private System.Windows.Forms.Button button_clear2;
        private System.Windows.Forms.GroupBox GroupOfGraph2;
        private System.Windows.Forms.Button button_save1;
        private System.Windows.Forms.Button button_save2;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Timer LoadInfoTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusSaveLoad;
        private System.Windows.Forms.GroupBox GroupOfGraph1;
        private System.Windows.Forms.PictureBox Graph_Zone1;
        private System.Windows.Forms.Button button_top1;
        private System.Windows.Forms.Button button_rib1;
        private System.Windows.Forms.Button button_delete1;
        private System.Windows.Forms.Button button_clear1;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem InfoStrip;
        private System.Windows.Forms.Button button_random1;
        private System.Windows.Forms.Button button_random2;
        private System.Windows.Forms.NumericUpDown numericrandom2;
        private System.Windows.Forms.NumericUpDown numericrandom1;
        private System.Windows.Forms.Timer ResultStatusTimer;
        private System.Windows.Forms.ProgressBar ProgressEqual;
        private System.Windows.Forms.Timer TimeToResult;
        private System.Windows.Forms.RichTextBox array1;
        private System.Windows.Forms.RichTextBox array2;
        private System.Windows.Forms.ToolStripMenuItem LastResultStrip;
        private System.Windows.Forms.Label ResultLabel;
    }
}

