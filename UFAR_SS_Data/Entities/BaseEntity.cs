using System.ComponentModel.DataAnnotations;

// This namespace contains entity classes representing data entities.
namespace UFAR_SS_Data.Entities
{
    /// <summary>
    /// The BaseEntity class provides a common structure that other entity classes can inherit from.
    /// This class represents a base entity with common properties.
    /// The unique identifier for the entity. 
    /// A boolean indicating whether the entity is deleted.
    /// </summary>
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; }
    }
}