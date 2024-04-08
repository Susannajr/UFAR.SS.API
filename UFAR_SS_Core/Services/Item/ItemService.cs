using UFAR_SS_Data.DAO;
using UFAR_SS_Data.Entities;

namespace UFAR_SS_Core.Services.Item
{
    /// <summary>
    /// This class implements the 'IItemService' interface and provides methods for managing items.
    /// Constructor for the 'ItemService' class, injecting the application database context.
    /// </summary>
    public class ItemService(ApplicationDBContext context) : iItemService
    {
        /// <summary>
        /// Set default values for item properties. 
        /// Add the item to the database context and save changes.
        /// </summary>
        public void AddItem(ItemEntity item)
            //To do business Logic
        {
            item.Name = "Item";
            item.Description = "Description";

            context.Add(item);
            context.SaveChanges();
        }
        /// <summary>
        /// Soft deletes an item from the system. 
        /// Find the item by ID and set the 'isDeleted' flag to 'true'. 
        /// Save changes to the database.
        /// </summary>
        public void RemoveItem(int itemId) {
            context.Items.FirstOrDefault(x => x.Id == itemId).isDeleted = true;
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing item's information. 
        /// Update the item in the database context and save changes.
        /// </summary>
        public void UpdateItem(ItemEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        /// <summary>
        /// Hard deletes an item from the system. 
        /// Remove the item from the database context and save changes.
        /// </summary>
        public void DeleteItem(ItemEntity entity) {
            context.Remove(entity);
            context.SaveChanges();
        }
        /// <summary>
        /// Retrieves a list of all items in the system.
        /// </summary>
        /// <returns> A List of 'ItemEntity' representing all items in the system.</returns>
        public List<ItemEntity> GetItems()
        {
            return context.Items.ToList();
        }
        /// <summary>
        /// Retrieves an item by its ID. 
        /// Retrieves an item by its name.
        /// </summary>
        /// <returns> An 'ItemEntity' representing the retrieved item. </returns>
        public ItemEntity GetItemById(int itemId)
        {
            return context.Items.FirstOrDefault(x => x.Id == itemId);
        }
        public ItemEntity GetItemByName(string itemName) {
            return context.Items.FirstOrDefault(x => x.Name == itemName);
        }
        /// <summary>
        /// Adds an item to the system. 
        /// Add the item to the database context and save changes.
        /// </summary>
        /// <returns> The added 'ItemEntity' object. </returns>
        public ItemEntity addItem(ItemEntity item)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return item;
        }
    }
}
