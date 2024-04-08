using UFAR_SS_Data.Entities;

///<summary>
/// The interface defines methods for managing authors.
/// Sequentially it adds a new author to the system.
/// Removes an author from the system by ID.
/// Updates an existing author's information. 
/// Deletes an author from the system. 
/// Retrieves a list of all authors in the system.
/// Retrieves an author by their ID. 
/// Retrieves an author by their first name. 
/// Retrieves an author by their last name.
/// Retrieves an author by their nick name.
/// </summary>

namespace UFAR_SS_Core.Services.Author
{
    public interface IAuthorService
    {
        AuthorEntity addAuthor(AuthorEntity author);
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