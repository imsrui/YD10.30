using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
    public class Order1
    {

        public Guid Order_Id { get; set; } = Guid.NewGuid();
        public string Order_Name { get; set; }
        public int Order_Price { get; set; }
        public string Order_Content { get; set; }
        public Guid Order_WebMenusId { get; set; }


        public DateTime Copyrights_CreateTime { get; set; } = DateTime.Now;
        public DateTime Copyrights_UpdateTime { get; set; } = DateTime.Now;
    }
}
