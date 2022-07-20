using System.Text.Json;

namespace CV.API.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch(Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                _logger.LogError($"{ex.Message}\n{ex.InnerException?.Message}");
                _logger.LogError($"Error query: {context.Request.Path}");
                _logger.LogError(ex.StackTrace);

                var message = JsonSerializer.Serialize(new
                {
                    StatusCode = context.Response.StatusCode,
                    ErrorMessage = ex.Message
                });

                await context.Response.WriteAsync(message);
            }
        }
    }
}
