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

        public Form1()
        {
            InitializeComponent();
            m = c.notifymodeltoview();        
        }  
        public void openview()
        {
           
        }
        //output view      
        public void updatecard()
        {

            if(checkp1_turn==true)
            {

                p1_screen.Visible = false;
                p2_screen.Visible = true;
                p2_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;                         

            }
            else if (checkp1_turn == false )
            {
                p2_screen.Visible = false;
                p1_screen.Visible = true;
                p1_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;                                            
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

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void p1_slot1_Click(object sender, EventArgs e)
        {

                fighter[0] = m._player[0].mydeck.drawcard();
            checkp1_selectcard_battle = true;
        }

        private void p1_slot3_Click(object sender, EventArgs e)
        {

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

        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
                            
        }

        private void button2_Click(object sender, EventArgs e)
        {              
            nameclan();
            showcard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void p2_slot1_Click(object sender, EventArgs e)
        {
  
           fighter[1] = m._player[1].mydeck.drawcard();
            checkp2_selectcard_battle = true;
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

        private void battlestart()
        {
            p1_screen.Visible = true;
            p2_screen.Visible = true;

            p1_battlepic.Visible = true;
            p2_battlepic.Visible = true;

            p1_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;
            p2_screen.Image = chuppy_useless_species.Properties.Resources.bg_select;

            p1_battlepic.Image = fighter[0].imagebattlecard;
            p2_battlepic.Image = fighter[1].imagebattlecard;
        }
    }
}
