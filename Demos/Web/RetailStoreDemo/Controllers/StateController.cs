using Microsoft.AspNetCore.Mvc;

namespace RetailStoreDemo.Controllers;

public class StateController : Controller
{
    public IActionResult RequestInfo()
    {
        var requestId =
            HttpContext.Items["RequestId"];

        var requestTime =
            HttpContext.Items["RequestTime"];

        var applicationName =
            HttpContext.Items["ApplicationName"];

        return Content(
            $"Request ID: {requestId}\n" +
            $"Request Time: {requestTime}\n" +
            $"Application: {applicationName}"
        );
    }
}