Module Module1

    Sub Main()


        AssignmentExpressions()






    End Sub

    Function AssignmentExpressions()
        Dim a As Long
        a = 100
        Dim b As Decimal
        b = 2.3
        Dim c As Decimal
        c = -52.2
        Dim d As Boolean
        d = True
        Dim e As String
        e = "I am"
        Dim f As String
        f = "a student"
        Dim g As Integer
        g = 0
        Dim h As String
        h = "!"

        Dim pi As Decimal
        pi = 3.142
        Dim name As String
        name = "Mario"

        Dim x As Long
        Dim y As Double
        Dim z As String

        x = a + b
        Console.WriteLine("1) " & x)

        y = a + b
        Console.WriteLine("2) " & y)

        z = e + f
        Console.WriteLine("3) " & z)

        x = b * c
        Console.WriteLine("4) " & x)

        pi = 22 / 7
        Console.WriteLine("5) " & pi)

        'z = name / g
        'Console.WriteLine(z)

        'z = c / g
        'Console.WriteLine(z)

        x = 10
        x = x ^ 3
        Console.WriteLine("8) " & x)

        z = name + " is " + f + h
        Console.WriteLine("9) " & z)

        'y = (name + 10) / name + h
        'Console.WriteLine(y)

        x = (a + b) / (d + c)
        Console.WriteLine("11) " & x)

        y = 100.3
        y = (y / (a + b)) - c
        Console.WriteLine("12) " & y)

        'x = (y ^ 2 + z ^ 2) / x
        'Console.WriteLine(x)

        'name = "is " + f - h
        'Console.WriteLine(name)

        y = (pi + 1 / pi + 2) / pi + 3
        Console.WriteLine("15) " & y)

        y = -2
        y = (y ^ 2 / a) ^ (1 / 3)
        Console.WriteLine("16) " & y)

        z = d / g
        z = z + name
        Console.WriteLine("17) " & z)

        'z = name
        'z = d / g + z
        'Console.WriteLine("18) " & z)

        x = -2.3
        y = a * x ^ 2 + b * x + c
        Console.WriteLine("19) " & y)

        y = y - (a - b) ^ ((b - c) ^ (c - d))
        Console.WriteLine("20) " & y)
    End Function

    Function Reserved_words()

        Dim four As String
        'dim for as double
        'dim 4 as double 
        'Dim _4 As Double
        'dim while as string
        'dim while as string 
        'dim sub as string
        'dim Sub as string
        'dim $ub as string
        Dim sub23 As String
        'dim next as string
        'dim exit as string
        'dim new as string
        Dim name As String
        Dim friends As String
        'dim class as double
        'dim object as string
        Dim student As String
        Dim day As Date
        'dim date as date
        Dim time As Date
        Dim month As Date
        Dim year As Integer
        Dim age As Integer
        Dim height As Integer
        Dim weight As Integer
        'dim 17beans as string
        Dim beans17 As String
        Dim note As String
        Dim _X_ As String


    End Function
    

End Module
