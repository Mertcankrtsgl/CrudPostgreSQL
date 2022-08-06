namespace Crudpostgresql.Model
{
    public class ApiRestonce
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public object? ResponseData { get; set; }
    }
    public enum ResponseType
    {
        Success,
        NotFound,
        Failure
    }
}
