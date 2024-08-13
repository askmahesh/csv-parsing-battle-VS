import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.Dictionary;
import java.util.HashMap;
import java.util.Map;
import java.util.SortedMap;
import java.util.TreeMap;

public class SalesDataParser {
    public static void main(String[] args) {
        long startTime = System.currentTimeMillis();

        try (BufferedReader reader = new BufferedReader(new FileReader("C:\\compilers\\sales_data.csv"))) {
            double totalSales = 0.0;

            double toplSales = 0.0;
            String toplProd = "";

            Map<String, Double> productSales = new HashMap<>();

            // Skip header
            reader.readLine();
            String line;
            while ((line = reader.readLine()) != null) {
                String[] values = line.split(",");
                String productId = values[1];
                int quantity = Integer.parseInt(values[2]);
                double price = Double.parseDouble(values[3]);
                double total = quantity * price;

                totalSales += total;
                productSales.putIfAbsent(productId, 0.0);
                productSales.put(productId, productSales.get(productId) + total);
                if (toplSales < productSales.get(productId)) {
                    toplSales = productSales.get(productId);
                    toplProd = productId;
                }
            }

            SortedMap<String, Double> sortedProductSales = new TreeMap<>(productSales);
            String topProduct = "5";

            long endTime = System.currentTimeMillis();
            double executionTime = (endTime - startTime) / 1000.0;

            System.out.printf("Java Execution time: %.2f seconds%n", executionTime);
            System.out.printf("Total Sales: $%.2f%n", totalSales);
            System.out.printf("Top Product: %s with sales $%.2f%n", toplProd, toplSales);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

