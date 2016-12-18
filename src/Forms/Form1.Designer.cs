namespace Stacker.Forms
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "キーワード予約は未実装です"}, -1);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.agKeyWordReservationListView = new System.Windows.Forms.ListView();
			this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.keyWordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.agTimeReservationListView = new System.Windows.Forms.ListView();
			this.startTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.endTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.agPersonalityLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.agProgramLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.agLengthUpDown = new System.Windows.Forms.NumericUpDown();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.agProgramListView = new System.Windows.Forms.ListView();
			this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.programNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.personalityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hasVideoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.programListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agTimeReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.番組ページ表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.agStartRecordButton = new System.Windows.Forms.ToolStripButton();
			this.agRecordStopButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.agRecordSpecifiedTimeButton = new System.Windows.Forms.ToolStripButton();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateDisplayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agUpdateProgramListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.toolStripContainer2.ContentPanel.SuspendLayout();
			this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer2.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.agLengthUpDown)).BeginInit();
			this.tabPage9.SuspendLayout();
			this.programListMenu.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(71, 18);
			this.tabControl1.Location = new System.Drawing.Point(0, 26);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(604, 413);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.toolStripContainer2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(596, 387);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "超！A＆G＋";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// toolStripContainer2
			// 
			// 
			// toolStripContainer2.ContentPanel
			// 
			this.toolStripContainer2.ContentPanel.Controls.Add(this.tabControl2);
			this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(590, 356);
			this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
			this.toolStripContainer2.Name = "toolStripContainer2";
			this.toolStripContainer2.Size = new System.Drawing.Size(590, 381);
			this.toolStripContainer2.TabIndex = 4;
			this.toolStripContainer2.Text = "toolStripContainer2";
			// 
			// toolStripContainer2.TopToolStripPanel
			// 
			this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage9);
			this.tabControl2.Controls.Add(this.tabPage8);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(590, 356);
			this.tabControl2.TabIndex = 1;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tableLayoutPanel1);
			this.tabPage4.Controls.Add(this.agPersonalityLabel);
			this.tabPage4.Controls.Add(this.label2);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.agProgramLabel);
			this.tabPage4.Controls.Add(this.label4);
			this.tabPage4.Controls.Add(this.agLengthUpDown);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(582, 330);
			this.tabPage4.TabIndex = 2;
			this.tabPage4.Text = "管理";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.agKeyWordReservationListView, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.agTimeReservationListView, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 80);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 244);
			this.tableLayoutPanel1.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "時間予約:";
			// 
			// agKeyWordReservationListView
			// 
			this.agKeyWordReservationListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agKeyWordReservationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeHeader,
            this.keyWordHeader});
			this.agKeyWordReservationListView.FullRowSelect = true;
			this.agKeyWordReservationListView.GridLines = true;
			this.agKeyWordReservationListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
			this.agKeyWordReservationListView.Location = new System.Drawing.Point(288, 15);
			this.agKeyWordReservationListView.MultiSelect = false;
			this.agKeyWordReservationListView.Name = "agKeyWordReservationListView";
			this.agKeyWordReservationListView.Size = new System.Drawing.Size(279, 226);
			this.agKeyWordReservationListView.TabIndex = 16;
			this.agKeyWordReservationListView.UseCompatibleStateImageBehavior = false;
			this.agKeyWordReservationListView.View = System.Windows.Forms.View.Details;
			// 
			// typeHeader
			// 
			this.typeHeader.Text = "タイプ";
			// 
			// keyWordHeader
			// 
			this.keyWordHeader.Text = "キーワード";
			this.keyWordHeader.Width = 300;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(288, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 12);
			this.label3.TabIndex = 17;
			this.label3.Text = "キーワード予約:";
			// 
			// agTimeReservationListView
			// 
			this.agTimeReservationListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agTimeReservationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.startTimeHeader,
            this.endTimeHeader,
            this.nameHeader});
			this.agTimeReservationListView.FullRowSelect = true;
			this.agTimeReservationListView.GridLines = true;
			this.agTimeReservationListView.Location = new System.Drawing.Point(3, 15);
			this.agTimeReservationListView.MultiSelect = false;
			this.agTimeReservationListView.Name = "agTimeReservationListView";
			this.agTimeReservationListView.Size = new System.Drawing.Size(279, 226);
			this.agTimeReservationListView.TabIndex = 10;
			this.agTimeReservationListView.UseCompatibleStateImageBehavior = false;
			this.agTimeReservationListView.View = System.Windows.Forms.View.Details;
			// 
			// startTimeHeader
			// 
			this.startTimeHeader.Text = "開始";
			// 
			// endTimeHeader
			// 
			this.endTimeHeader.Text = "終了";
			// 
			// nameHeader
			// 
			this.nameHeader.Text = "予約名";
			this.nameHeader.Width = 300;
			// 
			// agPersonalityLabel
			// 
			this.agPersonalityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agPersonalityLabel.AutoEllipsis = true;
			this.agPersonalityLabel.Location = new System.Drawing.Point(81, 31);
			this.agPersonalityLabel.Name = "agPersonalityLabel";
			this.agPersonalityLabel.Size = new System.Drawing.Size(495, 12);
			this.agPersonalityLabel.TabIndex = 15;
			this.agPersonalityLabel.Text = "未取得";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 12);
			this.label2.TabIndex = 14;
			this.label2.Text = "パーソナリティ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 12);
			this.label1.TabIndex = 13;
			this.label1.Text = "番組:";
			// 
			// agProgramLabel
			// 
			this.agProgramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agProgramLabel.AutoEllipsis = true;
			this.agProgramLabel.Location = new System.Drawing.Point(81, 9);
			this.agProgramLabel.Name = "agProgramLabel";
			this.agProgramLabel.Size = new System.Drawing.Size(495, 12);
			this.agProgramLabel.TabIndex = 12;
			this.agProgramLabel.Text = "未取得";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(67, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "分";
			// 
			// agLengthUpDown
			// 
			this.agLengthUpDown.Location = new System.Drawing.Point(6, 55);
			this.agLengthUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.agLengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.agLengthUpDown.Name = "agLengthUpDown";
			this.agLengthUpDown.Size = new System.Drawing.Size(58, 19);
			this.agLengthUpDown.TabIndex = 7;
			this.agLengthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.agProgramListView);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(582, 330);
			this.tabPage9.TabIndex = 4;
			this.tabPage9.Text = "番組表";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// agProgramListView
			// 
			this.agProgramListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeHeader,
            this.programNameHeader,
            this.personalityHeader,
            this.hasVideoHeader});
			this.agProgramListView.ContextMenuStrip = this.programListMenu;
			this.agProgramListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.agProgramListView.FullRowSelect = true;
			this.agProgramListView.GridLines = true;
			this.agProgramListView.Location = new System.Drawing.Point(3, 3);
			this.agProgramListView.MultiSelect = false;
			this.agProgramListView.Name = "agProgramListView";
			this.agProgramListView.Size = new System.Drawing.Size(576, 324);
			this.agProgramListView.TabIndex = 1;
			this.agProgramListView.UseCompatibleStateImageBehavior = false;
			this.agProgramListView.View = System.Windows.Forms.View.Details;
			this.agProgramListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agProgramListView_MouseDoubleClick);
			// 
			// timeHeader
			// 
			this.timeHeader.Text = "時間";
			this.timeHeader.Width = 55;
			// 
			// programNameHeader
			// 
			this.programNameHeader.Text = "番組名";
			this.programNameHeader.Width = 250;
			// 
			// personalityHeader
			// 
			this.personalityHeader.Text = "パーソナリティ";
			this.personalityHeader.Width = 200;
			// 
			// hasVideoHeader
			// 
			this.hasVideoHeader.Text = "動画";
			this.hasVideoHeader.Width = 40;
			// 
			// programListMenu
			// 
			this.programListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agTimeReservationMenuItem,
            this.toolStripSeparator2,
            this.番組ページ表示ToolStripMenuItem});
			this.programListMenu.Name = "programListMenu";
			this.programListMenu.Size = new System.Drawing.Size(161, 54);
			this.programListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.programListMenu_Opening);
			// 
			// agTimeReservationMenuItem
			// 
			this.agTimeReservationMenuItem.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.agTimeReservationMenuItem.Name = "agTimeReservationMenuItem";
			this.agTimeReservationMenuItem.Size = new System.Drawing.Size(160, 22);
			this.agTimeReservationMenuItem.Text = "時間予約(&T)";
			this.agTimeReservationMenuItem.Click += new System.EventHandler(this.agTimeReservationMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
			// 
			// 番組ページ表示ToolStripMenuItem
			// 
			this.番組ページ表示ToolStripMenuItem.Enabled = false;
			this.番組ページ表示ToolStripMenuItem.Name = "番組ページ表示ToolStripMenuItem";
			this.番組ページ表示ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.番組ページ表示ToolStripMenuItem.Text = "番組ページ表示";
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.button1);
			this.tabPage8.Controls.Add(this.label8);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(582, 330);
			this.tabPage8.TabIndex = 3;
			this.tabPage8.Text = "ライブラリ";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "保存フォルダを開く";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 12);
			this.label8.TabIndex = 16;
			this.label8.Text = "未実装です";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agStartRecordButton,
            this.agRecordStopButton,
            this.toolStripSeparator1,
            this.agRecordSpecifiedTimeButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(590, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// agStartRecordButton
			// 
			this.agStartRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agStartRecordButton.Image = global::Stacker.Properties.Resources.RecordHS;
			this.agStartRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agStartRecordButton.Name = "agStartRecordButton";
			this.agStartRecordButton.Size = new System.Drawing.Size(23, 22);
			this.agStartRecordButton.Text = "録音開始";
			this.agStartRecordButton.Click += new System.EventHandler(this.agStartRecordButton_Click);
			// 
			// agRecordStopButton
			// 
			this.agRecordStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agRecordStopButton.Image = global::Stacker.Properties.Resources.PauseHS;
			this.agRecordStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agRecordStopButton.Name = "agRecordStopButton";
			this.agRecordStopButton.Size = new System.Drawing.Size(23, 22);
			this.agRecordStopButton.Text = "録音停止";
			this.agRecordStopButton.Click += new System.EventHandler(this.agStopRecordButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// agRecordSpecifiedTimeButton
			// 
			this.agRecordSpecifiedTimeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agRecordSpecifiedTimeButton.Image = global::Stacker.Properties.Resources.clock_rec;
			this.agRecordSpecifiedTimeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agRecordSpecifiedTimeButton.Name = "agRecordSpecifiedTimeButton";
			this.agRecordSpecifiedTimeButton.Size = new System.Drawing.Size(23, 22);
			this.agRecordSpecifiedTimeButton.Text = "長さを指定して録音";
			this.agRecordSpecifiedTimeButton.Click += new System.EventHandler(this.agRecordSpecifiedTimeButton_Click);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label6);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(596, 387);
			this.tabPage6.TabIndex = 2;
			this.tabPage6.Text = "音泉";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 12);
			this.label6.TabIndex = 15;
			this.label6.Text = "未実装です";
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.label7);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(596, 387);
			this.tabPage7.TabIndex = 3;
			this.tabPage7.Text = "響";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "未実装です";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(604, 26);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDisplayMenuItem,
            this.agUpdateProgramListMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.viewToolStripMenuItem.Text = "表示(&V)";
			// 
			// updateDisplayMenuItem
			// 
			this.updateDisplayMenuItem.Name = "updateDisplayMenuItem";
			this.updateDisplayMenuItem.ShortcutKeyDisplayString = "";
			this.updateDisplayMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.updateDisplayMenuItem.Size = new System.Drawing.Size(177, 22);
			this.updateDisplayMenuItem.Text = "更新(&U)";
			this.updateDisplayMenuItem.Click += new System.EventHandler(this.updateDisplayMenuItem_Click);
			// 
			// agUpdateProgramListMenuItem
			// 
			this.agUpdateProgramListMenuItem.Name = "agUpdateProgramListMenuItem";
			this.agUpdateProgramListMenuItem.Size = new System.Drawing.Size(177, 22);
			this.agUpdateProgramListMenuItem.Text = "番組表の再取得(&P)";
			this.agUpdateProgramListMenuItem.Click += new System.EventHandler(this.agUpdateProgramListMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
			this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.versionToolStripMenuItem.Text = "バージョン情報(&A)";
			this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(604, 23);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
			this.toolStripStatusLabel1.Text = "準備完了";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 462);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(300, 340);
			this.Name = "Form1";
			this.Text = "{0} - ver.{1}";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.toolStripContainer2.ContentPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.PerformLayout();
			this.toolStripContainer2.ResumeLayout(false);
			this.toolStripContainer2.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.agLengthUpDown)).EndInit();
			this.tabPage9.ResumeLayout(false);
			this.programListMenu.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown agLengthUpDown;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton agStartRecordButton;
		private System.Windows.Forms.ToolStripButton agRecordStopButton;
		private System.Windows.Forms.ListView agTimeReservationListView;
		private System.Windows.Forms.ColumnHeader nameHeader;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton agRecordSpecifiedTimeButton;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.ListView agProgramListView;
		private System.Windows.Forms.ColumnHeader timeHeader;
		private System.Windows.Forms.ColumnHeader programNameHeader;
		private System.Windows.Forms.ColumnHeader personalityHeader;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateDisplayMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agUpdateProgramListMenuItem;
		private System.Windows.Forms.Label agProgramLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label agPersonalityLabel;
		private System.Windows.Forms.ColumnHeader startTimeHeader;
		private System.Windows.Forms.ColumnHeader endTimeHeader;
		private System.Windows.Forms.ColumnHeader hasVideoHeader;
		private System.Windows.Forms.ListView agKeyWordReservationListView;
		private System.Windows.Forms.ColumnHeader keyWordHeader;
		private System.Windows.Forms.ColumnHeader typeHeader;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip programListMenu;
		private System.Windows.Forms.ToolStripMenuItem agTimeReservationMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 番組ページ表示ToolStripMenuItem;
	}
}

