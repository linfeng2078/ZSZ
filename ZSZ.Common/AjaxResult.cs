using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSZ.Common
{
    /// <summary>
    /// ajax返回结果类
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 结果的状态码
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// 返回的实体
        /// </summary>
        public object Data { get; set; }
    }
}
