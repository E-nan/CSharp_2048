using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 최소화 이벤트
        /// </summary>
        private void HideForm()
        {

        }

        /// <summary>
        /// 폼 이전 크기로, 최대화 이벤트
        /// </summary>
        private void ResizeForm()
        {

        }

        /// <summary>
        /// 폼 나가기 이벤트
        /// </summary>
        private void ExitForm()
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);
        }

        private void tsb_hide_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void tsb_resize_Click(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void tsb_exit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }
    }
}
