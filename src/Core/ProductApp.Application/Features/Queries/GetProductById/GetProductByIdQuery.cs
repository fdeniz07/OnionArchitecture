using MediatR;
using ProductApp.Application.Dtos;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery:IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
