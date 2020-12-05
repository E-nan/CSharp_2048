namespace _2048
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ts_topBar = new System.Windows.Forms.ToolStrip();
            this.tsb_exit = new System.Windows.Forms.ToolStripButton();
            this.tsb_resize = new System.Windows.Forms.ToolStripButton();
            this.tsb_hide = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.ts_topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ts_topBar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.45963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.54037F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ts_topBar
            // 
            this.ts_topBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ts_topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_exit,
            this.tsb_resize,
            this.tsb_hide});
            this.ts_topBar.Location = new System.Drawing.Point(0, 0);
            this.ts_topBar.Name = "ts_topBar";
            this.ts_topBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_topBar.Size = new System.Drawing.Size(473, 25);
            this.ts_topBar.TabIndex = 0;
            this.ts_topBar.Text = "toolStrip1";
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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ts_topBar.ResumeLayout(false);
            this.ts_topBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip ts_topBar;
        private System.Windows.Forms.ToolStripButton tsb_exit;
        private System.Windows.Forms.ToolStripButton tsb_resize;
        private System.Windows.Forms.ToolStripButton tsb_hide;
    }
}

