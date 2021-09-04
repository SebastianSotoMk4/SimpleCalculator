'Sebastian Soto
'RCET0265
'Fall 2021
'SimpleCalculator
'
Option Strict On
Option Explicit On
Module SimpleCalculator
    Sub Main()
        Dim optOne As String
        Dim optTwo As String
        Dim optPos As String

        Console.WriteLine("Enter Number")
        optOne = Console.ReadLine()
        Console.WriteLine("Another one")
        optTwo = Console.ReadLine()

        Dim numOne As Integer = CInt(optOne)
        Dim numTwo As Integer = CInt(optTwo)

        Console.WriteLine("Product(*) or Sum(+)?")
        optPos = Console.ReadLine()
        If optPos = "+" Then
            Console.WriteLine(numTwo + numOne)
        ElseIf optPos = "*" Then
            Console.WriteLine(numTwo * numOne)
        End If
        Console.ReadLine()
    End Sub
End Module
