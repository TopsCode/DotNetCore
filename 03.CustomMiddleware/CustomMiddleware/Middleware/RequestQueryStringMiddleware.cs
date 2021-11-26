using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    public class RequestQueryStringMiddleware
    {
        private RequestDelegate next;

        public RequestQueryStringMiddleware(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["iscertified"] == "true")
            {
                await context.Response.WriteAsync("Message from class Based Middleware \n");
            }
            await next(context);
        }
    }
}
