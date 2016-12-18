namespace Stacker.Forms
{
	partial class AgTimeReservationSettingDialog
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
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(166, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 116);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(137, 16);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "動画モードを有効にする";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(310, 19);
			this.textBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "日",
            "月",
            "火",
            "水",
            "木",
            "金",
            "土"});
			this.comboBox2.Location = new System.Drawing.Point(166, 73);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(40, 20);
			this.comboBox2.TabIndex = 6;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "日",
            "月",
            "火",
            "水",
            "木",
            "金",
            "土"});
			this.comboBox1.Location = new System.Drawing.Point(12, 73);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(40, 20);
			this.comboBox1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "開始時間:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(164, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 12);
			this.label4.TabIndex = 11;
			this.label4.Text = "終了時間:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 12);
			this.label5.TabIndex = 12;
			this.label5.Text = "予約名:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "HH:mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(58, 74);
			this.dateTimePicker1.MaxDate = new System.DateTime(1900, 1, 2, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(60, 19);
			this.dateTimePicker1.TabIndex = 13;
			this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 15, 40, 0, 0);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "HH:mm";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(212, 74);
			this.dateTimePicker2.MaxDate = new System.DateTime(1900, 1, 2, 0, 0, 0, 0);
			this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowUpDown = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(60, 19);
			this.dateTimePicker2.TabIndex = 15;
			this.dateTimePicker2.Value = new System.DateTime(1900, 1, 1, 15, 40, 0, 0);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(247, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "キャンセル";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AgTimeReservationSettingDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 187);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Name = "AgTimeReservationSettingDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "時間予約の設定";
			this.Load += new System.EventHandler(this.AgTimeReservationSettingDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button2;
	}
}