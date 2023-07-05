using zKsiekiem.Models;

namespace zKsiekiem.Services
{
    public interface IMealService
    {
        List <Meal> GetAllMeals();
        Meal GetSingleMeal(int id);
        
        void AddMeal(Meal meal);    
        void DeleteMeal(int id);    
        void UpdateMeal(int id, Meal meal);

    }
}
