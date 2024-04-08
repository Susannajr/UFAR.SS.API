using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR_SS_Core.Services.Author;
using UFAR_SS_Core.Services.Item;
using UFAR_SS_Data.Entities;

/// <summary>
/// The first part of the code includes necessary libraries and namespaces.
/// It declares a namespace 'UFAR_SS_API.Controllers' where the 'ItemController' class resides.
/// The class 'ItemController' inherits from the 'ControllerBase' class.
/// [Route("api/[controller]")] attribute specifies the route for the controller. It indicates that the route should start with "api/" followed by the name of the controller.
/// [ApiController] attribute indicates that the controller responds to web 'API' requests.
/// 'public IItemService itemService' declares a variable 'itemService' of type 'IItemService'.
/// The constructor 'public ItemController(IItemService _itemService)' initializes the 'itemService' variable with the provided '_itemService' parameter.
/// </summary>

namespace UFAR_SS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public iItemService itemService;
        public ItemController(iItemService _itemService)
        {
            itemService = _itemService;
        }

        /// <summary>
        /// Retrieves a list of items.
        /// Retrieves an item by its ID.
        /// Retrieves an item by its Name.
        /// </summary>
        /// <returns> An IActionResult representing the HTTP response with the retrieved item. </returns>

        [HttpGet("List")]
        public IActionResult GetItem()
        {
            return Ok(itemService.GetItems());
        }

        [HttpGet("GetItemById")]
        public IActionResult GetItemById(int itemId)
        {
            return Ok(itemService.GetItemById(itemId));
        }

        // Calling Service layer method to get Item by name
        [HttpGet("GetItemByName")]
        public IActionResult GetItemByName(string itemName)
        {
            return Ok(itemService.GetItemByName(itemName));
        }

        /// <summary>
        /// Handles 'HTTP POST' requests to add a new item to the system.
        /// Adds a new item to the system.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response with the added item.</returns>

        [HttpPost("AddItem")]
        public IActionResult AddItem(ItemEntity item)
        {
            return Ok(itemService.addItem(item));
        }

        /// <summary>
        /// Handles 'HTTP DELETE' requests to remove an item from the system.
        /// Removes the item from the system.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response indicating the operation success. </returns>

        [HttpDelete("RemoveItem")]
        public IActionResult RemoveItem(int itemId)
        {
            itemService.RemoveItem(itemId);
            return Ok();
        }

        /// <summary>
        /// Handles HTTP PUT requests to update an existing item's information.
        /// Updates the existing item's information.
        /// </summary>
        /// <returns> Return an 'HTTP Ok' response indicating that the operation was successful. </returns>

        [HttpPut("UpdateItem")]
        public IActionResult UpdateItem(ItemEntity item)
        {
            itemService.UpdateItem(item);
            return Ok();
        }

        /// <summary>
        /// Handles HTTP DELETE requests to delete an item from the system.
        /// Deletes an item from the system.
        /// </summary>
        /// <returns> Return an 'HTTP Ok' response indicating that the operation was successful. </returns>

        [HttpDelete("DeleteItem")]
        public IActionResult DeleteItem(ItemEntity item)
        {
            itemService.DeleteItem(item);
            return Ok();
        }
    }
}
///<summary>
///'GetItemById' Retrieves an item by their ID.
///'GetItemName' Retrieves an item by their name. 
///'AddItem' Adds a new item to the system.
///'RemoveItem' Removes an item from the system by their ID. 
///'UpdateItem' Updates an existing item's information. 
///'DeleteItem' Deletes an item from the system.
/// </summary>