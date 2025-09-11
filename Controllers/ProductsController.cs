using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GitHubCICD.Data;

namespace GitHubCICD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProductsController(AppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(context.Employees.ToList());
        }

    }
}