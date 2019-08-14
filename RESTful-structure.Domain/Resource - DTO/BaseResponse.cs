using System;
namespace RESTfulstructure.Domain.ResourceDTO
{
    public abstract class BaseResponse
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public BaseResponse(string message)
        {
            Success = false;
            Message = message;
        }


        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
