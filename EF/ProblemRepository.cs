using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF
{
    public  class ProblemRepository
    {
        SqlDbContext context = new SqlDbContext();
        public  List<Problem> GetBy(IList<ProblemStatus> exclude, bool hasReward, bool descByPublishTime) 
        {
            List<Problem> result = context.Problems.ToList();
             
            if (hasReward)
            {
                result = result.Where(p => p.Reward != null).ToList();
            }//else nothing

            if (descByPublishTime)
            {
                result = result.OrderByDescending(s => s.PublishDateTime).ToList();
            }
            else  //需求模糊  假设不倒叙就是正序
            {
                result = result.OrderBy(s => s.PublishDateTime).ToList();
            }

            return result = result.Where(p => !exclude.Contains(p.Status)).ToList();
        }
    }
}
