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
    public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductDTO>>>
    {
        public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductDTO>>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public GetAllProductHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductDTO>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var list = await productRepository.GetAllAsync();
                var map=mapper.Map<List<ProductDTO>>(list);
               
                return new ServiceResponse<List<ProductDTO>>(map);
            }
        }
    }
}
