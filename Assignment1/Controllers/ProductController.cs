using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("Product/{prod_name?}")]
        public string GetProduct([FromRoute] string prod_name =
            "Not Avaliable")
        {
            return $"{prod_name}";
        }

        [HttpPost("ProductType")]
        public string AddProduct(Products product_Type)
        {
            return product_Type.prod_type;
        }
    }
}
