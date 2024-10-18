using Application.Use_Cases.Commands;
using MediatR;

namespace Application.Use_Cases.CommandHandlers
{
    internal class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepository repository;
        public UpdateBookCommandHandler(IBookRepository repository)
        {
            this.repository = repository;
        }
        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await repository.GetByIdAsync(request.Id);
            book.Title = request.Title;
            book.Author = request.Author;
            book.ISBN = request.ISBN;
            book.PublicationDate = request.PublicationDate;
            await repository.UpdateAsync(book);
        }
    }
}
