using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int yAxis;
        private int xAxis;
        private int names;
        private ComboBox cmb;
        private int test = 0;
        public Form1()
        {
            InitializeComponent();
            yAxis = groupBox1.Location.Y;
            xAxis = groupBox1.Location.X;
            names = 1;
            label2.Text = ""+test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "action" + names;
            GroupBox grp = new GroupBox();
            grp.Name = name;
            grp.Location = new Point(xAxis, yAxis+100);
            this.Controls.Add(grp);
            cmb = new ComboBox();
            cmb.Items.Add("TestAction");
            cmb.Items.Add("TestAction2");
            grp.Controls.Add(cmb);
            xAxis = grp.Location.X;
            yAxis = grp.Location.Y;
            names++;
        }
        private void TestAction()
        {
            test++;
        }
        private void TestAction2()
        {
            test = test+ 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                if(gb.Name.Contains("condition"))
                {
                    MessageBox.Show("condition zit erin");
                }
                else
                {
                    foreach (ComboBox cb in gb.Controls.OfType<ComboBox>())
                    {
                        List<ComboBox> cbs = new List<ComboBox>();
                        cbs.Add(cb);
                        for (int i = 1; i < cbs.Count; i++)
                        {
                            if (cbs[i].Name.Contains("" + i))
                            {
                                switch (Convert.ToString(cb.SelectedItem))
                                {
                                    case "TestAction":
                                        TestAction();
                                        label2.Text = "" + test;
                                        break;
                                    case "TestAction2":
                                        TestAction2();
                                        label2.Text = "" + test;
                                        break;
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "condition" + names;
            GroupBox grp = new GroupBox();
            grp.Name = name;
            grp.Location = new Point(xAxis, yAxis + 100);
            this.Controls.Add(grp);
            TextBox txt = new TextBox();
            txt.Location = new Point(50, 20);
            TextBox txt1 = new TextBox();
            txt1.Location = new Point(50, 70);
            grp.Controls.Add(txt);
            grp.Controls.Add(txt1);
            xAxis = grp.Location.X;
            yAxis = grp.Location.Y;
            names++;
        }
        private String sendSMS()
        {
            return "";
        }
        private Boolean check(string value1,string value2)
        {
            if (value1.Equals(value2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
