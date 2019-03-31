using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.Model
{
    [Serializable]
    public class UserInfo
    {
        /// <summary>
        /// 用户基本表主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户盐
        /// </summary>
        public string UserSalt { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 用户属性(位运算)
        /// </summary>
        public int UserAttribute { get; set; }
    }
}
