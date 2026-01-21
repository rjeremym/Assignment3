using Assignment3;

// initialize list of food items
List<FoodItem> foodItems = new List<FoodItem>();

Console.WriteLine("Welcome to the Food Bank Inventory System!");

// run a loop until continue is false
bool continueProgram = true;

while (continueProgram == true)
{
    Console.WriteLine("What would you like to do?\n" +
        "\nAdd Food Items: 0" +
        "\nDelete Food Items: 1" +
        "\nPrint List of Current Food Items: 2" +
        "\nExit the program: 3\n" +
        "\n(Enter a number): ");

    int choice;

    // error handling
    // convert input to int and then make sure it's between 0 and 3
    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 3.");
        continue;
    }

    // if input valid, continue loop
    else
    {
        // add food item
        if (choice == 0)
        {
            // prompt user for food info

            // get food name
            Console.WriteLine("Enter food name: ");
            string name = Console.ReadLine();

            // get food category
            Console.WriteLine("Enter food category: ");
            string category = Console.ReadLine();

            // get food quantity
            Console.WriteLine("Enter food quantity: ");

            // make sure they entered a number, and also save it to quantity variable
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                continue;
            }

            // get date
            Console.WriteLine("Enter expiration date (MM/dd/yyyy): ");

            // make sure they entered a valid date, and also save it to expDate variable
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly expDate))
            {
                Console.WriteLine("Invalid date format. Please use MM/dd/yyyy.");
                continue;
            }

            // then call constructor to make new food item
            FoodItem newFoodItem = new FoodItem(name, category, quantity, expDate);

            // add new food item to list
            foodItems.Add(newFoodItem);

            Console.WriteLine("Added " + name + " to list.\n");
        }

        // delete food item
        else if (choice == 1)
        {
            // prompt user for name of food item to delete
            Console.WriteLine("Enter the name of the item you would like to delete: ");
            string itemToDelete = Console.ReadLine();

            // remove all items that match the name. store to int so that we know if any were removed
            int removedCount = foodItems.RemoveAll(item => item.FoodName == itemToDelete);

            if (removedCount > 0)
            {
                Console.WriteLine(itemToDelete + " deleted.\n");
            }
            else
            {
                Console.WriteLine("Item not found.\n");
            }
        }

        // print current list of food items
        else if (choice == 2)
        {
            Console.WriteLine("Food Item List: \n");
            for (int i = 0; i < foodItems.Count; i++)
            {
                // call printfoodinfo method for each food item
                foodItems[i].PrintFoodInfo();
            }
        }

        // exit program
        else if (choice == 3)
        {
            continueProgram = false;
            Console.WriteLine("Exiting program. Goodbye!");
        }
    }



}
