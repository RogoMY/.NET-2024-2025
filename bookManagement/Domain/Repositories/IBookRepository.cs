using Domain.Entities;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllAsync();
    Task<Book> GetByIdAsync(Guid id);
    Task<Guid> AddAsync(Book book);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(Book book);
}
