using System.Windows.Forms;

namespace WaferLineControlLib
{
    /// <summary>
    /// 더블 버퍼링 패널
    /// </summary>
    public class DPanel : Panel
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public DPanel()
        {
            SetStyle(
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint,
                true);
            UpdateStyles();
        }
    }
}
