using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSharp_2048.function
{
    public static class Msg
    {
        public static void Error(string text)
        {
            MessageBox.Show(text, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Information(string text)
        {
            MessageBox.Show(text, "도움말", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string text)
        {
            MessageBox.Show(text, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Exclamation(string text)
        {
            MessageBox.Show(text, "ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Question(string text)
        {
            return MessageBox.Show(text, "질문", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
