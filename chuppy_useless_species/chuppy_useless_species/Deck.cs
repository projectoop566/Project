using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Deck
    {
        private string _Clan;
        private Card[ ] _card = new Card[5];
        public string Clan
        {
            get { return _Clan; }
            set { _Clan = value; }
        }
        public Card[] Card
        {
            get { return _card; }
            set { _card = value; }
        }

        public Deck()
        {
            //defalut           
            _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/human/human1.png"), Image.FromFile(@"../../images/card/human/human_1_g.gif"));
            _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/human/human2.png"), Image.FromFile(@"../../images/card/human/human_2_g.gif"));
            _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/human/human3.png"), Image.FromFile(@"../../images/card/human/human_3_g.gif"));
            _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/human/human4.png"), Image.FromFile(@"../../images/card/human/human_4_g.gif"));
            _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/human/human5.png"), Image.FromFile(@"../../images/card/human/human_5_g.gif"));

        }
        public Deck(int i) // 1=human 2=animal 3=orge 4=undead 5=spirit
        {
            if(i == 1)
            {
                _Clan = "Human";
                _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/human/human1.png"), Image.FromFile(@"../../images/card/human/human_1_g.gif"));
                _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/human/human2.png"), Image.FromFile(@"../../images/card/human/human_2_g.gif"));
                _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/human/human3.png"), Image.FromFile(@"../../images/card/human/human_3_g.gif"));
                _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/human/human4.png"), Image.FromFile(@"../../images/card/human/human_4_g.gif"));
                _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/human/human5.png"), Image.FromFile(@"../../images/card/human/human_5_g.gif"));
            }
            else if(i == 2)
            {
                _Clan = "Insect";
                _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/insect/insect1.png"), Image.FromFile(@"../../images/card/insect/insect_1_g.gif"));
                _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/insect/insect2.png"), Image.FromFile(@"../../images/card/insect/insect_2_g.gif"));
                _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/insect/insect3.png"), Image.FromFile(@"../../images/card/insect/insect_3_g.gif"));
                _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/insect/insect4.png"), Image.FromFile(@"../../images/card/insect/insect_4_g.gif"));
                _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/insect/insect5.png"), Image.FromFile(@"../../images/card/insect/insect_5_g.gif"));
            }
            else if (i == 3)
            {
                _Clan = "Orc";
                _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/orge/orc1.png"), Image.FromFile(@"../../images/card/orge/orc_1_g.gif"));
                _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/orge/orc2.png"), Image.FromFile(@"../../images/card/orge/orc_2_g.gif"));
                _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/orge/orc3.png"), Image.FromFile(@"../../images/card/orge/orc_3_g.gif"));
                _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/orge/orc4.png"), Image.FromFile(@"../../images/card/orge/orc_4_g.gif"));
                _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/orge/orc5.png"), Image.FromFile(@"../../images/card/orge/orc_5_g.gif"));
            }
            else if(i == 4)
            {
                _Clan = "Skeleton";
                _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/undead/skel1.png"), Image.FromFile(@"../../images/card/undead/skel_1_g.gif"));
                _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/undead/skel2.png"), Image.FromFile(@"../../images/card/undead/skel_2_g.gif"));
                _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/undead/skel3.png"), Image.FromFile(@"../../images/card/undead/skel_3_g.gif"));
                _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/undead/skel4.png"), Image.FromFile(@"../../images/card/undead/skel_4_g.gif"));
                _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/undead/skel5.png"), Image.FromFile(@"../../images/card/undead/skel_5_g.gif"));
            }
            else if(i == 5)
            {
                _Clan = "Spirit";
                _card[0] = new Card(1,3, Image.FromFile(@"../../images/card/human/human1.png"), Image.FromFile(@"../../images/card/human/human_1_g.gif"));
                _card[1] = new Card(2,2, Image.FromFile(@"../../images/card/human/human2.png"), Image.FromFile(@"../../images/card/human/human_2_g.gif"));
                _card[2] = new Card(3,1, Image.FromFile(@"../../images/card/human/human3.png"), Image.FromFile(@"../../images/card/human/human_3_g.gif"));
                _card[3] = new Card(4,1, Image.FromFile(@"../../images/card/human/human4.png"), Image.FromFile(@"../../images/card/human/human_4_g.gif"));
                _card[4] = new Card(5,1, Image.FromFile(@"../../images/card/human/human5.png"), Image.FromFile(@"../../images/card/human/human_5_g.gif"));
            }
            else
            {
                _Clan = "unselect";
            }
        } 
        public void shuffle()  //shuffle 5 card 
        {
            int counter = 0;
            int length = 5;
            Random random = new Random();
            Card[] array = new Card[length];
            while (counter < length)
            {
                int index = random.Next(0, 5);
                Card card = _card[index];
                if (!array.Contains(card))
                {
                    array[counter] = card;
                    counter++;
                }
            }
            _card = array;
        }
        public string getnamedeck()
        {
            return _Clan;
        }
        public Card drawcard()
        {
            Card c = _card[0];
           // _card[0] = new Card(0, Image.FromFile(@"../../images/bgcard.png"));
            return c;

        }
        public void decard(int n)
        {
            _card[n - 1].Level = 0;
        }

    }
}
