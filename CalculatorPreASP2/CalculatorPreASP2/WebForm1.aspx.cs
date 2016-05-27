using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorPreASP2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public enum operation
        {
            sum = 1,
            res = 2,
            div = 3,
            plus = 4,
            sin = 5,
            cos = 6,
            tan = 7

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }

        }


        protected void C_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            enableButtonsForTrigonometric();
            
        }

        protected void _7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 7;
        }

        protected void _8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 8;
        }

        protected void _9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 9;
        }

        protected void _4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 4;
        }

        protected void _5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 5;
        }

        protected void _6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 6;
        }

        protected void _1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 1;
        }

        protected void _2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 2;
        }

        protected void _3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 3;
        }

        protected void _0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 0;
        }

        protected void _dot_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
        }

        protected void add_Click(object sender, EventArgs e)
        {
            Double Total1 = +Convert.ToDouble(Display.Text);
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "";
            Session["Operation"] = (int)operation.sum;

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            Double Total1 = +Convert.ToDouble(Display.Text);
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "";
            Session["Operation"] = (int)operation.res;
        }

        protected void div_Click(object sender, EventArgs e)
        {
            Double Total1 = +Convert.ToDouble(Display.Text);
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "";
            Session["Operation"] = (int)operation.div;
        }

        protected void plus_Click(object sender, EventArgs e)
        {
            Double Total1 = +Convert.ToDouble(Display.Text);
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "";
            Session["Operation"] = (int)operation.plus;
        }

        protected void sin_Click(object sender, EventArgs e)
        {
            Double Total1 = 0.0;
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "Sin ";
            Session["Operation"] = (int)operation.sin;
            disableButtonsForTrigonometric(operation.sin);
        }

        protected void cos_Click(object sender, EventArgs e)
        {
            Double Total1 = 0.0;
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "Cos ";
            Session["Operation"] = (int)operation.cos;
            disableButtonsForTrigonometric(operation.cos);
        }

        protected void tan_Click(object sender, EventArgs e)
        {
            Double Total1 = 0.0;
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text = "Tan ";
            Session["Operation"] = (int)operation.tan;
            disableButtonsForTrigonometric(operation.tan);
        }

        protected void eval_Click(object sender, EventArgs e)
        {
            int op = (int)Session["Operation"]; 
            double Total2 = 0;
            string Cumulative = Convert.ToString(Session["Cumulative"]);
            double Total1 = Convert.ToDouble(Cumulative);
            try
            {
                switch (op)
                {
                    case 1:
                        Total2 = Total1 + Convert.ToDouble(Display.Text);
                        break;
                    case 2:
                        Total2 = Total1 - Convert.ToDouble(Display.Text);
                        break;
                    case 3:
                        Total2 = Total1 / Convert.ToDouble(Display.Text);
                        break;
                    case 4:
                        Total2 = Total1 * Convert.ToDouble(Display.Text);
                        break;
                    case 5:
                        String sinText = Display.Text;
                        String sinNum = sinText.Remove(0, 3);
                        Total2 = Math.Sin(Convert.ToDouble(sinNum));
                        enableButtonsForTrigonometric();
                        break;
                    case 6:
                        String cosText = Display.Text;
                        String cosNum = cosText.Remove(0, 3);
                        Total2 = Math.Cos(Convert.ToDouble(cosNum));
                        enableButtonsForTrigonometric();
                        break;
                    case 7:
                        String tanText = Display.Text;
                        String tanNum = tanText.Remove(0, 3);
                        Total2 = Math.Tan(Convert.ToDouble(tanNum));
                        enableButtonsForTrigonometric();
                        break;
                }
            }
            catch
            {
                Display.Text = "MATH Error!";
            }
            

            Display.Text = Convert.ToString(Total2);

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Double Total1 = +Convert.ToDouble(Display.Text.Remove(Display.Text.Length - 1));
            Session["Cumulative"] = Convert.ToString(Total1);
            Display.Text =(String)Session["Cumulative"];
        }

        protected void disableButtonsForTrigonometric(operation trigonometric)
        {
            delete.Enabled = false;
            add.Enabled = false;
            sub.Enabled = false;
            div.Enabled = false;
            plus.Enabled = false;
            int op = (int)trigonometric;
            switch (op)
            {
                case 5:
                    cos.Enabled = false;
                    tan.Enabled = false;
                    break;
                case 6:
                    sin.Enabled = false;
                    tan.Enabled = false;
                    break;
                case 7:
                    cos.Enabled = false;
                    sin.Enabled = false;
                    break;
            }
            
        }

        protected void enableButtonsForTrigonometric()
        {
            delete.Enabled = true;
            add.Enabled = true;
            sub.Enabled = true;
            div.Enabled = true;
            plus.Enabled = true;
            sin.Enabled = true;
            cos.Enabled = true;
            tan.Enabled = true;
        }


       

    }
}