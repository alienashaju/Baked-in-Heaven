using BakedinHeaven.BusinessService.Dtos;
using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public interface IItemService
    {
        List<ItemDto> GetItems();
        void Add(Item newItem);
        void Update (Item itemChange,int id);
        void Delete(int id);
    }
}
