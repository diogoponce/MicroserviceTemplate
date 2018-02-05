﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace project.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		private static ILogger<ValuesController> _logger;
		public ValuesController(ILogger<ValuesController> logger)
		{
			_logger = logger;
		}

		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			_logger.LogInformation("call method get");
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			_logger.LogInformation($"call method get with id {id}");
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
			_logger.LogInformation($"call method Post with value={value}");
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
			_logger.LogInformation($"call method Put with value={value}, id={id}");
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_logger.LogInformation($"call method Delete with id={id}");
		}
	}
}
