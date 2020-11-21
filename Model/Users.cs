﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users
    {
        public Guid Users_Id { get; set; } = Guid.NewGuid();
        public string Users_Account { get; set; }
        public string Users_Password { get; set; }
        public string Users_NickName { get; set; }
        public string Users_Photo { get; set; }
        public Guid Users_RolesId { get; set; }
        public int Users_DeleteId { get; set; } = 1;
        public DateTime Users_CreateTime { get; set; } = DateTime.Now;
        public DateTime Users_UpdateTime { get; set; } = DateTime.Now;
    }
}
