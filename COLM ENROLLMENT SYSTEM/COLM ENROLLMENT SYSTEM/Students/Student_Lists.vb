Public Class Student_Lists
    Public Sub LoadStudents()
        'Using conn As New SqlConnection(StringConnection)
        '    conn.Open()
        '    Using comm As New SqlCommand("SELECT * FROM FN_StudentInformation() ORDER BY Lastname,Firstname ASC", conn)
        '        Using reader As SqlDataReader = comm.ExecuteReader
        '            DataGridView1.Rows.Clear()
        '            While reader.Read
        '                DataGridView1.Rows.Add(reader("ID"), reader("Student_Number"), reader("Lastname") & " " & reader("Firstname") & " " & reader("Middlename"), reader("Mobile"), reader("Birthdate"), reader("Birthdate"), reader("Guardian_Name"), reader("Guardian_Mobile"))
        '            End While
        '        End Using
        '    End Using
        'End Using
    End Sub

    Private Sub Student_Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub
End Class
