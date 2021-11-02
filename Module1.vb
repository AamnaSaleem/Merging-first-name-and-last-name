Module Module1

    Sub Main()
        Dim FirstName, SecondName, FN, LN, LenSTR As String
        Dim SpaPos As Integer
        Console.Write("Enter First Name: ")
        FirstName = Console.ReadLine
        Console.Write("Enter Second Name: ")
        SecondName = Console.ReadLine
        SpaPos = InStr(FirstName, " ")
        FN = Left(FirstName, SpaPos - 1)
        SpaPos = InStr(SecondName, " ")
        lenSTR = Len(SecondName)
        LN = Right(SecondName, lenSTR - SpaPos)
        Console.WriteLine(FN & " " & LN)
        Console.ReadKey()




    End Sub

End Module
