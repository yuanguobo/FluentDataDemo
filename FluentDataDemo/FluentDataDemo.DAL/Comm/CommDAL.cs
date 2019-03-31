using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.DAL
{
    public class CommDAL
    {
        /// <summary>
        /// 返回一个dynamic对象
        /// Add:yuangb 2019-3-29
        /// </summary>
        /// <param name="columns">dynamic包含的列</param>
        /// <param name="froms">查询来源</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        public dynamic GetSingle(string columns, string froms, string where)
        {
            BO bo = new BO();
            dynamic dyn = bo.Context().Sql($@"
                SELECT
	                {columns}
                FROM
	                {froms}
                WHERE
	                {where}
                ").QuerySingle<dynamic>();
            return dyn;
        }
    }
}
