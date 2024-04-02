using UFAR.SS.Data.DAO;
using UFAR.SS.Data.Entities;

namespace UFAR.SS.Core.Services.Item
{
    public class ItemService(ApplicationDBContext context) : IItemServices
    {
        public void AddItem(ItemEntity item)
            //To do business Logic
        {
            item.Name = "Item";
            item.Description = "Description";

            context.Add(item);
            context.SaveChanges();
        }
        //Soft Delete
        public void RemoveItem(int itemId) {
            context.Items.FirstOrDefault(x => x.Id == itemId).isDeleted = true;
            context.SaveChanges();
        }
        public void UpdateItem(ItemEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        //Hard Delete
        public void DeleteItem(ItemEntity entity) {
            context.Remove(entity);
            context.SaveChanges();
        }
        public List<ItemEntity> GetItems()
        {
            return context.Items.ToList();
        }
        public ItemEntity GetItemById(int itemId)
        {
            return context.Items.FirstOrDefault(x => x.Id == itemId);
        }
        public ItemEntity GetItemByName(string itemName) {
            return context.Items.FirstOrDefault(x => x.Name == itemName);
        }
    }
}
