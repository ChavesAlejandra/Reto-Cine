using Microsoft.AspNetCore.Mvc;
using back.Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class MenuController : ControllerBase
{
    private static List<Menu> menus = DataGen();

    public static List<Menu> DataGen ()
    {
        List<Menu> genMenu = 
        [
            
        ];

        return genMenu;
    }
}