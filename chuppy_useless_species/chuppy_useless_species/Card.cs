using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Card
    {
        private int _Level;// Level = value of attack
        private int _numcard;
        private string _PictureID_card; //for picture
        public Image backcard = Image.FromFile(@"../../images/bgcard.png");
        public Image imagecard;
        public Image imagebattlecard;

        public int Numcard
        {
            get { return _numcard; }
            set { }
        }
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
            _Level = 0;
            imagecard = Image.FromFile(@"../../images/card/human/human1.png");
        }
        public Card(int n,int l,Image pid,Image pid_ani)
        {
            _numcard = n;
            _Level = l;
            imagecard = pid;
            imagebattlecard = pid_ani;
        }
    }
}
