using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Card
    {
        private int _Level;// Level = value of attack
        private string _PictureID_card; //for picture
        
        public string PictureID_card
        {
            get { return _PictureID_card; }
            set { _PictureID_card = value; }
        }
        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }
        public Card()
        {
            _Level = 1;
            _PictureID_card = "human_lv1_1.png";
        }
        public Card(int l,string pid)
        {
            _Level = l;
            _PictureID_card = pid;
        }
    }
}
