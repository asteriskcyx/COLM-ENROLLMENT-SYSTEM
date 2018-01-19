Public Class frm_students_entry


    Public Sub LoadDataGridViewFields()
        DataGridView1.Rows.Add("EDUCATION LEVEL:", "")
        DataGridView1.Rows.Add("STUDENT NO:", "", "GENERATE")
        DataGridView1.Rows.Add("LASTNAME:", "")
        DataGridView1.Rows.Add("FIRSTNAME:", "")
        DataGridView1.Rows.Add("MIDDLENAME:", "")
        DataGridView1.Rows.Add("EXTENSION NAME:", "")
        DataGridView1.Rows.Add("BIRTH MONTH:", "")
        DataGridView1.Rows.Add("BIRTH DAY:", "")
        DataGridView1.Rows.Add("BIRTH YEAR:", "")
        DataGridView1.Rows.Add("GENDER:", "", "MALE", "FEMALE")
        DataGridView1.Rows.Add("CIVIL STATUS:", "", "SINGLE", "MARRIED")
        DataGridView1.Rows.Add("STREET:", "")
        DataGridView1.Rows.Add("BRGY:", "")
        DataGridView1.Rows.Add("TOWN:", "")
        DataGridView1.Rows.Add("PROVINCE:", "")
        DataGridView1.Rows.Add("MOBILE:", "")
        DataGridView1.Rows.Add("TELEPHONE:", "")
        DataGridView1.Rows.Add("EMAIL ADDRESS:", "")
        DataGridView1.Rows.Add("SCHOOL NAME:", "")
        DataGridView1.Rows.Add("LOCATION:", "")
        DataGridView1.Rows.Add("SCHOOL ADVISER:", "")
        DataGridView1.Rows.Add("MOTHER NAME:", "")
        DataGridView1.Rows.Add("MOTHER MOBILE:", "")
        DataGridView1.Rows.Add("MOTHER TELEPHONE:", "")
        DataGridView1.Rows.Add("FATHER NAME:", "")
        DataGridView1.Rows.Add("FATHER MOBILE:", "")
        DataGridView1.Rows.Add("FATHER TELEPHONE:", "")
        DataGridView1.Rows.Add("MAIN GUARDIAN:", "")
        DataGridView1.Rows.Add("GUARDIAN NAME:", "")
        DataGridView1.Rows.Add("GUARDIAN MOBILE:", "")
        DataGridView1.Rows.Add("GUARDIAN TELEPHONE:", "")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_students_entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridViewFields()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Then
            ErrorProvider1.SetError(TextBox1, "PLEASE FILL UP THIS FIELD!")
        End If

        If TextBox2.Text = String.Empty Then
            ErrorProvider1.SetError(TextBox2, "PLEASE FILL UP THIS FIELD!")
        End If
    End Sub
End Class