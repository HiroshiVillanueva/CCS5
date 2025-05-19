Imports IBM.Data.DB2
Public Class Service_Request
    Private dbObject As Common.DbConnection

    Private Sub Service_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Populate_Grid()
        Dim cmdGst As DB2Command
        Dim rdrGst As DB2DataReader
        Dim row As String()
        Try
            cmdGst = dbObject.CreateCommand
            cmdGst.CommandText = "select * from ROOMSERVICEREQUEST"
            rdrGst = cmdGst.ExecuteReader
            Me.dgtvRq.Rows.Clear()
            While rdrGst.Read
                row = New String() {rdrGst.GetString(0), rdrGst.GetString(1), rdrGst.GetString(2), rdrGst.GetString(3), rdrGst.GetString(4), rdrGst.GetString(5)}
                Me.dgtvRq.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtSearch.Clear()
        Me.txtrqID.Clear()
        Me.txtrqID.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnAdd.Enabled = True
    End Sub

    Private Sub clear_screen()
        Me.txtrqID.Clear()
        Me.txtEmp.Clear()
        Me.txtGuest.Clear()
        Me.txtDate.Value = Today
        Me.txtsrvID.Clear()
        Me.txtBilling.Clear()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rqid As String
        Dim guest As String
        Dim emp As String
        Dim srvid As String
        Dim datt As Date
        Dim bill As String
        Dim cmdInsert As DB2Command

        Try
            rqid = Me.txtrqID.Text
            guest = Me.txtGuest.Text
            emp = Me.txtEmp.Text
            srvid = Me.txtsrvID.Text
            datt = Me.txtDate.Value
            datt = datt.ToShortDateString
            bill = Me.txtBilling.Text
            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into ROOMSERVICEREQUEST values('" & rqid & "', '" & guest & "', '" & emp & "', '" & srvid & "' '" & datt & "' '" & bill & "')"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rqid As String
        Dim guest As String
        Dim emp As String
        Dim srvid As String
        Dim datt As Date
        Dim bill As String
        Dim cmdUpdate As DB2Command

        Try
            rqid = Me.txtrqID.Text
            guest = Me.txtGuest.Text
            emp = Me.txtEmp.Text
            srvid = Me.txtsrvID.Text
            datt = Me.txtDate.Value
            datt = datt.ToShortDateString
            bill = Me.txtBilling.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "update ROOMSERVICEREQUEST set guestid = '" & guest & "', empid = '" & emp & "', srvid = '" & srvid & "', date = '" & datt & "', billingno = '" & bill & "' where reqid = '" & rqid & "'"


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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rqid As Integer
        Dim cmdUpdate As DB2Command

        Try
            rqid = Me.txtrqID.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "delete from ROOMSERVICEREQUEST where reqid = '" & rqid & "'"

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub dgtvRq_CellContentClick(sender As Object, e As EventArgs) Handles dgtvRq.MouseUp
        Try
            Me.txtrqID.Text = Me.dgtvRq.CurrentRow.Cells(0).Value
            Me.txtGuest.Text = Me.dgtvRq.CurrentRow.Cells(1).Value
            Me.txtEmp.Text = Me.dgtvRq.CurrentRow.Cells(2).Value
            Me.txtsrvID.Text = Me.dgtvRq.CurrentRow.Cells(3).Value
            Me.txtBilling.Text = Me.dgtvRq.CurrentRow.Cells(5).Value

            Me.txtsrvID.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnAdd.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim gstidsearch As String
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()
        Try
            gstidsearch = Me.txtSearch.Text
            cmdSearch = dbObject.CreateCommand
            cmdSearch.CommandText = "select * from ROOMSERVICEREQUEST where reqid like '" & gstidsearch & "%' order by reqid asc"
            rdrSearch = cmdSearch.ExecuteReader
            Me.dgtvRq.Rows.Clear()
            While rdrSearch.Read
                row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4)}
                Me.dgtvRq.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class