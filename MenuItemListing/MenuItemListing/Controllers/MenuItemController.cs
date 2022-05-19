using MenuItemListing.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,POC")]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id = 1, Name ="Phone", Active=true,Price=5000, DateOfLaunch= new DateTime(2022,05,17), FreeDelivery=false},
                new MenuItem() {Id = 2, Name ="Laptop", Active=false,Price=15000, DateOfLaunch= new DateTime(2022,03,03), FreeDelivery=false}
            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id = 1, Name ="Phone", Active=true,Price=5000, DateOfLaunch= new DateTime(2022,05,17), FreeDelivery=false},
                new MenuItem() {Id = 2, Name ="Laptop", Active=false,Price=15000, DateOfLaunch= new DateTime(2022,03,03), FreeDelivery=false}
            };
            MenuItem item = MenuList.SingleOrDefault(x => x.Id == id);
            return item;
        }
    }
}
