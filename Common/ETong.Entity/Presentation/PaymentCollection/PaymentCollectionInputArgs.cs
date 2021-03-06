using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETong.Entity.Presentation.PaymentCollection
{
    /// <summary>
    /// 代收货款用的输入参数
    /// </summary>
    public class PaymentCollectionInputArgs
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        public string MemberID
        {
            get;
            set;
        }

        /// <summary>
        /// 收款帐户真实名称
        /// </summary>
        public string ReceiveAccountRealName
        {
            get;
            set;
        }

        /// <summary>
        /// 收款帐户名称
        /// </summary>
        public string ReceiveAccountName
        {
            get;
            set;
        }

        /// <summary>
        /// 代收金额
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNo
        {
            get;
            set;
        }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName
        {
            get;
            set;
        }
        /// <summary>
        /// 类型编号
        /// </summary>
        public int TypeID
        {
            get;
            set;
        }
        /// <summary>
        /// 加密密码
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// ETM编号
        /// </summary>
        public string ETMId { get; set; }
    }
}
