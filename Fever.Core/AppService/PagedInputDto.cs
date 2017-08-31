namespace Fever.Core.AppService
{
    public class PagedInputDto : InputDtoBase, IPagedDto
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
    }
}