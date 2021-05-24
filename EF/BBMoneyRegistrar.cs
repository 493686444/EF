using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class BBMoneyRegistrar
    {
        SqlDbContext context = new SqlDbContext();
        public void Change(int payerId,int payeeId, int number)
        {
            //EF core：UoW和事务
            //    用事务实现帮帮币出售的过程
            //            卖方帮帮币足够，扣减数额后成功提交。 
            //            卖房帮帮币不够，事务回滚，买卖双方帮帮币不变。 
           
            using (IDbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    User payer = context.Users.Find(payerId);
                    payer.BBMoney = payer.BBMoney-number;
                    User payee = context.Users.Find(payeeId);
                    payee.BBMoney = payee.BBMoney+number;
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
