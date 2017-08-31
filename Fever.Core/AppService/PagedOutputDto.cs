namespace Fever.Core.AppService
{
    public class PagedOutputDto:OutputDtoBase,IPagedDto
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
    }
}