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
        private bool isMouseDown;
        private Point lastLocation;
        // 폼 이전크기, 최대화 관련 전역변수
        private bool isFormMaximized;
        private string[,] numberBlocks = new string[4,4];

        private struct BlockLocation{
            public int X;
            public int Y;
        }

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
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 폼 이전 크기로, 최대화 이벤트
        /// </summary>
        private void ResizeForm()
        {
            if (!isFormMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            isFormMaximized = !isFormMaximized;
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

        private void MoveBlock()
        {

        }

        /// <summary>
        /// 랜덤한 위치에 블럭을 생성하는 메서드
        /// </summary>
        /// <returns></returns>
        private bool CreateRandomBlock()
        {
            Point blockLocation;
            List<BlockLocation> emptyBlockLocation = new List<BlockLocation>();

            for(var i = 0; i < numberBlocks.GetLength(0); i++)
            {
                for (var j = 0; j < numberBlocks.GetLength(1); j++)
                {
                    if (string.IsNullOrEmpty(numberBlocks[i, j]))
                    {
                        emptyBlockLocation.Add(new BlockLocation { X = i, Y = j });
                    }
                }
            }

            if(emptyBlockLocation.Count == 0)
            {
                return false;
            }

            var randomIndex = new Random().Next(0, emptyBlockLocation.Count);
            blockLocation = new Point {
                X = emptyBlockLocation[randomIndex].X,
                Y = emptyBlockLocation[randomIndex].Y 
            };

            numberBlocks[blockLocation.X, blockLocation.Y] = "2";

            var btn = new Button() { Text = "2", Dock = DockStyle.Fill };
            tlp_numberBoard.Controls.Add(btn);
            tlp_numberBoard.SetCellPosition(btn, new TableLayoutPanelCellPosition(blockLocation.X, blockLocation.Y));
            return true;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);

            if (e.KeyCode == Keys.Right)
            {
                MoveBlock();
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Left)
            {
                MoveBlock();
                CreateRandomBlock();
            }
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
            if (!CreateRandomBlock())
            {
                Msg.Information("게임오버");
            }
        }

        private void ts_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        // 마우스 눌린 상태에서
        // 폼의 위치가 마우스 움직임에 따라서 X, Y 값을 계산하고 Update
        private void ts_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ts_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
