Imports IBM.Data.DB2
Public Class Guest_Information
    Private dbObject As Common.DbConnection

    Private Sub Guest_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Populate_Grid()
        Dim cmdGst As DB2Command
        Dim rdrGst As DB2DataReader
        Dim row As String()
        Try
            cmdGst = dbObject.CreateCommand
            cmdGst.CommandText = "select * from GUEST"
            rdrGst = cmdGst.ExecuteReader
            Me.dgtvGst.Rows.Clear()
            While rdrGst.Read
                row = New String() {rdrGst.GetString(0), rdrGst.GetString(1), rdrGst.GetString(2), rdrGst.GetString(3), rdrGst.GetString(4)}
                Me.dgtvGst.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtGstSearch.Clear()
        Me.txtGstID.Clear()
        Me.txtGstID.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnAdd.Enabled = True
    End Sub

    Private Sub clear_screen()
        Me.txtGstFN.Clear()
        Me.txtGstID.Clear()
        Me.txtGstLN.Clear()
        Me.txtGstMI.Clear()
        Me.txtContact.Clear()
        Me.txtGstID.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim gstid As Integer
        Dim lname As String
        Dim fname As String
        Dim mname As String
        Dim contact As String
        Dim cmdInsert As DB2Command

        Try
            gstid = Me.txtGstID.Text
            lname = Me.txtGstLN.Text
            fname = Me.txtGstFN.Text
            mname = Me.txtGstMI.Text
            contact = Me.txtContact.Text
            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into GUEST values('" & gstid & "', '" & fname & "', '" & mname & "', '" & lname & "', '" & contact & "')"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gstid As Integer
        Dim lname As String
        Dim fname As String
        Dim mname As String
        Dim contact As String
        Dim cmdUpdate As DB2Command

        Try
            gstid = Me.txtGstID.Text
            lname = Me.txtGstLN.Text
            fname = Me.txtGstFN.Text
            mname = Me.txtGstMI.Text
            contact = Me.txtContact.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "update GUEST set gstln = '" & lname & "', gstfn = '" & fname & "', gstmi = '" & mname & "', contact = '" & contact & "' where gstid = '" & gstid & "'"


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


    Private Sub dgtvGst_MouseUp(sender As Object, e As EventArgs) Handles dgtvGst.MouseUp
        Try
            Me.txtGstID.Text = Me.dgtvGst.CurrentRow.Cells(0).Value
            Me.txtGstFN.Text = Me.dgtvGst.CurrentRow.Cells(1).Value
            Me.txtGstMI.Text = Me.dgtvGst.CurrentRow.Cells(2).Value
            Me.txtGstLN.Text = Me.dgtvGst.CurrentRow.Cells(3).Value
            Me.txtContact.Text = Me.dgtvGst.CurrentRow.Cells(4).Value

            Me.txtGstID.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnAdd.Enabled = False

            If Room_Designation.Visible Then
                Try
                    Room_Designation.txtGuest.Text = Me.dgtvGst.CurrentRow.Cells(0).Value
                    dbObject.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf Transaction.Visible Then
                Try
                    Transaction.txtGuest.Text = Me.dgtvGst.CurrentRow.Cells(0).Value
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim gstid As Integer
        Dim cmdUpdate As DB2Command

        Try
            gstid = Me.txtGstID.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "delete from GUEST where gstid = '" & gstid & "'"

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub txtGstSearch_TextChanged(sender As Object, e As EventArgs) Handles txtGstSearch.TextChanged
        Dim gstidsearch As String
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()
        Try
            gstidsearch = Me.txtGstSearch.Text
            If IsInputNumeric(txtGstSearch.Text) Then
                'If numerical, assumes search is looking for ID'
                cmdSearch = dbObject.CreateCommand
                cmdSearch.CommandText = "select * from GUEST where gstid = '" & gstidsearch & "' order by gstid asc"
                rdrSearch = cmdSearch.ExecuteReader
                Me.dgtvGst.Rows.Clear()
                While rdrSearch.Read
                    row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4)}
                    Me.dgtvGst.Rows.Add(row)
                End While
            Else
                cmdSearch = dbObject.CreateCommand
                cmdSearch.CommandText = "select * from GUEST where gstln like '" & gstidsearch & "%' or gstfn like '" & gstidsearch & "%' order by gstln asc, gstfn asc"
                rdrSearch = cmdSearch.ExecuteReader
                Me.dgtvGst.Rows.Clear()
                While rdrSearch.Read
                    row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4)}
                    Me.dgtvGst.Rows.Add(row)
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