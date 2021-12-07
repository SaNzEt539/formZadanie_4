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
    public partial class fZad1 : Form
    {
        static int F(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
        static int C(int m, int n)
        {
            if (m == 0 || m == n)
            {
                return 1;
            }
            return ((F(n) / (F(n - m) * m)) + C(m - 1, n - 1));
        }
        public fZad1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(tbN.Text);
                int M = int.Parse(tbM.Text);
                if (M < 0 && N < M)
                {
                    throw new Exception();
                }
                //int s = C(M, N);
                labRes.Text = "Результат: " + C(M, N);
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
            }
            catch (Exception)
            {
                labRes.Text = "M должно быть больше или равно нулю, N должно быть больше или равно M";
            }
            finally
            {
                labRes.Visible = true;
            }
        }
    }
}
