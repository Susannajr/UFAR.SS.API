using UFAR_SS_Data.Entities;

///<summary>
///The interface defines methods for managing items.
///Sequentially it adds a new item to the system.
///Removes an item from the system by ID.
///Updates an existing item's information.
///Deletes an item from the system.
///Retrieves a list of all items in the system.
///Retrieves an item by its ID.
///Retrieves an item by its name.
///</summary>

namespace UFAR_SS_Core.Services.Item
{
    public interface iItemService
    {
        ItemEntity addItem(ItemEntity item);
        void RemoveItem(int itemId);
        void UpdateItem(ItemEntity item);
        void DeleteItem(ItemEntity item);
        List<ItemEntity> GetItems();
        ItemEntity GetItemById(int itemid);
        ItemEntity GetItemByName(string itemName);
    }
}