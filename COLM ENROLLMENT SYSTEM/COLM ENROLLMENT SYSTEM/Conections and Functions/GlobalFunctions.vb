Public Module GlobalFunctions
    Public Function GetAge(ByVal cmbMonth As ComboBox, ByVal txtDay As TextBox, ByVal txtYear As TextBox, Optional ByVal AsOf As System.DateTime = #1/1/1700#) As String
        Dim returned As String = String.Empty
        Dim Birthdate As DateTime
        If cmbMonth.Text = String.Empty Or txtDay.Text = String.Empty Or txtYear.Text = String.Empty Or Len(txtYear.Text) <> 4 Then
            returned = ""
        Else
            Try
                Birthdate = DateValue(cmbMonth.Text & " " & txtDay.Text & " " & txtYear.Text)
                Dim iMonths As Integer
                Dim iYears As Integer
                Dim dYears As Decimal
                Dim lDayOfBirth As Long
                Dim lAsOf As Long
                Dim iBirthMonth As Integer
                Dim iAsOFMonth As Integer

                If AsOf = "#1/1/1700#" Then
                    AsOf = DateTime.Now
                End If
                lDayOfBirth = DatePart(DateInterval.Day, Birthdate)
                lAsOf = DatePart(DateInterval.Day, AsOf)

                iBirthMonth = DatePart(DateInterval.Month, Birthdate)
                iAsOFMonth = DatePart(DateInterval.Month, AsOf)

                iMonths = DateDiff(DateInterval.Month, Birthdate, AsOf)

                dYears = iMonths / 12

                iYears = Math.Floor(dYears)

                If iBirthMonth = iAsOFMonth Then
                    If lAsOf < lDayOfBirth Then
                        iYears = iYears - 1
                    End If
                End If
                returned = iYears

            Catch ex As Exception
                cmbMonth.SelectedIndex = -1
                txtDay.Text = String.Empty
                txtYear.Text = String.Empty
                MsgBox("Invalid birthdate combination!", MsgBoxStyle.Critical)
                cmbMonth.Focus()
            End Try
        End If
        Return returned
    End Function

    'GETTING THE AGE OF PERSON BY BIRTHDATE
    Public Function GetAge(ByVal Birthdate As System.DateTime, Optional ByVal AsOf As System.DateTime = #1/1/1700#) As String
        Dim returned As String = String.Empty

        Try
            Birthdate = DateValue(Birthdate)
            Dim iMonths As Integer
            Dim iYears As Integer
            Dim dYears As Decimal
            Dim lDayOfBirth As Long
            Dim lAsOf As Long
            Dim iBirthMonth As Integer
            Dim iAsOFMonth As Integer

            If AsOf = "#1/1/1700#" Then
                AsOf = DateTime.Now
            End If
            lDayOfBirth = DatePart(DateInterval.Day, Birthdate)
            lAsOf = DatePart(DateInterval.Day, AsOf)

            iBirthMonth = DatePart(DateInterval.Month, Birthdate)
            iAsOFMonth = DatePart(DateInterval.Month, AsOf)

            iMonths = DateDiff(DateInterval.Month, Birthdate, AsOf)

            dYears = iMonths / 12

            iYears = Math.Floor(dYears)

            If iBirthMonth = iAsOFMonth Then
                If lAsOf < lDayOfBirth Then
                    iYears = iYears - 1
                End If
            End If
            returned = iYears
        Catch ex As Exception

        End Try

        Return returned
    End Function

    Public Function Convert_To_Currency(str As String)
        str = Format(str, "Currency")
        str = str.Replace("$", "")
        Return str
    End Function
End Module
