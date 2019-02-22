Module Module1
    Sub main()
        Console.WriteLine("introduce a number")
        Console.WriteLine("1 for 6.2.1 one dimension array" & vbCrLf &
                          "2 for 6.2.1 one dimension array power of three" & vbCrLf &
                          "3 for 6.2.1 one dimension array constant K" & vbCrLf &
                          "4 for 6.3.2 read in data from the console window" & vbCrLf &
                          "5 for 6.3.3 reading data" & vbCrLf &
                          "6 for 6.3.4 writing data" & vbCrLf &
                          "7 for 6.4 segementation of protein sequences")
        Dim n As Integer = Console.ReadLine()
        Select Case n
            Case 1
                One_dimension_array_power_of_half()
            Case 2
                One_dimension_array_power_of_three()
            Case 3
                One_dimension_arrays_constant_k()
            Case 4
                writing_a_text_into_a_file()
            Case 5
                reading_data()
            Case 6
                writing_data()
            Case 7
                segmentation_of_protein_sequences()
            Case 8


        End Select
    End Sub

    Function DisplayArray(ByVal array() As Double)
        Dim i As Long, n As Long
        n = array.GetLength(0)
        Dim sum As Integer

        sum = 0
        For i = 0 To n - 1
            sum += array(i)

            Console.WriteLine(array(i))
        Next i
    End Function

    Function One_dimension_array_power_of_half()
        Dim array(24) As Double, i As Long
        array(0) = 1
        For i = 1 To 24
            array(i) = 0.5 * array(i - 1)
        Next i
        Call DisplayArray(array)
    End Function

    Function One_dimension_array_power_of_three()
        Dim array(24) As Double, i As Long
        array(0) = 1
        For i = 1 To 24
            array(i) = 3 * array(i - 1)
        Next i
        Call DisplayArray(array)

    End Function
    
    Function One_dimension_arrays_constant_k()

        Dim array(24) As Double, i As Long
        Console.WriteLine("size of array")
        Dim n As Integer = Console.ReadLine()

        Dim k As Double

        array(0) = 1
        For i = 1 To n

            array(i) = 2 * array(i - 1)

            k = 3 * (i - 1)


        Next
        If k = array(i) Then
            Console.WriteLine(k)
        End If


    End Function
    
    Function writing_a_text_into_a_file()

        Dim fh As Long
        Dim text$
        Text = Console.ReadLine()

        fh = FreeFile()
        FileOpen(fh, "C:\temp\test.text", OpenMode.Output)

        PrintLine(fh, text)

        While text = ""
            Console.Write("enter some text" & vbCrLf)
            text = Console.ReadLine()
            PrintLine(fh, text)

        End While
        FileClose(fh)


    End Function

    Function reading_data()
        Console.WriteLine("Word Count - c:\temp\Billy goats.txt")
        Console.WriteLine()
        Dim value As String = My.Computer.FileSystem.ReadAllText("c:\temp\Billy Goats.txt")

        Dim Counts As Integer
        Dim dupText As String
        dupText = Replace(Trim(value), vbNewLine, " ")
        If dupText = "" Then '
            Counts = 0
        Else
            Counts = 1
            For i = 1 To Len(dupText)
                If Mid(dupText, i, 1) = " " Then
                    If Mid(dupText, i - 1, 1) <> " " Then
                        Counts = Counts + 1
                    End If
                End If
            Next
        End If
        Console.WriteLine(Counts)

    End Function

    Function writing_data()

        Dim fh As Long, i As Long, line As String

        fh = FreeFile()
        Console.WriteLine("Two Dimensional Matrix")
        Console.WriteLine()
        FileOpen(fh, "c:\temp\matrix.txt", OpenMode.Output)
        Console.WriteLine()

        For i = 1 To 10
            line = Str(i) + Str(i + 2)
            PrintLine(fh, line)
        Next i

        Console.WriteLine("Completed." & vbCrLf & "Please check file (Z:\matrix.txt).")

        FileClose(fh)
    End Function


    Function segmentation_of_protein_sequences()
        Console.WriteLine("6.4 - Segmentation of protein sequences" & vbCrLf)

        Dim x As Integer
        Dim y As Integer = 0


        Dim z As String = "GLSDGEWQQVLNVWGKVEADIAGHGQEVLIRLFTGHPETLEKFDKFKHLKTEAEMKASEDLKKHGTVVLTALGGILKKKGHHEAELKPLAQSHATKHKIPIKYLEFISDAIIHVLHSKHPGDFGADAQGAMTKALELFRNDIAAKYKELGFQG"

        For x = 0 To (z.Length - 1)
            If (z.Chars(x) = "R") Or (z.Chars(x) = "K") Then 

                If (x + 1) < (z.Length) And z.Chars(x + 1) <> "P" Then
                    Console.WriteLine(z.Substring(y, x - y + 1))
                    y = (x + 1)

                End If
            End If
        Next

        Console.WriteLine(z.Substring(y))


    End Function

End Module
