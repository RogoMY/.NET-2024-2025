using MediatR;
using Application.DTOs;
namespace Application.Use_Cases.Queries
{
    public class GetAllBooksQuery : IRequest<List<BookDto>>
    {
    }
}
