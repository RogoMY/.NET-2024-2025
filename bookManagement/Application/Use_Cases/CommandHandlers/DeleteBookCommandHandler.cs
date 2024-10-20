﻿using Application.Use_Cases.Commands;
using MediatR;

namespace Application.Use_Cases.CommandHandlers
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IBookRepository repository;
        public DeleteBookCommandHandler(IBookRepository repository)
        {
            this.repository = repository;
        }
        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(request.Id);
        }
    }
}
