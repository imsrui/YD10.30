using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
   public  class Menu
    {
        public Guid Menu_Id { get; set; } = Guid.NewGuid();
        public string Menu_Title { get; set; }
        public string Menu_Href { get; set; }
    }
}
