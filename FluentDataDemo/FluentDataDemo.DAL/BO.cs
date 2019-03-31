using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.DAL
{
    public class BO
    {
        public IDbContext Context()
        {
            return new DbContext().ConnectionStringName("FluentDataDemo", new SqlServerProvider());
        }
    }
}
