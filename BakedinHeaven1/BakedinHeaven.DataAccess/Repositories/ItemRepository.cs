using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakedinHeaven.DataAccess.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ItemRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Item itemEntity)
        {
            _dbContext.Items.Add(itemEntity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            Item item =_dbContext.Items.Where(e => e.ItemId == id).FirstOrDefault();
            if(item!=null)
            {
                _dbContext.Remove(item);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public List<Item> GetAllItems()
        {
            return _dbContext.Items.ToList();
        }

        public List<Item>GetItems()
        {
            return _dbContext.Items.ToList();
        }


        public Item Update(Item itemChange ,int id)
        {
            Item item = _dbContext.Items.Where(x  => x.ItemId == id).FirstOrDefault();
            if (item != null)
            {
                item.ItemName = itemChange.ItemName;
                item.Kcal = itemChange.Kcal;
                item.Price = itemChange.Price;
                item.Quantity = itemChange.Quantity;
                item.WeightInGrams = itemChange.WeightInGrams;
                item.IsVeg = itemChange.IsVeg;
                item.IsSpecial = itemChange.IsSpecial;
                item.AvailableDate = itemChange.AvailableDate;
                _dbContext.SaveChanges();

            }
            return item;
        }
    }
}
