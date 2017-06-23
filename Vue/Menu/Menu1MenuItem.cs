using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFinal.Vue;

namespace XamarinFinal
{

    public class Menu1MenuItem
    {
        public Menu1MenuItem()
        {
            TargetType = typeof(Test);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
