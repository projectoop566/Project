using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Gamecontroller
    {
        model m = new model();

        private bool checkselectP1 = false;
        private bool checkselectP2 = false;

        public bool player1select = false;
        public bool playerselect = false;
        //start view

        public bool checkstart()
        {
            if (checkselectP1 & checkselectP2)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public void selectclan(int c)
        {
            if (checkselectP1 == false)
            {
                m.P1selectclan(c);
                checkselectP1 = true;
                playerselect = true;
                player1select = true;
            }
            else if (checkselectP2 == false)
            {
                m.P2selectclan(c);
                checkselectP2 = true;
                player1select = false;
                playerselect = true;
            }

        }
        public void startbutton()
        {

        }
        public void P1resetbutton()
        {
            if (checkselectP1 == true)
            {
                m.P1selectclan(0);
                checkselectP1 = false;
                playerselect = true;
                player1select = true;
              
            }
          
        }
        public void P2resetbutton()
        {         
            if (checkselectP2 == true)
            {
                m.P2selectclan(0);
                checkselectP2 = false;
                player1select = false;
                playerselect = true;
            }
        }

        public model notifymodeltoview()
        {
            return m;
        }

        //form view
        public void randomcard()
        {
            m._player[0].mydeck.shuffle();
            m._player[1].mydeck.shuffle();
        }
        public void select()
        {
        
        }
        public void reselect()
        {

        }
        public void skill()
        {

        }
        public void startfight()
        {

        }      

    }
}
