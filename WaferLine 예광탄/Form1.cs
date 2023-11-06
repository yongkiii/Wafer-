using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLine_예광탄
{
    public partial class Form1 : Form
    {
        WaferLine wl = null;
        public Form1()
        {
            InitializeComponent();
            //첫번째 웨이퍼를 가져간다 왜냐하면 배열에 있는 웨이퍼를 빼기 때문이지
            wl = new WaferLine(1);
        }


        private void tbar_spin_Scroll(object sender, EventArgs e)
        {
            lb_spin.Text = tbar_spin.Value.ToString();
            wl.SetSpin(tbar_spin.Value);
        }

        private void tbar_drop_Scroll(object sender, EventArgs e)
        {
            lb_drop.Text = tbar_drop.Value.ToString();
            wl.SetDrop(tbar_drop.Value);
            ChangeInterval();
        }

        private void ChangeInterval()
        {

            tm_coating.Interval = 20000000 / (wl.Spin * wl.Drop);
        }

        private void btn_wafer_Click(object sender, EventArgs e)
        {
            wl.InWafer(tbar_wafer.Value);
            lb_wcnt.Text = wl.BWCnt.ToString();
            ts_lb.Text = string.Format("코팅 전 wafer  개수 : {0}", wl.BWCnt);
            tbar_wafer.Value = 0;

        }

        private void tbar_pr_ValueChanged(object sender, EventArgs e)
        {
            lb_pr.Text = tbar_pr.Value.ToString();
        }

        private void tbar_wafer_ValueChanged(object sender, EventArgs e)
        {
            lb_wafer.Text = tbar_wafer.Value.ToString();
        }

        private void btn_pr_Click(object sender, EventArgs e)
        {
            wl.InPr(tbar_pr.Value);
            lb_pcnt.Text = wl.PCnt.ToString();
            tbar_pr.Value = 0;
            ts_lb.Text = string.Format("코팅 액 {0}병 남은", wl.PCnt);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (tm_coating.Enabled == false)
            {
                tm_coating.Enabled = true;
                btn_start.Text = "멈춤";
            }
            else
            {
                tm_coating.Enabled = false;
                btn_start.Text = "시작";
            }
        }

        private void cb_awafer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_awafer.SelectedIndex == -1)
            {
                return;
            }
            Wafer wafer = cb_awafer.SelectedItem as Wafer;
            pn_awafer.Wafer = wafer;
            pn_awafer.Invalidate();
        }

        private void tm_coating_Tick(object sender, EventArgs e)
        {
            if (wl.Coating() == false) // 코팅 못했을때
            {
                tm_coating.Enabled = false;
                btn_start.Text = "시작";
            }
            Wafer wafer = wl.Now;
            pn_nwafer.Wafer = wafer;
            if (wafer != null)
            {
                int ccnt = wafer.Now;
                if (ccnt == 1)
                {
                    Wafer lwafer = wl.LastWafer;
                    if (lwafer != null)
                    {
                        cb_awafer.Items.Add(lwafer);
                        lb_awcnt.Text = wl.AWCnt.ToString();
                        ts_lb.Text = string.Format("코팅 완료 :{0}", lwafer);
                    }
                    lb_wcnt.Text = wl.BWCnt.ToString();
                }

            }
            //부족해서 하나를 꺼내고 방울 하나를 떨군 상태
            if (wl.NPcnt == 999)
            {
                lb_pcnt.Text = wl.PCnt.ToString();
                ts_lb.Text = string.Format("코팅액 교체: {0}병 남음", wl.PCnt);
            }
            Invalidate(true);
        }

        private void pn_wafer_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.DarkGray, 1);
            pen.DashStyle = DashStyle.Dot;
            int xu = pn_wafer.Width / 10;
            int yu = pn_wafer.Height / 20;
            int wcnt = wl.BWCnt;

            Point st = new Point();
            Point et = new Point();
            for (int x = 1; x < 10; x++)
            {
                st.X = x * xu;
                st.Y = 0;
                et.X = x * xu;
                et.Y = pn_wafer.Height;
                graphics.DrawLine(pen, st, et);
            }
            for (int y = 1; y < 20; y++)
            {
                st.X = 0;
                st.Y = y * yu;
                et.X = pn_wafer.Width;
                et.Y = y * yu;
                graphics.DrawLine(pen, st, et);
            }
            Brush brush1 = new HatchBrush(HatchStyle.DiagonalCross, Color.Goldenrod);
            Brush brush2 = new SolidBrush(pn_wafer.BackColor);
            Brush brush;
            for (int i = 0; i < 200; i++)
            {
                if (200 - i <= wcnt)
                {
                    brush = brush1;
                }
                else
                {
                    brush = brush2;
                }
                int x = i % 10;
                int y = i / 10;
                st.X = x * xu + 1;
                st.Y = y * yu + 1;
                graphics.FillRectangle(brush, new Rectangle(st, new Size(xu - 1, yu - 1)));
            }
        }

        private void pn_pr_Paint(object sender, PaintEventArgs e)
        {
            if (wl == null) { return; }
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.DarkGray, 1);
            pen.DashStyle = DashStyle.Dot;
            int yu = pn_pr.Height / 20;
            for (int y = 1; y < 20; y++)
            {
                graphics.DrawLine(pen, new Point(0, y * yu), new Point(pn_pr.Width, y * yu));
            }
            int pcnt = wl.PCnt;
            for (int i = 0, ri = 20; i < 20; i++, ri--)
            {
                Color color = pn_pr.BackColor;
                if (ri <= pcnt)
                {
                    color = Color.DarkCyan;
                }
                Brush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, new Rectangle(0, i * yu + 1, pn_pr.Width, yu - 1));
            }
        }

        private void pn_npr_Paint(object sender, PaintEventArgs e)
        {
            if (wl == null) { return; }
            Graphics graphics = e.Graphics;
            int npcnt = wl.NPcnt;
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (npcnt < (1000 - y * 50 + x))
                    {
                        graphics.DrawLine(Pens.White, new Point(x, y), new Point(x + 1, y));
                    }
                    else
                    {
                        graphics.DrawLine(Pens.DarkCyan, new Point(x, y), new Point(x + 1, y));
                    }

                }
            }

        }

    }
}
