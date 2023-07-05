using zKsiekiem.Models;

namespace zKsiekiem.Services
{
    public class MealService : IMealService
    {
        List<Meal> meals = new List<Meal>{
           new Meal{Id=0, Name="Barszcz", Price=21.37},
            new Meal{Id=1, Name="Zurek", Price=49.37},
             new Meal{Id=2, Name="Schabowy", Price=11.37},
        };

        public void AddMeal(Meal meal)
        {
            meals.Add(meal);
        }

        public void DeleteMeal(int id)
        {
            meals.RemoveAll(meal => meal.Id == id);
        }

        public List<Meal> GetAllMeals()
        {
            return meals;
        }

        public Meal GetSingleMeal(int id)
        {
            var mealToReturn = meals.Find(meal => meal.Id == id);
            if (mealToReturn != null)
            {
                return mealToReturn;
            }
            else
            {
                throw new Exception("Nie znaleziono potrawy o tym id!");
            }
        }

        public void UpdateMeal(int id, Meal meal)
        {
            var mealToUpdate = meals.Find(meal => meal.Id == id);
            if (mealToUpdate != null)
            {
                mealToUpdate = meal;
            }
            else
            {
                throw new Exception("Nie znaleziono potrawy do zaktualizowania!");
            }
            
        }

    }
}
