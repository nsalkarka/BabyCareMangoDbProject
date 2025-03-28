using BabyCareMangoDbProject.Dtos.ProductDtos;
using BabyCareMangoDbProject.Services.InstructorServices;
using BabyCareMangoDbProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BabyCareMangoDbProject.Areas.Admin.Controllers
{
    public class ProductController(IProductService _productService, IInstructorService _ınstructorService) : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            var values=await _productService.GetAllAsync();
            return View(values);
        }
        public async Task<IActionResult> DeleteProduct(string id)

        {
            await _productService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateProduct()
        {
            var instructors= await _ınstructorService.GetAllInstructorAsync();
            ViewBag.instructors= (from x in instructors 
                                  select new SelectListItem
                                  {
                                      Text=x.FullName,
                                      Value=x.FullName
                                  }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateAsync(createProductDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateProduct(string id)
        {
            var instructors = await _ınstructorService.GetAllInstructorAsync();
            ViewBag.instructors = (from x in instructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();
            var value=await _productService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateAsync(updateProductDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
