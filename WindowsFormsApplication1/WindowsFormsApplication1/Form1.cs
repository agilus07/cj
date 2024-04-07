using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
       
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ginbilogRB_CheckedChanged(object sender, EventArgs e)
        {

        }
       
       
        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        
        private void fundador_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void emperadorcb_CheckedChanged(object sender, EventArgs e)
        {
            if (emperadorcb.Checked == true)
            {
                emperadortb.Enabled = true;
            }
            if (emperadorcb.Checked == false)
            {
                emperadortb.Enabled =false;
                emperadortb.Text = "0";
            }
        }

        private void alfonsocb_CheckedChanged(object sender, EventArgs e)
        {
            if (alfonsocb.Checked == true)
            {
                alfonsotxtbox.Enabled = true;
            }
            if (alfonsocb.Checked == false)
            {
                alfonsotxtbox.Enabled = false;
                alfonsotxtbox.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (fundadorcb.Checked == true)
            {
                fundadortb.Enabled = true;
            }
            if (fundadorcb.Checked == false)
            {
                fundadortb.Enabled = false;
                fundadortb.Text = "0";
            }
        }

        private void hennessycb_CheckedChanged(object sender, EventArgs e)
        {
            if (hennessycb.Checked == true)
            {
                hennessytb.Enabled = true;
            }
            if (hennessycb.Checked == false)
            {
                hennessytb.Enabled = false;
                hennessytb.Text = "0";
            }
        }

        private void cuervocb_CheckedChanged(object sender, EventArgs e)
        {
            if (cuervocb.Checked == true)
            {
                cuervotb.Enabled = true;
            }
            if (cuervocb.Checked == false)
            {
                cuervotb.Enabled = false;
                cuervotb.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (blacklabelcb.Checked == true)
            {
                blacklabeltb.Enabled = true;
            }
            if (blacklabelcb.Checked == false)
            {
                blacklabeltb.Enabled = false;
                blacklabeltb.Text = "0";
            }
        }

        private void bacardicb_CheckedChanged(object sender, EventArgs e)
        {
            if (bacardicb.Checked == true)
            {
                bacarditb.Enabled = true;
            }
            if (bacardicb.Checked == false)
            {
                bacarditb.Enabled = false;
                bacarditb.Text = "0";
            }
        }

        private void jdcb_CheckedChanged(object sender, EventArgs e)
        {
            if (jdcb.Checked == true)
            {
                jdtb.Enabled = true;
            }
            if (jdcb.Checked == false)
            {
                jdtb.Enabled = false;
                jdtb.Text = "0";
            }
        }

        private void banistercb_CheckedChanged(object sender, EventArgs e)
        {
            if (banistercb.Checked == true)
            {
                banistertb.Enabled = true;
            }
            if (banistercb.Checked == false)
            {
                banistertb.Enabled = false;
                banistertb.Text = "0";
            }
        }

        private void vodkacb_CheckedChanged(object sender, EventArgs e)
        {
            if (vodkacb.Checked == true)
            {
                vodkatb.Enabled = true;
            }
            if (vodkacb.Checked == false)
            {
                vodkatb.Enabled = false;
                vodkatb.Text = "0";
            }
        }

        private void buffalocb_CheckedChanged(object sender, EventArgs e)
        {
            if (buffalocb.Checked == true)
            {
                buffalotb.Enabled = true;
            }
            if (buffalocb.Checked == false)
            {
                buffalotb.Enabled = false;
                buffalotb.Text = "0";
            }
        }

        private void friescb_CheckedChanged(object sender, EventArgs e)
        {
            if (friescb.Checked == true)
            {
                friestb.Enabled = true;
            }
            if (friescb.Checked == false)
            {
                friestb.Enabled = false;
                friestb.Text = "0";
            }
        }

        private void nachoscb_CheckedChanged(object sender, EventArgs e)
        {
            if (nachoscb.Checked == true)
            {
                nachostb.Enabled = true;
            }
            if (nachoscb.Checked == false)
            {
                nachostb.Enabled = false;
                nachostb.Text = "0";
            }
        }

        private void hotdogcb_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdogcb.Checked == true)
            {
                hotdogtb.Enabled = true;
            }
            if (hotdogcb.Checked == false)
            {
                hotdogtb.Enabled = false;
                hotdogtb.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (sisigcb.Checked == true)
            {
                sisigtb.Enabled = true;
            }
            if (sisigcb.Checked == false)
            {
                sisigtb.Enabled = false;
                sisigtb.Text = "0";
            }
        }

        private void onioncb_CheckedChanged(object sender, EventArgs e)
        {
            if (onioncb.Checked == true)
            {
                oniontb.Enabled = true;
            }
            if (onioncb.Checked == false)
            {
                oniontb.Enabled = false;
                oniontb.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (oystercb.Checked == true)
            {
                oystertb.Enabled = true;
            }
            if (oystercb.Checked == false)
            {
                oystertb.Enabled = false;
                oystertb.Text = "0";
            }
        }

        private void crispycb_CheckedChanged(object sender, EventArgs e)
        {
            if (crispycb.Checked == true)
            {
                crispytb.Enabled = true;
            }
            if (crispycb.Checked == false)
            {
                crispytb.Enabled = false;
                crispytb.Text = "0";
            }
        }

        private void shrimpcb_CheckedChanged(object sender, EventArgs e)
        {
            if (shrimpcb.Checked == true)
            {
                shrimptb.Enabled = true;
            }
            if (shrimpcb.Checked == false)
            {
                shrimptb.Enabled = false;
                shrimptb.Text = "0";
            }
        }

        private void bicolcb_CheckedChanged(object sender, EventArgs e)
        {
            if (bicolcb.Checked == true)
            {
                bicoltb.Enabled = true;
            }
            if (bicolcb.Checked == false)
            {
                bicoltb.Enabled = false;
                bicoltb.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelb.Text = DateTime.Now.ToLongTimeString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timelb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

             datalb.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timelb.Text = DateTime.Now.ToLongDateString();
        }

        private void oniontxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oystertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shrimptxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {


        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {


        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void totalLB_Click(object sender, EventArgs e)
        {

        }

        private void taxlb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double empeup = 4, alfoup = 6, fundaup = 9, henneup = 14, cuervoup = 16, BLup = 11, bacardiup = 141, JDup = 70, Banisterup = 70, vodkaup = 19;
        double buffup = 9, friesup = 5, nachoesup = 3, hotdogup = 6, sisigup = 14, onionup = 7, oysterup = 18, pataup = 11, shrimpup = 31, bicolup = 6;
       
        double empetp, alfotp, fundatp, hennetp, cuervotp, BLtp, bacarditp, jdtp, banistertp, vodkatp, friestp, bufftp, nachoestp, hotdogtp, sisigtp, oniontp, oystertp, patatp, shrimptp, bicoltp;
        double subtotal = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            empeup = empetp * Convert.ToDouble(emperadortb.Text);
            alfoup = alfotp * Convert.ToDouble(alfonsotxtbox.Text);
            fundaup = fundatp * Convert.ToDouble(fundadortb.Text);
            henneup = hennetp * Convert.ToDouble(hennessytb.Text);
            cuervoup = cuervotp * Convert.ToDouble(cuervotb.Text);
            BLup = BLtp * Convert.ToDouble(blacklabeltb.Text);
            bacardiup = bacarditp * Convert.ToDouble(bacarditb.Text);
            JDup = jdtp * Convert.ToDouble(jdtb.Text);
            Banisterup = banistertp * Convert.ToDouble(banistertb.Text);
            vodkaup = vodkatp * Convert.ToDouble(vodkatb.Text);

            buffup = bufftp * Convert.ToDouble(buffalotb.Text);
            friesup = friestp * Convert.ToDouble(friestb.Text);
            nachoesup = nachoestp * Convert.ToDouble(nachostb.Text);
            hotdogup = hotdogtp * Convert.ToDouble(hotdogtb.Text);
            sisigup = sisigtp * Convert.ToDouble(sisigtb.Text);
            onionup = oniontp * Convert.ToDouble(oniontb.Text);
            oysterup = oystertp * Convert.ToDouble(oystertb.Text);
            pataup = patatp * Convert.ToDouble(crispytb.Text);
            shrimpup = shrimptp * Convert.ToDouble(shrimptb.Text);
            bicolup = bicoltp * Convert.ToDouble(bicoltb.Text);

            RecipTB.Clear();
            RecipTB.AppendText(Environment.NewLine);
            RecipTB.AppendText("\t\t==========MAMAMOBLUE=========="+Environment.NewLine);
            RecipTB.AppendText("\t\t\t=============================="+Environment.NewLine);
            }
            


         

         private void emperadortb_TextChanged()
         {

         }
       

        

         

       
        

        

       
    }
}

       