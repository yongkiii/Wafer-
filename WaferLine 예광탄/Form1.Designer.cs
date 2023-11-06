namespace WaferLine_예광탄
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.lb_spin = new System.Windows.Forms.Label();
            this.tbar_drop = new System.Windows.Forms.TrackBar();
            this.tbar_spin = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pr = new System.Windows.Forms.Button();
            this.btn_wafer = new System.Windows.Forms.Button();
            this.lb_pr = new System.Windows.Forms.Label();
            this.lb_wafer = new System.Windows.Forms.Label();
            this.tbar_pr = new System.Windows.Forms.TrackBar();
            this.tbar_wafer = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_awafer = new WaferLineControlLib.WaferPanel();
            this.cb_awafer = new System.Windows.Forms.ComboBox();
            this.lb_awcnt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pn_nwafer = new WaferLineControlLib.WaferPanel();
            this.pn_npr = new WaferLineControlLib.DPanel();
            this.btn_start = new System.Windows.Forms.Button();
            this.pn_pr = new WaferLineControlLib.DPanel();
            this.lb_pcnt = new System.Windows.Forms.Label();
            this.pn_wafer = new WaferLineControlLib.DPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_wcnt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ts_lb1 = new System.Windows.Forms.StatusStrip();
            this.ts_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm_coating = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).BeginInit();
            this.ts_lb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.lb_drop);
            this.splitContainer1.Panel1.Controls.Add(this.lb_spin);
            this.splitContainer1.Panel1.Controls.Add(this.tbar_drop);
            this.splitContainer1.Panel1.Controls.Add(this.tbar_spin);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pr);
            this.splitContainer1.Panel1.Controls.Add(this.btn_wafer);
            this.splitContainer1.Panel1.Controls.Add(this.lb_pr);
            this.splitContainer1.Panel1.Controls.Add(this.lb_wafer);
            this.splitContainer1.Panel1.Controls.Add(this.tbar_pr);
            this.splitContainer1.Panel1.Controls.Add(this.tbar_wafer);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pn_awafer);
            this.splitContainer1.Panel2.Controls.Add(this.cb_awafer);
            this.splitContainer1.Panel2.Controls.Add(this.lb_awcnt);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.pn_nwafer);
            this.splitContainer1.Panel2.Controls.Add(this.pn_npr);
            this.splitContainer1.Panel2.Controls.Add(this.btn_start);
            this.splitContainer1.Panel2.Controls.Add(this.pn_pr);
            this.splitContainer1.Panel2.Controls.Add(this.lb_pcnt);
            this.splitContainer1.Panel2.Controls.Add(this.pn_wafer);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.lb_wcnt);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Size = new System.Drawing.Size(892, 599);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "ps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(665, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "rpm";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(613, 68);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(17, 12);
            this.lb_drop.TabIndex = 13;
            this.lb_drop.Text = "20";
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(601, 18);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(29, 12);
            this.lb_spin.TabIndex = 12;
            this.lb_spin.Text = "1000";
            // 
            // tbar_drop
            // 
            this.tbar_drop.Location = new System.Drawing.Point(471, 68);
            this.tbar_drop.Maximum = 200;
            this.tbar_drop.Minimum = 20;
            this.tbar_drop.Name = "tbar_drop";
            this.tbar_drop.Size = new System.Drawing.Size(104, 45);
            this.tbar_drop.TabIndex = 11;
            this.tbar_drop.Value = 20;
            this.tbar_drop.Scroll += new System.EventHandler(this.tbar_drop_Scroll);
            // 
            // tbar_spin
            // 
            this.tbar_spin.Location = new System.Drawing.Point(471, 18);
            this.tbar_spin.Maximum = 8000;
            this.tbar_spin.Minimum = 1000;
            this.tbar_spin.Name = "tbar_spin";
            this.tbar_spin.Size = new System.Drawing.Size(104, 45);
            this.tbar_spin.TabIndex = 10;
            this.tbar_spin.Value = 1000;
            this.tbar_spin.Scroll += new System.EventHandler(this.tbar_spin_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "낙하 속도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "회전 속도";
            // 
            // btn_pr
            // 
            this.btn_pr.Location = new System.Drawing.Point(281, 68);
            this.btn_pr.Name = "btn_pr";
            this.btn_pr.Size = new System.Drawing.Size(75, 23);
            this.btn_pr.TabIndex = 7;
            this.btn_pr.Text = "투입";
            this.btn_pr.UseVisualStyleBackColor = true;
            this.btn_pr.Click += new System.EventHandler(this.btn_pr_Click);
            // 
            // btn_wafer
            // 
            this.btn_wafer.Location = new System.Drawing.Point(281, 23);
            this.btn_wafer.Name = "btn_wafer";
            this.btn_wafer.Size = new System.Drawing.Size(75, 23);
            this.btn_wafer.TabIndex = 6;
            this.btn_wafer.Text = "투입";
            this.btn_wafer.UseVisualStyleBackColor = true;
            this.btn_wafer.Click += new System.EventHandler(this.btn_wafer_Click);
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(233, 73);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(11, 12);
            this.lb_pr.TabIndex = 5;
            this.lb_pr.Text = "0";
            // 
            // lb_wafer
            // 
            this.lb_wafer.AutoSize = true;
            this.lb_wafer.Location = new System.Drawing.Point(233, 23);
            this.lb_wafer.Name = "lb_wafer";
            this.lb_wafer.Size = new System.Drawing.Size(11, 12);
            this.lb_wafer.TabIndex = 4;
            this.lb_wafer.Text = "0";
            // 
            // tbar_pr
            // 
            this.tbar_pr.Location = new System.Drawing.Point(103, 73);
            this.tbar_pr.Maximum = 20;
            this.tbar_pr.Name = "tbar_pr";
            this.tbar_pr.Size = new System.Drawing.Size(104, 45);
            this.tbar_pr.TabIndex = 3;
            this.tbar_pr.ValueChanged += new System.EventHandler(this.tbar_pr_ValueChanged);
            // 
            // tbar_wafer
            // 
            this.tbar_wafer.Location = new System.Drawing.Point(103, 23);
            this.tbar_wafer.Maximum = 200;
            this.tbar_wafer.Name = "tbar_wafer";
            this.tbar_wafer.Size = new System.Drawing.Size(104, 45);
            this.tbar_wafer.TabIndex = 2;
            this.tbar_wafer.ValueChanged += new System.EventHandler(this.tbar_wafer_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "코팅액";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wafer";
            // 
            // pn_awafer
            // 
            this.pn_awafer.Location = new System.Drawing.Point(576, 166);
            this.pn_awafer.Name = "pn_awafer";
            this.pn_awafer.Size = new System.Drawing.Size(186, 174);
            this.pn_awafer.TabIndex = 25;
            this.pn_awafer.Wafer = null;
            // 
            // cb_awafer
            // 
            this.cb_awafer.FormattingEnabled = true;
            this.cb_awafer.Location = new System.Drawing.Point(592, 88);
            this.cb_awafer.Name = "cb_awafer";
            this.cb_awafer.Size = new System.Drawing.Size(146, 20);
            this.cb_awafer.TabIndex = 27;
            this.cb_awafer.SelectedIndexChanged += new System.EventHandler(this.cb_awafer_SelectedIndexChanged);
            // 
            // lb_awcnt
            // 
            this.lb_awcnt.AutoSize = true;
            this.lb_awcnt.Location = new System.Drawing.Point(727, 54);
            this.lb_awcnt.Name = "lb_awcnt";
            this.lb_awcnt.Size = new System.Drawing.Size(11, 12);
            this.lb_awcnt.TabIndex = 26;
            this.lb_awcnt.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(590, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "Wafer(후)";
            // 
            // pn_nwafer
            // 
            this.pn_nwafer.Location = new System.Drawing.Point(314, 166);
            this.pn_nwafer.Name = "pn_nwafer";
            this.pn_nwafer.Size = new System.Drawing.Size(186, 174);
            this.pn_nwafer.TabIndex = 24;
            this.pn_nwafer.Wafer = null;
            // 
            // pn_npr
            // 
            this.pn_npr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_npr.Location = new System.Drawing.Point(365, 88);
            this.pn_npr.Name = "pn_npr";
            this.pn_npr.Size = new System.Drawing.Size(56, 28);
            this.pn_npr.TabIndex = 23;
            this.pn_npr.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_npr_Paint);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(355, 54);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 22;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pn_pr
            // 
            this.pn_pr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_pr.Location = new System.Drawing.Point(188, 166);
            this.pn_pr.Name = "pn_pr";
            this.pn_pr.Size = new System.Drawing.Size(101, 205);
            this.pn_pr.TabIndex = 21;
            this.pn_pr.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_pr_Paint);
            // 
            // lb_pcnt
            // 
            this.lb_pcnt.AutoSize = true;
            this.lb_pcnt.Location = new System.Drawing.Point(232, 104);
            this.lb_pcnt.Name = "lb_pcnt";
            this.lb_pcnt.Size = new System.Drawing.Size(11, 12);
            this.lb_pcnt.TabIndex = 20;
            this.lb_pcnt.Text = "0";
            // 
            // pn_wafer
            // 
            this.pn_wafer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_wafer.Location = new System.Drawing.Point(33, 166);
            this.pn_wafer.Name = "pn_wafer";
            this.pn_wafer.Size = new System.Drawing.Size(101, 205);
            this.pn_wafer.TabIndex = 18;
            this.pn_wafer.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_wafer_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "코팅액";
            // 
            // lb_wcnt
            // 
            this.lb_wcnt.AutoSize = true;
            this.lb_wcnt.Location = new System.Drawing.Point(77, 104);
            this.lb_wcnt.Name = "lb_wcnt";
            this.lb_wcnt.Size = new System.Drawing.Size(11, 12);
            this.lb_wcnt.TabIndex = 17;
            this.lb_wcnt.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "Wafer";
            // 
            // ts_lb1
            // 
            this.ts_lb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lb});
            this.ts_lb1.Location = new System.Drawing.Point(0, 577);
            this.ts_lb1.Name = "ts_lb1";
            this.ts_lb1.Size = new System.Drawing.Size(892, 22);
            this.ts_lb1.TabIndex = 1;
            this.ts_lb1.Text = "statusStrip1";
            // 
            // ts_lb
            // 
            this.ts_lb.Name = "ts_lb";
            this.ts_lb.Size = new System.Drawing.Size(138, 17);
            this.ts_lb.Text = "상태 변화를 나타냅니다.";
            // 
            // tm_coating
            // 
            this.tm_coating.Tick += new System.EventHandler(this.tm_coating_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.ts_lb1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "WaferLine 예광탄";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).EndInit();
            this.ts_lb1.ResumeLayout(false);
            this.ts_lb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_pr;
        private System.Windows.Forms.Button btn_wafer;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.Label lb_wafer;
        private System.Windows.Forms.TrackBar tbar_pr;
        private System.Windows.Forms.TrackBar tbar_wafer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.TrackBar tbar_drop;
        private System.Windows.Forms.TrackBar tbar_spin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_awafer;
        private System.Windows.Forms.Label lb_awcnt;
        private System.Windows.Forms.Label label15;
        private WaferLineControlLib.WaferPanel pn_nwafer;
        private WaferLineControlLib.DPanel pn_npr;
        private System.Windows.Forms.Button btn_start;
        private WaferLineControlLib.DPanel pn_pr;
        private System.Windows.Forms.Label lb_pcnt;
        private WaferLineControlLib.DPanel pn_wafer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_wcnt;
        private System.Windows.Forms.Label label12;
        private WaferLineControlLib.WaferPanel pn_awafer;
        private System.Windows.Forms.StatusStrip ts_lb1;
        private System.Windows.Forms.ToolStripStatusLabel ts_lb;
        private System.Windows.Forms.Timer tm_coating;
    }
}

