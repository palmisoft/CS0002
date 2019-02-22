Module CourseWork

    'The "loval value" is delcared
    ''Due to it is a local value it will apply to any function of the program 
    '''The value will be given in the "Accuracy Option" section
    Dim localva As Integer

    Sub Main()
        'These lines display the number of the different sections
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("CS0002 Coursework by Mario Palmis ")
        Console.WriteLine("*****************************")
        Console.WriteLine("1. Accuaracy Option")
        Console.WriteLine("2. Quadratic Equation")
        Console.WriteLine("3. Monte-Carlo Integration")
        Console.WriteLine("4. Prime Decision")
        Console.WriteLine("5. Help")
        Console.WriteLine("6. Exit")

        selection() 'It calls the selection function

    End Sub
    Function selection()
        ' In this function the user will be able to select any option of the menu showed above 
        Console.WriteLine("____________________________________________________" & vbCrLf &
                          "Please choose from otions 1-6 and then press return: ")

        ' declaration of the variable value that will be introduced with the keyboard
        Dim inp As Integer

        'The Do while loop has been introduced to recall selec case every time that the user introduce a number that is out of the range showed above
        Do While inp < 1 Or inp > 6 'For numbers less than 1 or above than 6 the select case will be ejecuted again 
            '' till the user select a correct number
            Integer.TryParse(Console.ReadLine, inp) 'This reads any string and find any digits in it 

            Select Case inp ' Selec case statement has been implemented to call every fucntion in the program 
                '' Although there are many means to organise a program, I have decided to separate each section into FUNCTIONS
                '' Eevery case call a function 

                Case 1 ' It will call accuracy option
                    accuaracy_option()
                Case 2 'It will call Quadratic Equation
                    Quadratic_Equation()
                Case 3 'It will call Montecarlo 
                    Montecarlo()
                Case 4 'It will call Pime decision
                    Prime_decision()
                Case 5 ' It will call help
                    help()
                Case 6 ' It will exit 
                    Console.WriteLine("The program will close")
                Case Else

                    Console.WriteLine("Please introduce a vualue between 1 and 6") 'This statement will be shown everytime the number introduced is worng 
            End Select

        Loop 'end of the while do loop 

    End Function

    Function accuaracy_option()


        Dim valuex As Double = 0 ' declaration of the random number
        Dim MinNumber As Integer = 0 ' minimum number
        Dim Maxnumber As Integer = 1 ' maximum number

        Do While localva > 5 Or localva < 1 ' As in the menu the Do While loop has been introduced to check that the local value is set in between 1 and 5 
            ' if the value is less than 1 and more than 5 it will ask the user ton introduce again the number 
            Console.WriteLine("Introduce the number of decimal places")
            ' the statement try catch has been introduced to control that the input is any number different to "nothing" or "empty"
            Try
                localva = Console.ReadLine() ' this is the "local value", it does not need to be declared as it was done at the beginning of the program 
            Catch ex As Exception

                accuaracy_option() ' if the user leaves the gap empty "accuaracy_option" will be called 
            End Try

        Loop

        valuex = CDbl((MinNumber - Maxnumber) * Rnd() + Maxnumber) 'This statement generates the random number. It has been extracted from http://www.recursosvisualbasic.com.ar/htm/trucos-codigofuente-visual-basic/71.htm
        'FormatNumber (value, number of decimals that the user want to show) 
        Console.WriteLine("The answer is : " & vbCrLf & FormatNumber(valuex, localva))

        selection() ' call the selection menu 
    End Function


    Function Quadratic_Equation()


        Dim a, b, c As Single ' Declaration of the variables that are going to be used a,b and c

        ' Each variable has a try catch to identify when the user does not introduce any "string" 
        '' Every try catch call the Quadratic function from the begining, so the previous values will be lost 

        'Block for A
        Console.WriteLine("Write coefficient 'a'")
        Try
            a = Console.ReadLine()
        Catch ex As Exception
            Quadratic_Equation()
        End Try
        'Block for B
        Console.WriteLine("Write coefficient 'b'")
        Try
            b = Console.ReadLine()
        Catch ex As Exception
            Quadratic_Equation()
        End Try
        'Block for C
        Console.WriteLine("Write coefficient 'c'")
        Try
            c = Console.ReadLine()
        Catch ex As Exception
            Quadratic_Equation()
        End Try

        ' This is the body of the quadratic equation 
        Dim body As Integer = b ^ 2 - 4 * a * c
        ' The if then else statement has been used to check if the body is more or equal to 0
        If body >= 0 Then ' the quadratic is calculable 
            If body = 0 Then ' when equal to 0 
                Console.WriteLine("Roots are real and equal")
            Else
                Console.WriteLine("Roots are real and different")
            End If

            Console.Write("Roots are: ")
            ' this is the + 
            Console.Write(FormatNumber(((-b + body ^ 0.5) / (2 * a)), localva) & " , ")
            ' this is the + 
            Console.WriteLine(FormatNumber((-b - body ^ 0.5) / (2 * a)), localva)

        Else ' when the body is less than 0 
            Console.Write("Roots are: ")
            ' the euqation is splited in two, leaving the square root on the right. 
            ' this is the + 
            Console.Write(FormatNumber((-b / (2 * a)), localva) & "+" & FormatNumber(((body * -1) ^ 0.5 / (2 * a)), localva) & "i")
            Console.Write(" , ")
            ' this is the -
            Console.WriteLine(FormatNumber((-b / (2 * a)), localva) & "-" & FormatNumber(((body * -1) ^ 0.5 / (2 * a)), localva) & "i")

        End If


        selection() ' call the selection menu 
    End Function

    Function Prime_decision()

        Dim StartTime As Double, endtime As Double ' Time value declaration

        ' call the selection menu 
        Dim a As Integer = 0
        Dim n As Integer ' number that is going to be checked 
        Dim i As Integer
        Console.WriteLine("Introduce a number")

        ' this has been implemented to get to the begining if the user does not enter any number and press enter
        Try
            n = Console.ReadLine()
        Catch ex As Exception
            Prime_decision()
        End Try
        ' startime has been extracted from MSDN
        StartTime = Timer 'Stores start time in variable "StartTime" 

        ' the loop for...next will divided the number selected for a range of number that goes from the number introduced to the same plus one
        For i = 1 To n + 1
            If (n Mod i = 0) Then 'When mod = 0, that means that there is no rest, one will be aded to "a" 
                a = a + 1
            End If
        Next i
        endtime = Timer 'Stores end time in variable "endTime"
        ' Prime number can just be divided by two numbers 1 and its onw value so when we introduce a prime number in "n" iT will add till 2

        If (a <> 2) Then ' the program will jump here when a = less or more than 2
            Console.Write("It is not Prime")
        Else 'The program will jump to this line when a = 2
            Console.Write("It is Prime")
        End If
        'FormatNumber will decided the number of decimals that are going to be shown usig the local variable. 
        Console.WriteLine(vbCrLf & "Execution time in seconds: " + FormatNumber((Format$(endtime - StartTime)), localva))

        selection() ' call the selection menu 
    End Function

    Function Montecarlo()
        'variable that should be introduced by the user 
        Dim n As Integer = 0

        Console.WriteLine("Introduce the number of pairs")

        ' this has been implemented to get to the beginning if the user does not enter any number and press enter
        Try
            n = Console.ReadLine()
        Catch ex As Exception
            Montecarlo()
        End Try


        Dim MaxNumber As Double
        Dim MinNumber As Double
        Dim Valuex As Double
        Dim valuey As Double

        'define maximum and minimum values
        MinNumber = 0
        MaxNumber = 1

        'define each parameter 
        Dim countx As Integer
        Dim countx2 As Integer
        Dim countx3 As Integer
        Dim countcos As Integer
        Dim countsin As Integer

        'create number and add to the list
        ' The for...next loop has been introduced to make every function run according to the number of pairs. 
        For i As Integer = 0 To n - 1

            'generate the decimal value between the two values (max and min ) 
            'The same as the one used in accuaracy_option()
            Valuex = CDbl((MinNumber - MaxNumber) * Rnd() + MaxNumber)
            valuey = CDbl((MinNumber - MaxNumber) * Rnd() + MaxNumber)

            ' to get all the vaules that are under the line we will apply every random number to each equation

            'Every equation will count1 every time the vaule of "y" is less than x in any of its forms cos,sin,x2,ect...
            ' when y = x
            If (valuey < Valuex) Then
                countx = countx + 1
            End If
            ' when y = x^2
            If (valuey < Valuex ^ 2) Then
                countx2 = countx2 + 1
            End If
            'when y = x^3
            If (valuey < Valuex ^ 3) Then
                countx3 = countx3 + 1
            End If
            'when y = sinx
            If (valuey < Math.Sin(Valuex)) Then
                countsin = countsin + 1
            End If
            'when y = cosx
            If (valuey < Math.Cos(Valuex)) Then
                countcos = countcos + 1
            End If
        Next

        'Display the results 
        'FormatNumber has been implemented to slect he number of decimals that are going to be shown using the local variable as a parameter 
        ''The total value of each sum is divided then by the number of pairs 
        Console.WriteLine("Result equation y = x " & vbCrLf & FormatNumber((countx / n), localva))
        Console.WriteLine("Result equation y = x^2 " & vbCrLf & FormatNumber((countx2 / n), localva))
        Console.WriteLine("Result equation y = x^3 " & vbCrLf & FormatNumber((countx3 / n), localva))
        Console.WriteLine("Result equation y = sinx " & vbCrLf & FormatNumber((countsin / n), localva))
        Console.WriteLine("result equation y = cosx " & vbCrLf & FormatNumber((countcos / n), localva))

        selection() ' call the selection menu 

    End Function


    Function help()
        Console.WriteLine("Accuaracy Option")
        Console.WriteLine("________________")
        Console.WriteLine("The number introduced by the user will be used to show a the number of decimal places in the rest of the equations." & vbCrLf &
                          "In addition the program will use a random number to show how the rest of the results will look like" & vbCrLf)

        Console.WriteLine("Quadratic Equation")
        Console.WriteLine("__________________")
        Console.WriteLine("A Quadratic Equation will be caculated" & vbCrLf &
                          "The user will have to introduce a,b and c" & vbCrLf)

        Console.WriteLine("Montecarlo Integration")
        Console.WriteLine("______________________")
        Console.WriteLine("The program will claculate from random number 3 equations and it will count the times that the value y is less than x." & vbCrLf &
                          "the result will be divided by the number of paris" & vbCrLf)

        Console.WriteLine("Prime Decision")
        Console.WriteLine("______________")
        Console.WriteLine("This will show if a number its primer" & vbCrLf &
                          "This means when a number can be divided by itself and one" & vbCrLf &
                          "In addition the program will calculate the time invested to reach the answer")

        selection() ' call the selection menu 
    End Function

End Module
