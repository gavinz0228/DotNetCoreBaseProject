using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System;
using Newtonsoft.Json.Linq;


namespace  App.Web.Infrastructure
{
    public static class GlobalErrorHandling
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder application, ILogger logger)
        {
            application.UseExceptionHandler(appError =>{
                appError.Run(async context =>{
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "application/json";

                        logger.LogError(context.Features.Get<IExceptionHandlerFeature>().Error, "Error Captured at Global Error Handling Class.");
                        ErrorDetail errorDetail = new ErrorDetail(){
                            ErrorMessage = "Internal Server Error",
                            StatusCode = context.Response.StatusCode 
                        };

                        string message = JObject.FromObject(errorDetail).ToString();
                        await context.Response.WriteAsync(message);
                });
            });
        }
    }
    
}