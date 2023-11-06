namespace Wafer_예광탄
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
            this.btn_start = new System.Windows.Forms.Button();
            this.tm_coating = new System.Windows.Forms.Timer(this.components);
            this.wp = new WaferLineControlLib.WaferPanel();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(127, 30);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tm_coating
            // 
            this.tm_coating.Tick += new System.EventHandler(this.tm_coating_Tick);
            // 
            // wp
            // 
            this.wp.Location = new System.Drawing.Point(59, 116);
            this.wp.Name = "wp";
            this.wp.Size = new System.Drawing.Size(202, 175);
            this.wp.TabIndex = 2;
            this.wp.Wafer = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 379);
            this.Controls.Add(this.wp);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Wafer 예광탄";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer tm_coating;
        private WaferLineControlLib.WaferPanel wp;
    }
}

