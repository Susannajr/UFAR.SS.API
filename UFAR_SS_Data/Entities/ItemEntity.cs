using System.ComponentModel.DataAnnotations;

// This namespace contains entity classes representing data entities.
namespace UFAR_SS_Data.Entities
{
    /// <summary>
    /// This class represents an item entity which contains sequently:
    /// The name of the item. 
    /// The description of the item.
    /// </summary>
    public class ItemEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // Navigation property representing the collection of styles associated with this item.
        public ICollection<StyleEntity> Styles { get; set; }
        // A boolean indicating whether the item is a sculpture.
        public bool isSculture = true;
    }
}