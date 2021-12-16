using Application.Dto;
using Application.Interfaces.Repositoy;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetProducts
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery,ServiceResponse<ProductDTO>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<ProductDTO>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<ProductDTO>(product);
            return new ServiceResponse<ProductDTO>(dto);
        }
    }
}
