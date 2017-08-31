namespace Fever.Core.AppService
{
    public abstract class ReqeustHandler<TInputDto, TOutputDto>:IRequestHandler<TInputDto,TOutputDto>
        where TInputDto : InputDtoBase, new()
        where TOutputDto : OutputDtoBase, new()
    {
        public TOutputDto Request(TInputDto inputDto)
        {
            return ProgrecessRequest(inputDto);
        }

        protected abstract TOutputDto ProgrecessRequest(TInputDto inputDto);
    }
}