using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
   public class Email
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
    }
}
