using System;
using System.Collections.Generic;

#nullable disable

namespace RightSolutions4u.Models
{
    public partial class ContactUs
    {
        public int RecId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
