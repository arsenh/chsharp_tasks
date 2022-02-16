﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_web.Models;

namespace Task_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IList<TestModel> _testModels;

        public TestController(IList<TestModel> testModels)
        {
            _testModels = testModels;
        }


        /*
         *
         * необходимо релизовать CRUD для testModels
         *
         */

        // Read all
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTestModels()
        {
            return Ok(_testModels);
        }

        // Read by ID
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetTestModelById(Guid id)
        {
            var model = _testModels.SingleOrDefault(x => x.Id == id);
            if (null != model)
            {
                return Ok(model);
            }
            return NotFound($"TestModel with Id:{id} was not found.");
        }

        // Create
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddTestModel(TestModel model)
        {
            model.Id = Guid.NewGuid();
            _testModels.Add(model);
            return Ok(model);
        }

        // Delete
        //[HttpGet]
        //[Route("api/[controller]/{id}")]
        //public IActionResult DeleteTestModelById(Guid id)
        //{

        //}


        // Update
        //[HttpGet]
        //[Route("api/[controller]/{id}")]
        //IActionResult EditTestModelById(Guid id)
        //{

        //}
    }
}
