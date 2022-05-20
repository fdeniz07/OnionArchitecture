namespace ProductApp.Application.Wrappers
{
    public class PagedResponse<T>:ServiceResponse<T>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        
        public PagedResponse(T value , int pageNumber, int pageSize):base(value)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

    }
}
