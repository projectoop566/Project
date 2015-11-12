using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuppy_useless_species
{
    class Skill
    {
        private string _skill;
        public string skill
        {
            get { return _skill; }
            set { _skill = value; }
        }
        private string _PictureID_skill;
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
            if (i == 1)
            {

            }else if(i == 2)
            {

            }else if (i == 3)
            {

            }
        }
    
    }
}
