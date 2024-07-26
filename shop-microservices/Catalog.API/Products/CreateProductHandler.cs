﻿using MediatR;

namespace Catalog.API.Products;
public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal price)
        : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);


internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

