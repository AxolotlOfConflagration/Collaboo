﻿using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUsersServices _usersServices;
        private readonly IMapper _mapper;

        public UsersController(IUsersServices usersServices, IMapper mapper)
        {
            _usersServices = usersServices;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetUser()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var login = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
                    var credentials = new Credentials(await HttpContext.GetTokenAsync("access_token"));

                    return await _usersServices.GetAuthUserAsync(login, credentials);
                }
                else
                {
                    return BadRequest("Authentication Exception");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{id}/skill")]
        public async Task<IActionResult> AddUserSkill(int id, [FromBody] AddUserSkillDTO skill)
        {
            try
            {
                //if (User.Identity.IsAuthenticated)
                {
                    //var login = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
                    //var credentials = new Credentials(await HttpContext.GetTokenAsync("access_token"));

                    //var user = _usersServices.GetUserAsync(login);

                    //if (user.Id != id)
                    //    throw new Exception("Authentication Exception: User not authorize to change other user Id");

                    await _usersServices.AddUserSkillAsync(skill, id);

                    return NoContent();
                }
                //else
                //{
                //    return BadRequest("Authentication Exception");
                //}
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        [HttpGet("{login}")]
        public async Task<ActionResult<UserDTO>> GetUserByLogin(string login)
        {
            try
            {
                return await _usersServices.GetUserAsync(login);
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            try
            {
                return await _usersServices.GetUserAsync(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
    }
}

