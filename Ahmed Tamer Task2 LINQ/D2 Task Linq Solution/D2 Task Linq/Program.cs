using day10_G01;
using System;
using System.Linq;
using System.IO;
using static day10_G01.ListGenerators;

namespace D2_Task_Linq
{
    internal class Program
    {
        static void Main()
        {

            #region  Restriction Operators 

            //// Q1: Find all products that are out of stock.
            //var result1 = ProductList.Where(p => p.UnitsInStock == 0);

            //Console.WriteLine("Out of Stock Products:");
            //foreach (var p in result1)
            //    Console.WriteLine(p);

            //Console.WriteLine(new string('-', 50));

            //// Q2: Find all products that are in stock and cost more than 3.00 per unit.
            //var result2 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //Console.WriteLine("In Stock & Cost > 3.00:");
            //foreach (var p in result2)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            //Console.WriteLine(new string('-', 50));

            //// Q3: Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result3 = Arr.Select((name, index) => new { Name = name, Index = index })
            //                 .Where(x => x.Name.Length < x.Index);

            //Console.WriteLine("Digits with name length < value:");
            //foreach (var d in result3)
            //    Console.WriteLine($"Digit: {d.Name}, Index: {d.Index}");

            #endregion

            #region  Element Operators 

            //// Q1: Get first Product out of Stock  
            //var result1 = ProductList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine("First product out of stock:");
            //Console.WriteLine(result1);

            //Console.WriteLine(new string('-', 50));

            //// Q2: Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result2 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine("First product price > 1000 or default:");
            //Console.WriteLine(result2?.ProductName ?? "No product found");

            //Console.WriteLine(new string('-', 50));

            //// Q3: Retrieve the second number greater than 5  
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = Arr.Where(n => n > 5)
            //                 .OrderBy(n => n)
            //                 .Skip(1)
            //                 .FirstOrDefault();

            //Console.WriteLine("Second number > 5:");
            //Console.WriteLine(result3);

            #endregion

            #region Aggregate Operators

            //// Q1: Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result1 = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine("Number of odd numbers in array:");
            //Console.WriteLine(result1);
            //Console.WriteLine(new string('-', 50));


            //// Q2: Return a list of customers and how many orders each has.
            //var result2 = CustomerList.Select(c => new { c.Name, OrdersCount = c.Orders.Count() });

            //Console.WriteLine("Customers and number of orders:");
            //foreach (var c in result2)
            //    Console.WriteLine($"{c.Name} - Orders: {c.OrdersCount}");
            //Console.WriteLine(new string('-', 50));


            //// Q3: Return a list of categories and how many products each has
            //var result3 = ProductList.GroupBy(p => p.Category)
            //              .Select(g => new { Category = g.Key, Count = g.Count() });

            //Console.WriteLine("Categories and number of products:");
            //foreach (var c in result3)
            //    Console.WriteLine($"{c.Category} - Products: {c.Count}");
            //Console.WriteLine(new string('-', 50));


            //// Q4: Get the total of the numbers in an array.
            //var result4 = Arr.Sum();

            //Console.WriteLine("Sum of numbers in array:");
            //Console.WriteLine(result4);
            //Console.WriteLine(new string('-', 50));


            //// Q5: Get the total number of characters of all words in dictionary_english.txt
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");

            //var result5 = dictionary.Sum(word => word.Length);

            //Console.WriteLine("Total number of characters in dictionary words:");
            //Console.WriteLine(result5);
            //Console.WriteLine(new string('-', 50));


            //// Q6: Get the total units in stock for each product category.
            //var result6 = ProductList.GroupBy(p => p.Category)
            //             .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

            //Console.WriteLine("Total units in stock per category:");
            //foreach (var c in result6)
            //    Console.WriteLine($"{c.Category} - Units: {c.TotalUnits}");
            //Console.WriteLine(new string('-', 50));


            //// Q7: Get the length of the shortest word in dictionary_english.txt
            //var result7 = dictionary.Min(word => word.Length);

            //Console.WriteLine("Length of shortest word:");
            //Console.WriteLine(result7);
            //Console.WriteLine(new string('-', 50));


            //// Q8: Get the cheapest price among each category's products
            //var result8 = ProductList.GroupBy(p => p.Category)
            //              .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });

            //Console.WriteLine("Cheapest price per category:");
            //foreach (var c in result8)
            //    Console.WriteLine($"{c.Category} - Min Price: {c.MinPrice}");
            //Console.WriteLine(new string('-', 50));


            //// Q9: Get the products with the cheapest price in each category (Use Let)
            //var result9 = ProductList.GroupBy(p => p.Category)
            //             .SelectMany(g =>
            //             {
            //                 var minPrice = g.Min(p => p.UnitPrice);
            //                 return g.Where(p => p.UnitPrice == minPrice)
            //                         .Select(p => new { p.Category, p.ProductName, p.UnitPrice });
            //             });

            //Console.WriteLine("Products with cheapest price per category:");
            //foreach (var p in result9)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //Console.WriteLine(new string('-', 50));


            //// Q10: Get the length of the longest word in dictionary_english.txt
            //var result10 = dictionary.Max(word => word.Length);

            //Console.WriteLine("Length of longest word:");
            //Console.WriteLine(result10);
            //Console.WriteLine(new string('-', 50));


            //// Q11: Get the most expensive price among each category's products.
            //var result11 = ProductList.GroupBy(p => p.Category)
            //              .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });

            //Console.WriteLine("Most expensive price per category:");
            //foreach (var c in result11)
            //    Console.WriteLine($"{c.Category} - Max Price: {c.MaxPrice}");
            //Console.WriteLine(new string('-', 50));


            //// Q12: Get the products with the most expensive price in each category.
            //var result12 = ProductList.GroupBy(p => p.Category)
            //               .SelectMany(g =>
            //               {
            //                   var maxPrice = g.Max(p => p.UnitPrice);
            //                   return g.Where(p => p.UnitPrice == maxPrice)
            //                           .Select(p => new { p.Category, p.ProductName, p.UnitPrice });
            //               });

            //Console.WriteLine("Products with most expensive price per category:");
            //foreach (var p in result12)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //Console.WriteLine(new string('-', 50));


            //// Q13: Get the average length of the words in dictionary_english.txt
            //var result13 = dictionary.Average(word => word.Length);

            //Console.WriteLine("Average word length:");
            //Console.WriteLine(result13);
            //Console.WriteLine(new string('-', 50));


            //// Q14: Get the average price of each category's products.
            //var result14 = ProductList.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });

            //Console.WriteLine("Average price per category:");
            //foreach (var c in result14)
            //    Console.WriteLine($"{c.Category} - Avg Price: {c.AvgPrice}");

            #endregion

            #region Ordering Operators

            //// Q1: Sort a list of products by name
            //var result1 = ProductList
            //    .OrderBy(p => p.ProductName);

            //Console.WriteLine("Q1: Products sorted by name:");
            //foreach (var p in result1)
            //    Console.WriteLine($"{p.ProductName}");
            //Console.WriteLine(new string('-', 50));


            //// Q2: Case-insensitive sort of words in an array
            //string[] Arr1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result2 = Arr1
            //    .OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("Q2: Words sorted case-insensitive:");
            //foreach (var w in result2)
            //    Console.WriteLine(w);
            //Console.WriteLine(new string('-', 50));


            //// Q3: Sort products by units in stock from highest to lowest
            //var result3 = ProductList
            //    .OrderByDescending(p => p.UnitsInStock);

            //Console.WriteLine("Q3: Products sorted by units in stock (desc):");
            //foreach (var p in result3)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //Console.WriteLine(new string('-', 50));


            //// Q4: Sort digits by length then alphabetically
            //string[] Arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result4 = Arr2
            //    .OrderBy(d => d.Length)
            //    .ThenBy(d => d);

            //Console.WriteLine("Q4: Digits sorted by length then name:");
            //foreach (var d in result4)
            //    Console.WriteLine(d);
            //Console.WriteLine(new string('-', 50));


            //// Q5: Sort words first by length then case-insensitive
            //string[] words1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result5 = words1
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("Q5: Words sorted by length then case-insensitive:");
            //foreach (var w in result5)
            //    Console.WriteLine(w);
            //Console.WriteLine(new string('-', 50));


            //// Q6: Sort products by category then price (desc)
            //var result6 = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //Console.WriteLine("Q6: Products sorted by category then price desc:");
            //foreach (var p in result6)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //Console.WriteLine(new string('-', 50));


            //// Q7: Sort words by length then case-insensitive descending
            //string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result7 = Arr3
            //    .OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("Q7: Words sorted by length then case-insensitive descending:");
            //foreach (var w in result7)
            //    Console.WriteLine(w);
            //Console.WriteLine(new string('-', 50));


            //// Q8: Digits whose second letter is 'i', reversed from original order
            //string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result8 = Arr4
            //    .Where(d => d.Length > 1 && d[1] == 'i')
            //    .Reverse();

            //Console.WriteLine("Q8: Digits with second letter 'i' reversed:");
            //foreach (var d in result8)
            //    Console.WriteLine(d);
            //Console.WriteLine(new string('-', 50));

            #endregion

            #region Transformation Operators

            //// Q1: Return a sequence of just the names of a list of products.
            //var productNames = ProductList
            //    .Select(p => p.ProductName);

            //Console.WriteLine("Q1: Product Names:");
            //foreach (var name in productNames)
            //    Console.WriteLine(name);
            //Console.WriteLine(new string('-', 40));


            //// Q2: Produce a sequence of the uppercase and lowercase versions of each word
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordVariants = words
            //    .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            //Console.WriteLine("Q2: Uppercase & Lowercase of Words:");
            //foreach (var w in wordVariants)
            //    Console.WriteLine($"Upper: {w.Upper}, Lower: {w.Lower}");
            //Console.WriteLine(new string('-', 40));


            //// Q3: Produce a sequence containing some properties of Products (Price renamed)
            //var productDetails = ProductList
            //    .Select(p => new
            //    {
            //        p.ProductName,
            //        p.Category,
            //        Price = p.UnitPrice
            //    });

            //Console.WriteLine("Q3: ProductName, Category, Price:");
            //foreach (var p in productDetails)
            //    Console.WriteLine($"{p.ProductName} - {p.Category} - {p.Price}");
            //Console.WriteLine(new string('-', 40));


            //// Q4: Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numberCheck = Arr
            //    .Select((value, index) => new { Number = value, InPlace = value == index });

            //Console.WriteLine("Q4: Number vs Position Match:");
            //foreach (var n in numberCheck)
            //    Console.WriteLine($"Number: {n.Number}, In-place? {n.InPlace}");
            //Console.WriteLine(new string('-', 40));


            //// Q5: Returns all pairs of numbers where a < b
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA
            //    .SelectMany(a => numbersB,
            //                (a, b) => new { A = a, B = b })
            //    .Where(x => x.A < x.B);

            //Console.WriteLine("Q5: Pairs where a < b:");
            //foreach (var p in pairs)
            //    Console.WriteLine($"{p.A} is less than {p.B}");
            //Console.WriteLine(new string('-', 40));


            //// Q6: Select all orders where the order total is less than 500.00.
            //var cheapOrders = CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.Total < 500.00);

            //Console.WriteLine("Q6: Orders with Total < 500:");
            //foreach (var o in cheapOrders)
            //    Console.WriteLine($"OrderID: {o.Id}, Total: {o.Total}");
            //Console.WriteLine(new string('-', 40));


            //// Q7: Select all orders where the order was made in 1998 or later.
            //var recentOrders = CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998);

            //Console.WriteLine("Q7: Orders from 1998 or later:");
            //foreach (var o in recentOrders)
            //    Console.WriteLine($"OrderID: {o.Id}, Date: {o.OrderDate:d}");
            //Console.WriteLine(new string('-', 40));

            #endregion


            #region Partitioning Operators

            //// Q1: Get the first 3 orders from customers in Washington
            //var result1 = CustomerList
            //    .Where(c => c.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //Console.WriteLine("Q1: First 3 orders from Washington:");
            //foreach (var order in result1)
            //    Console.WriteLine($"OrderID: {order.Id}, Total: {order.Total}");
            //Console.WriteLine(new string('-', 40));

            //// Q2: Get all but the first 2 orders from customers in Washington
            //var result2 = CustomerList
            //    .Where(c => c.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //Console.WriteLine("Q2: All but first 2 orders from Washington:");
            //foreach (var order in result2)
            //    Console.WriteLine($"OrderID: {order.Id}, Total: {order.Total}");
            //Console.WriteLine(new string('-', 40));

            //// Q3: Return elements starting from beginning until number < position
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = numbers
            //    .TakeWhile((n, index) => n >= index);

            //Console.WriteLine("Q3: TakeWhile n >= index:");
            //foreach (var n in result3)
            //    Console.WriteLine(n);
            //Console.WriteLine(new string('-', 40));

            //// Q4: Get elements starting from first divisible by 3
            //var result4 = numbers
            //    .SkipWhile(n => n % 3 != 0);

            //Console.WriteLine("Q4: SkipWhile until first divisible by 3:");
            //foreach (var n in result4)
            //    Console.WriteLine(n);
            //Console.WriteLine(new string('-', 40));

            //// Q5: Get elements starting from first element < position
            //var result5 = numbers
            //    .SkipWhile((n, index) => n >= index);

            //Console.WriteLine("Q5: SkipWhile until n < index:");
            //foreach (var n in result5)
            //    Console.WriteLine(n);
            //Console.WriteLine(new string('-', 40));

            #endregion

            #region Quantifiers Operators

            //// Q1: Determine if any of the words in dictionary contain 'ei'
            //string[] dictionary = System.IO.File.ReadAllLines("dictionary_english.txt");

            //bool result1 = dictionary.Any(word => word.Contains("ei"));
            //Console.WriteLine($"Q1: Any word contains 'ei'? {result1}");
            //Console.WriteLine(new string('-', 40));

            //// Q2: Return grouped list of products only for categories with at least one out-of-stock product
            //var result2 = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            //Console.WriteLine("Q2: Categories with at least one out-of-stock product:");
            //foreach (var group in result2)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var p in group)
            //        Console.WriteLine($"  Product: {p.ProductName}, Stock: {p.UnitsInStock}");
            //}
            //Console.WriteLine(new string('-', 40));

            //// Q3: Return grouped list of products only for categories with all products in stock
            //var result3 = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //Console.WriteLine("Q3: Categories with all products in stock:");
            //foreach (var group in result3)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var p in group)
            //        Console.WriteLine($"  Product: {p.ProductName}, Stock: {p.UnitsInStock}");
            //}
            //Console.WriteLine(new string('-', 40));

            #endregion






        }
    }
}
