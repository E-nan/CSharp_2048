using CSharp_2048.function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2048
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MoveBlock();
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
            string[] words = new string[]
{
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
};              // 9 (or words.Length) ^0

            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            string[] lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
            foreach (var word in allWords)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in firstPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in lastPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();
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

            var createNumberPercentage = new Random().Next(1, 101);
            var createNumberString = string.Empty;
            if(createNumberPercentage <= 80)
            {
                createNumberString = "2";
                numberBlocks[blockLocation.X, blockLocation.Y] = "2";
            }
            else
            {
                createNumberString = "4";
                numberBlocks[blockLocation.X, blockLocation.Y] = "4";
            }


            var btn = new Button() { Text = createNumberString, Dock = DockStyle.Fill };
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
        // 마우스를 빠르게 움직이면, 마우스가 폼 밖으로 나간 경우 버그 발생
        private void ts_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // 방법1
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.lastLocation.X,
                                     p2.Y - this.lastLocation.Y);
                this.Location = p3;

                // 방법2
                //this.Location = new Point(
                //    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ts_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
