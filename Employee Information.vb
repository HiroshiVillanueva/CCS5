Imports IBM.Data.DB2
Public Class Employee_Information
    Private dbObject As Common.DbConnection

    Private Sub Employee_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            'With Me.dgtvEmp
            '.ColumnCount = 6
            '.Columns(0).Name = "EmpID"
            '.Columns(1).Name = "EmpLN"
            '.Columns(2).Name = "EmpFN"
            '.Columns(3).Name = "EmpMI"
            '.Columns(4).Name = "EmpTYPE"
            '.Columns(5).Name = "Salary"
            'End With
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    'function responsible for inserting record into the database'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empid As Integer
        Dim lname As String
        Dim fname As String
        Dim mname As String
        Dim empty As String
        Dim salary As Decimal
        Dim cmdInsert As DB2Command

        Try
            empid = Me.txtEmpID.Text
            lname = Me.txtEmpLN.Text
            fname = Me.txtEmpFN.Text
            mname = Me.txtEmpMI.Text
            empty = Me.txtEmpType.Text
            salary = Me.txtSalary.Text
            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into EMPLOYEE values('" & empid & "', '" & lname & "', '" & fname & "', '" & mname & "', '" & empty & "', '" & salary & "')"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    'function for disabling insert functions and activating update functions
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim empid As Integer
        Dim lname As String
        Dim fname As String
        Dim mname As String
        Dim empty As String
        Dim salary As Decimal
        Dim cmdUpdate As DB2Command

        Try
            empid = Me.txtEmpID.Text
            lname = Me.txtEmpLN.Text
            fname = Me.txtEmpFN.Text
            mname = Me.txtEmpMI.Text
            empty = Me.txtEmpType.Text
            salary = Me.txtSalary.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "update EMPLOYEE set empln = '" & lname & "', empfn = '" & fname & "', empmi = '" & mname & "', emptype = '" & empty & "', salary = '" & salary & "' where empid = '" & empid & "'"

            Me.btnUpdate.Enabled = False
            Me.btnAdd.Enabled = True

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Updated successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgtvEmp_MouseUp(sender As Object, e As EventArgs) Handles dgtvEmp.MouseUp
        Try
            Me.txtEmpID.Text = Me.dgtvEmp.CurrentRow.Cells(0).Value
            Me.txtEmpLN.Text = Me.dgtvEmp.CurrentRow.Cells(1).Value
            Me.txtEmpFN.Text = Me.dgtvEmp.CurrentRow.Cells(2).Value
            Me.txtEmpMI.Text = Me.dgtvEmp.CurrentRow.Cells(3).Value
            Me.txtEmpType.Text = Me.dgtvEmp.CurrentRow.Cells(4).Value
            Me.txtSalary.Text = Me.dgtvEmp.CurrentRow.Cells(5).Value


            Me.txtEmpID.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnAdd.Enabled = False

            If Room_Designation.Visible Then
                Try
                    Room_Designation.txtGuest.Text = Me.dgtvEmp.CurrentRow.Cells(0).Value
                    dbObject.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf Transaction.Visible Then
                Try
                    Transaction.txtGuest.Text = Me.dgtvEmp.CurrentRow.Cells(0).Value
                    dbObject.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf Transaction.Visible Then
                Try

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub clear_screen()
        Me.txtEmpFN.Clear()
        Me.txtEmpID.Clear()
        Me.txtEmpLN.Clear()
        Me.txtEmpMI.Clear()
        Me.txtEmpType.Text = ""
        Me.txtSalary.Clear()
        Me.txtEmpID.Focus()
    End Sub

    Private Sub Populate_Grid()
        Dim cmdEmp As DB2Command
        Dim rdrEmp As DB2DataReader
        Dim row As String()
        Try
            cmdEmp = dbObject.CreateCommand
            cmdEmp.CommandText = "select * from EMPLOYEE"
            rdrEmp = cmdEmp.ExecuteReader
            Me.dgtvEmp.Rows.Clear()
            While rdrEmp.Read
                row = New String() {rdrEmp.GetString(0), rdrEmp.GetString(1), rdrEmp.GetString(2), rdrEmp.GetString(3), rdrEmp.GetString(4), rdrEmp.GetString(5)}
                Me.dgtvEmp.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtEmpIDSearch.Clear()
        Me.txtEmpID.Clear()
        Me.txtEmpID.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnAdd.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim empid As Integer
        Dim cmdUpdate As DB2Command

        Try
            empid = Me.txtEmpID.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "delete from EMPLOYEE where empid = '" & empid & "'"

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateSal_Click(sender As Object, e As EventArgs) Handles btnUpdateSal.Click
        Dim empid As Integer
        Dim salary As Decimal
        Dim cmdUpdate As DB2Command

        Try
            empid = Me.txtEmpID.Text
            salary = Me.txtSalary.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "update EMPLOYEE set salary = '" & salary & "' where empid = '" & empid & "'"

            Me.btnUpdate.Enabled = False
            Me.btnAdd.Enabled = True

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Updated successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub txtEmpIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmpIDSearch.TextChanged
        Dim empidsearch As String
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()
        Try
            empidsearch = Me.txtEmpIDSearch.Text
            If IsInputNumeric(txtEmpIDSearch.Text) Then
                'If numerical, assumes search is looking for ID'
                cmdSearch = dbObject.CreateCommand
                cmdSearch.CommandText = "select * from EMPLOYEE where empid = '" & empidsearch & "' order by empid asc"
                rdrSearch = cmdSearch.ExecuteReader
                Me.dgtvEmp.Rows.Clear()
                While rdrSearch.Read
                    row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4), rdrSearch.GetString(5)}
                    Me.dgtvEmp.Rows.Add(row)
                End While
            Else
                cmdSearch = dbObject.CreateCommand
                cmdSearch.CommandText = "select * from EMPLOYEE where empln like '" & empidsearch & "%' or empfn like '" & empidsearch & "%' order by empln asc, empfn asc"
                rdrSearch = cmdSearch.ExecuteReader
                Me.dgtvEmp.Rows.Clear()
                While rdrSearch.Read
                    row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4), rdrSearch.GetString(5)}
                    Me.dgtvEmp.Rows.Add(row)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function IsInputNumeric(input As String) As Boolean
        If String.IsNullOrWhiteSpace(input) Then Return False
        If IsNumeric(input) Then Return True
        Dim parts() As String = input.Split("/"c)
        If parts.Length <> 2 Then Return False
        Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(1))
    End Function

End Class