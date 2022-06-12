namespace Common.Dtos;

public class ApiResponseBaseDto
{
    public bool IsSuccess { get; set; }

    public IEnumerable<string> Errors { get; set; }

    public string Error
    {
        set => Errors = new List<string> {value};
    }
}
public class ApiResponseDto<T> : ApiResponseBaseDto
{
    public T Data { get; set; }
}

public class ApiResponseListDto<T> : ApiResponseBaseDto
{
    public T[] Data { get; set; }
    public int Total { get; set; }
}