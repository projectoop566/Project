using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Skill
    {
        private string Name;
        private int Num;
        private string _PictureID_skill;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        
        public string PictureID_skill
        {
            get { return _PictureID_skill; }
            set { _PictureID_skill = value; }
        }


        public Skill()
        {
            //defalut
        }

        public Skill(int i) // 1=  2=  3=
        {
            Num = i;
        }
    
    }
}
