using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Message
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string Body { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool Readed { get; set; }
    }
}
