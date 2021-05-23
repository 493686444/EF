using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF
{
    public class RepositoryMessage
    {
        SqlDbContext context = new SqlDbContext();

        public List<Message> GetMessage() 
        {
            List<Message> result = context.Messages
                .OrderByDescending(m => m.Readed)
                .OrderBy(m => m.CreateDateTime).ToList();

            return result;
        }
    }
}
