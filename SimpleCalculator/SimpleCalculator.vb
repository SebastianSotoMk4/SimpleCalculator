'Sebastian Soto
'RCET0265
'Fall 2021
'SimpleCalculator
'https://github.com/SebastianSotoMk4/SimpleCalculator.gitoo
Option Strict On
Option Explicit On
Module SimpleCalculator
    Sub Main()
        Dim optOne As String
        Dim optTwo As String
        Dim optPos As String
        Dim result As Integer
        'Ask for numbers
        Console.WriteLine("Enter Number")
        optOne = Console.ReadLine()
        Console.WriteLine("Another one")
        optTwo = Console.ReadLine()
        'convert string number to intiger
        Dim numOne As Integer = CInt(optOne)
        Dim numTwo As Integer = CInt(optTwo)
        'Ask for operator and display answer
        Console.WriteLine("Product(*) or Sum(+)?")
        optPos = Console.ReadLine()
        If optPos = "+" Then
            result = numTwo + numOne
        ElseIf optPos = "*" Then
            result = numTwo * numOne
        End If
        Console.WriteLine("Answer is " & result)
        '
        Console.ReadLine()
    End Sub
End Module
