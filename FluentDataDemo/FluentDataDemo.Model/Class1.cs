﻿using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.Model
{
    public class Class1
    {
        public IDbContext Context1()
        {
            return new DbContext().ConnectionStringName("FluentDataDemo", new SqlServerProvider());
        }

        public void Temp()
        {
            dynamic product = Context1().Sql(@"").QuerySingle<dynamic>();
        }
    }
}
