using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arma_3_Cam_to_Texture_creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string vision;
            

            if (radioButton1.Checked)
            {
                vision = "0";
            }
            else if(radioButton2.Checked)
            {
                vision = "1";
            }
            else{
                vision = "2";
            }

            string outcode = textBox1.Text + " = 'camera' camCreate[0, 0, 0];\n" + textBox1.Text + " cameraEffect['Internal', 'Back', '" + textBox3.Text + "'];\n" + textBox1.Text + " attachTo[" + textBox2.Text + ", [0,0,0], 'PiP0_pos'];\n '" + textBox3.Text + "' setPiPEffect[" + vision + "];\n addMissionEventHandler['Draw3D', {\n_dir = \n (" + textBox2.Text + " selectionPosition 'PiP0_pos') \n vectorFromTo(" + textBox2.Text + " selectionPosition 'PiP0_dir');\n " + textBox1.Text + " setVectorDirAndUp[\n _dir,\n _dir vectorCrossProduct[-(_dir select 1), _dir select 0, 0]\n];\n}];";
            CodeOutput.Text = outcode;
            string outtex = "#(argb,512,512,1)r2t(" + textBox3.Text + ",1)";
            textBox4.Text = outtex;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + numericUpDown1.Text;
            textBox2.Text = textBox2.Text + numericUpDown1.Text;
            textBox3.Text = textBox3.Text + numericUpDown1.Text;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void CodeOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
