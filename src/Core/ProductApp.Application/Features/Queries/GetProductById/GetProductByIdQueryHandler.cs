using AutoMapper;
using MediatR;
using ProductApp.Application.Dtos;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler:IRequestHandler<GetProductByIdQuery,ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        #region Implementation of IRequestHandler<in GetProductByIdQuery,ServiceResponse<List<ProductViewDto>>>

        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            var dto = _mapper.Map<GetProductByIdViewModel>(product);

            return new ServiceResponse<GetProductByIdViewModel>(dto);
        }

        #endregion
    }
}
