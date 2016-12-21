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
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
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
			this.agTimeReservationListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agAddTimeReservationListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agEditTimeReservationListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.agDeleteTimeReservationListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.agProgramListView = new System.Windows.Forms.ListView();
			this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.programNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.personalityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.broadcastTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hasVideoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.agProgramListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agTimeReservateProgramListViewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.agDisplayProgramPageProgramListViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.agStartRecordButton = new System.Windows.Forms.ToolStripButton();
			this.agRecordStopButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.agRecordSpecifiedTimeButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.agProgramLabel = new System.Windows.Forms.ToolStripLabel();
			this.agPersonalityLabel = new System.Windows.Forms.ToolStripLabel();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.録音RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RealtimeRecordingMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agEnableVideoRealtimeMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateDisplayMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agUpdateProgramListMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.agTimeReservationListViewMenu.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.agProgramListViewMenu.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(799, 413);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.toolStripContainer2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(791, 387);
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
			this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(785, 356);
			this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
			this.toolStripContainer2.Name = "toolStripContainer2";
			this.toolStripContainer2.Size = new System.Drawing.Size(785, 381);
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
			this.tabControl2.Size = new System.Drawing.Size(785, 356);
			this.tabControl2.TabIndex = 1;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tableLayoutPanel1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(777, 330);
			this.tabPage4.TabIndex = 2;
			this.tabPage4.Text = "管理";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.agKeyWordReservationListView, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.agTimeReservationListView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 324);
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
            listViewItem2});
			this.agKeyWordReservationListView.Location = new System.Drawing.Point(388, 15);
			this.agKeyWordReservationListView.MultiSelect = false;
			this.agKeyWordReservationListView.Name = "agKeyWordReservationListView";
			this.agKeyWordReservationListView.Size = new System.Drawing.Size(380, 306);
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
			this.label3.Location = new System.Drawing.Point(388, 0);
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
			this.agTimeReservationListView.ContextMenuStrip = this.agTimeReservationListViewMenu;
			this.agTimeReservationListView.FullRowSelect = true;
			this.agTimeReservationListView.GridLines = true;
			this.agTimeReservationListView.Location = new System.Drawing.Point(3, 15);
			this.agTimeReservationListView.MultiSelect = false;
			this.agTimeReservationListView.Name = "agTimeReservationListView";
			this.agTimeReservationListView.Size = new System.Drawing.Size(379, 306);
			this.agTimeReservationListView.TabIndex = 10;
			this.agTimeReservationListView.UseCompatibleStateImageBehavior = false;
			this.agTimeReservationListView.View = System.Windows.Forms.View.Details;
			this.agTimeReservationListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agTimeReservationListView_MouseDoubleClick);
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
			// agTimeReservationListViewMenu
			// 
			this.agTimeReservationListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agAddTimeReservationListMenuItem,
            this.agEditTimeReservationListMenuItem,
            this.toolStripSeparator3,
            this.agDeleteTimeReservationListMenuItem});
			this.agTimeReservationListViewMenu.Name = "TimeReservationListMenu";
			this.agTimeReservationListViewMenu.Size = new System.Drawing.Size(121, 76);
			this.agTimeReservationListViewMenu.Opening += new System.ComponentModel.CancelEventHandler(this.agTimeReservationListViewMenu_Opening);
			// 
			// agAddTimeReservationListMenuItem
			// 
			this.agAddTimeReservationListMenuItem.Name = "agAddTimeReservationListMenuItem";
			this.agAddTimeReservationListMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agAddTimeReservationListMenuItem.Text = "追加(&A)";
			this.agAddTimeReservationListMenuItem.Click += new System.EventHandler(this.agAddTimeReservationListMenuItem_Click);
			// 
			// agEditTimeReservationListMenuItem
			// 
			this.agEditTimeReservationListMenuItem.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.agEditTimeReservationListMenuItem.Name = "agEditTimeReservationListMenuItem";
			this.agEditTimeReservationListMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agEditTimeReservationListMenuItem.Text = "編集(&E)";
			this.agEditTimeReservationListMenuItem.Click += new System.EventHandler(this.agEditTimeReservationListMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(117, 6);
			// 
			// agDeleteTimeReservationListMenuItem
			// 
			this.agDeleteTimeReservationListMenuItem.Name = "agDeleteTimeReservationListMenuItem";
			this.agDeleteTimeReservationListMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agDeleteTimeReservationListMenuItem.Text = "削除(&D)";
			this.agDeleteTimeReservationListMenuItem.Click += new System.EventHandler(this.agDeleteTimeReservationListMenuItem_Click);
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.agProgramListView);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(777, 330);
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
            this.broadcastTypeHeader,
            this.hasVideoHeader});
			this.agProgramListView.ContextMenuStrip = this.agProgramListViewMenu;
			this.agProgramListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.agProgramListView.FullRowSelect = true;
			this.agProgramListView.GridLines = true;
			this.agProgramListView.Location = new System.Drawing.Point(3, 3);
			this.agProgramListView.MultiSelect = false;
			this.agProgramListView.Name = "agProgramListView";
			this.agProgramListView.Size = new System.Drawing.Size(771, 324);
			this.agProgramListView.TabIndex = 1;
			this.agProgramListView.UseCompatibleStateImageBehavior = false;
			this.agProgramListView.View = System.Windows.Forms.View.Details;
			this.agProgramListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agProgramListView_MouseDoubleClick);
			// 
			// timeHeader
			// 
			this.timeHeader.Text = "時間";
			this.timeHeader.Width = 100;
			// 
			// programNameHeader
			// 
			this.programNameHeader.Text = "番組名";
			this.programNameHeader.Width = 300;
			// 
			// personalityHeader
			// 
			this.personalityHeader.Text = "パーソナリティ";
			this.personalityHeader.Width = 200;
			// 
			// broadcastTypeHeader
			// 
			this.broadcastTypeHeader.Text = "放送タイプ";
			this.broadcastTypeHeader.Width = 70;
			// 
			// hasVideoHeader
			// 
			this.hasVideoHeader.Text = "動画";
			this.hasVideoHeader.Width = 40;
			// 
			// agProgramListViewMenu
			// 
			this.agProgramListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agTimeReservateProgramListViewMenu,
            this.toolStripSeparator2,
            this.agDisplayProgramPageProgramListViewMenuItem});
			this.agProgramListViewMenu.Name = "programListMenu";
			this.agProgramListViewMenu.Size = new System.Drawing.Size(161, 54);
			this.agProgramListViewMenu.Opening += new System.ComponentModel.CancelEventHandler(this.agProgramListViewMenu_Opening);
			// 
			// agTimeReservateProgramListViewMenu
			// 
			this.agTimeReservateProgramListViewMenu.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.agTimeReservateProgramListViewMenu.Name = "agTimeReservateProgramListViewMenu";
			this.agTimeReservateProgramListViewMenu.Size = new System.Drawing.Size(160, 22);
			this.agTimeReservateProgramListViewMenu.Text = "時間予約(&T)";
			this.agTimeReservateProgramListViewMenu.Click += new System.EventHandler(this.agTimeReservateProgramListViewMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
			// 
			// 番組ページ表示ToolStripMenuItem
			// 
			this.agDisplayProgramPageProgramListViewMenuItem.Enabled = false;
			this.agDisplayProgramPageProgramListViewMenuItem.Name = "番組ページ表示ToolStripMenuItem";
			this.agDisplayProgramPageProgramListViewMenuItem.Size = new System.Drawing.Size(160, 22);
			this.agDisplayProgramPageProgramListViewMenuItem.Text = "番組ページ表示";
			this.agDisplayProgramPageProgramListViewMenuItem.Click += new System.EventHandler(this.agDisplayProgramPageProgramListViewMenuItem_Click);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.button1);
			this.tabPage8.Controls.Add(this.label8);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(777, 330);
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
            this.agRecordSpecifiedTimeButton,
            this.toolStripSeparator4,
            this.agProgramLabel,
            this.agPersonalityLabel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(785, 25);
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
			this.agStartRecordButton.Text = "リアルタイム録音開始";
			this.agStartRecordButton.Click += new System.EventHandler(this.agStartRecordButton_Click);
			// 
			// agRecordStopButton
			// 
			this.agRecordStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agRecordStopButton.Image = global::Stacker.Properties.Resources.PauseHS;
			this.agRecordStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agRecordStopButton.Name = "agRecordStopButton";
			this.agRecordStopButton.Size = new System.Drawing.Size(23, 22);
			this.agRecordStopButton.Text = "リアルタイム録音停止";
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
			this.agRecordSpecifiedTimeButton.Text = "リアルタイム録音開始(タイマー)";
			this.agRecordSpecifiedTimeButton.Click += new System.EventHandler(this.agRecordSpecifiedTimeButton_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// agProgramLabel
			// 
			this.agProgramLabel.Name = "agProgramLabel";
			this.agProgramLabel.Size = new System.Drawing.Size(77, 22);
			this.agProgramLabel.Text = "番組: 未取得";
			// 
			// agPersonalityLabel
			// 
			this.agPersonalityLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.agPersonalityLabel.Name = "agPersonalityLabel";
			this.agPersonalityLabel.Size = new System.Drawing.Size(137, 22);
			this.agPersonalityLabel.Text = "パーソナリティ: 未取得";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label6);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(791, 387);
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
			this.tabPage7.Size = new System.Drawing.Size(791, 387);
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
            this.録音RToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(799, 26);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 録音RToolStripMenuItem
			// 
			this.録音RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RealtimeRecordingMainMenuItem});
			this.録音RToolStripMenuItem.Name = "録音RToolStripMenuItem";
			this.録音RToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.録音RToolStripMenuItem.Text = "録音(&R)";
			// 
			// RealtimeRecordingMainMenuItem
			// 
			this.RealtimeRecordingMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agEnableVideoRealtimeMainMenuItem});
			this.RealtimeRecordingMainMenuItem.Name = "RealtimeRecordingMainMenuItem";
			this.RealtimeRecordingMainMenuItem.Size = new System.Drawing.Size(172, 22);
			this.RealtimeRecordingMainMenuItem.Text = "リアルタイム録音";
			// 
			// agEnableVideoRealtimeMainMenuItem
			// 
			this.agEnableVideoRealtimeMainMenuItem.CheckOnClick = true;
			this.agEnableVideoRealtimeMainMenuItem.Name = "agEnableVideoRealtimeMainMenuItem";
			this.agEnableVideoRealtimeMainMenuItem.Size = new System.Drawing.Size(152, 22);
			this.agEnableVideoRealtimeMainMenuItem.Text = "動画モード";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDisplayMainMenuItem,
            this.agUpdateProgramListMainMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.viewToolStripMenuItem.Text = "表示(&V)";
			// 
			// updateDisplayMainMenuItem
			// 
			this.updateDisplayMainMenuItem.Name = "updateDisplayMainMenuItem";
			this.updateDisplayMainMenuItem.ShortcutKeyDisplayString = "";
			this.updateDisplayMainMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.updateDisplayMainMenuItem.Size = new System.Drawing.Size(177, 22);
			this.updateDisplayMainMenuItem.Text = "更新(&U)";
			this.updateDisplayMainMenuItem.Click += new System.EventHandler(this.updateDisplayMenuItem_Click);
			// 
			// agUpdateProgramListMainMenuItem
			// 
			this.agUpdateProgramListMainMenuItem.Name = "agUpdateProgramListMainMenuItem";
			this.agUpdateProgramListMainMenuItem.Size = new System.Drawing.Size(177, 22);
			this.agUpdateProgramListMainMenuItem.Text = "番組表の再取得(&P)";
			this.agUpdateProgramListMainMenuItem.Click += new System.EventHandler(this.agUpdateProgramListMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionMainMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
			this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
			// 
			// versionMainMenuItem
			// 
			this.versionMainMenuItem.Name = "versionMainMenuItem";
			this.versionMainMenuItem.Size = new System.Drawing.Size(178, 22);
			this.versionMainMenuItem.Text = "バージョン情報(&A)";
			this.versionMainMenuItem.Click += new System.EventHandler(this.versionMainMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(799, 23);
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
			this.ClientSize = new System.Drawing.Size(799, 462);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.agTimeReservationListViewMenu.ResumeLayout(false);
			this.tabPage9.ResumeLayout(false);
			this.agProgramListViewMenu.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem versionMainMenuItem;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
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
		private System.Windows.Forms.ToolStripMenuItem updateDisplayMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agUpdateProgramListMainMenuItem;
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
		private System.Windows.Forms.ContextMenuStrip agProgramListViewMenu;
		private System.Windows.Forms.ToolStripMenuItem agTimeReservateProgramListViewMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem agDisplayProgramPageProgramListViewMenuItem;
		private System.Windows.Forms.ContextMenuStrip agTimeReservationListViewMenu;
		private System.Windows.Forms.ToolStripMenuItem agEditTimeReservationListMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem agDeleteTimeReservationListMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 録音RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RealtimeRecordingMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agEnableVideoRealtimeMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agAddTimeReservationListMenuItem;
		private System.Windows.Forms.ColumnHeader broadcastTypeHeader;
		private System.Windows.Forms.ToolStripLabel agProgramLabel;
		private System.Windows.Forms.ToolStripLabel agPersonalityLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}

