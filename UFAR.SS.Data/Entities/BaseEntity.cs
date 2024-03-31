using System.ComponentModel.DataAnnotations;

namespace UFAR.SS.Data.Entities
{
    public  class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; }
    }
}
