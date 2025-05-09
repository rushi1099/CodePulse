using CodePulse.api.Data;
using CodePulse.api.Models.Domain;
using CodePulse.api.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private  readonly ApplicationDbContext dbContext;

        public CategoriesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
                
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategpryRequest request)
        {
            //MApt DTO to  Domain class
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();


            //map Domain to DTO
            var responce = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(responce);
        }

    }
}
