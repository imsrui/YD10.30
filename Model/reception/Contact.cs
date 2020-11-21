using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
    public class Contact
    {
        public Guid Contact_Id { get; set; } = Guid.NewGuid();
        public string Contact_Address { get; set; }
        public string Contact_QQ { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_WorkTime { get; set; }
        public string Contact_QRCode { get; set; }



        public int Copyrights_DeleteId { get; set; } = 1;

        public DateTime Copyrights_CreateTime { get; set; } = DateTime.Now;
        public DateTime Copyrights_UpdateTime { get; set; } = DateTime.Now;
    }
}
