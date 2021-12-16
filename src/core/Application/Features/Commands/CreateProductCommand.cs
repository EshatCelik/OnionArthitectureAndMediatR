using Application.Dto;
using Application.Interfaces.Repositoy;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public  class CreateProductCommand:IRequest<ServiceResponse<Guid>>
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public int  Quantity { get; set; }

    }
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product=mapper.Map<Product>(request);
            await productRepository.AddAsync(product);

            return new ServiceResponse<Guid>(product.Id);
        }
    }
}
