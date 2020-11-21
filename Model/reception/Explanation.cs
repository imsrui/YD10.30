using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.reception
{
   public class Explanation
    {
       public Guid Explanation_Id { get; set; } = Guid.NewGuid();
        public string LoanType_Id { get; set; }
        public string Explanation_Detail { get; set; }
        public int Copyrights_DeleteId { get; set; } = 1;

        public DateTime Copyrights_CreateTime { get; set; } = DateTime.Now;
        public DateTime Copyrights_UpdateTime { get; set; } = DateTime.Now;
    }
}
