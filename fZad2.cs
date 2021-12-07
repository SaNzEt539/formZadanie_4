using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_4
{
    public partial class fZad2 : Form
    {
        string str = String.Empty;
        void f(char a, int space, int count)
        {
            if (a == 'Z')
            {
                for (int i = 0; i < space; i++)
                {
                    str += " ";
                }
                for (int i = 0; i < count; i++)
                {
                    str += a;
                }
                str += '\n';
                return;
            }
            for (int i = 0; i < space; i++)
            {
                str += " ";
            }
            for (int i = 0; i < count; i++)
            {
                str += a;
            }
            str += '\n';
            f(++a, space + 1, count - 2);
            a--;
            for (int i = 0; i < space; i++)
            {
                str += " ";
            }
            for (int i = 0; i < count; i++)
            {
                str += a;
            }
            str += '\n';
        }
        public fZad2()
        {
            InitializeComponent();
        }

        private void fZad2_Load(object sender, EventArgs e)
        {
            f('A', 0, 80);
            string[] str2 = str.Split('\n');
            label1.Text = str;
        }
    }
}
