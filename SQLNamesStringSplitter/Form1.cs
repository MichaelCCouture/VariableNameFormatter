using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLNamesStringSplitter
{
    public partial class Form1 : Form
    {
        string originalInput;
        bool capitalizeFirstLetter;
        bool atSignAtFront;
        bool commaSeparated;
        bool underscoresBetweenWords;
        bool updateFormat;
        bool DALGetFormat;
        bool DALUpdateFormat;
        bool divTagFormat;
        bool setTextboxFormat;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            originalInput = txtInput.Text;

            capitalizeFirstLetter = chkCapitalize.Checked;
            atSignAtFront = chkAtSign.Checked;
            commaSeparated = chkCommaSeparated.Checked;
            underscoresBetweenWords = chkUnderscores.Checked;
            updateFormat = chkUpdateFormat.Checked;
            DALUpdateFormat = chkSprocGetFormat.Checked;
            DALGetFormat = chkSprocUpdateFormat.Checked;
            divTagFormat = chkDivTagFormat.Checked;
            setTextboxFormat = chkSetTextboxFormat.Checked;

            if (updateFormat)
            {
                PrintUpdateFormat();
                return;
            }

            if (DALGetFormat)
            {
                PrintDALGetFormat();
                return;
            }

            if (DALUpdateFormat)
            {
                PrintDALUpdateFormat();
                return;
            }

            if (divTagFormat)
            {
                DivPrintFormat();
                return;
            }

            if(setTextboxFormat)
            {
                SetTextBoxFormat();
                return;
            }


            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] input = textInput.Split(new char[] { ' ', ','});

            input = input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (capitalizeFirstLetter)
                {
                    input[i] = input[i].First().ToString().ToUpper() + String.Join("", input[i].Skip(1));                   
                }
                else
                {
                    input[i] = input[i].First().ToString().ToLower() + String.Join("", input[i].Skip(1));             
                }

                if (atSignAtFront)
                {
                    if (input[i].First().ToString() != "@")
                    {
                        input[i] = "@" + input[i];
                    }
                }
                else
                {
                    if (input[i][0].ToString() == "@")
                    {
                        input[i] = String.Join("", input[i].Skip(1));
                    }
                }

                if (underscoresBetweenWords)
                {
                    for (int j = 1; j < input[i].Length; j++)
                    {
                        if (char.IsUpper(input[i][j]) && (!char.IsUpper(input[i][j - 1]) || !char.IsUpper(input[i][j + 1])))
                        {
                            input[i] = String.Join("_", input[i].Substring(0, j), input[i].Substring(j));
                            j++;
                        }
                    }
                    input[i] = input[i].ToLower();
                }
                else
                {
                    //is_plo_elgible
                    for (int j = 1; j < input[i].Length; j++)
                    {
                        if (input[i][j].ToString() == "_")
                        {
                            input[i] = String.Join("", input[i].Substring(0, j), input[i].Substring(j+1, 1).ToUpper(), input[i].Substring(j+2));
                            j++;
                        }
                    }
                }
            }

            txtInput.Clear();

            for (int i = 0; i < input.Length; i++)
            {
                if(commaSeparated)
                {
                    if (i+1 == input.Length)
                    {
                        txtInput.Text += input[i];
                    }
                    else
                    {
                        txtInput.Text += input[i] + ", \n";
                    }                    
                }
                else
                {
                    if (i+1 == input.Length)
                    {
                        txtInput.Text += input[i];
                        //txtInput.Text += "public [v] "+ input[i] + " { get; set; }";
                    }
                    else
                    {
                        txtInput.Text += input[i] + "\n";
                        //txtInput.Text += "public [v] " + input[i] + " { get; set; }" + "\n";
                    }                    
                }
            }
        }

        public void PrintUpdateFormat()
        {
            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] leftHalfInput = textInput.Split(new char[] { ' ', ',' });
            string[] rightHalfInput = textInput.Split(new char[] { ' ', ',' }); ;

            leftHalfInput = leftHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            rightHalfInput = rightHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            txtInput.Clear();

            for (int i = 0; i < leftHalfInput.Length; i++)
            {
                leftHalfInput[i] = leftHalfInput[i].First().ToString().ToLower() + String.Join("", leftHalfInput[i].Skip(1));

                rightHalfInput[i] = rightHalfInput[i].First().ToString().ToUpper() + String.Join("", rightHalfInput[i].Skip(1));

                //isPLOElgible

                for (int j = 1; j < leftHalfInput[i].Length; j++)
                {
                    if (char.IsUpper(leftHalfInput[i][j]) && (!char.IsUpper(leftHalfInput[i][j-1]) || !char.IsUpper(leftHalfInput[i][j+1])))
                    {
                        leftHalfInput[i] = String.Join("_", leftHalfInput[i].Substring(0, j), leftHalfInput[i].Substring(j));
                        j++;
                    }
                }
                leftHalfInput[i] = leftHalfInput[i].ToLower();


                if (rightHalfInput[i].First().ToString() != "@")
                {
                    rightHalfInput[i] = "@" + rightHalfInput[i];
                }

                if (i + 1 == rightHalfInput.Length)
                {
                    txtInput.Text += leftHalfInput[i] + " = " + rightHalfInput[i];
                }
                else
                {
                    txtInput.Text += leftHalfInput[i] + " = " + rightHalfInput[i] + ", \n";
                }    
            }
        }

        public void PrintDALGetFormat()
        {
            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] rightHalfInput = textInput.Split(new char[] { ' ', ',' });
            string[] leftHalfInput = textInput.Split(new char[] { ' ', ',' }); ;

            rightHalfInput = rightHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            leftHalfInput = leftHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            txtInput.Clear();

            for (int i = 0; i < rightHalfInput.Length; i++)
            {
                rightHalfInput[i] = rightHalfInput[i].First().ToString().ToLower() + String.Join("", rightHalfInput[i].Skip(1));

                leftHalfInput[i] = leftHalfInput[i].First().ToString().ToUpper() + String.Join("", leftHalfInput[i].Skip(1));

                //isPLOElgible

                if (leftHalfInput[i].First().ToString() != "@")
                {
                    leftHalfInput[i] = "@" + leftHalfInput[i];
                }

                txtInput.Text +=  "cmd.Parameters.AddWithValue(" + '"' + leftHalfInput[i] + '"' +", " + rightHalfInput[i] +"); \n";                
            }
        }

        public void PrintDALUpdateFormat()
        {
            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] rightHalfInput = textInput.Split(new char[] { ' ', ',' });
            string[] leftHalfInput = textInput.Split(new char[] { ' ', ',' }); ;

            rightHalfInput = rightHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            leftHalfInput = leftHalfInput.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            txtInput.Clear();

            for (int i = 0; i < rightHalfInput.Length; i++)
            {
                rightHalfInput[i] = rightHalfInput[i].First().ToString().ToLower() + String.Join("", rightHalfInput[i].Skip(1));

                leftHalfInput[i] = leftHalfInput[i].First().ToString().ToUpper() + String.Join("", leftHalfInput[i].Skip(1));

                //isPLOElgible

                for (int j = 1; j < rightHalfInput[i].Length; j++)
                {
                    if (char.IsUpper(rightHalfInput[i][j]) && (!char.IsUpper(rightHalfInput[i][j - 1]) || !char.IsUpper(rightHalfInput[i][j + 1])))
                    {
                        rightHalfInput[i] = String.Join("_", rightHalfInput[i].Substring(0, j), rightHalfInput[i].Substring(j));
                        j++;
                    }
                }
                rightHalfInput[i] = rightHalfInput[i].ToLower();

                txtInput.Text += "pageData." + leftHalfInput[i] + " = reader[" + '"' + rightHalfInput[i] + '"' + "].ToString(); \n"; 
            }
        }

        public void DivPrintFormat()
        {
            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] input = textInput.Split(new char[] { ' ', ',' });

            input = input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            txtInput.Text = "";

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].First().ToString().ToUpper() + String.Join("", input[i].Skip(1));

                //<div class="prettyForm-line">
                //    <asp:Label ID="lblProvProgStandardsDate" runat="server" Text="Standard/Description Date" AssociatedControlID="txtProvProgStandardsDate"></asp:Label>
                //    <asp:TextBox ID="txtProvProgStandardsDate" runat="server" CssClass="datePicker" aria-describedby="txtProvProgStandardsDateHint"></asp:TextBox>
                //    <span id="txtProvProgStandardsDateHint" class="form-hint">Date of program standard or description.</span>
                //</div>

                txtInput.Text += "<div class=\"prettyForm-line\"> \n";
                txtInput.Text += "<asp:Label ID=\"lbl" + input[i] + "\" runat=\"server\" Text=\"Standard/Description Date\" AssociatedControlID=\"txt" + input[i] + "\"></asp:Label> \n";
                txtInput.Text += "<asp:TextBox ID=\"txt" + input[i] + "\" runat=\"server\" CssClass=\"datePicker\" aria-describedby=\"txt" + input[i]+ "Hint\"></asp:TextBox> \n";
                txtInput.Text += "<span id=\"txt" + input[i] + "Hint\" class=\"form-hint\">Date of program standard or description.</span> \n";
                txtInput.Text += "</div> \n\n";
                
                //txtInput.Text += "<tr> \n<td> \n";
                //txtInput.Text += "<asp:Label ID=\"lblPrevious" + input[i] + "\" runat=\"server\" Text=\"" + input[i] + "\" AssociatedControlID=\"txtPrevious" + input[i] + "\"></asp:Label> \n";
                //txtInput.Text += "<asp:TextBox ID=\"txtPrevious" + input[i] + "\" runat=\"server\" CssClass=\"editor editor--wide\" TextMode=\"MultiLine\"></asp:TextBox> \n";
                //txtInput.Text += "</td> \n";


                //txtInput.Text += "<td> \n" ;
                //txtInput.Text += "<asp:Label ID=\"lbl" + input[i] + "\" runat=\"server\" Text=\"" + input[i] + "\" AssociatedControlID=\"txt" + input[i] + "\"></asp:Label> \n";
                //txtInput.Text += "<asp:TextBox ID=\"txt" + input[i] + "\" runat=\"server\" CssClass=\"editor editor--wide\" TextMode=\"MultiLine\"></asp:TextBox> \n";
                //txtInput.Text += "</td> \n</tr> \n";
            }

        }

        public void SetTextBoxFormat()
        {
            string textInput = Regex.Replace(txtInput.Text, @"\r\n?|\n", ",");

            string[] input = textInput.Split(new char[] { ' ', ',' });

            input = input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            txtInput.Text = "";

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].First().ToString().ToUpper() + String.Join("", input[i].Skip(1));

                //txtConnectionToPloDate.Text = checklist.ConnectionToPloDate == null ? "" : ((DateTime)checklist.ConnectionToPloDate).ToString("yyyy/MM/dd"); 
                //txtProvProgStandardsDate.Text = template.StandardsDate == null ? "" : ((DateTime)template.StandardsDate).ToString("yyyy/MM/dd");
                txtInput.Text += "txt" + input[i] + ".Text = checklist." + input[i] + " == null ? \"\" : ((DateTime)checklist." + input[i] + ").ToString(\"yyyy/MM/dd\"); \n";

                //txtInput.Text += "string " + input[i].ToLower() + " = txt" + input[i] + ".Text; \n";

                //txtInput.Text += "DateTime? " + input[i] + " = !string.IsNullOrWhiteSpace(txt" + input[i] + ".Text) ? DateTime.Parse(txt" + input[i] + ".Text) : (DateTime?) null; \n";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                btnSubmit.PerformClick();
            }
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            if (originalInput != null)
            {
                txtInput.Text = originalInput;
            }
        }
    }
}
