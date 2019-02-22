Module Module1

    Function Fibonacci(ByVal n As Integer) As Integer

        Dim a As Integer = 0
        Dim b As Integer = 1

        ' Add up numbers.
        For i As Integer = 0 To n - 1
            Dim temp As Integer = a
            a = b
            b = temp + b
        Next
        Return a
    End Function
    Sub Main()
        ' Display first 10 Fibonacci numbers.
        Dim m As Integer = 0
        Console.WriteLine("Introduce nth number")
        m = Console.ReadLine

        For i As Integer = 0 To m
            Console.WriteLine(Fibonacci(i))
        Next
    End Sub
    

End Module
