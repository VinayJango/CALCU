using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CALCU
{
    public partial class CALCU_1 : Form
    {
    

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public CALCU_1()
        {
            InitializeComponent();
        }
        string CalTotal;
        int num1;
        int num2;
        int x  = 0;
        string option;
        int result;
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
   
        private void CALCU_1_Load(object sender, EventArgs e)
        {

        }

        private void CALCU_1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void CALCU_1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
    
        }

        private void CALCU_1_MouseMove(object sender, MouseEventArgs e)
        {
          if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y); 
            }
        }

        private void button22_Click(object sender, EventArgs e) // 1_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e) // 7_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "7";

        }

        private void button21_Click(object sender, EventArgs e) // 2_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "2";

        }

        private void button1_Click(object sender, EventArgs e) //CUBE_BUTTON
        {
            option = "x³";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //CLEAR_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + btn_ERASE.Text;

        }

        private void button9_Click(object sender, EventArgs e) // SQUARE_BUTTON
        {
            option = "x²";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }

        private void btnpercentage_Click(object sender, EventArgs e)
        {
            TxtTOTAL.Text = TxtTOTAL.Text + btnpercentage.Text;

        }

        private void btn_ERASE_Click(object sender, EventArgs e) //ERASE_BUTTON
        {
            TxtTOTAL.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnDIVIDE_NUM_0_Click(object sender, EventArgs e) //DIVIDE THE NUM BY 0_BUTTON
        {
            option = "1/(0)";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }

        private void button25_Click(object sender, EventArgs e) // 0_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "0";

        }

        private void btn_DIVIDE_Click(object sender, EventArgs e) //DIVIDE_BUTTON
        {
            option = "/";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }

        private void btn8_Click(object sender, EventArgs e) // 8_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e) // 9_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "9";

        }

        private void btn4_Click(object sender, EventArgs e) // 4_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e) // 5_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e) // 6_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "6";

        }

        private void btn_SUBTRACT_Click(object sender, EventArgs e) // SUBTRACT_BUTTON
        {
            option = "-";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }

        private void btn3_Click(object sender, EventArgs e) // 3_BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + "3";

        }

        private void btn_ADD_Click(object sender, EventArgs e) // ADDITION_BUTTON
        {
            option = "+";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();

        }

        private void btnPOINT_Click(object sender, EventArgs e) // POINT . _BUTTON
        {
            TxtTOTAL.Text = TxtTOTAL.Text + btnPOINT.Text;

        }

        private void btn_IS_EQUAL_TO_Click(object sender, EventArgs e) // = IS_EQUAL_TO_BUTTON
        {
            num2 = int.Parse(TxtTOTAL.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            if (option.Equals("x²")) // OUTPUTS THE SQUARE OF NUM
                result = num1 * num1;

            if (option.Equals("x³")) // OUTPUTS THE CUBE OF NUM
                result = num1 * num1 * num1;

            if (option.Equals("1/(0)"))
                result = num1 / x;   // DIVIDES THE NUMBER BY 0 HERE X IS A INTEGER DECLARED AS 0

            TxtTOTAL.Text = result + "";
        }

        private void TxtTOTAL_TextChanged(object sender, EventArgs e) //DISPLAY ANSWER TB
        {

        }

        private void btn_MULTIPLY_Click(object sender, EventArgs e) // MULTIPLY_BUTTON
        {
            option = "*";
            num1 = int.Parse(TxtTOTAL.Text);

            TxtTOTAL.Clear();
        }
    }
}
