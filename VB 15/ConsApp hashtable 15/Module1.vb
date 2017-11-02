Module Module1

    Sub Main()

        'hash Table

        Dim employees As Hashtable = New Hashtable

        employees.Add(102, "bob smith")
        employees.Add(105, "bob hope")

        If employees.ContainsKey(105) Then
            Console.WriteLine(employees.Item(105) & " exists")

        End If

        Console.ReadLine()

    End Sub

End Module
