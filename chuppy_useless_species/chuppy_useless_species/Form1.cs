using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuppy_useless_species
{
    public partial class Form1 : Form
    {
        model m = new model();
        Gamecontroller c = new Gamecontroller();
        //image

        bool checkp1_turn = true;

        bool checkp1_selectcard_battle =false;
        bool checkp2_selectcard_battle = false;

        Card[] fighter = new Card[2];
        public int p1_numcard;
        public int p2_numcard;

        public Form1()
        {
            InitializeComponent();
            m = c.notifymodeltoview();
            Enter_turn.Hide();
            p1_Select.Hide();
            P2_Select.Hide();
            start.Hide();
        }  
        public void openview()
        {
           
        }
        //output view      
        public void updatecard()
        {

            if(checkp1_turn==true)
            {
                playerturn.Text = "Player 1";
                                    

            }
            else if (checkp1_turn == false )
            {
                playerturn.Text = "Player 2";
            }
        } 
        public void showcard()
        {           
            p1_slot1.Image = m._player[0].mydeck.Card[0].imagecard;
            p1_slot2.Image = m._player[0].mydeck.Card[1].imagecard;
            p1_slot3.Image = m._player[0].mydeck.Card[2].imagecard;
            p1_slot4.Image = m._player[0].mydeck.Card[3].imagecard;
            p1_slot5.Image = m._player[0].mydeck.Card[4].imagecard;

            p2_slot1.Image = m._player[1].mydeck.Card[0].imagecard;
            p2_slot2.Image = m._player[1].mydeck.Card[1].imagecard;
            p2_slot3.Image = m._player[1].mydeck.Card[2].imagecard;
            p2_slot4.Image = m._player[1].mydeck.Card[3].imagecard;
            p2_slot5.Image = m._player[1].mydeck.Card[4].imagecard;                         
        }
        public void backcard()
        {
            p1_slot1.Image = m._player[0].mydeck.Card[0].backcard;
            p1_slot2.Image = m._player[0].mydeck.Card[1].backcard;
            p1_slot3.Image = m._player[0].mydeck.Card[2].backcard;
            p1_slot4.Image = m._player[0].mydeck.Card[3].backcard;
            p1_slot5.Image = m._player[0].mydeck.Card[4].backcard;

            p2_slot1.Image = m._player[1].mydeck.Card[0].backcard;
            p2_slot2.Image = m._player[1].mydeck.Card[1].backcard;
            p2_slot3.Image = m._player[1].mydeck.Card[2].backcard;
            p2_slot4.Image = m._player[1].mydeck.Card[3].backcard;
            p2_slot5.Image = m._player[1].mydeck.Card[4].backcard;
        }
        public void updatescore()
        {

        }
        public void updateskill()
        {

        }
        public void fightwindow()
        {

        }
        public void nameclan()
        {
            player1clan.Text = m.getclan(0);
            player2clan.Text = m.getclan(1);
        }
        public void clanpic()
        {
           
          
        }
        public void notify()
        {
      
        }


        //input view
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fighter[0] = m._player[0].mydeck.Card[1];
            checkp1_selectcard_battle = true;
            p1_numcard = 2;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void p1_slot1_Click(object sender, EventArgs e)
        {
            fighter[0] = m._player[0].mydeck.Card[0];
            checkp1_selectcard_battle = true;
            p1_numcard = 1;
        }

        private void p1_slot3_Click(object sender, EventArgs e)
        {
            fighter[0] = m._player[0].mydeck.Card[2];
            checkp1_selectcard_battle = true;
            p1_numcard = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
       
        }

        private void player2clan_Click(object sender, EventArgs e)
        {

        }
        // selest view
        public void setclan(int x)
        {
            c.selectclan(x);
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Hide show button
            showc.Enabled = false;
            showc.Hide();
            Enter_turn.Show();
            p1_Select.Show();
            P2_Select.Show();
            start.Hide();
                    
            c.randomcard();
            backcard();
            updatecard();

        }
        public void resettext(int x)
        {
            if(x==1)
            {
                c.P1resetbutton();
            }
            else if(x==2)
            {
                c.P2resetbutton();
            }
        }

        private void p1_slot4_Click(object sender, EventArgs e)
        {
            fighter[0] = m._player[0].mydeck.Card[3];
            checkp1_selectcard_battle = true;
            p1_numcard = 4;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
                            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.Show(); 
            nameclan();
            showcard();
            showc.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void p2_slot1_Click(object sender, EventArgs e)
        {
           fighter[1] = m._player[1].mydeck.Card[0];
            checkp2_selectcard_battle = true;
            p2_numcard = 1;
        }

        private void p1_Select_Click(object sender, EventArgs e)
        {
            if(checkp1_selectcard_battle == true)
            {
                checkp1_turn = false;
                updatecard();
            }
        }

        private void P2_Select_Click(object sender, EventArgs e)
        {
            if (checkp2_selectcard_battle == true)
            {
                //runbattle
                battlestart();
            }
        }
        public void deletecard(int player)
        {
            if(player == 1)
            {
                switch (p1_numcard)
                {
                    case 1:
                        p1_slot1.Hide();
                        break;
                    case 2:
                        p1_slot2.Hide();
                        break;
                    case 3:
                        p1_slot3.Hide();
                        break;
                    case 4:
                        p1_slot4.Hide();
                        break;
                    case 5:
                        p1_slot5.Hide();
                        break;
                }
            }
           else
            {
                switch (p2_numcard)
                {
                    case 1:
                        p2_slot1.Hide();
                        break;
                    case 2:
                        p2_slot2.Hide();
                        break;
                    case 3:
                        p2_slot3.Hide();
                        break;
                    case 4:
                        p2_slot4.Hide();
                        break;
                    case 5:
                        p2_slot5.Hide();
                        break;
                }
            }
            
        }
        private void battlestart()
        {          
            p1_battlepic.Visible = true;
            p2_battlepic.Visible = true;
            p1_lvcard.Text = "LV Card : " + fighter[0].Level;
            p2_lvcard.Text = "LV Card : " + fighter[1].Level;
            //p1_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;
            //p2_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;
            p1_battlepic.Image = fighter[0].imagebattlecard;
            p2_battlepic.Image = fighter[1].imagebattlecard;
            
            //Battle lv of card
            if(fighter[0].Level!=fighter[1].Level)
            {
                if(fighter[0].Level>fighter[1].Level)
                {
                    m._player[0].Winscore += 1;
                    m._player[1].mydeck.decard(fighter[1].Numcard);
                    deletecard(2);
                }
                else if (fighter[1].Level > fighter[0].Level)
                {
                    m._player[1].Winscore += 1;
                    m._player[0].mydeck.decard(fighter[0].Numcard);
                    deletecard(1);
                }
            }  

        }

        private void p1_battlepic_Click(object sender, EventArgs e)
        {

        }

        private void p1_screen_Click(object sender, EventArgs e)
        {

        }

        private void clan_trun_Click(object sender, EventArgs e)
        {

        }

        private void p1_slot5_Click(object sender, EventArgs e)
        {
            fighter[0] = m._player[0].mydeck.Card[4];
            checkp1_selectcard_battle = true;
            p1_numcard = 5;
        }

        private void p2_slot2_Click(object sender, EventArgs e)
        {
            fighter[1] = m._player[1].mydeck.Card[1];
            checkp2_selectcard_battle = true;
            p2_numcard = 2;
        }

        private void p2_slot3_Click(object sender, EventArgs e)
        {
            fighter[1] = m._player[1].mydeck.Card[2];
            checkp2_selectcard_battle = true;
            p2_numcard = 3;
        }

        private void p2_slot4_Click(object sender, EventArgs e)
        {
            fighter[1] = m._player[1].mydeck.Card[3];
            checkp2_selectcard_battle = true;
            p2_numcard = 4;
        }

        private void p2_slot5_Click(object sender, EventArgs e)
        {
            fighter[1] = m._player[1].mydeck.Card[4];
            checkp2_selectcard_battle = true;
            p2_numcard = 5;
        }

        private void Enter_turn_Click(object sender, EventArgs e)
        {

        }
    }
}
