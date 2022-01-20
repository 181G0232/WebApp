using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
