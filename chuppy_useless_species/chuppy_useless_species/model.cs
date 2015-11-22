using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class model
    {
                
//property
        public Player[] _player = new Player[2];
        private Skill[] _skill = new Skill[3];



        //update to view
        public void NotifyAll()
        {
           
        }
        //method
        public model()
        {

        }
        public void P1selectclan(int c)
        {
            _player[0] = new Player();
            _player[0].creatdeck(c);          
        }
        public void P2selectclan(int c)
        {
            _player[1] = new Player();
            _player[1].creatdeck(c);          
        }
        public void resetselect()
        {

        }
        public void start()
        {

        }

        public string getclan(int x)
        {
            return _player[x].mydeck.Clan;
        }
    }
}
