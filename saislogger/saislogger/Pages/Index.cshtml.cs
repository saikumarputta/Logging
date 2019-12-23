using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace saislogger.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ////logging levels
            //_logger.LogTrace("This is the log trace");
            //_logger.LogDebug("This is the log debug");
            //_logger.LogInformation("This is the log information");
            //_logger.LogWarning("This is the log warning");
            //_logger.LogError("This is the log error");
            //_logger.LogCritical("This is the log critical");

            //Advanced logging messages
            _logger.LogWarning("server went down temporarily {Time}", DateTime.UtcNow);
            try
            {
                throw new Exception("thrown new execption");
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "This is the execption of the application{Time}", DateTime.UtcNow);
            }
        }
    }
}
