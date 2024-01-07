namespace HeightsBookHub.Domain.Entities.SharedEntities
{
    public class BaseResponse<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }

        public BaseResponse(bool isSucceeded, string message, List<string> errors, T data, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            Errors = errors;
            Data = data;
            StatusCode = statusCode;
        }

        public BaseResponse(bool isSucceeded, string message, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            StatusCode = statusCode;
        }

        public BaseResponse(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public BaseResponse(bool isSucceeded, List<string> errors, T data)
        {
            Succeeded = isSucceeded;
            Errors = errors;
            Data = data;
        }

        public BaseResponse(bool isSucceeded, string message, List<string> errors, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            Errors = errors;
            StatusCode = statusCode;
        }

        public static BaseResponse<T> Success(T data, string message, int statusCode)
        {
            return new BaseResponse<T>(true, message, new List<string>(), data, statusCode);
        }

        public static BaseResponse<T> Failed(List<string> errors)
        {
            return new BaseResponse<T>(false, errors, default);
        }


        public static BaseResponse<T> Failed(bool isSucceeded, string message, int statusCode, List<string> errors)
        {
            return new BaseResponse<T>(isSucceeded, message, errors, statusCode);
        }

    }
}
