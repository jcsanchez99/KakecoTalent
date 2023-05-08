namespace KakecoTalent.Application.UseCase.Commons.Bases
{
    public class BaseResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? Mensaje { get; set; }
        public IEnumerable<BaseError>? Errors { get; set; }
    }
}
