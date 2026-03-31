namespace Raura.Views.ResultView
{
    partial class ucResultScreen
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BteamLabel_1 = new Label();
            BteamLabel_5 = new Label();
            BteamLabel_2 = new Label();
            BteamLabel_4 = new Label();
            BteamLabel_3 = new Label();
            TOP_B = new PictureBox();
            JUNGLE_B = new PictureBox();
            MID_B = new PictureBox();
            BOT_B = new PictureBox();
            SUP_B = new PictureBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            RteamLabel_3 = new Label();
            RteamLabel_1 = new Label();
            RteamLabel_2 = new Label();
            RteamLabel_5 = new Label();
            RteamLabel_4 = new Label();
            TOP_R = new PictureBox();
            JUNGLE_R = new PictureBox();
            MID_R = new PictureBox();
            BOT_R = new PictureBox();
            SUP_R = new PictureBox();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TOP_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JUNGLE_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MID_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BOT_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SUP_B).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TOP_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JUNGLE_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MID_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BOT_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SUP_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(336, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 40);
            label1.TabIndex = 2;
            label1.Text = "Result";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(527, 384);
            button1.Name = "button1";
            button1.Size = new Size(245, 48);
            button1.TabIndex = 1;
            button1.Text = "Retry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(387, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TEAM BLUE";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel2.Controls.Add(BteamLabel_1, 1, 0);
            tableLayoutPanel2.Controls.Add(BteamLabel_5, 1, 4);
            tableLayoutPanel2.Controls.Add(BteamLabel_2, 1, 1);
            tableLayoutPanel2.Controls.Add(BteamLabel_4, 1, 3);
            tableLayoutPanel2.Controls.Add(BteamLabel_3, 1, 2);
            tableLayoutPanel2.Controls.Add(TOP_B, 0, 0);
            tableLayoutPanel2.Controls.Add(JUNGLE_B, 0, 1);
            tableLayoutPanel2.Controls.Add(MID_B, 0, 2);
            tableLayoutPanel2.Controls.Add(BOT_B, 0, 3);
            tableLayoutPanel2.Controls.Add(SUP_B, 0, 4);
            tableLayoutPanel2.Location = new Point(6, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(375, 273);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // BteamLabel_1
            // 
            BteamLabel_1.Anchor = AnchorStyles.None;
            BteamLabel_1.AutoSize = true;
            BteamLabel_1.Location = new Point(119, 14);
            BteamLabel_1.Name = "BteamLabel_1";
            BteamLabel_1.Size = new Size(63, 25);
            BteamLabel_1.TabIndex = 0;
            BteamLabel_1.Text = "label2";
            // 
            // BteamLabel_5
            // 
            BteamLabel_5.Anchor = AnchorStyles.None;
            BteamLabel_5.AutoSize = true;
            BteamLabel_5.Location = new Point(119, 232);
            BteamLabel_5.Name = "BteamLabel_5";
            BteamLabel_5.Size = new Size(63, 25);
            BteamLabel_5.TabIndex = 4;
            BteamLabel_5.Text = "label6";
            // 
            // BteamLabel_2
            // 
            BteamLabel_2.Anchor = AnchorStyles.None;
            BteamLabel_2.AutoSize = true;
            BteamLabel_2.Location = new Point(119, 68);
            BteamLabel_2.Name = "BteamLabel_2";
            BteamLabel_2.Size = new Size(63, 25);
            BteamLabel_2.TabIndex = 1;
            BteamLabel_2.Text = "label3";
            // 
            // BteamLabel_4
            // 
            BteamLabel_4.Anchor = AnchorStyles.None;
            BteamLabel_4.AutoSize = true;
            BteamLabel_4.Location = new Point(119, 176);
            BteamLabel_4.Name = "BteamLabel_4";
            BteamLabel_4.Size = new Size(63, 25);
            BteamLabel_4.TabIndex = 2;
            BteamLabel_4.Text = "label5";
            // 
            // BteamLabel_3
            // 
            BteamLabel_3.Anchor = AnchorStyles.None;
            BteamLabel_3.AutoSize = true;
            BteamLabel_3.Location = new Point(119, 122);
            BteamLabel_3.Name = "BteamLabel_3";
            BteamLabel_3.Size = new Size(63, 25);
            BteamLabel_3.TabIndex = 3;
            BteamLabel_3.Text = "label4";
            // 
            // TOP_B
            // 
            TOP_B.Dock = DockStyle.Fill;
            TOP_B.Location = new Point(303, 3);
            TOP_B.Name = "TOP_B";
            TOP_B.Size = new Size(69, 48);
            TOP_B.SizeMode = PictureBoxSizeMode.Zoom;
            TOP_B.TabIndex = 5;
            TOP_B.TabStop = false;
            // 
            // JUNGLE_B
            // 
            JUNGLE_B.Dock = DockStyle.Fill;
            JUNGLE_B.Location = new Point(303, 57);
            JUNGLE_B.Name = "JUNGLE_B";
            JUNGLE_B.Size = new Size(69, 48);
            JUNGLE_B.SizeMode = PictureBoxSizeMode.Zoom;
            JUNGLE_B.TabIndex = 6;
            JUNGLE_B.TabStop = false;
            // 
            // MID_B
            // 
            MID_B.Dock = DockStyle.Fill;
            MID_B.Location = new Point(303, 111);
            MID_B.Name = "MID_B";
            MID_B.Size = new Size(69, 48);
            MID_B.SizeMode = PictureBoxSizeMode.Zoom;
            MID_B.TabIndex = 7;
            MID_B.TabStop = false;
            // 
            // BOT_B
            // 
            BOT_B.Dock = DockStyle.Fill;
            BOT_B.Location = new Point(303, 165);
            BOT_B.Name = "BOT_B";
            BOT_B.Size = new Size(69, 48);
            BOT_B.SizeMode = PictureBoxSizeMode.Zoom;
            BOT_B.TabIndex = 8;
            BOT_B.TabStop = false;
            // 
            // SUP_B
            // 
            SUP_B.Dock = DockStyle.Fill;
            SUP_B.Location = new Point(303, 219);
            SUP_B.Name = "SUP_B";
            SUP_B.Size = new Size(69, 51);
            SUP_B.SizeMode = PictureBoxSizeMode.Zoom;
            SUP_B.TabIndex = 9;
            SUP_B.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 308);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "TEAM RED";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel3.Controls.Add(RteamLabel_2, 1, 1);
            tableLayoutPanel3.Controls.Add(TOP_R, 0, 0);
            tableLayoutPanel3.Controls.Add(JUNGLE_R, 0, 1);
            tableLayoutPanel3.Controls.Add(MID_R, 0, 2);
            tableLayoutPanel3.Controls.Add(BOT_R, 0, 3);
            tableLayoutPanel3.Controls.Add(SUP_R, 0, 4);
            tableLayoutPanel3.Controls.Add(RteamLabel_1, 1, 0);
            tableLayoutPanel3.Controls.Add(RteamLabel_3, 1, 2);
            tableLayoutPanel3.Controls.Add(RteamLabel_5, 1, 4);
            tableLayoutPanel3.Controls.Add(RteamLabel_4, 1, 3);
            tableLayoutPanel3.Location = new Point(6, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(366, 273);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // RteamLabel_3
            // 
            RteamLabel_3.Anchor = AnchorStyles.None;
            RteamLabel_3.AutoSize = true;
            RteamLabel_3.Location = new Point(179, 122);
            RteamLabel_3.Name = "RteamLabel_3";
            RteamLabel_3.Size = new Size(73, 25);
            RteamLabel_3.TabIndex = 5;
            RteamLabel_3.Text = "label11";
            // 
            // RteamLabel_1
            // 
            RteamLabel_1.Anchor = AnchorStyles.None;
            RteamLabel_1.AutoSize = true;
            RteamLabel_1.Location = new Point(184, 14);
            RteamLabel_1.Name = "RteamLabel_1";
            RteamLabel_1.Size = new Size(63, 25);
            RteamLabel_1.TabIndex = 9;
            RteamLabel_1.Text = "label7";
            // 
            // RteamLabel_2
            // 
            RteamLabel_2.Anchor = AnchorStyles.None;
            RteamLabel_2.AutoSize = true;
            RteamLabel_2.Location = new Point(184, 68);
            RteamLabel_2.Name = "RteamLabel_2";
            RteamLabel_2.Size = new Size(63, 25);
            RteamLabel_2.TabIndex = 6;
            RteamLabel_2.Text = "label8";
            // 
            // RteamLabel_5
            // 
            RteamLabel_5.Anchor = AnchorStyles.None;
            RteamLabel_5.AutoSize = true;
            RteamLabel_5.Location = new Point(179, 232);
            RteamLabel_5.Name = "RteamLabel_5";
            RteamLabel_5.Size = new Size(73, 25);
            RteamLabel_5.TabIndex = 7;
            RteamLabel_5.Text = "label10";
            // 
            // RteamLabel_4
            // 
            RteamLabel_4.Anchor = AnchorStyles.None;
            RteamLabel_4.AutoSize = true;
            RteamLabel_4.Location = new Point(184, 176);
            RteamLabel_4.Name = "RteamLabel_4";
            RteamLabel_4.Size = new Size(63, 25);
            RteamLabel_4.TabIndex = 8;
            RteamLabel_4.Text = "label9";
            // 
            // TOP_R
            // 
            TOP_R.Dock = DockStyle.Fill;
            TOP_R.Location = new Point(3, 3);
            TOP_R.Name = "TOP_R";
            TOP_R.Size = new Size(60, 48);
            TOP_R.SizeMode = PictureBoxSizeMode.Zoom;
            TOP_R.TabIndex = 10;
            TOP_R.TabStop = false;
            // 
            // JUNGLE_R
            // 
            JUNGLE_R.Dock = DockStyle.Fill;
            JUNGLE_R.Location = new Point(3, 57);
            JUNGLE_R.Name = "JUNGLE_R";
            JUNGLE_R.Size = new Size(60, 48);
            JUNGLE_R.SizeMode = PictureBoxSizeMode.Zoom;
            JUNGLE_R.TabIndex = 11;
            JUNGLE_R.TabStop = false;
            // 
            // MID_R
            // 
            MID_R.Dock = DockStyle.Fill;
            MID_R.Location = new Point(3, 111);
            MID_R.Name = "MID_R";
            MID_R.Size = new Size(60, 48);
            MID_R.SizeMode = PictureBoxSizeMode.Zoom;
            MID_R.TabIndex = 12;
            MID_R.TabStop = false;
            // 
            // BOT_R
            // 
            BOT_R.Dock = DockStyle.Fill;
            BOT_R.Location = new Point(3, 165);
            BOT_R.Name = "BOT_R";
            BOT_R.Size = new Size(60, 48);
            BOT_R.SizeMode = PictureBoxSizeMode.Zoom;
            BOT_R.TabIndex = 13;
            BOT_R.TabStop = false;
            // 
            // SUP_R
            // 
            SUP_R.Dock = DockStyle.Fill;
            SUP_R.Location = new Point(3, 219);
            SUP_R.Name = "SUP_R";
            SUP_R.Size = new Size(60, 51);
            SUP_R.SizeMode = PictureBoxSizeMode.Zoom;
            SUP_R.TabIndex = 14;
            SUP_R.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 70);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(769, 308);
            splitContainer1.SplitterDistance = 387;
            splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.73779F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.26221F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(775, 435);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ucResultScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "ucResultScreen";
            Size = new Size(800, 450);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TOP_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)JUNGLE_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)MID_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)BOT_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)SUP_B).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TOP_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)JUNGLE_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)MID_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)BOT_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)SUP_R).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private SplitContainer splitContainer1;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Label BteamLabel_1;
        private Label BteamLabel_2;
        private Label BteamLabel_3;
        private Label BteamLabel_4;
        private Label BteamLabel_5;

        private Label RteamLabel_1;
        private Label RteamLabel_2;
        private Label RteamLabel_3;
        private Label RteamLabel_4;
        private Label RteamLabel_5;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;

        //blue Team Icon
        private PictureBox TOP_B;
        private PictureBox JUNGLE_B;
        private PictureBox MID_B;
        private PictureBox BOT_B;
        private PictureBox SUP_B;

        //RED Team Icon
        private PictureBox TOP_R;
        private PictureBox JUNGLE_R;
        private PictureBox MID_R;
        private PictureBox BOT_R;
        private PictureBox SUP_R;
    }
}
