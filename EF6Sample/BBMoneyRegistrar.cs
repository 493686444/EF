using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Sample
{
    class BBMoneyRegistrar
    {
        SqlDbContext context = new SqlDbContext();
        public void Change(int payerId, int payeeId, int number)
        {
            using (DbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    User payer = context.Users.Find(payerId);
                    payer.BBMoney = payer.BBMoney - number;
                    User payee = context.Users.Find(payeeId);
                    payee.BBMoney = payee.BBMoney + number;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
