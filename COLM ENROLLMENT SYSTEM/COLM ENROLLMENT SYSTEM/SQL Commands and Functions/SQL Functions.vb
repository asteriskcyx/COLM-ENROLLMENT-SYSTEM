Imports System.Xml
Imports System.Xml.Linq
Module SQL_Functions

    Public Function VerifyDatabaseFunctions(FunctionName As String) As Boolean
        Dim FunctionExists As Boolean = False
        Using conn As New SqlConnection(StringConnection)
            conn.Open()
            Using comm As New SqlCommand("SELECT * FROM dbo.sysobjects WHERE name = @functionname AND type = 'IF'", conn)
                comm.Parameters.AddWithValue("@functionname", FunctionName)
                Using reader As SqlDataReader = comm.ExecuteReader
                    If reader.HasRows = True Then
                        FunctionExists = True
                    End If
                End Using
            End Using
        End Using
        Return FunctionExists
    End Function

    Public Sub FN_FunctionName()

        Dim FunctionCodes As String = <a>

                                      </a>
        Using conn As New SqlConnection(StringConnection)
            conn.Open()
            Using comm As New SqlCommand(FunctionCodes, conn)
                comm.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
