namespace WEEK09_01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "대한민국",
            "82"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "미국",
            "1"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "이탈리아",
            "39"}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "캐나다",
            "1"}, 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "프랑스",
            "33"}, 4);
            this.rb_LargeIcon = new System.Windows.Forms.RadioButton();
            this.rb_SmallIcon = new System.Windows.Forms.RadioButton();
            this.rb_List = new System.Windows.Forms.RadioButton();
            this.rb_Details = new System.Windows.Forms.RadioButton();
            this.rb_Tile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rb_LargeIcon
            // 
            this.rb_LargeIcon.AutoSize = true;
            this.rb_LargeIcon.Location = new System.Drawing.Point(29, 33);
            this.rb_LargeIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_LargeIcon.Name = "rb_LargeIcon";
            this.rb_LargeIcon.Size = new System.Drawing.Size(118, 22);
            this.rb_LargeIcon.TabIndex = 0;
            this.rb_LargeIcon.TabStop = true;
            this.rb_LargeIcon.Text = "Large Icon";
            this.rb_LargeIcon.UseVisualStyleBackColor = true;
            this.rb_LargeIcon.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_SmallIcon
            // 
            this.rb_SmallIcon.AutoSize = true;
            this.rb_SmallIcon.Location = new System.Drawing.Point(304, 43);
            this.rb_SmallIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_SmallIcon.Name = "rb_SmallIcon";
            this.rb_SmallIcon.Size = new System.Drawing.Size(115, 22);
            this.rb_SmallIcon.TabIndex = 1;
            this.rb_SmallIcon.TabStop = true;
            this.rb_SmallIcon.Text = "Small Icon";
            this.rb_SmallIcon.UseVisualStyleBackColor = true;
            this.rb_SmallIcon.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_List
            // 
            this.rb_List.AutoSize = true;
            this.rb_List.Location = new System.Drawing.Point(29, 111);
            this.rb_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_List.Name = "rb_List";
            this.rb_List.Size = new System.Drawing.Size(60, 22);
            this.rb_List.TabIndex = 2;
            this.rb_List.TabStop = true;
            this.rb_List.Text = "List";
            this.rb_List.UseVisualStyleBackColor = true;
            this.rb_List.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_Details
            // 
            this.rb_Details.AutoSize = true;
            this.rb_Details.Location = new System.Drawing.Point(304, 111);
            this.rb_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Details.Name = "rb_Details";
            this.rb_Details.Size = new System.Drawing.Size(85, 22);
            this.rb_Details.TabIndex = 3;
            this.rb_Details.TabStop = true;
            this.rb_Details.Text = "Details";
            this.rb_Details.UseVisualStyleBackColor = true;
            this.rb_Details.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_Tile
            // 
            this.rb_Tile.AutoSize = true;
            this.rb_Tile.Location = new System.Drawing.Point(29, 185);
            this.rb_Tile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Tile.Name = "rb_Tile";
            this.rb_Tile.Size = new System.Drawing.Size(59, 22);
            this.rb_Tile.TabIndex = 4;
            this.rb_Tile.TabStop = true;
            this.rb_Tile.Text = "Tile";
            this.rb_Tile.UseVisualStyleBackColor = true;
            this.rb_Tile.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "South Korea.png");
            this.imageList1.Images.SetKeyName(1, "USA.png");
            this.imageList1.Images.SetKeyName(2, "Italy.png");
            this.imageList1.Images.SetKeyName(3, "Canada.png");
            this.imageList1.Images.SetKeyName(4, "France.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(29, 244);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 240);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "국가";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "국가번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(483, 620);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_Tile);
            this.Controls.Add(this.rb_Details);
            this.Controls.Add(this.rb_List);
            this.Controls.Add(this.rb_SmallIcon);
            this.Controls.Add(this.rb_LargeIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "WEE09_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_LargeIcon;
        private System.Windows.Forms.RadioButton rb_SmallIcon;
        private System.Windows.Forms.RadioButton rb_List;
        private System.Windows.Forms.RadioButton rb_Details;
        private System.Windows.Forms.RadioButton rb_Tile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

