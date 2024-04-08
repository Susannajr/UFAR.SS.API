using System.Threading.Channels;
using UFAR_SS_Data.DAO;
using UFAR_SS_Data.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace UFAR_SS_Core.Services.Author
{
    /// <summary>
    /// This class implements the IAuthorService interface and provides methods for managing authors.
    /// Constructor for the AuthorService class, injecting the application database context.
    /// </summary>
    public class AuthorService : IAuthorService
    {
        ApplicationDBContext context;
        public AuthorService(ApplicationDBContext _context) {
            context = _context;
        }
        /// <summary>
        /// Adds an author to the system.
        /// Set default values for author properties.
        /// </summary>
        public void AddAuthor(AuthorEntity author)
        {
            author.FirstName = "FirstName";
            author.LastName = "LastName";
            author.NickName = "NickName";

            context.Add(author);
            context.SaveChanges();
        }
        /// <summary>
        /// Soft deletes an author from the system. 
        /// Finds the author by ID and sets the 'isDeleted' flag to 'true'.
        /// </summary>
        /// <returns> Saves changes to the database. </returns>
        public void RemoveAuthor(int authorId)
        {
            context.Author.FirstOrDefault(x => x.Id == authorId).isDeleted = true;
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing author's information.
        /// Updates the author in the database context and saves changes.
        /// </summary>
        public void UpdateAuthor(AuthorEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        /// <summary>
        /// Hard deletes an author from the system.
        /// </summary>
        /// <returns> Remove the author from the database context and save changes. </returns>
        public void DeleteAuthor(AuthorEntity entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        /// <summary>
        ///  Retrieves a list of all authors in the system.
        /// </summary>
        /// <returns> A List of 'AuthorEntity' representing all authors in the system. </returns>
        public List<AuthorEntity> GetAuthor()
        {
            return context.Author.ToList();
        }
        /// <summary>
        /// Retrieves an author by their ID. 
        /// Retrieves an author by their first name. 
        /// Retrieves an author by their last name. 
        /// Retrieves an author by their nickname.
        /// </summary>
        /// <returns> An 'AuthorEntity' representing the retrieved author.</returns>
        public AuthorEntity GetAuthorById(int authorId)
        {
            return context.Author.FirstOrDefault(x => x.Id == authorId);
        }
        public AuthorEntity GetAuthorByFirstName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.FirstName == authorName);
        }
        public AuthorEntity GetAuthorByLastName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.LastName == authorName);
        }
        public AuthorEntity GetAuthorByNickName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.NickName == authorName);
        }
        /// <summary>
        /// Adds an author to the system.
        /// Add the author to the database context and save changes.
        /// </summary>
        /// <returns> The added 'AuthorEntity' object. </returns>
        public AuthorEntity addAuthor(AuthorEntity author)
        {
            context.Author.Add(author);
            context.SaveChanges();
            return author;
        }
    }
}