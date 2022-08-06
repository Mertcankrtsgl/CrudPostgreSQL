namespace Crudpostgresql.Model
{
    public class ResponseHandler
    {
        public static ApiRestonce GetExceptionResponse(Exception ex)
        {
            ApiRestonce response = new ApiRestonce();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;
        }
        public static ApiRestonce GetAppResponse(ResponseType type, object? contract)
        {
            ApiRestonce response;

            response = new ApiRestonce { ResponseData = contract };
            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";

                    break;
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No record available";
                    break;
            }
            return response;
        }
    }
}
