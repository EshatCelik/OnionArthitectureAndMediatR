using Application.Dto;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetProducts
{
    public  class GetProductByIdQuery:IRequest<ServiceResponse<ProductDTO>>
    {
        public Guid Id { get; set; }
    }
}
