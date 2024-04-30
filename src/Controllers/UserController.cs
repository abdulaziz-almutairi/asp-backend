using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;


public class UserController : CostumeController
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }


    [HttpPatch("{email}")]
    public User? UpdateOne(string email, [FromBody] User user)
    {
        return _userService.UpdateOne(email, user);
    }

    [HttpGet]
    public List<User> FindAll()
    {
        return _userService.FindAll();
    }

    [HttpGet("{email}")]
    public User? FindOne(string email)
    {
        return _userService.FindOneByEmail(email);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<User> CreateOne([FromBody] User user)
    {
        // PS. when you create a resource you should return that new resrouce only
        if (user is not null)
        {
            var createdUser = _userService.CreateOne(user);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();

    }
}