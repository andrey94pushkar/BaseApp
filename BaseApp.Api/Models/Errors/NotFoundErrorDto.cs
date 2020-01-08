namespace BaseApp.Api.Models.Errors
{
    /// <summary>
    /// A representation of not found error
    /// </summary>
    public sealed class NotFoundErrorDto : ErrorDto
    {
        public NotFoundErrorDto()
        {
            Code = ReadableErrorCodes.NotFound;
        }
    }
}
