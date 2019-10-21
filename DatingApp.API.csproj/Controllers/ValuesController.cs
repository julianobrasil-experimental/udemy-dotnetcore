﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.csproj.Data;
using DatingApp.API.csproj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.csproj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        private readonly ILogger<ValuesController> _logger;

        private readonly DataContext _context;

        public ValuesController(DataContext x, ILogger<ValuesController> logger)
        {
            this._context = x;
            this._logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await this._context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id) {
          var value = await this._context.Values.FirstOrDefaultAsync(x => x.Id == id);

          return Ok(value);
        }
    }
}
