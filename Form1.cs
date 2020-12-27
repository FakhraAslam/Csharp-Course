using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture4._1
{
    //text :------------user 
    //name :-----------------backend
    public partial class Form1 : Form
    {
        String gender;
        String type;
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text.ToString();
            String fatherName = txt_father_name.Text.ToString();
            MessageBox.Show("you entered" + name+"\n" + " your father name is" + fatherName);
            txt_name.Text = " ";
            txt_father_name.Text = " ";
            if (radioButton1.Checked)
            {
                //  gender = "Male";
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = "female";
            }
            else
            {
                gender = "other";
            }


            if (checkBox1.Checked)
            {
                //type = "vegetrian";
                type = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                type = checkBox2.Text;
            }
            //  MessageBox.Show("Name: " + name+"\n"+"Father Name: " + fatherName+"\n"+" Gender: " + gender+"\n" + "\n" + " type: " + type);

            listView1.Items.Add(name);   
            listView1.Items.Add(fatherName);  
            listView1.Items.Add(gender); 
            listView1.Items.Add(type);

        }
    }
}
