using BaseApp.Api.DtoBuilders;
using BaseApp.Api.Models.Errors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BaseApp.Api.Filters
{
    public class ErrorFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            ObjectResult result = null;
            switch (context.Exception)
            {
                case BaseApiException baseApiException:
                    var dto = ExceptionDtoBuilder.Map(baseApiException);
                    result = new ObjectResult(dto);
                    result.StatusCode = (int)baseApiException.HttpCode;
                    break;

                default:
                    var ddto = ExceptionDtoBuilder.Map(context.Exception);
                    result = new ObjectResult(ddto);
                    result.StatusCode = 500;
                    break;
            }
            context.Result = result;

        }
    }
}
