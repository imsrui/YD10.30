using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class SystemMenus
    {
        public Guid SystemMenus_Id { get; set; } = Guid.NewGuid();
        public string SystemMenus_Title { get; set; }
        public string SystemMenus_Link { get; set; }
        public Guid SystemMenus_ParentId { get; set; }
        public string SystemMenus_Icon { get; set; }
        public int SystemMenus_DeleteId { get; set; } = 1;
        public DateTime SystemMenus_CreateTime { get; set; } = DateTime.Now;
        public DateTime SystemMenus_UpdateTime { get; set; } = DateTime.Now;
    }
}
