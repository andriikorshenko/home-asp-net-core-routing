using Microsoft.AspNetCore.Mvc;

namespace Task_001.Controllers
{
    public class ProductsController : Controller
    {
        private Warehouse? _warehouse;
        private List<Warehouse>? _inventory;        

        public ProductsController()
        {
            _warehouse = new();
            _inventory = _warehouse.ReadAsJsonFormat<List<Warehouse>>("warehouse.json");
        }

        [Route("")]
        [Route("products/list/{category?}")]
        public IActionResult List(string? category)
        {
            if (category == "pc")
            {
                var linq = from p in _inventory where p.Category == "PC" select p;
                return View(linq as object);
            }
            else if (category == "office")
            {
                var linq = from p in _inventory where p.Category == "Office" select p;
                return View(linq as object);
            }
            return View(_inventory as object);
        }        
    }
}
