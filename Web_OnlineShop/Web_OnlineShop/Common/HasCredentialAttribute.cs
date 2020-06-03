using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.Models;

namespace Web_OnlineShop.Common
{
    public class HasCredentialAttribute: AuthorizeAttribute
    {
        public string RoleID { set; get; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var session=(LoginViewModel)HttpContext.Current.Session[DEFINE.USERSESSION];
            if (session == null) return false;

            List<string> privilegeLevels = this.GetCredentialByLoggedInUser(session.UserName);
            
            if (privilegeLevels.Contains(this.RoleID)||session.GroupID==DEFINE.ADMIN_GROUP)
            {
                return true;
            }
            return false;
           
        }

        private List<string> GetCredentialByLoggedInUser(string p)
        {
            var credentials = (List<string>)HttpContext.Current.Session[DEFINE.CREDENTIAL_SESSION];
            return credentials;
        }
    }
}