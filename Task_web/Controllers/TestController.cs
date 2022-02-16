using System;
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
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTestModels()
        {
            return Ok(_testModels);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetTestModelById(Guid id)
        {

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddTestModel(TestModel model)
        {
            model.Id = Guid.NewGuid();
            _testModels.Add(model);
            return Ok(model);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteTestModelById(Guid id)
        {

        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        IActionResult EditTestModelById(Guid id)
        {

        }
    }
}
