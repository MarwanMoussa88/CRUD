using System.Net;
using Entities.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace API.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this WebApplication app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async httpContext =>
                {
                    httpContext.Response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                    httpContext.Response.ContentType = "application/json";

                    var contextFeatures = httpContext.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeatures != null)
                    {
                        // i know i am not supposed to include stack Trace in the model but just pretend as this is a log
                        // :)
                        var error = new ErrorModel()
                        {
                            Message = contextFeatures.Error.Message,
                            StatusCode = httpContext.Response.StatusCode,
                            StackTrace = contextFeatures.Error.StackTrace,
                            Route = contextFeatures.Path
                        };
                        await httpContext.Response.WriteAsync(error.ToString());
                    }
                });
            });
        }
    }
}
