using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
   public class About
    {
       public Guid About_Id { get; set; } = Guid.NewGuid();
        public string About_Title { get; set; }
        public string About_Content { get; set; }
        public string About_Image { get; set; }
        public Guid About_WebMenuId { get; set; }
        public int About_DeleteId { get; set; }
        public DateTime About_CreateTime { get; set; }
        public DateTime About_UpdateTime { get; set; }
    }
}
