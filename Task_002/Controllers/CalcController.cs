using Microsoft.AspNetCore.Mvc;

namespace Task_002.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int x, int y)
            => View("Result", x + y);
        

        public IActionResult Mul(int x, int y)        
            => View("Result", x * y);
        

        public IActionResult Div(int x, int y)        
            => y == 0 ? BadRequest("Divide by zero!") : View("Result", x / y);
        

        public IActionResult Sub(int x, int y)        
            => View("Result", x - y);        
    }
}
