using _2048.function;
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
        // 마우스 이벤트 관련 전역변수
        private bool mouseDown;
        private Point lastLocation;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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
            if (Msg.Question("정말 종료하시겠습니까?") == DialogResult.OK)
            {
                Close();
            }
        }

        /// <summary>
        /// 랜덤한 위치에 블럭을 생성하는 메서드
        /// </summary>
        /// <returns></returns>
        private bool CreateRandomBlock()
        {
            Point blockLocation;

            while (true)
            {
                blockLocation = new Point(new Random().Next(0, 4), new Random().Next(0, 4));

                if (CheckNumberPanel(blockLocation))
                    break;
            }            

            var btn = new Button() { Text = "2", Dock = DockStyle.Fill };
            tlp_numberBoard.Controls.Add(btn);
            tlp_numberBoard.SetCellPosition(btn, new TableLayoutPanelCellPosition(blockLocation.X, blockLocation.Y));
            return true;
        }

        /// <summary>
        /// 넘버패널이 존재하는지 확인하는 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckNumberPanel(Point point)
        {
            var block = tlp_numberBoard.GetControlFromPosition(point.X, point.Y);

            if (block is null)
                return true;
            else
                return false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CreateRandomBlock();
        }

        private void ts_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // 마우스 눌린 상태에서
        // 폼의 위치가 마우스 움직임에 따라서 X, Y 값을 계산하고 Update
        private void ts_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ts_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
