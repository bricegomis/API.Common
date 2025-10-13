using Microsoft.AspNetCore.Mvc.Filters;

namespace Ati.API.Common.Filters;

public class UnescapeIdActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        foreach (var key in context.ActionArguments.Keys.ToList())
        {
            if (key.Equals("id", StringComparison.OrdinalIgnoreCase) &&
                context.ActionArguments[key] is string idValue)
            {
                context.ActionArguments[key] = Uri.UnescapeDataString(idValue);
            }
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }
}