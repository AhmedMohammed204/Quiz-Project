using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{

    public static class clsTextColor
    {
        private static void txtLeave(TextBox txt)
        {

            txt.ForeColor = ColorTranslator.FromHtml("#87CCCC");
        }
        private static void txtEnter(TextBox txt)
        {
            txt.ForeColor = ColorTranslator.FromHtml("#284160");
        }
        public static void ChangeTextColor(object sender, bool IsEnter = true)
        {
            TextBox txt = (TextBox)sender;

            if (IsEnter)
            {
                txtEnter(txt);
                return;
            }
            txtLeave(txt);
        }
    }
}
