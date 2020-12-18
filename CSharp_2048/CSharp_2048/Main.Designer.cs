namespace CSharp_2048
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsl_main = new System.Windows.Forms.TableLayoutPanel();
            this.ts_topBar = new System.Windows.Forms.ToolStrip();
            this.tsb_exit = new System.Windows.Forms.ToolStripButton();
            this.tsb_resize = new System.Windows.Forms.ToolStripButton();
            this.tsb_hide = new System.Windows.Forms.ToolStripButton();
            this.tsl_icon = new System.Windows.Forms.ToolStripLabel();
            this.tsl_title = new System.Windows.Forms.ToolStripLabel();
            this.tlp_numberBoard = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tsl_main.SuspendLayout();
            this.ts_topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsl_main
            // 
            this.tsl_main.ColumnCount = 1;
            this.tsl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tsl_main.Controls.Add(this.ts_topBar, 0, 0);
            this.tsl_main.Controls.Add(this.tlp_numberBoard, 0, 2);
            this.tsl_main.Controls.Add(this.panel1, 0, 1);
            this.tsl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsl_main.Location = new System.Drawing.Point(0, 0);
            this.tsl_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tsl_main.Name = "tsl_main";
            this.tsl_main.RowCount = 3;
            this.tsl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tsl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34515F));
            this.tsl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.65485F));
            this.tsl_main.Size = new System.Drawing.Size(473, 674);
            this.tsl_main.TabIndex = 0;
            // 
            // ts_topBar
            // 
            this.ts_topBar.AllowDrop = true;
            this.ts_topBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ts_topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_topBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_exit,
            this.tsb_resize,
            this.tsb_hide,
            this.tsl_icon,
            this.tsl_title});
            this.ts_topBar.Location = new System.Drawing.Point(0, 0);
            this.ts_topBar.Name = "ts_topBar";
            this.ts_topBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_topBar.Size = new System.Drawing.Size(473, 25);
            this.ts_topBar.TabIndex = 0;
            this.ts_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ts_topBar_MouseDown);
            this.ts_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ts_topBar_MouseMove);
            this.ts_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ts_topBar_MouseUp);
            // 
            // tsb_exit
            // 
            this.tsb_exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_exit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_exit.Image")));
            this.tsb_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exit.Name = "tsb_exit";
            this.tsb_exit.Size = new System.Drawing.Size(23, 22);
            this.tsb_exit.Text = "toolStripButton1";
            this.tsb_exit.Click += new System.EventHandler(this.tsb_exit_Click);
            // 
            // tsb_resize
            // 
            this.tsb_resize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_resize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_resize.Image = ((System.Drawing.Image)(resources.GetObject("tsb_resize.Image")));
            this.tsb_resize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_resize.Name = "tsb_resize";
            this.tsb_resize.Size = new System.Drawing.Size(23, 22);
            this.tsb_resize.Text = "toolStripButton2";
            this.tsb_resize.Click += new System.EventHandler(this.tsb_resize_Click);
            // 
            // tsb_hide
            // 
            this.tsb_hide.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_hide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_hide.Image = ((System.Drawing.Image)(resources.GetObject("tsb_hide.Image")));
            this.tsb_hide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_hide.Name = "tsb_hide";
            this.tsb_hide.Size = new System.Drawing.Size(23, 22);
            this.tsb_hide.Text = "toolStripButton3";
            this.tsb_hide.Click += new System.EventHandler(this.tsb_hide_Click);
            // 
            // tsl_icon
            // 
            this.tsl_icon.AutoSize = false;
            this.tsl_icon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tsl_icon.Name = "tsl_icon";
            this.tsl_icon.Size = new System.Drawing.Size(22, 22);
            // 
            // tsl_title
            // 
            this.tsl_title.Name = "tsl_title";
            this.tsl_title.Size = new System.Drawing.Size(35, 22);
            this.tsl_title.Text = "2048";
            // 
            // tlp_numberBoard
            // 
            this.tlp_numberBoard.BackColor = System.Drawing.Color.DarkKhaki;
            this.tlp_numberBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlp_numberBoard.ColumnCount = 4;
            this.tlp_numberBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_numberBoard.Location = new System.Drawing.Point(3, 187);
            this.tlp_numberBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlp_numberBoard.Name = "tlp_numberBoard";
            this.tlp_numberBoard.RowCount = 4;
            this.tlp_numberBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_numberBoard.Size = new System.Drawing.Size(467, 483);
            this.tlp_numberBoard.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 150);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 674);
            this.Controls.Add(this.tsl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.tsl_main.ResumeLayout(false);
            this.tsl_main.PerformLayout();
            this.ts_topBar.ResumeLayout(false);
            this.ts_topBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tsl_main;
        private System.Windows.Forms.ToolStrip ts_topBar;
        private System.Windows.Forms.ToolStripButton tsb_exit;
        private System.Windows.Forms.ToolStripButton tsb_resize;
        private System.Windows.Forms.ToolStripButton tsb_hide;
        private System.Windows.Forms.TableLayoutPanel tlp_numberBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripLabel tsl_icon;
        private System.Windows.Forms.ToolStripLabel tsl_title;
    }
}

