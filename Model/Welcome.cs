using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Welcome
    {
        public Guid Welcome_Id { get; set; } = Guid.NewGuid();
        public string Welcome_Detail { get; set; }
    }
}
