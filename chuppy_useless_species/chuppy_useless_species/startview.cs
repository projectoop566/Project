using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuppy_useless_species
{
    public partial class startview : Form 
    {
        private model m = new model();
        private Gamecontroller c = new Gamecontroller();
        Form1 gameview = new Form1(); 
        public startview()
        {
            InitializeComponent();          
        }
        public void Notify()
        {
            if(c.playerselect==true)
            {
                updateclanp();
            }                 
        }
        

        public void updateclanp()
        {
            if (c.player1select == true)
            { nameclanP1.Text = m.getclan(0); }
            else
            { nameclanP2.Text = m._player[1].mydeck.Clan; }
        }      
      
        private void startview_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            c.selectclan(1);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(1);
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover_c;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            c.selectclan(2);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(2);

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            c.selectclan(3);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(3);

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            c.selectclan(4);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(4);

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            c.selectclan(5);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(5);

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void confirmselect_Click(object sender, EventArgs e)
        {
            if(c.checkstart())
            {
                gameview.Visible = true;
                gameview.Enabled = true;
                this.Visible = false;
                this.Enabled = false;                                      
            }         
        }

        private void reset_Click(object sender, EventArgs e)
        {
            c.P1resetbutton();
            gameview.resettext(1);
            Notify();

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.P2resetbutton();
            gameview.resettext(2);
            Notify();

            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }
      
    }
}
