using System;

class Menu
{
    string appetizer;
    string maincourse;
    string dessert;

    public string Appetizer
    {
        get { return appetizer; }
        set { appetizer = value; }
    }

    public string MainCourse
    {
        get { return maincourse; }
        set { maincourse = value; }
    }

    public string Dessert
    {
        get { return dessert; }
        set { dessert = value; }
    }
}

class MenuItem
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Appetizer = "Fried Calamari";
        menu.MainCourse = "Steak & Lobster";
        menu.Dessert = "Cherry Cheesecake";

        System.Console.WriteLine("Appetizer \n$8");
        System.Console.WriteLine("Calamari rings are breaded and fried until golden for a delightful appetizer. \nServed with spicy mayonnaise - " +menu.Appetizer);
       
        System.Console.WriteLine("Main Course \n$60");
        System.Console.WriteLine("Steamed Lobster served over a layer of garlic and butter. \n20oz. cut of our juicy, flavorful ribeye served on the bone for extra flavor - " + menu.MainCourse);
        
        System.Console.WriteLine("Dessert \n$5");
        System.Console.WriteLine("Thick velvety smooth cream cheese batter baked in a sweet \ngraham craker crust - " +menu.Dessert);
    }
}