using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR_SS_Core.Services.Author;
using UFAR_SS_Data.Entities;

/// <summary>
/// The first part of the code includes necessary libraries and namespaces.
/// It declares a namespace 'UFAR_SS_API.Controllers' where the 'AuthorController' class resides.
/// The class 'AuthorController' inherits from the 'ControllerBase' class.
/// [Route("api/[controller]")] attribute specifies the route for the controller. It indicates that the route should start with "api/" followed by the name of the controller.
/// [ApiController] attribute indicates that the controller responds to web 'API' requests.
/// 'public IAuthorService authorService' declares a variable 'authorService' of type 'IAuthorService'.
/// The constructor 'public AuthorController(IAuthorService _authorService)' initializes the 'authorService' variable with the provided '_authorService' parameter.
/// </summary>

namespace UFAR_SS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public IAuthorService authorService;
        public AuthorController(IAuthorService _authorService)
        {
            authorService = _authorService;
        }

        /// <summary>
        /// 'HTTP GET' handles requests to retrieve a list of authors.
        /// '[HttpGet("List")]' attribute specifies the route for this method. 
        /// 'public IActionResult GetAuthors()' returns an 'IActionResult' which represents a response from the action method. 
        /// </summary>
        /// <returns> Returns an 'HTTP 200 OK' response along with the list of authors obtained by calling the 'GetAuthor()' method from the 'authorService'.</returns>

        [HttpGet("List")]
        public IActionResult GetAuthors()
        {
            return Ok(authorService.GetAuthor());
        }

        [HttpGet("GetAuthorById")]
        public IActionResult GetAuthorById(int authorId)
        {
            return Ok(authorService.GetAuthorById(authorId));
        }

        // Calling Service layer method to get Author by name
        [HttpGet("GetAuthorByFirstName")]
        public IActionResult GetAuthorByFirstName(string authorFirstName)
        {
            return Ok(authorService.GetAuthorByFirstName(authorFirstName));
        }

        [HttpGet("GetAuthorByLastName")]
        public IActionResult GetAuthorByLastName(string authorLastName)
        {
            return Ok(authorService.GetAuthorByLastName(authorLastName));
        }

        [HttpGet("GetAuthorByNickName")]
        public IActionResult GetAuthorByNickName(string authorNickName)
        {
            return Ok(authorService.GetAuthorByNickName(authorNickName));
        }

        /// <summary>
        /// Calls the 'addAuthor' method of the 'authorService' to add the author to the system, 
        /// and return the result wrapped in an 'HTTP Ok' response.
        /// </summary>
        /// <returns> An 'IActionResult' representing the 'HTTP' response with the added 'author'. </returns>
        
        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor(AuthorEntity author)
        {
            return Ok(authorService.addAuthor(author));
        }

        /// <summary>
        /// Calls the 'RemoveAuthor' method of the 'authorService' to remove the author from the system.
        /// It takes an integer parameter authorId representing the ID of the author to be removed.
        /// </summary>
        /// <returns> Returns an 'HTTP 200 OK' response indicating that the operation was successful. </returns>

        [HttpDelete("RemoveAuthor")]
        public IActionResult RemoveAuthor(int authorId)
        {
            authorService.RemoveAuthor(authorId);
            return Ok();
        }
        /// <summary>
        /// Calls the 'UptadeAuthor' method of the 'authorService' to update the author's information in the system.
        /// It takes an 'AuthorEntity' object author as a parameter representing the updated information of the author.
        /// 'authorService.UpdateAuthor(author)' calls the 'UpdateAuthor' method of the 'authorService' object, passing the author object to update the author's information.
        /// </summary>
        /// <returns> Returns an 'HTTP 200 OK' response indicating that the operation was successful. </returns>

        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(AuthorEntity author)
        {
            authorService.UpdateAuthor(author);
            return Ok();
        }
        /// <summary>
        /// It takes an 'AuthorEntity' object author as a parameter representing the author to be deleted. 
        /// 'authorService.DeleteAuthor(author)' calls the 'DeleteAuthor' method  passing the author object to delete the author from the system.
        /// </summary>
        /// <returns> Returns an 'HTTP 200 OK' response indicating that the operation was successful. </returns>

        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor(AuthorEntity author)
        {
            authorService.DeleteAuthor(author);
            return Ok();
        }
    }
}
///<summary>
///'GetAuthorById' Retrieves an author by their ID.
///'GetAuthorByFirstName' Retrieves an author by their first name.
///'GetAuthorByLastName' Retrieves an author by their last name. 
///'GetAuthorByNickName' Retrieves an author by their nickname. 
///'AddAuthor' Adds a new author to the system.
///'RemoveAuthor' Removes an author from the system by their ID. 
///'UpdateAuthor Updates an existing author's information. 
///'DeleteAuthor' Deletes an author from the system.
/// </summary>