Module Module1

    Sub Main()

        Console.WriteLine("1 for factorial" & vbCrLf &
                          "2 for fibonacci" & vbCrLf &
                          "3 for McCarthy91" & vbCrLf &
                            "4 for McCarthy91 between -250 to 250" & vbCrLf &
                            "5 for palindrome" & vbCrLf &
                            "6 for Character counter")

        Dim n As Integer = Console.ReadLine()
        Dim m As Integer

        Select Case n
            Case 1
                factorial(m)
            Case 2
                fibonacci_principal()
            Case 3
                Mccarthy91()
            Case 4
                Mccarthy91For()
            Case 5
                palindrome()
            Case 6
                character_counter()
        End Select

    End Sub

    Function factorial(ByVal n As Integer) As Integer
        n = Console.ReadLine()
        If n <= 1 Then
            Return 1
        Else
            Return factorial(n - 1) * n
        End If
    End Function

    Function fibonacci_principal()
        Dim m As Integer = 0
        Console.WriteLine("Introduce nth number")
        m = Console.ReadLine

        For i As Integer = 0 To m
            Console.WriteLine(Fibonacci(i))
        Next
    End Function


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

    Function Mccarthy91()
        Console.WriteLine("introduce a number")
        Dim x As Integer = Console.ReadLine()

        Do While x
            If x > 100 Then
                x = x - 10
            ElseIf x <= 100 Then
                x = x + 10
            ElseIf x <= 100 Then
                x = x + 10
            End If
            Console.WriteLine(x)
        Loop

    End Function

    Function Mccarthy91For()
        Console.WriteLine("between -250 and 250")
        Dim x As Integer

        For x = -250 To 250
            If x > 100 Then
                x = x - 10
            ElseIf x <= 100 Then
                x = x + 10
            ElseIf x <= 100 Then
                x = x + 10
            End If
            Console.WriteLine(x)
        Next
    End Function

    Function palindrome()
        Dim Word As String
        Console.WriteLine("introduce word")
        Word = Console.ReadLine
        Dim MidPoint As Integer = Word.Length / 2

        For i As Integer = 0 To MidPoint
            If Word.Chars(i) <> Word.Chars((Word.Length - 1) - i) Then
                Console.WriteLine("No Match")

            End If
        Next
        Console.WriteLine("Word is a Palindrome")
    End Function



    Function character_counter()
        Console.WriteLine("introduce a word")
        Dim word As String = Console.ReadLine()
        Console.WriteLine("select a letter")
        Dim letter As String = Console.ReadLine()
        Dim count As Integer

        For i = (Len(word)) To 1 Step -1
            If Mid$(word, i, 1) = letter Then
                count = count + 1
            End If
        Next
        Console.WriteLine(count)





    End Function
End Module


