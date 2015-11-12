using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _card[0] = new Card(1, "human_lv1_1.png");
            _card[1] = new Card(3, "human_lv3_2.png");
            _card[2] = new Card(3, "human_lv3_3.png");
            _card[3] = new Card(3, "human_lv3_4.png");
            _card[4] = new Card(5, "human_lv5_5.png");
        }

        public Deck(int i) // 1=human 2=animal 3=orge 4=undead 5=spirit
        {
            if(i == 1)
            {
                _card[0] = new Card(1, "human_lv1_1.png");
                _card[1] = new Card(3, "human_lv3_2.png");
                _card[2] = new Card(3, "human_lv3_3.png");
                _card[3] = new Card(3, "human_lv3_4.png");
                _card[4] = new Card(5, "human_lv5_5.png");
            }else if(i == 2)
            {
                _card[0] = new Card(1, "animal_lv1_1.png");
                _card[1] = new Card(2, "animal_lv2_2.png");
                _card[2] = new Card(3, "animal_lv3_3.png");
                _card[3] = new Card(4, "animal_lv4_4.png");
                _card[4] = new Card(5, "animal_lv5_5.png");
            }else if (i == 3)
            {
                _card[0] = new Card(2, "orge_lv2_1.png");
                _card[1] = new Card(2, "orge_lv2_2.png");
                _card[2] = new Card(3, "orge_lv3_3.png");
                _card[3] = new Card(4, "orge_lv4_4.png");
                _card[4] = new Card(4, "orge_lv4_5.png");
            }else if(i == 4)
            {
                _card[0] = new Card(3, "undead_lv3_1.png");
                _card[1] = new Card(2, "undead_lv3_2.png");
                _card[2] = new Card(3, "undead_lv3_3.png");
                _card[3] = new Card(4, "undead_lv3_4.png");
                _card[4] = new Card(5, "undead_lv3_5.png");
            }else if(i == 5)
            {
                _card[0] = new Card(1, "spirit_lv1_1.png");
                _card[1] = new Card(2, "spirit_lv2_2.png");
                _card[2] = new Card(2, "spirit_lv2_3.png");
                _card[3] = new Card(5, "spirit_lv5_4.png");
                _card[4] = new Card(5, "spirit_lv5_5.png");
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


    }
}
