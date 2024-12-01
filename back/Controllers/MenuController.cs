using Microsoft.AspNetCore.Mvc;
using back.Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class MenuController : ControllerBase
{
    public static List<Menu> menus = DataGen();

    public static List<Menu> DataGen ()
    {
        List<Menu> genMenus = 
        [
            new Menu("Menu Normal", 8, "MenuNormal.jpg"),
            new Menu("Menu Doble Coca-Cola", 16, "MenuDobleCola.jpg"),
            new Menu("Menu Doble Pop Corn", 19, "MenuDoblePopCorn.jpg"),
            new Menu("Pop Corn Normal", 6, "MenuPopCorn.jpg"),
            new Menu("Coca-Cola", 3, "MenuCola.jpg")
        ];

        return genMenus;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Menu>> GetMenus(){ return Ok(menus);}

    [HttpGet("id/{id}")]
    public ActionResult<IEnumerable<Menu>> GetMenusId (int id)
    {
        List<Menu> filteredMenus = new List<Menu>();
        menus.ForEach(el => //el = Element
        {
            if (el._id.Equals(id)) {filteredMenus.Add(el);}
        });

        if(filteredMenus.ToArray().Length == 0) {return NotFound();}
        return Ok(filteredMenus);
    }
}