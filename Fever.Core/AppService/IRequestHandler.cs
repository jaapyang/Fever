namespace Fever.Core.AppService
{
    public interface IRequestHandler<in TInputDto, out TOutputDto>
    {
        TOutputDto Request(TInputDto inputDto);
    }
}