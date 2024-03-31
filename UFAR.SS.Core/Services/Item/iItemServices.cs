using UFAR.SS.Data.Entities;

namespace UFAR.SS.Core.Services.Item
{
    public interface IItemServices
    {
        void AddItem(ItemEntity item);
        void RemoveItem(int itemId);
        void UpdateItem(ItemEntity item);
        void DeleteItem(ItemEntity item);
        List<ItemEntity> GetItems();
        ItemEntity GetItemById(int itemid);
        ItemEntity GetItemByName(string itemName);
    }
}