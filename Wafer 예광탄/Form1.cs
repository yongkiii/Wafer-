using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineLib;

namespace Wafer_예광탄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            tm_coating.Start();
            btn_start.Enabled = false;
        }


        Random random = new Random();
        private void tm_coating_Tick(object sender, EventArgs e)
        {
            
            if(wp.Wafer == null)
            {
                wp.Wafer = new Wafer();
            }
            wp.Wafer.Coating(random.Next(70, 100));
            if (wp.Wafer.Increment() == false)//코팅 완료일 때
            {
                tm_coating.Enabled = false;//타이머 멈춤
                btn_start.Enabled = true;
                wp.Wafer = null;
            }
            wp.Invalidate();//웨이퍼 패널을 무효화
            
        }

    }
}
