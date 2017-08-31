namespace Fever.Core.AppService
{
    public interface IPagedDto
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int Total { get; set; }
    }
}