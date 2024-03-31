using System.ComponentModel.DataAnnotations;

namespace UFAR.SS.Data.Entities
{
    public class AuthorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        public ICollection<ItemEntity> Items { get; set; }
    }
}
