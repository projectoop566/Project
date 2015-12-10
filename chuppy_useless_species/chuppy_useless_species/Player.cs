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
        private int _Winscore;
        private int _Lossscore;
        public  int[] myskill  = new int[3];
        
        public Deck mydeck = new Deck();
       
       
               
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Winscore
        {
            get { return _Winscore; }
            set { }
        }
        public int Lossscore
        {
            get { return _Lossscore; }
            set { }
        } 
        public Player()
        {
            _Winscore = _Lossscore = 0;
            myskill[0] = 0;
            myskill[1] = 0;
            myskill[2] = 0;
        }
        public void setname(string name) //setplayer name
        {
            _Name = name;
        }
        public void creatdeck(int c)
        {
            mydeck = new Deck(c);
            
        }
        public void win()
        {
            _Winscore = _Winscore + 1;
        }
        
    }
}
