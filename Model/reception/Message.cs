using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
    public class Message
    {

        public Guid Message_Id { get; set; } = Guid.NewGuid();
        public string Message_Name { get; set; }
        public string Message_Phone { get; set; }
        public string Message_OrderId { get; set; }
        public string Message_Email { get; set; }
        public string Message_site { get; set; }
        public string Message_Link { get; set; }
        public string Message_Address { get; set; }
        public DateTime Copyrights_CreateTime { get; set; } = DateTime.Now;
        public DateTime Copyrights_UpdateTime { get; set; } = DateTime.Now;
    }
}
