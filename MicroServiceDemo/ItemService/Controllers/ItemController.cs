﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ItemService.Models;
using ItemService.Repositories;


namespace ItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IitemRepository _repo;
        public ItemController(IitemRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetItems")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllItems());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }

        [HttpGet]
        [Route("GetById/{id}")]

        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_repo.GetById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }



        [HttpPost]
        [Route("AddItem")]
        public IActionResult Post(Items item)
        {
            try
            {
                _repo.AddItem(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }

        }
        [HttpPut]
        [Route("updateitem")]
        public IActionResult Update(Items item)
        {
            try
            {
                _repo.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }


        }


        [HttpDelete]
        [Route("Deleteitem/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _repo.DeleteItem(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }


    }
}