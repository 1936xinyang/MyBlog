using Microsoft.AspNetCore.Cors;
using ServicesModel;

namespace MyBlog.App.Areas.Admin.Controllers
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    [EnableCors("Any")]//统一设置Cors策略
    public class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>
        /// 用户登录态
        /// </summary>
        public Token UserToken { get; set; }

        /// <summary>
        /// 当前菜单Tid
        /// </summary>
        public long CurrentMenuTid { get; set; }

    }

}