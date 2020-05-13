using src.web.auth;
using src.web.Models.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace src.web.filters
{
    public class Auth : ActionFilterAttribute
    {
        private readonly Claims _claim;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="claim"></param>
        public Auth(Claims claim) => _claim = claim;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Contains("token")
                && TokenCache.Instance.CheckByToken(actionContext.Request.Headers.GetValues("token").First(), _claim)) return;

            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
        }
    }
}
