using UFAR.SS.Data.Entities;

namespace UFAR.SS.Core.Services.Author
{
    public interface IAuthorServices
    {
        void addAuthor(AuthorEntity author);
        void RemoveAuthor(int authorId);
        void UpdateAuthor(AuthorEntity author);
        void DeleteAuthor(AuthorEntity author);
        List<AuthorEntity> GetAuthor();
        AuthorEntity GetAuthorById(int authorid);
        AuthorEntity GetAuthorByFirstName(string authorName);
        AuthorEntity GetAuthorByLastName(string authorName);
        AuthorEntity GetAuthorByNickName(string authorName);
    }
}