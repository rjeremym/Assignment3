using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal class FoodItem
    {
        // initialize food info
        public string FoodName = "";
        public string FoodCategory = "";
        public int FoodQuantity = 0;
        public DateOnly ExpirationDate;

        // constructor
        public FoodItem(string name, string category, int quantity, DateOnly expDate)
        {
            FoodName = name;
            FoodCategory = category;
            FoodQuantity = quantity;
            ExpirationDate = expDate;
        }

        public void PrintFoodInfo()
        {
            Console.WriteLine($"Name: {FoodName}, Category: {FoodCategory}, Quantity: {FoodQuantity}, Expiration Date: {ExpirationDate}");
        }
    }
}
