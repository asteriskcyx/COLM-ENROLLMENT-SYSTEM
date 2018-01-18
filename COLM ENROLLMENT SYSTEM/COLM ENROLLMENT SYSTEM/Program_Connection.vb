Module Program_Connection

    Public StringConnection As String = "Data Source=COLM\SQLEXPRESS;Initial Catalog=PROGRAM_TEST_2;Integrated Security=True" '= LoadConnection() '"Data Source=CYX-PC\SQLEXPRESS;Initial Catalog=PROJECT_COLM;Integrated Security=True"
    'Public StringConnection As String = "Data Source=CYREKXS-PC\SQLEXPRESS;Initial Catalog=PROGRAM_TEST_2;Integrated Security=True"
    Private Function LoadConnection()

        If StringConnection <> String.Empty Then
            Return StringConnection
            Exit Function
        End If

        Dim File_Name As String = Application.StartupPath & "\Connection_Source.txt"
        Dim Text_Line As String = String.Empty

        If System.IO.File.Exists(File_Name) Then
            Dim reader As New System.IO.StreamReader(File_Name)
            Text_Line = reader.ReadLine
        Else
            MsgBox("Cannot Locate Connection!", MsgBoxStyle.Critical)
        End If

        Return Text_Line

    End Function
End Module
