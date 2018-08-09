using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SayedTodo.Controllers {
    public class BaseController : Controller {

        protected const string UsernameCookieKey = "username";

        // TODO: Perhaps this should be implemented in middleware and added to all requests?
        protected string GetUsername(/*HttpRequest request, HttpResponse outgoingResponse*/){
            // see if there is already a cookie in the request, if so return it. If not create and add to response.
            string username = null;
            var usernamecookie = this.Request.Cookies[UsernameCookieKey];
            if (usernamecookie != null) {
                username = usernamecookie;
            }

            if (string.IsNullOrWhiteSpace(username)) {
                username = GetNewUsername();
                Response.Cookies.Append(UsernameCookieKey, username, new CookieOptions {
                    Expires = DateTime.Now.AddYears(1)
                });
            }

            return username;
        }

        protected string GetNewUsername() {
            int randomnum = new Random().Next(10000);
            return $"user-{randomnum}";
        }
    }
}
