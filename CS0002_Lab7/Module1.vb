Module Module1



    Sub Main()
        Console.WriteLine("1 for 7.2.1 Nnumber comparison flow chart" & vbCrLf &
                          "2 for 7.2.2 Checking array " & vbCrLf &
                          "3 for 7.2.3 The newton-Raphson Method, f(x) = x^2 - 2 = 0" & vbCrLf &
                          "4 for 7.2.3 The newton-Raphson Method, f(x) = x^7 - 5x^4 +2x-17=0 " & vbCrLf &
                          "5 for 7.2.3 The newton-Raphson Method, f(x) = cos(x+sin(x)) = 0 " & vbCrLf &
                          "6 for 7.2.3 The newton-Raphson Method, f(x) = (0.5)^x - x^3 = 0" & vbCrLf &
                          "Any other number to exit")
        Dim n As Integer = Console.ReadLine()
        Select Case n
            Case 1
                comparison_flow_chart()
            Case 2
                checking_array()
            Case 3
                newton_raphson()
            Case 4
                newton_raphson2()
            Case 5
                newton_raphosn3()
            Case 6
                newton_raphson4()
            Case Else
                Exit Sub

        End Select

    End Sub
    Function comparison_flow_chart()
        Dim a As Long, b As Long
        Console.WriteLine("Please input value for a: ")
        a = Console.ReadLine()
        Console.WriteLine("Please input value for b: ")
        b = Console.ReadLine()

        If a = b Then
            Console.WriteLine("0")
        Else
            If a > b Then
                Console.WriteLine("1")
            Else
                Console.WriteLine("-1")
            End If
        End If


    End Function
    Function checking_array()
        Dim i As Long, n As Long
        Dim A As String '
        A = Console.ReadLine
        Console.WriteLine()
        i = 1
        n = 1

        If i >= n Then
            Console.WriteLine("TRUE")
        Else
            While i < n
                If A(i - 1) < A(i) Then
                    Console.WriteLine("FALSE")
                Else
                    Do '
                        i = i + 1
                        If i >= n Then
                            Console.WriteLine("TRUE")
                        End If
                    Loop Until i >= n
                    Do
                        i = i + 1
                        If A(i - 1) < A(i) Then
                            Console.WriteLine("FALSE")
                        End If
                    Loop Until A(i - 1) < A(i)
                End If
            End While
        End If

    End Function

    Function newton_raphson()
        Dim x As Double = 1.0, i As Long = 0
        Console.Write(Format(i, "0") + " ")
        Console.Write(Format(x, "0.000") + " ")
        Console.WriteLine(Format(FofX1(x), "0.000"))
        While Math.Abs(FofX1(x)) > 0.00001
            i = i + 1
            x -= FofX1(x) / FDashX1(x)
            Console.Write(Format(i, "0") + " ")
            Console.Write(Format(x, "0.000") + " ")
            Console.WriteLine(Format(FofX1(x), "0.000"))
        End While


    End Function
    Function FofX1(ByVal x As Double)
        FofX1 = x ^ 2 - 2
    End Function
    Function FDashX1(ByVal x As Double)
        FDashX1 = 2 * x
    End Function

    Function newton_raphson2()
        Console.WriteLine("7.2.3 - The Newton-Raphson Method")
        Console.WriteLine("Equation 2 - f(x) = x^7 - 5x^4 +2x-17=0")
        Console.WriteLine()
        Dim x As Double = 1.0, i As Long = 0
        Console.Write(Format(i, "0") + " ")
        Console.Write(Format(x, "0.000") + " ")
        Console.WriteLine(Format(FofX2(x), "0.000"))
        While Math.Abs(FofX2(x)) > 0.00001
            i = i + 1
            x -= FofX2(x) / FDashX2(x)
            Console.Write(Format(i, "0") + " ")
            Console.Write(Format(x, "0.000") + " ")
            Console.WriteLine(Format(FofX2(x), "0.000"))
        End While
    End Function
    Function FofX2(ByVal x As Double)
        FofX2 = x ^ 7 - 5 * x ^ 4 + 2 * x - 17
    End Function
    Function FDashX2(ByVal x As Double)
        FDashX2 = 7 * x ^ 6 - 20 * x ^ 3 + 2

    End Function

    Function newton_raphosn3()
        Console.WriteLine("7.2.3 - The Newton-Raphson Method")
        Console.WriteLine("Equation 3 - f(x) = cos(x+sin(x)) = 0")
        Console.WriteLine()
        Dim x As Double = 1.0, i As Long = 0
        Console.Write(Format(i, "0") + " ")
        Console.Write(Format(x, "0.000") + " ")
        Console.WriteLine(Format(FofX3(x), "0.000"))
        While Math.Abs(FofX3(x)) > 0.00001
            i = i + 1
            x -= FofX3(x) / FDashX3(x)
            Console.Write(Format(i, "0") + " ")
            Console.Write(Format(x, "0.000") + " ")
            Console.WriteLine(Format(FofX3(x), "0.000"))

        End While
    End Function
    Function FofX3(ByVal x As Double)
        FofX3 = Math.Cos(x + Math.Sin(x))
    End Function
    Function FDashX3(ByVal x As Double)
        FDashX3 = -(Math.Cos(x) + 1) * Math.Sin(Math.Sin(x) + x)

    End Function

    Function newton_raphson4()
        Console.WriteLine("7.2.3 - The Newton-Raphson Method")
        Console.WriteLine("Equation 4 - f(x) = (0.5)^x - x^3 = 0")
        Console.WriteLine()
        Dim x As Double = 1.0, i As Long = 0
        Console.Write(Format(i, "0") + " ")
        Console.Write(Format(x, "0.000") + " ")
        Console.WriteLine(Format(FofX4(x), "0.000"))
        While Math.Abs(FofX4(x)) > 0.00001
            i = i + 1
            x -= FofX4(x) / FDashX4(x)
            Console.Write(Format(i, "0") + " ")
            Console.Write(Format(x, "0.000") + " ")
            Console.WriteLine(Format(FofX4(x), "0.000"))
        End While

    End Function
    Function FofX4(ByVal x As Double)
        FofX4 = (0.5) ^ x - x ^ 3
    End Function
    Function FDashX4(ByVal x As Double)
        FDashX4 = -0.693147 * 0.5 ^ x - 3 * x ^ 2
    End Function
End Module