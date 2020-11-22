using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
   public class News
    {
       
            public int Id { get; set; }

        public string Title { get; set; }
        public string Image { get; set; }
        public string content { get; set; }
        public Guid ParentId { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
