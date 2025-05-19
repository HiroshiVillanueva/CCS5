Imports IBM.Data.DB2
Public Class Transaction
    Private dbObject As Common.DbConnection
    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clear_screen()
        Me.txtReciept.Clear()
        Me.txtGuest.Clear()
        Me.txtEmp.Clear()
        Me.txtdate.Value = Today
        Me.txtReciept.Focus()
    End Sub

    Public Sub Populate_Grid()
        Dim cmdEmp As DB2Command
        Dim rdrEmp As DB2DataReader
        Dim row As String()
        Try
            cmdEmp = dbObject.CreateCommand
            cmdEmp.CommandText = "select * from TRANSACTIONS"
            rdrEmp = cmdEmp.ExecuteReader
            Me.dgtvTRANS.Rows.Clear()
            While rdrEmp.Read
                row = New String() {rdrEmp.GetString(0), rdrEmp.GetString(1), rdrEmp.GetString(2), rdrEmp.GetString(3), rdrEmp.GetString(4)}
                Me.dgtvTRANS.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtSearch.Clear()
        Me.txtReciept.Clear()
        Me.txtReciept.Enabled = True
        Me.btnAdd.Enabled = True
    End Sub

    Private Sub btnOpenListing_Click(sender As Object, e As EventArgs) Handles btnOpenListing.Click
        Room_Listing.Show()
    End Sub

    Private Sub btnOpenService_Click(sender As Object, e As EventArgs) Handles btnOpenService.Click
        'room service here'
    End Sub

    Private Sub txtGuest_TextChanged(sender As Object, e As EventArgs) Handles txtGuest.MouseUp
        Guest_Information.Show()
    End Sub

    Private Sub txtEmp_TextChanged(sender As Object, e As EventArgs) Handles txtEmp.MouseUp
        Employee_Information.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rec As String
        Dim gst As String
        Dim emp As String
        Dim dat As Date
        Dim cmdInsert As DB2Command

        Try
            rec = Me.txtReciept.Text
            gst = Me.txtGuest.Text
            emp = Me.txtEmp.Text
            dat = Me.txtdate.Value
            dat = dat.ToShortDateString

            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into TRANSACTIONS values('" & rec & "', '" & gst & "', '" & emp & "', '" & dat & "', 0)"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")

            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim listno As String
        Dim cmdUpdate As DB2Command

        Try
            listno = Me.txtReciept.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "delete from TRANSACTIONS where reciept = '" & listno & "'"

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgtvTRANS_CellContentClick(sender As Object, e As EventArgs) Handles dgtvTRANS.MouseUp
        Try
            Me.txtReciept.Text = Me.dgtvTRANS.CurrentRow.Cells(0).Value
            Me.txtGuest.Text = Me.dgtvTRANS.CurrentRow.Cells(1).Value
            Me.txtEmp.Text = Me.dgtvTRANS.CurrentRow.Cells(2).Value

            If Room_Listing.Visible Then
                Try
                    Room_Listing.txtBill.Text = Me.dgtvTRANS.CurrentRow.Cells(0).Value
                    dbObject.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            Me.btnAdd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim listsearch As String
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()
        Try
            listsearch = Me.txtSearch.Text
            cmdSearch = dbObject.CreateCommand
            cmdSearch.CommandText = "select * from TRANSACTIONS where reciept = '" & listsearch & "' order by reciept asc"
            rdrSearch = cmdSearch.ExecuteReader
            Me.dgtvTRANS.Rows.Clear()
            While rdrSearch.Read
                row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4)}
                Me.dgtvTRANS.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class