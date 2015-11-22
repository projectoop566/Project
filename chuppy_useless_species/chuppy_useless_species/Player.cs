using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Player
    {
        
        private string _Name;
        private string _Winscore;
        private string _Lossscore;
        public Deck mydeck = new Deck();
              
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Winscore
        {
            get { return _Winscore; }
            set { }
        }
        public string Lossscore
        {
            get { return _Lossscore; }
            set { }
        } 
        public Player()
        {
            _Winscore = _Lossscore = "0";
        }
        public void setname(string name) //setplayer name
        {
            _Name = name;
        }
        public void creatdeck(int c)
        {
            mydeck = new Deck(c);
            
        }

        
    }
}
