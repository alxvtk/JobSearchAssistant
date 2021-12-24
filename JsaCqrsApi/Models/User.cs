﻿using System;
using System.Collections.Generic;

#nullable disable

namespace JsaCqrsApi.Domain.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
