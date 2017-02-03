using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePractice
{
    public partial class Form1 : Form, ITestInterface
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        //public void Update()
        //{

        //}

        public void ToRed()
        {
           
        }

        public void ToYellow()
        {
            
        }

        public void ToGreen()
        {
           
        }

        public void ToEnd()
        {
           
        }


        public int LightChanage()
        {
            bool RedOn = false;
            bool YellowOn = false;
            bool GreenOn = false;

            if (RedOn == false && YellowOn == false && GreenOn == false)
            {
                RedOn = true;
            }

            




            return 0;
        }



    }
}
