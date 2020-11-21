using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class FriendLinks
    {
        public Guid FriendShips_Id { get; set; } = Guid.NewGuid();

        public int FriendShips_DeleteId { get; set; } = 1;

        public DateTime FriendShips_CreateTime { get; set; } = DateTime.Now;
        public DateTime FriendShips_UpdateTime { get; set; } = DateTime.Now;
        public string FriendShips_Title { get; set; }
        public string FriendShips_Link { get; set; }
    }
}
