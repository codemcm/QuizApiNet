namespace Dto.outDto;
    public class BasicResponse<T>
{
    public string Status { get; set; }
    public T Body { get; set; }
    public string Message { get; set; }
}

