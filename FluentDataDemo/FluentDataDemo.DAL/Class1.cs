using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.DAL
{
    public class Class1
    {
        public IDbContext Context1()
        {
            return new DbContext().ConnectionStringName("FluentDataDemo", new SqlServerProvider());
        }

        public dynamic Temp()
        {
            dynamic product = Context1().Sql(@"select * from Demo ").QuerySingle<dynamic>();
            return product;
        }
    }
}
