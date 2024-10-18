using Application.DTOs;
using Application.Use_Cases.Queries;
using AutoMapper;
using Domain.Entities;

using MediatR;

namespace Application.Use_Cases.QuerryHandlers
{
    internal class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IBookRepository repository;
        public GetAllBooksQueryHandler(IBookRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Book> books = await repository.GetAllAsync();
            List<BookDto> booksDto = new List<BookDto>();
            foreach (var book in books)
            {
                booksDto.Add(new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    ISBN = book.ISBN,
                    PublicationDate = book.PublicationDate
                });
            }
            return booksDto;

        }
    }

}
