﻿using System;
using System.Collections.Generic;
using gendei.Entities;

namespace gendei.Entities
{
    public partial class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime AuthDate { get; set; }
        public string LastToken { get; set; }
        public DateTime TokenRefreshDate { get; set; }
        public string RefreshTokenCode { get; set; }

        public virtual User User { get; set; }
    }
}
