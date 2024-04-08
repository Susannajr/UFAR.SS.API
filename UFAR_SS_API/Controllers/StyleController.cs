using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using UFAR_SS_Core.Services.Style;
using UFAR_SS_Data.Entities;

/// <summary>
/// The first part of the code includes necessary libraries and namespaces.
/// It declares a namespace 'UFAR_SS_API.Controllers' where the 'StyleController' class resides.
/// The class 'StyleController' inherits from the 'ControllerBase' class.
/// [Route("api/[controller]")] attribute specifies the route for the controller. It indicates that the route should start with "api/" followed by the name of the controller.
/// [ApiController] attribute indicates that the controller responds to web 'API' requests.
/// 'public IStyleService styleService' declares a variable 'styleService' of type 'IStyleService'.
/// The constructor 'public StyleController(IStyleService _styleService)' initializes the 'styleService' variable with the provided '_styleService' parameter.
/// </summary>

namespace UFAR.SS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StyleController : ControllerBase
    {
        public IStyleServices styleService;
        public StyleController(IStyleServices _styleService)
        {
            styleService = _styleService;
        }
        /// <summary>
        /// Retrieves a list of style.
        /// Retrieves an style by its ID.
        /// Retrieves an style by its Name.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response with the retrieved style. </returns>

        [HttpGet("List")]
        public IActionResult GetStyle()
        {
            return Ok(styleService.GetStyle());
        }

        [HttpGet("GetStyleById")]
        public IActionResult GetStyleById(int styleId)
        {
            return Ok(styleService.GetStyleById(styleId));
        }

        // Calling Service layer method to get Style by name
        [HttpGet("GetStyleByName")]
        public IActionResult GetStyleByName(string styleName)
        {
            return Ok(styleService.GetStyleByName(styleName));
        }
        /// <summary>
        /// Handles 'HTTP POST' requests to add a new style to the system.
        /// Adds a new style to the system.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response with the added style.</returns>

        [HttpPost("AddStyle")]
        public IActionResult AddStyle(StyleEntity style)
        {
            return Ok(styleService.AddStyle(style));
        }
        /// <summary>
        /// Handles 'HTTP DELETE' requests to remove a style from the system.
        /// Removes the style from the system.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response indicating the operation success. </returns>

        [HttpDelete("RemoveStyle")]
        public IActionResult RemoveStyle(int styleId)
        {
            styleService.RemoveStyle(styleId);
            return Ok();
        }
        /// <summary>
        /// Handles HTTP PUT requests to update an existing style's information.
        /// Updates the existing style's information.
        /// </summary>
        /// <returns> Return an 'HTTP Ok' response indicating that the operation was successful. </returns>

        [HttpPut("UpdateStyle")]
        public IActionResult UpdateStyle(StyleEntity style)
        {
            styleService.UpdateStyle(style);
            return Ok();
        }
        /// <summary>
        /// Handles HTTP DELETE requests to delete a style from the system.
        /// Deletes a style from the system.
        /// </summary>
        /// <returns> Return an 'HTTP Ok' response indicating that the operation was successful. </returns>

        [HttpDelete("DeleteStyle")]
        public IActionResult DeleteStyle(StyleEntity style)
        {
            styleService.DeleteStyle(style);
            return Ok();
        }
    }
}
///<summary>
///'GetStyleById' Retrieves an style by their ID.
///'GetStyleName' Retrieves an style by their name. 
///'AddStyle' Adds a new style to the system.
///'RemoveStyle' Removes an style from the system by their ID. 
///'UpdateStyle' Updates an existing style's information. 
///'DeleteStyle' Deletes an style from the system.
/// </summary>