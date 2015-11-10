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
        private string _PictureID; //for picture
        
        public string PictureID
        {
            get { return _PictureID; }
            set { _PictureID = value; }
        }
        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }
        public Card()
        {
            _Level = 1;
            _PictureID = "human_lv1_1.png";
        }
        public Card(int l,string pid)
        {
            _Level = l;
            _PictureID = pid;
        }
    }
}
