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
        // null인 블럭을 대체할 0
        private const string zero = "0";

        // 숫자 블럭 2, 4
        private const string two = "2";
        private const string four = "4";

        // 마우스 이벤트 관련 전역변수
        private bool isMouseDown;
        private Point lastLocation;

        // 폼 이전크기, 최대화 관련 전역변수
        private bool isFormMaximized;

        // 좌표의 정보를 가지고 있는 전역변수
        private string[,] numberBlocks = new string[4,4];

        // 블럭 위치를 나타내는 구조체
        private struct BlockLocation{
            public int X;
            public int Y;
        }

        // 상, 하, 좌, 우
        private enum KeyMoveStatus
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
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

        private void MoveBlocks(KeyMoveStatus keyMoveStatus)
        {
            switch (keyMoveStatus)
            {
                case KeyMoveStatus.UP:
                    {
                        List<BlockLocation> blockLocations = new List<BlockLocation>();
                        for (var xLocation = 0; xLocation < numberBlocks.GetLength(0); xLocation++)
                        {
                            for (var yLocation = 0; yLocation < numberBlocks.GetLength(1) - 1; yLocation++)
                            {
                                var block = int.Parse(numberBlocks[xLocation, yLocation] ?? zero);

                                if(block is 0)
                                {
                                    continue;
                                }

                                for (var nextYLocation = yLocation + 1; nextYLocation < numberBlocks.GetLength(1) - 1; nextYLocation++)
                                {
                                    var nextBlock = int.Parse(numberBlocks[xLocation, nextYLocation] ?? zero);
                                    var value = (nextBlock + block).ToString();

                                    if(nextBlock is 0)
                                    {
                                        continue;
                                    }

                                    if (nextBlock.Equals(block))
                                    {
                                        numberBlocks[xLocation, yLocation] = null;
                                        numberBlocks[xLocation, nextYLocation] = null;

                                        for (var zeroYLocation = 0; zeroYLocation <= yLocation; zeroYLocation++)
                                        {
                                            if(numberBlocks[xLocation, zeroYLocation] is null)
                                            {
                                                numberBlocks[xLocation, zeroYLocation] = value;
                                                break;
                                            }
                                        }

                                        break;
                                    }
                                    
                                }
                            }
                        }

                        break;
                    }

                case KeyMoveStatus.DOWN:
                    {

                        break;
                    }

                case KeyMoveStatus.LEFT:
                    {

                        break;
                    }

                case KeyMoveStatus.RIGHT:
                    {

                        break;
                    }
            }
            
        }

        private void RefreshBlocks()
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

            for(var xLocation = 0; xLocation < numberBlocks.GetLength(0); xLocation++)
            {
                for (var yLocation = 0; yLocation < numberBlocks.GetLength(1); yLocation++)
                {
                    if (string.IsNullOrEmpty(numberBlocks[xLocation, yLocation]))
                    {
                        emptyBlockLocation.Add(new BlockLocation { X = xLocation, Y = yLocation });
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
                createNumberString = two;
                numberBlocks[blockLocation.X, blockLocation.Y] = two;
            }
            else
            {
                createNumberString = four;
                numberBlocks[blockLocation.X, blockLocation.Y] = four;
            }


            var btn = new Button() { Text = createNumberString, Dock = DockStyle.Fill };
            tlp_numberBoard.Controls.Add(btn);
            tlp_numberBoard.SetCellPosition(btn, new TableLayoutPanelCellPosition(blockLocation.X, blockLocation.Y));
            return true;
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

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);

            if (e.KeyCode == Keys.Up)
            {
                MoveBlocks(KeyMoveStatus.UP);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveBlocks(KeyMoveStatus.DOWN);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Left)
            {
                MoveBlocks(KeyMoveStatus.LEFT);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveBlocks(KeyMoveStatus.RIGHT);
                CreateRandomBlock();
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);

            if (e.KeyCode == Keys.Up)
            {
                MoveBlocks(KeyMoveStatus.UP);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveBlocks(KeyMoveStatus.DOWN);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Left)
            {
                MoveBlocks(KeyMoveStatus.LEFT);
                CreateRandomBlock();
            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveBlocks(KeyMoveStatus.RIGHT);
                CreateRandomBlock();
            }
        }
    }
}
