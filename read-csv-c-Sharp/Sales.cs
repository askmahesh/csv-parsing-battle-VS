using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var startTime = DateTime.Now;

        using (var reader = new StreamReader("sales_data.csv"))
        {
            var totalSales = 0.0;

            var toplSales = 0.0;
            var toplProd = "";

            var productSales = new Dictionary<string, double>();

            // Skip header
            reader.ReadLine();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var productId = values[1];
                var quantity = int.Parse(values[2]);
                var price = double.Parse(values[3]);
                var total = quantity * price;

                totalSales += total;
                if (!productSales.ContainsKey(productId))
                {
                    productSales[productId] = 0;
                }

                productSales[productId] += total;
                if (toplSales < productSales[productId])
                {
                    toplSales = productSales[productId];
                    toplProd = productId;
                }
            }


            var endTime = DateTime.Now;
            var executionTime = (endTime - startTime).TotalSeconds;

            Console.WriteLine($"C# Execution time: {executionTime} seconds");
            Console.WriteLine($"Total Sales: ${totalSales}");
            Console.WriteLine($"Top Product: {toplProd} with sales ${toplSales}");

        }
    }
}

