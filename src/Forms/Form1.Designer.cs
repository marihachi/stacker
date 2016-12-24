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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.statusTabPage = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.timeReservationTabPage = new System.Windows.Forms.TabPage();
			this.agTimeReservationListView = new System.Windows.Forms.ListView();
			this.startTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.endTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.agTimeReservationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agAddTimeReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agEditTimeReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.agDeleteTimeReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keywordReservationTabPage = new System.Windows.Forms.TabPage();
			this.agKeywordReservationListView = new System.Windows.Forms.ListView();
			this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.keyWordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.agKeywordReservationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agAddKeywordReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agEditKeywordReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.agDeleteKeywordReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.programListTabPage = new System.Windows.Forms.TabPage();
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
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.agStartRecordButton = new System.Windows.Forms.ToolStripButton();
			this.agRecordStopButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.agRecordSpecifiedTimeButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.agUpdateProgramListButton = new System.Windows.Forms.ToolStripButton();
			this.agOpenLibraryDirectoryButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.agProgramLabel = new System.Windows.Forms.ToolStripLabel();
			this.agPersonalityLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateDisplayMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.時間予約を有効切り替えToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.キーワード予約を有効化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.キーワード予約ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動画モード自動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動画モードありToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動画モードなしToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RealtimeRecordingMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agEnableVideoRealtimeMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsInportExportMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issuesMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.versionMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.toolStripContainer2.ContentPanel.SuspendLayout();
			this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer2.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.statusTabPage.SuspendLayout();
			this.timeReservationTabPage.SuspendLayout();
			this.agTimeReservationMenu.SuspendLayout();
			this.keywordReservationTabPage.SuspendLayout();
			this.agKeywordReservationMenu.SuspendLayout();
			this.programListTabPage.SuspendLayout();
			this.agProgramListViewMenu.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(744, 413);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.toolStripContainer2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(736, 387);
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
			this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(730, 356);
			this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
			this.toolStripContainer2.Name = "toolStripContainer2";
			this.toolStripContainer2.Size = new System.Drawing.Size(730, 381);
			this.toolStripContainer2.TabIndex = 4;
			this.toolStripContainer2.Text = "toolStripContainer2";
			// 
			// toolStripContainer2.TopToolStripPanel
			// 
			this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.statusTabPage);
			this.tabControl2.Controls.Add(this.timeReservationTabPage);
			this.tabControl2.Controls.Add(this.keywordReservationTabPage);
			this.tabControl2.Controls.Add(this.programListTabPage);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.ImageList = this.imageList1;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(730, 356);
			this.tabControl2.TabIndex = 1;
			// 
			// statusTabPage
			// 
			this.statusTabPage.Controls.Add(this.label1);
			this.statusTabPage.Location = new System.Drawing.Point(4, 23);
			this.statusTabPage.Name = "statusTabPage";
			this.statusTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.statusTabPage.Size = new System.Drawing.Size(722, 329);
			this.statusTabPage.TabIndex = 6;
			this.statusTabPage.Text = "状態";
			this.statusTabPage.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "未実装です。レコードタスクの活動状況などを表示します";
			// 
			// timeReservationTabPage
			// 
			this.timeReservationTabPage.Controls.Add(this.agTimeReservationListView);
			this.timeReservationTabPage.Location = new System.Drawing.Point(4, 23);
			this.timeReservationTabPage.Name = "timeReservationTabPage";
			this.timeReservationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.timeReservationTabPage.Size = new System.Drawing.Size(722, 329);
			this.timeReservationTabPage.TabIndex = 2;
			this.timeReservationTabPage.Text = "時間予約";
			this.timeReservationTabPage.UseVisualStyleBackColor = true;
			// 
			// agTimeReservationListView
			// 
			this.agTimeReservationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.startTimeHeader,
            this.endTimeHeader,
            this.nameHeader});
			this.agTimeReservationListView.ContextMenuStrip = this.agTimeReservationMenu;
			this.agTimeReservationListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.agTimeReservationListView.FullRowSelect = true;
			this.agTimeReservationListView.GridLines = true;
			this.agTimeReservationListView.Location = new System.Drawing.Point(3, 3);
			this.agTimeReservationListView.MultiSelect = false;
			this.agTimeReservationListView.Name = "agTimeReservationListView";
			this.agTimeReservationListView.Size = new System.Drawing.Size(716, 323);
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
			this.nameHeader.Width = 570;
			// 
			// agTimeReservationMenu
			// 
			this.agTimeReservationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agAddTimeReservationMenuItem,
            this.agEditTimeReservationMenuItem,
            this.toolStripSeparator3,
            this.agDeleteTimeReservationMenuItem});
			this.agTimeReservationMenu.Name = "TimeReservationListMenu";
			this.agTimeReservationMenu.Size = new System.Drawing.Size(121, 76);
			this.agTimeReservationMenu.Opening += new System.ComponentModel.CancelEventHandler(this.agTimeReservationMenu_Opening);
			// 
			// agAddTimeReservationMenuItem
			// 
			this.agAddTimeReservationMenuItem.Name = "agAddTimeReservationMenuItem";
			this.agAddTimeReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agAddTimeReservationMenuItem.Text = "追加(&A)";
			this.agAddTimeReservationMenuItem.Click += new System.EventHandler(this.agAddTimeReservationMenuItem_Click);
			// 
			// agEditTimeReservationMenuItem
			// 
			this.agEditTimeReservationMenuItem.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.agEditTimeReservationMenuItem.Name = "agEditTimeReservationMenuItem";
			this.agEditTimeReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agEditTimeReservationMenuItem.Text = "編集(&E)";
			this.agEditTimeReservationMenuItem.Click += new System.EventHandler(this.agEditTimeReservationMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(117, 6);
			// 
			// agDeleteTimeReservationMenuItem
			// 
			this.agDeleteTimeReservationMenuItem.Name = "agDeleteTimeReservationMenuItem";
			this.agDeleteTimeReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agDeleteTimeReservationMenuItem.Text = "削除(&D)";
			this.agDeleteTimeReservationMenuItem.Click += new System.EventHandler(this.agDeleteTimeReservationMenuItem_Click);
			// 
			// keywordReservationTabPage
			// 
			this.keywordReservationTabPage.Controls.Add(this.agKeywordReservationListView);
			this.keywordReservationTabPage.Location = new System.Drawing.Point(4, 23);
			this.keywordReservationTabPage.Name = "keywordReservationTabPage";
			this.keywordReservationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.keywordReservationTabPage.Size = new System.Drawing.Size(722, 329);
			this.keywordReservationTabPage.TabIndex = 5;
			this.keywordReservationTabPage.Text = "キーワード予約";
			this.keywordReservationTabPage.UseVisualStyleBackColor = true;
			// 
			// agKeywordReservationListView
			// 
			this.agKeywordReservationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeHeader,
            this.keyWordHeader});
			this.agKeywordReservationListView.ContextMenuStrip = this.agKeywordReservationMenu;
			this.agKeywordReservationListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.agKeywordReservationListView.FullRowSelect = true;
			this.agKeywordReservationListView.GridLines = true;
			this.agKeywordReservationListView.Location = new System.Drawing.Point(3, 3);
			this.agKeywordReservationListView.MultiSelect = false;
			this.agKeywordReservationListView.Name = "agKeywordReservationListView";
			this.agKeywordReservationListView.Size = new System.Drawing.Size(716, 323);
			this.agKeywordReservationListView.TabIndex = 17;
			this.agKeywordReservationListView.UseCompatibleStateImageBehavior = false;
			this.agKeywordReservationListView.View = System.Windows.Forms.View.Details;
			this.agKeywordReservationListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agKeywordReservationListView_MouseDoubleClick);
			// 
			// typeHeader
			// 
			this.typeHeader.Text = "タイプ";
			// 
			// keyWordHeader
			// 
			this.keyWordHeader.Text = "キーワード";
			this.keyWordHeader.Width = 630;
			// 
			// agKeywordReservationMenu
			// 
			this.agKeywordReservationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agAddKeywordReservationMenuItem,
            this.agEditKeywordReservationMenuItem,
            this.toolStripSeparator8,
            this.agDeleteKeywordReservationMenuItem});
			this.agKeywordReservationMenu.Name = "agKeywordReservationListViewMenu";
			this.agKeywordReservationMenu.Size = new System.Drawing.Size(121, 76);
			this.agKeywordReservationMenu.Opening += new System.ComponentModel.CancelEventHandler(this.agKeywordReservationMenu_Opening);
			// 
			// agAddKeywordReservationMenuItem
			// 
			this.agAddKeywordReservationMenuItem.Name = "agAddKeywordReservationMenuItem";
			this.agAddKeywordReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agAddKeywordReservationMenuItem.Text = "追加(&A)";
			this.agAddKeywordReservationMenuItem.Click += new System.EventHandler(this.agAddKeywordReservationMenuItem_Click);
			// 
			// agEditKeywordReservationMenuItem
			// 
			this.agEditKeywordReservationMenuItem.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.agEditKeywordReservationMenuItem.Name = "agEditKeywordReservationMenuItem";
			this.agEditKeywordReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agEditKeywordReservationMenuItem.Text = "編集(&E)";
			this.agEditKeywordReservationMenuItem.Click += new System.EventHandler(this.agEditKeywordReservationMenuItem_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(117, 6);
			// 
			// agDeleteKeywordReservationMenuItem
			// 
			this.agDeleteKeywordReservationMenuItem.Name = "agDeleteKeywordReservationMenuItem";
			this.agDeleteKeywordReservationMenuItem.Size = new System.Drawing.Size(120, 22);
			this.agDeleteKeywordReservationMenuItem.Text = "削除(&D)";
			this.agDeleteKeywordReservationMenuItem.Click += new System.EventHandler(this.agDeleteKeywordReservationMenuItem_Click);
			// 
			// programListTabPage
			// 
			this.programListTabPage.Controls.Add(this.agProgramListView);
			this.programListTabPage.ImageKey = "programList.png";
			this.programListTabPage.Location = new System.Drawing.Point(4, 23);
			this.programListTabPage.Name = "programListTabPage";
			this.programListTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.programListTabPage.Size = new System.Drawing.Size(722, 329);
			this.programListTabPage.TabIndex = 4;
			this.programListTabPage.Text = "番組表";
			this.programListTabPage.UseVisualStyleBackColor = true;
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
			this.agProgramListView.Size = new System.Drawing.Size(716, 323);
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
			this.personalityHeader.Width = 180;
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
			// agDisplayProgramPageProgramListViewMenuItem
			// 
			this.agDisplayProgramPageProgramListViewMenuItem.Enabled = false;
			this.agDisplayProgramPageProgramListViewMenuItem.Name = "agDisplayProgramPageProgramListViewMenuItem";
			this.agDisplayProgramPageProgramListViewMenuItem.Size = new System.Drawing.Size(160, 22);
			this.agDisplayProgramPageProgramListViewMenuItem.Text = "番組ページ表示";
			this.agDisplayProgramPageProgramListViewMenuItem.Click += new System.EventHandler(this.agDisplayProgramPageProgramListViewMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "programList.png");
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
            this.agUpdateProgramListButton,
            this.agOpenLibraryDirectoryButton,
            this.toolStripSeparator6,
            this.agProgramLabel,
            this.agPersonalityLabel,
            this.toolStripSeparator7});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(730, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// agStartRecordButton
			// 
			this.agStartRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agStartRecordButton.Image = global::Stacker.Properties.Resources.record;
			this.agStartRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agStartRecordButton.Name = "agStartRecordButton";
			this.agStartRecordButton.Size = new System.Drawing.Size(23, 22);
			this.agStartRecordButton.Text = "リアルタイム録音開始";
			this.agStartRecordButton.Click += new System.EventHandler(this.agStartRecordButton_Click);
			// 
			// agRecordStopButton
			// 
			this.agRecordStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agRecordStopButton.Image = global::Stacker.Properties.Resources.pause;
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
			this.agRecordSpecifiedTimeButton.Image = global::Stacker.Properties.Resources.clockRec;
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
			// agUpdateProgramListButton
			// 
			this.agUpdateProgramListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agUpdateProgramListButton.Image = global::Stacker.Properties.Resources.refresh;
			this.agUpdateProgramListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agUpdateProgramListButton.Name = "agUpdateProgramListButton";
			this.agUpdateProgramListButton.Size = new System.Drawing.Size(23, 22);
			this.agUpdateProgramListButton.Text = "番組表を再取得する";
			this.agUpdateProgramListButton.Click += new System.EventHandler(this.agUpdateProgramListButton_Click);
			// 
			// agOpenLibraryDirectoryButton
			// 
			this.agOpenLibraryDirectoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.agOpenLibraryDirectoryButton.Image = global::Stacker.Properties.Resources.folder;
			this.agOpenLibraryDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.agOpenLibraryDirectoryButton.Name = "agOpenLibraryDirectoryButton";
			this.agOpenLibraryDirectoryButton.Size = new System.Drawing.Size(23, 22);
			this.agOpenLibraryDirectoryButton.Text = "保存ディレクトリを開く";
			this.agOpenLibraryDirectoryButton.Click += new System.EventHandler(this.agOpenLibraryDirectoryButton_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label6);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(736, 387);
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
			this.tabPage7.Size = new System.Drawing.Size(736, 387);
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
            this.fileMainMenuItem,
            this.viewMainMenuItem,
            this.settingMainMenuItem,
            this.helpMainMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(744, 26);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileMainMenuItem
			// 
			this.fileMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMainMenuItem});
			this.fileMainMenuItem.Name = "fileMainMenuItem";
			this.fileMainMenuItem.Size = new System.Drawing.Size(85, 22);
			this.fileMainMenuItem.Text = "ファイル(&F)";
			// 
			// exitMainMenuItem
			// 
			this.exitMainMenuItem.Name = "exitMainMenuItem";
			this.exitMainMenuItem.Size = new System.Drawing.Size(130, 22);
			this.exitMainMenuItem.Text = "閉じる(&X)";
			this.exitMainMenuItem.Click += new System.EventHandler(this.exitMainMenuItem_Click);
			// 
			// viewMainMenuItem
			// 
			this.viewMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDisplayMainMenuItem});
			this.viewMainMenuItem.Name = "viewMainMenuItem";
			this.viewMainMenuItem.Size = new System.Drawing.Size(62, 22);
			this.viewMainMenuItem.Text = "表示(&V)";
			// 
			// updateDisplayMainMenuItem
			// 
			this.updateDisplayMainMenuItem.Name = "updateDisplayMainMenuItem";
			this.updateDisplayMainMenuItem.ShortcutKeyDisplayString = "";
			this.updateDisplayMainMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.updateDisplayMainMenuItem.Size = new System.Drawing.Size(141, 22);
			this.updateDisplayMainMenuItem.Text = "更新(&U)";
			this.updateDisplayMainMenuItem.Click += new System.EventHandler(this.updateDisplayMenuItem_Click);
			// 
			// settingMainMenuItem
			// 
			this.settingMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.時間予約を有効切り替えToolStripMenuItem,
            this.キーワード予約を有効化ToolStripMenuItem,
            this.キーワード予約ToolStripMenuItem,
            this.RealtimeRecordingMainMenuItem,
            this.toolStripSeparator9,
            this.settingsInportExportMainMenuItem});
			this.settingMainMenuItem.Name = "settingMainMenuItem";
			this.settingMainMenuItem.Size = new System.Drawing.Size(62, 22);
			this.settingMainMenuItem.Text = "設定(&S)";
			// 
			// 時間予約を有効切り替えToolStripMenuItem
			// 
			this.時間予約を有効切り替えToolStripMenuItem.Checked = true;
			this.時間予約を有効切り替えToolStripMenuItem.CheckOnClick = true;
			this.時間予約を有効切り替えToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.時間予約を有効切り替えToolStripMenuItem.Enabled = false;
			this.時間予約を有効切り替えToolStripMenuItem.Name = "時間予約を有効切り替えToolStripMenuItem";
			this.時間予約を有効切り替えToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.時間予約を有効切り替えToolStripMenuItem.Text = "時間予約を有効化";
			// 
			// キーワード予約を有効化ToolStripMenuItem
			// 
			this.キーワード予約を有効化ToolStripMenuItem.Checked = true;
			this.キーワード予約を有効化ToolStripMenuItem.CheckOnClick = true;
			this.キーワード予約を有効化ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.キーワード予約を有効化ToolStripMenuItem.Enabled = false;
			this.キーワード予約を有効化ToolStripMenuItem.Name = "キーワード予約を有効化ToolStripMenuItem";
			this.キーワード予約を有効化ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.キーワード予約を有効化ToolStripMenuItem.Text = "キーワード予約を有効化";
			// 
			// キーワード予約ToolStripMenuItem
			// 
			this.キーワード予約ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.動画モード自動ToolStripMenuItem,
            this.動画モードありToolStripMenuItem,
            this.動画モードなしToolStripMenuItem});
			this.キーワード予約ToolStripMenuItem.Enabled = false;
			this.キーワード予約ToolStripMenuItem.Name = "キーワード予約ToolStripMenuItem";
			this.キーワード予約ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
			this.キーワード予約ToolStripMenuItem.Text = "キーワード予約";
			// 
			// 動画モード自動ToolStripMenuItem
			// 
			this.動画モード自動ToolStripMenuItem.Name = "動画モード自動ToolStripMenuItem";
			this.動画モード自動ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.動画モード自動ToolStripMenuItem.Text = "動画モード: 自動";
			this.動画モード自動ToolStripMenuItem.Click += new System.EventHandler(this.keywordReservationVideoModeMainMenuItem_Click);
			// 
			// 動画モードありToolStripMenuItem
			// 
			this.動画モードありToolStripMenuItem.Name = "動画モードありToolStripMenuItem";
			this.動画モードありToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.動画モードありToolStripMenuItem.Text = "動画モード: あり";
			this.動画モードありToolStripMenuItem.Click += new System.EventHandler(this.keywordReservationVideoModeMainMenuItem_Click);
			// 
			// 動画モードなしToolStripMenuItem
			// 
			this.動画モードなしToolStripMenuItem.Name = "動画モードなしToolStripMenuItem";
			this.動画モードなしToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.動画モードなしToolStripMenuItem.Text = "動画モード: なし";
			this.動画モードなしToolStripMenuItem.Click += new System.EventHandler(this.keywordReservationVideoModeMainMenuItem_Click);
			// 
			// RealtimeRecordingMainMenuItem
			// 
			this.RealtimeRecordingMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agEnableVideoRealtimeMainMenuItem});
			this.RealtimeRecordingMainMenuItem.Name = "RealtimeRecordingMainMenuItem";
			this.RealtimeRecordingMainMenuItem.Size = new System.Drawing.Size(268, 22);
			this.RealtimeRecordingMainMenuItem.Text = "リアルタイム録音";
			// 
			// agEnableVideoRealtimeMainMenuItem
			// 
			this.agEnableVideoRealtimeMainMenuItem.CheckOnClick = true;
			this.agEnableVideoRealtimeMainMenuItem.Name = "agEnableVideoRealtimeMainMenuItem";
			this.agEnableVideoRealtimeMainMenuItem.Size = new System.Drawing.Size(152, 22);
			this.agEnableVideoRealtimeMainMenuItem.Text = "動画モード";
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(265, 6);
			// 
			// settingsInportExportMainMenuItem
			// 
			this.settingsInportExportMainMenuItem.Enabled = false;
			this.settingsInportExportMainMenuItem.Name = "settingsInportExportMainMenuItem";
			this.settingsInportExportMainMenuItem.Size = new System.Drawing.Size(268, 22);
			this.settingsInportExportMainMenuItem.Text = "設定のインポートとエクスポート...";
			this.settingsInportExportMainMenuItem.Click += new System.EventHandler(this.settingsInportExportMainMenuItem_Click);
			// 
			// helpMainMenuItem
			// 
			this.helpMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuesMainMenuItem,
            this.toolStripSeparator5,
            this.versionMainMenuItem});
			this.helpMainMenuItem.Name = "helpMainMenuItem";
			this.helpMainMenuItem.Size = new System.Drawing.Size(75, 22);
			this.helpMainMenuItem.Text = "ヘルプ(&H)";
			// 
			// issuesMainMenuItem
			// 
			this.issuesMainMenuItem.Name = "issuesMainMenuItem";
			this.issuesMainMenuItem.Size = new System.Drawing.Size(211, 22);
			this.issuesMainMenuItem.Text = "ご意見・不具合の報告(&I)";
			this.issuesMainMenuItem.Click += new System.EventHandler(this.issuesMainMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(208, 6);
			// 
			// versionMainMenuItem
			// 
			this.versionMainMenuItem.Name = "versionMainMenuItem";
			this.versionMainMenuItem.Size = new System.Drawing.Size(211, 22);
			this.versionMainMenuItem.Text = "バージョン情報(&A)";
			this.versionMainMenuItem.Click += new System.EventHandler(this.versionMainMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(744, 23);
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
			this.ClientSize = new System.Drawing.Size(744, 462);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(300, 340);
			this.Name = "Form1";
			this.Text = "{0} - ver.{1}(α) info:不具合を見つけた場合は報告してください";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.toolStripContainer2.ContentPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.PerformLayout();
			this.toolStripContainer2.ResumeLayout(false);
			this.toolStripContainer2.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.statusTabPage.ResumeLayout(false);
			this.statusTabPage.PerformLayout();
			this.timeReservationTabPage.ResumeLayout(false);
			this.agTimeReservationMenu.ResumeLayout(false);
			this.keywordReservationTabPage.ResumeLayout(false);
			this.agKeywordReservationMenu.ResumeLayout(false);
			this.programListTabPage.ResumeLayout(false);
			this.agProgramListViewMenu.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem helpMainMenuItem;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage timeReservationTabPage;
		private System.Windows.Forms.ToolStripMenuItem versionMainMenuItem;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton agStartRecordButton;
		private System.Windows.Forms.ToolStripButton agRecordStopButton;
		private System.Windows.Forms.ListView agTimeReservationListView;
		private System.Windows.Forms.ColumnHeader nameHeader;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton agRecordSpecifiedTimeButton;
		private System.Windows.Forms.TabPage programListTabPage;
		private System.Windows.Forms.ListView agProgramListView;
		private System.Windows.Forms.ColumnHeader timeHeader;
		private System.Windows.Forms.ColumnHeader programNameHeader;
		private System.Windows.Forms.ColumnHeader personalityHeader;
		private System.Windows.Forms.ToolStripMenuItem viewMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateDisplayMainMenuItem;
		private System.Windows.Forms.ColumnHeader startTimeHeader;
		private System.Windows.Forms.ColumnHeader endTimeHeader;
		private System.Windows.Forms.ColumnHeader hasVideoHeader;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ContextMenuStrip agProgramListViewMenu;
		private System.Windows.Forms.ToolStripMenuItem agTimeReservateProgramListViewMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem agDisplayProgramPageProgramListViewMenuItem;
		private System.Windows.Forms.ContextMenuStrip agTimeReservationMenu;
		private System.Windows.Forms.ToolStripMenuItem agEditTimeReservationMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem agDeleteTimeReservationMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agAddTimeReservationMenuItem;
		private System.Windows.Forms.ColumnHeader broadcastTypeHeader;
		private System.Windows.Forms.ToolStripLabel agProgramLabel;
		private System.Windows.Forms.ToolStripLabel agPersonalityLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem issuesMainMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.TabPage keywordReservationTabPage;
		private System.Windows.Forms.ListView agKeywordReservationListView;
		private System.Windows.Forms.ColumnHeader typeHeader;
		private System.Windows.Forms.ColumnHeader keyWordHeader;
		private System.Windows.Forms.TabPage statusTabPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripButton agOpenLibraryDirectoryButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton agUpdateProgramListButton;
		private System.Windows.Forms.ContextMenuStrip agKeywordReservationMenu;
		private System.Windows.Forms.ToolStripMenuItem agAddKeywordReservationMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agEditKeywordReservationMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem agDeleteKeywordReservationMenuItem;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem 時間予約を有効切り替えToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem キーワード予約を有効化ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem RealtimeRecordingMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agEnableVideoRealtimeMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsInportExportMainMenuItem;
		private System.Windows.Forms.ToolStripMenuItem キーワード予約ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 動画モード自動ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 動画モードありToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 動画モードなしToolStripMenuItem;
	}
}

