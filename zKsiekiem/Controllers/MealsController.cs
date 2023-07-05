using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zKsiekiem.Models;
using zKsiekiem.Services;

namespace zKsiekiem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly IMealService _mealService;

        public MealsController(IMealService mealService)
        {
            _mealService = mealService;
        }
        [HttpGet("GetAllMeals")]
        public IActionResult GetAllMeals() {
            var result = _mealService.GetAllMeals();
            return Ok(result);
        }

        [HttpPost("AddMeal")]
        public IActionResult AddMeal(Meal meal)
        {
            _mealService.AddMeal(meal);
            return Ok();
        }

        [HttpPut("UpdateMeal")]
        public IActionResult UpdateMeal(int id, Meal meal)
        {
            _mealService.UpdateMeal(id, meal);
            return Ok();
        }

        [HttpDelete("DeleteMeal")]
        public IActionResult DeleteMeal(int id)
        {
            _mealService.DeleteMeal(id);
            return Ok();
        }

        [HttpGet("GetSingleMeal")]
        public IActionResult GetSingleMeal(int id)
        {
            var singleMealToReturn = _mealService.GetSingleMeal(id);
            return Ok(singleMealToReturn);
        }


    }
}
