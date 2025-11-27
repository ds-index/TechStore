using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TechStore.WebAPI.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.ModelState.IsValid == false)
            {
                var errors = context.ModelState
                    .Where(x => x.Value!.Errors.Any())
                    .Select(x => new
                    {
                        Filed = x.Key,
                        Error = x!.Value!.Errors.Select(e => e.ErrorMessage).ToList()
                    });

                context.Result = new BadRequestObjectResult(
                    new { Message = "Model validation failed", Errors = errors }
                    );
            }
        }
    }
}
