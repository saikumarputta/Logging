using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;
        ////This is the standard way of capturing the category
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("DemoCatageory");
        }

        public void OnGet()
        {
            //Logging levels
            _logger.LogTrace("This is log trace");
            _logger.LogDebug("This is log debug");
            _logger.LogInformation("This is the information of the log");
            _logger.LogError("This is the log error");
            _logger.LogCritical("This is the log critical");

            ////Advanced login messages
            //_logger.LogError("The server went down temporarily at {Time}", DateTime.UtcNow);
            //try
            //{
            //    throw new Exception("you forgot to catch me");
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogCritical(ex,"There was a bad exception at {Time}",DateTime.UtcNow);
            //    throw;
            //}
        }
    }
    public class LoggingId
    {
        public const int Democode = 1001;
    }
}
