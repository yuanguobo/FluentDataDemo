using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDataDemo.Model
{
    [Serializable]
    public class UserExtend
    {
        /// <summary>
        /// 用户扩展表主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 关联UserInfo.ID
        /// </summary>
        public int UserInfoID { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        public string UserHead { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 连续登录错误次数
        /// </summary>
        public int LoginErrorCount { get; set; }
    }
}
