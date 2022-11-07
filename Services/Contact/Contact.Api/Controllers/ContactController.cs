﻿using Contact.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Getir()
        {
            return Ok("calisti");
        }


        //[HttpGet]
        //public async Task<IActionResult> GetContactById(int id)
        //{
        //    var result = await contactService.GetById(id);
        //    return Ok(result);
        //}
    }
}
