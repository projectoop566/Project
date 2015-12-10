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

        //fight card
        Card[] fighter = new Card[2];
        public int p1_numcard;
        public int p2_numcard;

        //Location card
        Point p1card1 = new Point(12,100);
        Point p1card2 = new Point(123, 100);
        Point p1card3 = new Point(234, 100);
        Point p1card4 = new Point(345, 100);
        Point p1card5 = new Point(456, 100);

        Point p2card1 = new Point(568, 100);
        Point p2card2 = new Point(679, 100);
        Point p2card3 = new Point(790, 100);
        Point p2card4 = new Point(901, 100);
        Point p2card5 = new Point(1012, 100);

        //skill   

        int skill_P1 = 0;
        int skill_P2 = 0;

        public Form1()
        {
            InitializeComponent();
            m = c.notifymodeltoview();
            battle_button.Hide();
            p1_Select.Hide();
            P2_Select.Hide();
            start.Hide();
            next_button.Hide();           
          
        }  
        //show pic of skill 
        public void showskill()
        {
            p1_skill1.Image = returnimgskill(m._player[0].myskill[0]);
            p1_skill2.Image = returnimgskill(m._player[0].myskill[1]);
            p1_skill3.Image = returnimgskill(m._player[0].myskill[2]);

            p2_skill1.Image = returnimgskill(m._player[1].myskill[0]);
            p2_skill2.Image = returnimgskill(m._player[1].myskill[1]);
            p2_skill3.Image = returnimgskill(m._player[1].myskill[2]);
        }
        public Image returnimgskill(int skillnum)
        {
            Image m = Image.FromFile(@"../../images/bgcard.png");
            switch (skillnum)
            {
                case 1:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 2:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 3:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 4:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 5:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 6:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 7:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 8:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 9:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
                case 10:
                    m = Image.FromFile(@"../../images/bgcard.png");
                    break;
            }
            return m;
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
            winscore1.Text = ""+m._player[0].Winscore;
            winscore2.Text = ""+m._player[1].Winscore;
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
        public void setskill(int i)
        {
            c.selectskill(i);
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Hide show button
            showc.Enabled = false;
            showc.Hide();
           
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
            showskill();
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
                battle_button.Show();
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
            if(skill_P1 != 0 || skill_P2 != 0)
            {
                
            }
            updatetextandpic();
            battlelv();

        }
        public void updatetextandpic()
        {
            p1_battlepic.Show();
            p2_battlepic.Show();
            

            p1_lvcard.Text = "LV Card : " + fighter[0].Level;
            p2_lvcard.Text = "LV Card : " + fighter[1].Level;
            p1_battlepic.Image = fighter[0].imagebattlecard;
            p2_battlepic.Image = fighter[1].imagebattlecard;
        }
        public void usedskill(int n,int player)
        {
            
                switch(n)
                {
                    case 1:
                        fighter[player].Level = fighter[player].Level * 2;
                    break;

                    case 2:
                    fighter[player].Level = fighter[player].Level * 2;
                    break;

                    case 3:
                    fighter[player].Level = fighter[player].Level * 2;
                    break;

            }
                                 
        }

        public void battlelv()
        {
            //Battle lv of card
            if (fighter[0].Level != fighter[1].Level)
            {
                if (fighter[0].Level > fighter[1].Level)
                {
                    m._player[0].win();
                    m._player[1].mydeck.decard(p2_numcard);
                    deletecard(2);
                    updatescore();
                }
                else
                {
                    m._player[1].win();
                    m._player[0].mydeck.decard(p1_numcard);
                    deletecard(1);
                    updatescore();
                }
            }
            else
            {

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
            battle_button.Hide();
            battlestart();
            next_button.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            checkp1_turn = true;
            checkp1_selectcard_battle = false;
            checkp2_selectcard_battle = false;
            p1_battlepic.Hide();
            p2_battlepic.Hide();
            next_button.Hide();
            updatecard();
            shufflecard();
            p1_lvcard.Text = "...";
            p2_lvcard.Text = "...";

            skill_P1 = skill_P2 = 0;

        }

        public void shufflecard()
        {
            Random rand = new Random();
            int ran = rand.Next(1, 10);
            switch (ran)
            {
                case 1:
                    p1_slot1.Location = p1card2;
                    p1_slot2.Location = p1card3;
                    p1_slot3.Location = p1card4;
                    p1_slot4.Location = p1card5;
                    p1_slot5.Location = p1card1;

                    p2_slot1.Location = p2card2;
                    p2_slot2.Location = p2card3;
                    p2_slot3.Location = p2card4;
                    p2_slot4.Location = p2card5;
                    p2_slot5.Location = p2card1;

                    break;
                case 2:
                    p1_slot1.Location = p1card3;
                    p1_slot2.Location = p1card4;
                    p1_slot3.Location = p1card5;
                    p1_slot4.Location = p1card1;
                    p1_slot5.Location = p1card2;

                    p2_slot1.Location = p2card3;
                    p2_slot2.Location = p2card4;
                    p2_slot3.Location = p2card5;
                    p2_slot4.Location = p2card1;
                    p2_slot5.Location = p2card2;
                    break;
                case 3:
                    p1_slot1.Location = p1card4;
                    p1_slot2.Location = p1card5;
                    p1_slot3.Location = p1card1;
                    p1_slot4.Location = p1card2;
                    p1_slot5.Location = p1card3;

                    p2_slot1.Location = p2card4;
                    p2_slot2.Location = p2card5;
                    p2_slot3.Location = p2card1;
                    p2_slot4.Location = p2card2;
                    p2_slot5.Location = p2card3;
                    break;
                case 4:
                    p1_slot1.Location = p1card5;
                    p1_slot2.Location = p1card1;
                    p1_slot3.Location = p1card2;
                    p1_slot4.Location = p1card3;
                    p1_slot5.Location = p1card4;

                    p2_slot1.Location = p2card5;
                    p2_slot2.Location = p2card1;
                    p2_slot3.Location = p2card2;
                    p2_slot4.Location = p2card3;
                    p2_slot5.Location = p2card4;
                    break;
                case 5:
                    p1_slot1.Location = p1card1;
                    p1_slot2.Location = p1card2;
                    p1_slot3.Location = p1card3;
                    p1_slot4.Location = p1card4;
                    p1_slot5.Location = p1card5;

                    p2_slot1.Location = p2card1;
                    p2_slot2.Location = p2card2;
                    p2_slot3.Location = p2card3;
                    p2_slot4.Location = p2card4;
                    p2_slot5.Location = p2card5;
                    break;
                case 6:
                    p1_slot1.Location = p1card5;
                    p1_slot2.Location = p1card1;
                    p1_slot3.Location = p1card2;
                    p1_slot4.Location = p1card3;
                    p1_slot5.Location = p1card4;

                    p2_slot1.Location = p2card2;
                    p2_slot2.Location = p2card3;
                    p2_slot3.Location = p2card4;
                    p2_slot4.Location = p2card5;
                    p2_slot5.Location = p2card1;
                    break;
                case 7:
                    p1_slot1.Location = p1card4;
                    p1_slot2.Location = p1card5;
                    p1_slot3.Location = p1card1;
                    p1_slot4.Location = p1card2;
                    p1_slot5.Location = p1card3;

                    p2_slot1.Location = p2card3;
                    p2_slot2.Location = p2card4;
                    p2_slot3.Location = p2card5;
                    p2_slot4.Location = p2card1;
                    p2_slot5.Location = p2card2;
                    break;
                case 8:
                    p1_slot1.Location = p1card3;
                    p1_slot2.Location = p1card4;
                    p1_slot3.Location = p1card5;
                    p1_slot4.Location = p1card1;
                    p1_slot5.Location = p1card2;

                    p2_slot1.Location = p2card4;
                    p2_slot2.Location = p2card5;
                    p2_slot3.Location = p2card1;
                    p2_slot4.Location = p2card2;
                    p2_slot5.Location = p2card3;
                    break;
                case 9:
                    p1_slot1.Location = p1card2;
                    p1_slot2.Location = p1card3;
                    p1_slot3.Location = p1card4;
                    p1_slot4.Location = p1card5;
                    p1_slot5.Location = p1card1;

                    p2_slot1.Location = p2card5;
                    p2_slot2.Location = p2card1;
                    p2_slot3.Location = p2card2;
                    p2_slot4.Location = p2card3;
                    p2_slot5.Location = p2card4;
                    break;
                case 10:
                    p1_slot1.Location = p1card5;
                    p1_slot2.Location = p1card1;
                    p1_slot3.Location = p1card3;
                    p1_slot4.Location = p1card4;
                    p1_slot5.Location = p1card2;

                    p2_slot1.Location = p2card1;
                    p2_slot2.Location = p2card3;
                    p2_slot3.Location = p2card2;
                    p2_slot4.Location = p2card4;
                    p2_slot5.Location = p2card5;
                    break;
            }

        }
    //check select skill 
        private void p1_skill1_Click(object sender, EventArgs e)
        {
            if(skill_P1==0)
            {
                p1_skill1.Hide();
                skill_P1 = m._player[0].myskill[0];
            }
           
        }

        private void p1_skill2_Click(object sender, EventArgs e)
        {
            if(skill_P1==0)
            {
                p1_skill2.Hide();
                skill_P1 = m._player[0].myskill[1];
            }
        }

        private void p1_skill3_Click(object sender, EventArgs e)
        {
            if (skill_P1 == 0)
            {
                p1_skill3.Hide();
                skill_P1 = m._player[0].myskill[2];
            }
        }

        private void p2_skill1_Click(object sender, EventArgs e)
        {
            if (skill_P2 == 0 && checkp1_turn==false)
            {
                p2_skill1.Hide();
                skill_P2 = m._player[0].myskill[0];
            }
        }

        private void p2_skill2_Click(object sender, EventArgs e)
        {
            if (skill_P2 == 0 && checkp1_turn == false)
            {
                p2_skill2.Hide();
                skill_P2 = m._player[0].myskill[1];
            }
        }

        private void p2_skill3_Click(object sender, EventArgs e)
        {
            if (skill_P2 == 0 && checkp1_turn == false)
            {
                p2_skill3.Hide();
                skill_P2 = m._player[0].myskill[2];
            }
        }
    }
}
