using BakedinHeaven.BusinessService;
using BakedinHeaven.BusinessService.Dtos;
using BakedinHeaven1.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakedinHeaven1.Controllers
{
[ApiController]
[Route("api/Bakery")]
public class BakeryController : ControllerBase
{
    private readonly IItemService _itemService;
    private readonly IUserService _userService;
    private readonly IOrderService _orderService;
    public BakeryController(IItemService itemService, IUserService userService, IOrderService orderService)
    {
        _itemService = itemService;
        _userService = userService;
        _orderService = orderService;
    }
    [HttpGet]
    public IEnumerable<ItemDto> GetAllItems()
    {

        return _itemService.GetItems();
    }

    [HttpPost]
    public void Add(Item item)
    {
        _itemService.Add(item);
    }

    [HttpDelete("{Id}")]
    public void Delete(int Id)
    {
        _itemService.Delete(Id);
    }


    [HttpPut("{Id}")]
    public void Update(Item item, int Id)
    {
        _itemService.Update(item, Id);
    }
}
}
