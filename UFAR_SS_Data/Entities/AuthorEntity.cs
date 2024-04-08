using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//This namespace contains entity classes representing data entities.
namespace UFAR_SS_Data.Entities
{
    /// <summary>
    /// This class represents an author entity which contains sequently:
    /// The first name of the author.
    /// The last name of the author.
    /// The nickname of the author.
    /// </summary>
    public class AuthorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        // Navigation property representing the collection of items associated with this author.
        public ICollection<ItemEntity> Items { get; set; }
    }
}