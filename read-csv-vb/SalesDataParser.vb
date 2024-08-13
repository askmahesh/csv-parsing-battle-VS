Imports System
Imports System.Collections.Generic
Imports System.IO

Module Program
    Sub Main()
        Dim startTime As DateTime = DateTime.Now

        Using reader As New StreamReader("C:\compilers\sales_data.csv")
            Dim totalSales As Double = 0.0

            Dim toplSales As Double = 0.0
            Dim toplProd As String = ""

            Dim productSales As New Dictionary(Of String, Double)()

            ' Skip header
            reader.ReadLine()
            Dim line As String


            While (Not reader.EndOfStream)
                line = reader.ReadLine()

                Dim values() As String = line.Split(","c)
                Dim productId As String = values(1)
                Dim quantity As Integer = Integer.Parse(values(2))
                Dim price As Double = Double.Parse(values(3))
                Dim total As Double = quantity * price

                totalSales += total
                If Not productSales.ContainsKey(productId) Then
                    productSales(productId) = 0
                End If

                productSales(productId) += total
                If toplSales < productSales(productId) Then
                    toplSales = productSales(productId)
                    toplProd = productId
                End If
            End While

            Dim sortedProductSales As New SortedDictionary(Of String, Double)(productSales)
            Dim topProduct As String = "5"

            Dim endTime As DateTime = DateTime.Now
            Dim executionTime As Double = (endTime - startTime).TotalSeconds

            Console.WriteLine($"VB.NET Execution time: {executionTime} seconds")
            Console.WriteLine($"Total Sales: ${totalSales}")
            Console.WriteLine($"Top Product: {toplProd} with sales ${toplSales}")
        End Using
    End Sub
End Module

