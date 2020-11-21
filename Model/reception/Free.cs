using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
    public class Free
    {

        public Guid Free_Id { get; set; } = Guid.NewGuid();
        public Guid Free_ParentId { get; set; }
        
        public string Free_Name { get; set; }
        public string Free_Title { get; set; }
        public int Free_Price { get; set; }
        public string Free_Publish { get; set; }
        public string Free_Author { get; set; }
        public string Free_Content { get; set; }
        public string Free_Catalohue { get; set; }
        public string Free_Portion { get; set; }
        public DateTime Free_CreateTime { get; set; } = DateTime.Now;
        public DateTime Free_UpdateTime { get; set; } = DateTime.Now;
    }
}
