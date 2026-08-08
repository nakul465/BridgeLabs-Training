using System;
namespace Generics
{
    public interface IMealPlan
    {
        bool Validate();
        void DisplayMeal();
    }

    public class VegetarianMeal : IMealPlan
    {
        public bool Validate()
        {
            return true;
        }

        public void DisplayMeal()
        {
            Console.WriteLine("Vegetarian meal: Paneer, Rice and Vegetables");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public bool Validate()
        {
            return true;
        }

        public void DisplayMeal()
        {
            Console.WriteLine("Vegan meal: Tofu, Rice and Vegetables");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public bool Validate()
        {
            return true;
        }

        public void DisplayMeal()
        {
            Console.WriteLine("Keto meal: Eggs, Chicken and Avocado");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public bool Validate()
        {
            return true;
        }

        public void DisplayMeal()
        {
            Console.WriteLine("High-protein meal: Chicken, Eggs and Paneer");
        }
    }

    public class Meal<T> where T : IMealPlan
    {
        public T MealPlan { get; set; }

        public Meal(T mealPlan)
        {
            MealPlan = mealPlan;
        }

        public void GenerateMeal()
        {
            MealPlan.DisplayMeal();
        }
    }

    public class MealGenerator
    {
        public void ValidateAndGenerate<T>(T meal) where T : IMealPlan
        {
            if (meal.Validate())
            {
                Console.WriteLine("Meal plan is valid.");
                meal.DisplayMeal();
            }
            else
            {
                Console.WriteLine("Meal plan is invalid.");
            }
        }
    }

}

