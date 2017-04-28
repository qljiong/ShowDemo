using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Filter
{
    public class ActionOptAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Aciton内的方法执行后切入
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        /// <summary>
        /// Aciton内的方法执行前切入
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }

        /// <summary>
        /// 返回结果之后切入
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }

        /// <summary>
        /// 返回结果之前切入
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
        }
    }
}