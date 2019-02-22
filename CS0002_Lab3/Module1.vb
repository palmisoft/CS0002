Module Module1

    Sub Main()
        Console.WriteLine("1 for 3.2.1 Relational operator" &
                          vbCrLf & "2 for 3.2.2 If Statement with numbers" &
                          vbCrLf & "3 for 3.2.2 If statement with string" &
                          vbCrLf & "4 for 3.2.3 Compound Conditions " &
                          vbCrLf & "5 for 3.2.4 Select Statement" &
                          vbCrLf & "6 for 3.3.1 generating dequences using for loops" &
                          vbCrLf & "7 for 3.3.2 Generating Patterns Using For Loops" &
                          vbCrLf & "8 for 3.3.3 While loops" &
                          vbCrLf & "9 for 3.3.4 Nested loops" &
                          vbCrLf & "10 for More nested loops")
        Console.writeline("introduce a number")
        Dim n As Integer = Console.ReadLine()
 Select n
            Case 1
                Relational_operators()
                Exit Select
            Case 2
                IF_Statement()
                Exit Select
            Case 3
                IF_statement_string()
            Case 4
                compound_conditions()
            Case 5
                Select_statement()
            Case 6
                Generating_sequences_using_for_loops()
            Case 7
                generating_patterns_using_for_loops()
            Case 8
                While_loop()
            Case 9
                nested_loops()
            Case 10
                more_nested_loops()
            Case Else
                Console.WriteLine("enter any number")
        End Select




    End Sub
    Function Relational_operators()
        Dim x As Integer = 100
        Dim y As Integer = 204
        Dim z As Double = -23.1
        Dim b As Boolean = False
        Dim a As Boolean = True
        Dim c As Double = -204

        If x < y Then
            Console.WriteLine("1) True")
        End If

        If x > z And a = b Then
            Console.WriteLine("2) True")
        End If

        If 2 * c > y Then
            Console.WriteLine("3) True")
        End If

        If x = b Then
            Console.WriteLine("4) True")
        End If

        If c <> y Or c = y Then
            Console.WriteLine("5) True")
        End If

        If z <> y And c = a Then
            Console.WriteLine("6) True")
        End If

        If y >= y And a + 3 <> 2 Then
            Console.WriteLine("7) True")
        End If

    End Function

    Function IF_Statement()
        Console.WriteLine("introduce First number")
        Dim n1 As Integer = Console.ReadLine()
        Console.WriteLine("introduce Second number")
        Dim n2 As Integer = Console.ReadLine()
        Console.WriteLine("introduce Third number")
        Dim n3 As Integer = Console.ReadLine()

        If n1 < n2 Then
            If n2 < n3 Then
                Console.WriteLine(n1 & n2 & n3)
            ElseIf n1 < n3 Then
                Console.WriteLine(n1 & n3 & n2)
            Else
                Console.WriteLine(n3 & n1 & n2)
            End If
        ElseIf n2 > n3 Then
            Console.WriteLine(n3 & n2 & n1)
        ElseIf n1 > n3 Then
            Console.WriteLine(n2 & n3 & n1)
        Else
            Console.WriteLine(n2 & n1 & n3)

        End If

    End Function

    Function IF_statement_string()
        Console.WriteLine("introduce a word")
        Dim name1 As String = Console.ReadLine()
        Console.WriteLine("introduce a another word")
        Dim name2 As String = Console.ReadLine()
        Console.WriteLine("introduce the last word")
        Dim name3 As String = Console.ReadLine()


        If name1 < name2 And name2 < name3 Then
            Console.WriteLine(name1 & name2 & name3)
        ElseIf name1 < name3 And name3 < name2 Then
            Console.WriteLine(name1 & name3 & name2)
        ElseIf name3 < name1 And name1 < name2 Then
            Console.WriteLine(name3 & name1 & name2)
        ElseIf name2 < name1 And name1 < name3 Then
            Console.WriteLine(name2 & name1 & name3)
        ElseIf name2 < name3 And name3 < name1 Then
            Console.WriteLine(name2 & name3 & name1)
        Else
            Console.WriteLine(name3 & name2 & name1)
        End If


    End Function

    Function compound_conditions()
        Dim x As Integer


        For x = 1 To 100
            If (x Mod 2 = 0 And x Mod 3 = 0) Then
                Console.WriteLine("numbers divisible by 3 and 5: " & x)
            End If
        Next

        For x = 1 To 100
            If (x Mod 7 = 0 Or x Mod 9 = 0) Then
                Console.WriteLine("numbers divisible by 7 or 9: " & x)
            End If
        Next

        For x = 1 To 100
            If (x Mod 2 = 0 And x Mod 3 = 0 And x Mod 5 <> 0) Then
                Console.WriteLine("numbers divisible by 2 and 3 but not 5: " & x)
            End If
        Next



    End Function

    Function Select_statement()
        Console.WriteLine("insert a number from 0 to 100")
        Dim n As Integer = Console.ReadLine()
        Select Case n
            Case 1 To 10
                Console.WriteLine(" < 10 ")
            Case Is >= 90
                Console.WriteLine("greater or equal to 90")
            Case 30 To 40
                Console.WriteLine("Between 30 and 40 inclusive")
            Case 11 Or 21 Or 51 Or 61
                Console.WriteLine("Equal to 11, 21, 51, 61")
            Case 71 To 79
                Console.WriteLine("Between 70 and 80 exclusive")
        End Select




    End Function

    Function Generating_sequences_using_for_loops()
        Dim i As Integer
        Dim i2 As Integer
        Dim i3 As Integer
        Dim i4 As Integer
        Dim i5 As Integer
        Dim i6 As Integer

        For i = 10 To 19 Step 3
            Console.WriteLine("1) " & i)
        Next

        For i2 = 1 To 16 Step 3
            Console.WriteLine("2) " & i2)
        Next

        For i3 = 2 To 12 Step 2
            Console.WriteLine("3) " & i3)
        Next

        For i4 = 1 To 10
            Console.WriteLine("4) " & i4 ^ 2)
        Next

        For i5 = -10 To 10 Step 2
            Console.WriteLine("5) " & i5)
        Next

        For i6 = -20 To 20 Step 5
            Console.WriteLine("6)" & i6)
        Next

    End Function

    Function generating_patterns_using_for_loops()
        Dim i As Integer
        Dim i2 As Integer
        Dim i3 As Integer
        Dim i4 As Integer

        For i = 1 To 10
            Console.Write("+")
        Next

        For i2 = 1 To 9
            Console.Write("-")
        Next

        For i3 = 1 To 5
            Console.Write("+-")
        Next

        For i4 = 1 To 3
            Console.Write("*+-")
        Next
    End Function

    Function While_loop()
        Console.WriteLine("write a number")
        Dim a As Integer = Console.ReadLine()
        Console.WriteLine("write another number")
        Dim b As Integer = Console.ReadLine()
        Dim c As Integer

        c = a Mod b
        Do While c > 0
            a = b
            b = c
            c = a Mod b
        Loop

        Console.WriteLine("the HCF is " & b)

    End Function

    Function nested_loops()
        Dim i As Long, j As Long
        Console.WriteLine("1) ")
        For i = 1 To 5
            For j = 1 To i
                Console.Write(i)
            Next j
        Next i

        Console.WriteLine(vbCrLf & "2) ")
        For i = 1 To 6
            For j = 1 To i
                Console.Write(i)
            Next j
        Next i

        Console.WriteLine(vbCrLf & "3) ")
        For i = 1 To 5 Step 2
            For j = 1 To i
                Console.Write(i)
            Next j
        Next i

        Console.WriteLine(vbCrLf & "4) ")
        For i = 1 To 7 Step 2
            For j = 1 To i
                Console.Write(i)
            Next j
        Next i

    End Function

    Function more_nested_loops()
        Dim i As Integer, j As Integer
        Dim num As Integer, num2 As Integer, num3 As Integer = 0

        For i = 1 To 10
            For j = 1 To 10
                num += 1
            Next j
        Next i
        Console.WriteLine("1) " & num)

        For i = 1 To 10
            For j = i + 1 To 10
                num2 += 1
            Next j
        Next i
        Console.WriteLine("2) " & num2)

        For i = 1 To 4
            For j = 4 To 8
                num3 += 1
            Next j
        Next i
        Console.WriteLine("3) " & num3)




    End Function
End Module
