﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_WORKFLOW.DataAccess.Models
{
    public class Usuario
    {

        public virtual int Id { get; set; } 
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
