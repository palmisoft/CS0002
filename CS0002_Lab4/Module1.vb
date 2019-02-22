Imports System.Math
Module Module1

    Sub Main()
        Console.WriteLine("1 for 4.2.3 text functions" & vbCrLf &
                          "2 for 4.3.1 Local and globarl variables, scope and side effects" & vbCrLf &
                          "3 for 4.3.2 writing user defined functions" & vbCrLf &
                          "4 for a function that calculates the days of any month in a chosen year" & vbCrLf &
                          "5 for The fibonacci Sequence")


        Dim n As Integer = Console.ReadLine()

        Select Case n
            Case 1
                text_functions()
            Case 2
                user_defined_functions()
            Case 3
                writing_user_defined_functions_even_odd()
                writing_user_defined_functions_reverse_string()
                writing_user_defined_functions_lap_year(n)
                writing_user_defined_functions_days_in_a_month()

            Case 4
                writing_user_defined_functions_days_alive()
            Case 5
                fibonacci_principal()
        End Select

    End Sub
    Function text_functions()
        Dim x As Double = 123.456
        Dim y As Double = 17 / 3
        Dim z As Decimal = Sqrt(2)
        Dim a As String = "Hello"
        Dim b As String = "world"

        Console.WriteLine("1) " & Format(y, ".000"))

        Console.WriteLine("2) " & InStr(x, 3) & ", " & InStr(y, 5) & ", " & InStr(z, 1))

        Console.Write("3) ")
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String

        For i = 5 To 1 Step -1
            c1 = Mid(a, i, 1)
            Console.Write(c1)
        Next

        Console.Write(" ")

        For i = 5 To 1 Step -1
            c2 = Mid(b, i, 1)
            Console.Write(c2)
        Next



    End Function

    Function user_defined_functions()

        Dim v1 As Double, v2 As Double
        v1 = 10.2
        v2 = 0
        Console.WriteLine("Before v1 =" + Str$(v1))
        Console.WriteLine("Before v2 =" + Str$(v2))
        v2 = TestLocal(v1)
        Console.WriteLine("After v1 =" + Str$(v1))
        Console.WriteLine("After v2 =" + Str$(v2))

    End Function

    Function TestLocal(ByVal p1 As Double) As Double
        Dim loc1 As Double
        loc1 = p1 + 100
        p1 = 1234
        Console.WriteLine("Within p1 =" + Str$(p1))
        Console.WriteLine("Within loc1 =" + Str$(loc1))
        TestLocal = loc1
    End Function

    Function writing_user_defined_functions_even_odd()
        Console.WriteLine("EVEN ODD ")

        Dim i As Long, eo As Boolean, s As String
        For i = 1 To 25
            eo = evenodd(i)
            If eo = True Then
                s = "even"
            Else
                s = "Odd"
            End If
            Console.WriteLine(Str(i) + " is " + s)
        Next i


    End Function
    Function evenodd(ByVal x As Long) As Boolean

        If x Mod 2 = 0 Then
            x = True
        Else
            x = False
        End If
        evenodd = x
    End Function

    Function writing_user_defined_functions_reverse_string()
        Console.WriteLine("REVERSE STRING")
        Console.WriteLine("introduce a word")
        Dim n As String = Console.ReadLine()
        Dim c1 As String

        For i = Len(n) To 1 Step -1
            c1 = Mid(n, i, 1)
            Console.Write(c1)
        Next
        Console.Write(vbCrLf)

    End Function

    Function writing_user_defined_functions_lap_year(ByVal x As Integer) As Boolean
        Console.WriteLine("introduce a desired year")

        Dim n As Integer = Console.ReadLine()
        If n Mod 4 <> 0 Then
            Console.WriteLine("common year")
        ElseIf n Mod 100 <> 0 Then
            x = True
            Console.WriteLine("leap year")
        ElseIf n Mod 400 <> 0 Then
            x = False
            Console.WriteLine("common year")
        Else
            x = True
            Console.WriteLine("leap year")
        End If
        writing_user_defined_functions_lap_year = x

    End Function

    Function writing_user_defined_functions_days_in_a_month()
        Dim y As Integer
        Dim x As Boolean
        x = writing_user_defined_functions_lap_year(y)

        Console.WriteLine("introduce the number of the month")
        Dim m As Integer = Console.ReadLine()

        Select Case x
            Case True
                If m Mod 2 = 0 And m <> 2 Then
                    Console.WriteLine("it has 30 days")
                ElseIf m = 2 Then
                    Console.WriteLine("it has 29 days")
                Else
                    Console.WriteLine("it has 31 days")
                End If
            Case False
                If m Mod 2 = 0 And m <> 2 Then
                    Console.WriteLine("it has 30 days")
                ElseIf m = 2 Then
                    Console.WriteLine("it has 29 days")
                Else
                    Console.WriteLine("it has 31 days")
                End If
        End Select

    End Function


    Function writing_user_defined_functions_days_alive()
        Console.WriteLine("introduce a day")
        Dim d As Integer = Console.ReadLine()
        Console.WriteLine("introduce a month")
        Dim m As Integer = Console.ReadLine()
        Console.WriteLine("introduce a year")
        Dim y As Integer = Console.ReadLine()

        Dim count1 As Integer
        Dim count2 As Integer
        Dim countm As Integer
        Dim counth As Integer

        Dim x As Boolean

        Dim thisday As Integer = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Dim thismonth As Integer = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dim thisyear As Integer = Microsoft.VisualBasic.DateAndTime.Year(Now)

       
        For i = (thisyear - 1) To 1992 Step -1
            If writing_user_defined_functions_lap_year2(i) = True Then
                count1 = count1 + 366
            Else
                count2 = count2 + 365
            End If
        Next

        Select Case writing_user_defined_functions_lap_year2(1991)
            Case True
                For h = 9 To 12 Step 1
                    If h Mod 2 = 0 And h Mod 2 <> 0 Then
                        counth = counth + 30
                    ElseIf h = 2 Then
                        counth = counth + 29
                    Else
                        counth = counth + 30
                    End If
                Next
            Case False
                For h = 8 To 12 Step 1
                    If h Mod 2 = 0 And h Mod 2 <> 0 Then
                        counth = counth + 30
                    ElseIf h = 2 Then
                        counth = counth + 28
                    Else
                        counth = counth + 30
                    End If

                Next

        End Select



        Select Case x = writing_user_defined_functions_lap_year2(thisyear)
            Case True
                For j = (thismonth - 1) To 1 Step -1
                    If j Mod 2 = 0 And j Mod 2 <> 0 Then
                        countm = countm + 30
                    ElseIf j = 2 Then
                        countm = countm + 29
                    Else
                        countm = countm + 30
                    End If
                Next
            Case False
                For j = (thismonth - 1) To 1 Step -1
                    If j Mod 2 = 0 And j Mod 2 <> 0 Then
                        countm = countm + 30
                    ElseIf j = 2 Then
                        countm = countm + 28
                    Else
                        countm = countm + 30
                    End If
                Next
        End Select


        Console.WriteLine(count1 + count2 + countm + thisday + counth + 27)


    End Function

    Function writing_user_defined_functions_lap_year2(ByVal x As Integer) As Boolean
        Dim n As Integer = x
        If n Mod 4 <> 0 Then

        ElseIf n Mod 100 <> 0 Then
            x = True

        ElseIf n Mod 400 <> 0 Then
            x = False

        Else
            x = True

        End If
        writing_user_defined_functions_lap_year2 = x

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

End Module
