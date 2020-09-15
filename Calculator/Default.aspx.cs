using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        static float var_a, var_b, var_c;
        static char char_d;
        static String e_code = "Invalid operation!";
        List<string> hello = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOne_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnOne.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnOne.Text;
            }
        }

        protected void BtnTwo_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnTwo.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnTwo.Text;
            }
        }

        protected void BtnThree_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnThree.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnThree.Text;
            }
        }

        protected void BtnFour_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnFour.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnFour.Text;
            }
        }

        protected void BtnFive_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnFive.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnFive.Text;
            }
        }

        protected void BtnSix_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnSix.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnSix.Text;
            }
        }

        protected void BtnSeven_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnSeven.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnSeven.Text;
            }
        }

        protected void BtnEight_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnEight.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnEight.Text;
            }
        }

        protected void BtnNine_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnNine.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnNine.Text;
            }
        }

        protected void BtnZero_Click(object sender, EventArgs e)
        {
            if (LblResults.Text == "/" || LblResults.Text == "*" || LblResults.Text == "+" || LblResults.Text == "-" || LblResults.Text.Equals(e_code))
            {
                LblResults.Text = "";
                LblResults.Text = LblResults.Text + BtnZero.Text;
            }
            else
            {
                LblResults.Text = LblResults.Text + BtnZero.Text;
            }
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(LblResults.Text, out int results))
            {
                var_a = Convert.ToInt32(LblResults.Text);
                LblResults.Text = "";
                char_d = '*';
                LblResults.Text += char_d;
            }

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(LblResults.Text, out int results))
            {
                var_a = Convert.ToInt32(LblResults.Text);
                LblResults.Text = "";
                char_d = '+';
                LblResults.Text += char_d;
            }
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(LblResults.Text, out int results))
            {
                var_a = Convert.ToInt32(LblResults.Text);
                LblResults.Text = "";
                char_d = '-';
                LblResults.Text += char_d;
            }
        }
        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(LblResults.Text, out int results))
            {
                var_a = Convert.ToInt32(LblResults.Text);
                LblResults.Text = "";
                char_d = '/';
                LblResults.Text += char_d;
            }
        }

        protected void BtnDelVar_Click(object sender, EventArgs e)
        {
            //char[] hello = (LblResults.Text).Reverse().Skip(1).Reverse().ToArray();
            //char[] hello = LblResults.Text.Take(LblResults.Text.Length - 1).ToArray();

            string hello = new string(LblResults.Text.Take(LblResults.Text.Length - 1).ToArray());
            LblResults.Text = "";
            LblResults.Text = hello;

        }

        protected void BtnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((LblResults.Text)))
            {
                if (Int32.TryParse(LblResults.Text, out int results))
                {
                    var_c = Convert.ToInt32(LblResults.Text);
                    LblResults.Text = "";
                    if (char_d == '/')
                    {
                        var_b = var_a / var_c;
                        hello.Add(var_a + "/" + var_b);
                        LblResults.Text += var_b;
                        var_a = var_b;
                    }
                    else if (char_d == '*')
                    {
                        var_b = var_a * var_c;
                        LblResults.Text += var_b;
                        hello.Add(var_a + "*" + var_b);
                        var_a = var_b;
                    }
                    else if (char_d == '+')
                    {
                        var_b = var_a + var_c;
                        LblResults.Text += var_b;
                        hello.Add(var_a + "+" + var_b);
                        var_a = var_b;
                    }
                    else if (char_d == '-')
                    {
                        var_b = var_a - var_c;
                        LblResults.Text += var_b;

                        hello.Add(var_a + "-" + var_b);
                        var_a = var_b;
                    }
                    else
                    {
                        var_b = var_a + var_b;
                        LblResults.Text += var_b;
                        var_a = var_b;
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(results.ToString()))
                    {
                        LblResults.Text = "";
                        LblResults.Text += LblResults.Text;
                    }
                    else
                    {
                        LblResults.Text = "";
                        LblResults.Text += e_code;
                        var_a =  0;
                    }

                }
            }


        }



        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            LblResults.Text = "";
            hello.Append("Clear");
        }
    }
}