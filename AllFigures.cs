using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    class AllFigures
    {
        public string Info { get; set; }
        public AllFigures Next { get; set; }
        public AllFigures(string name)
        {
            Info = name;
            Next = null;
        }
        private void Add(AllFigures  a, string Info)
        {
            if (a.Next == null)
            {
                a.Next = new AllFigures(Info);
                return;
            }
            Add(a.Next, Info);
        }
        public void Add(string Info)
        {
            Add(this, Info);
        }
        //public void update(string name)
        //{
        //    string 
        //    if (name == "Triangle" || name == "Right_Triangle" || name == "Equilateral_Triangle")
        //    {

        //    }
        //}
      
    }
}
