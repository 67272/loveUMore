using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // storzone categorie wczesnie z predefinowane
        // jak chcesz dodac tworzenie wlasne to muszisz tylko troche zmieinc helpera, adding expeneses i 
        // tutaj zmienic troche jedna methode chyba ze chcesz bez walidacji
        public static readonly Category Food = new Category(1, "Food");
        public static readonly Category Transportation = new Category(2, "Transportation");
        public static readonly Category Utilities = new Category(3, "Utilities");
        public static readonly Category Other = new Category(4, "Other");

        private Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        

       

        // lista z kategorami wyzej zrobionymi
        public static List<Category> PredefinedCategories()
        {
            return new List<Category> { Food, Transportation, Utilities, Other };
        }

        // tak o dodane 
        public static bool IsValidCategoryId(int categoryId)
        {
            return PredefinedCategories().Any(category => category.Id == categoryId);
        }

        //zwraca wartosc podanej categori tego 
        public static Category GetCategoryById(int categoryId)
        {
            // nie wiem czemu nie dziala tak to gowno
            // musze uzyc methody ktora i tak zwraca liste a nie moge samej listy nie ogarniam 
           // var list = PredefinedCategories();
            
            return PredefinedCategories().FirstOrDefault(category => category.Id == categoryId);
        }

    }
}
