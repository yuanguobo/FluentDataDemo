using FluentDataDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public UserInfo GetItem(int ID)
        {
            BO bo = new BO();
            UserInfo model = bo.Context().Sql($@"
                SELECT * FROM UserInfo WHERE ID = {ID} "
            ).QuerySingle<UserInfo>();
            return model;
        }
    }
}
