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

        public Deck()
        {
                //defalut
        }
    }
}
