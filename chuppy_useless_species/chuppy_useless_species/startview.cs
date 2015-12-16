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
            opengame.Show();
            skillpic.Hide();      
               text_turn.Hide();
           
        }
        public void Notify()
        {
            if(c.playerselect==true)
            {
                updateclanp();          
            }                 
        }
        public void showturn()
        {
           if(c.allplayerselectedskill == false)
            {
                if (c.selectedskill_p1 == true)
                {
                    text_turn.Text = " Player 2 select skill";
                }
                else
                {
                    text_turn.Text = " Player 1 select skill ";
                }
            }
            else
            {
                text_turn.Text = "Let's PLAY";
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
            if (c.checkp1())
            {
                text_deck.Text = "Player 2 Select Deck";
            }
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover_c;
            pictureBox1.Hide();
            if (c.checkselectdeck())
            {
                text_deck.Hide();
                text_turn.Show();
            }
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
            if (c.checkp1())
            {
                text_deck.Text = "Player 2 Select Deck";
            }
            pictureBox8.Hide();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
            if (c.checkselectdeck())
            {
                text_deck.Hide();
                text_turn.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            c.selectclan(3);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(3);
            if (c.checkp1())
            {
                text_deck.Text = "Player 2 Select Deck";
            }
            pictureBox3.Hide();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
            if (c.checkselectdeck())
            {
                text_deck.Hide();
                text_turn.Show();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            c.selectclan(4);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(4);
            if (c.checkp1())
            {
                text_deck.Text = "Player 2 Select Deck";
            }
            pictureBox2.Hide();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
            if (c.checkselectdeck())
            {
                text_deck.Hide();
                text_turn.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            c.selectclan(5);
            m = c.notifymodeltoview();
            Notify();
            gameview.setclan(5);
            if(c.checkp1())
            {
                text_deck.Text = "Player 2 Select Deck";
            }

            pictureBox5.Hide();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
            if(c.checkselectdeck())
            {
                text_deck.Hide();
                text_turn.Show();
            }
            

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
        public void showpicturebox()
        {
            pictureBox1.Show();
            pictureBox8.Show();
            pictureBox3.Show();
            pictureBox2.Show();
            pictureBox5.Show();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            c.P1resetbutton();
            gameview.resettext(1);
            Notify();
            showpicturebox();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.P2resetbutton();
            gameview.resettext(2);
            Notify();
            showpicturebox();
            pictureBox1.Image = chuppy_useless_species.Properties.Resources.human_cover;
        }

        public void checkselectedallplayer()
        {
            if(c.allplayerselectedskill)
            {

                picbox_skill1.Hide();
                picbox_skill2.Hide();
                picbox_skill3.Hide();
                picbox_skill4.Hide();
                picbox_skill5.Hide();
                picbox_skill6.Hide();
                picbox_skill7.Hide();
                picbox_skill8.Hide();
                picbox_skill9.Hide();
                picbox_skill10.Hide();
            }
        }
        private void picbox_skill1_Click(object sender, EventArgs e)
        {
            int skillnum = 1;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill1.Hide();
            showturn();
        }

        private void picbox_skill2_Click(object sender, EventArgs e)
        {
            int skillnum = 2;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill2.Hide();
            showturn();
        }

        private void picbox_skill3_Click(object sender, EventArgs e)
        {
            int skillnum = 3;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill3.Hide();
            showturn();
        }

        private void picbox_skill4_Click(object sender, EventArgs e)
        {
            int skillnum = 4;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill4.Hide();
            showturn();
        }

        private void picbox_skill5_Click(object sender, EventArgs e)
        {
            int skillnum = 5;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill5.Hide();
            showturn();
        }

        private void picbox_skill6_Click(object sender, EventArgs e)
        {
            int skillnum = 6;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill6.Hide();
            showturn();
        }

        private void picbox_skill7_Click(object sender, EventArgs e)
        {
            int skillnum = 7;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill7.Hide();
            showturn();
        }

        private void picbox_skill8_Click(object sender, EventArgs e)
        {
            int skillnum = 8;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill8.Hide();
            showturn();
        }

        private void picbox_skill9_Click(object sender, EventArgs e)
        {
            int skillnum = 9;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill9.Hide();
            showturn();
        }

        private void picbox_skill10_Click(object sender, EventArgs e)
        {
            int skillnum = 10;
            gameview.setskill(skillnum);
            c.selectskill(skillnum);
            checkselectedallplayer();
            picbox_skill10.Hide();
            showturn();
        }

        private void text_turn_Click(object sender, EventArgs e)
        {

        }

        private void opengame_Click(object sender, EventArgs e)
        {
            opengame.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            skillpic.Show();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            skillpic.Hide();
        }

        private void opengame_Click_1(object sender, EventArgs e)
        {
            opengame.Hide();
        }

        private void opengame_Click_2(object sender, EventArgs e)
        {
            opengame.Hide();
        }
    }
}
