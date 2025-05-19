Imports IBM.Data.DB2
Public Class Room_Listing
    Private dbObject As Common.DbConnection

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Room_Listing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If Room_Designation.Visible Then
            Me.txtDesig.Text = Room_Designation.txtDesigNo.text
            Room_Designation.txtDesigNo.Clear()
        End If
    End Sub

    Private Sub Populate_Grid()
        Dim cmdEmp As DB2Command
        Dim rdrEmp As DB2DataReader
        Dim row As String()
        Try
            cmdEmp = dbObject.CreateCommand
            cmdEmp.CommandText = "select * from ROOMLISTING"
            rdrEmp = cmdEmp.ExecuteReader
            Me.dgtvLST.Rows.Clear()
            While rdrEmp.Read
                row = New String() {rdrEmp.GetString(0), rdrEmp.GetString(1), rdrEmp.GetString(2), rdrEmp.GetString(3), rdrEmp.GetString(4), rdrEmp.GetString(5)}
                Me.dgtvLST.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtSearch.Text = ""
        Me.txtRoom.Clear()
        Me.txtList.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnAdd.Enabled = True
    End Sub

    Private Sub clear_screen()
        Me.txtList.Clear()
        Me.txtDesig.Clear()
        Me.txtRoom.Clear()
        Me.txtSearch.Clear()
        Me.txtBill.Clear()
        Me.txtcheckin.Value = Today
        Me.txtcheckout.Value = Today
        Me.txtList.Focus()

        Me.txtcheckin.Enabled = True
        Me.txtcheckout.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim list As String
        Dim room As String
        Dim desig As String
        Dim checkin As Date
        Dim checkout As Date
        Dim billing As String
        Dim day As Integer
        Dim cmdInsert As DB2Command

        Try
            list = Me.txtList.Text
            desig = Me.txtDesig.Text
            room = Me.txtRoom.Text
            checkin = Me.txtcheckin.Value
            checkout = Me.txtcheckout.Value
            day = (checkout - checkin).Days
            checkin = checkin.ToShortDateString
            checkout = checkout.ToShortDateString
            billing = Me.txtBill.Text
            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into ROOMLISTING values('" & list & "', '" & room & "', '" & desig & "', '" & checkin & "', '" & checkout & "', '" & billing & "', '" & day & "')"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")

            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim list As String
        Dim room As String
        Dim desig As String
        Dim billing As String
        Dim checkin As Date
        Dim checkout As Date
        Dim day As Integer
        Dim cmdUpdate As DB2Command

        Try
            list = Me.txtList.Text
            desig = Me.txtDesig.Text
            room = Me.txtRoom.Text
            billing = Me.txtBill.Text
            checkin = Me.txtcheckin.Value
            checkout = Me.txtcheckout.Value
            day = (checkout - checkin).Days
            checkin = checkin.ToShortDateString
            checkout = checkout.ToShortDateString

            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "update ROOMLISTING set designo = '" & desig & "', roomid = '" & room & "', billingno = '" & billing & "', checkin = '" & checkin & "', checkout = '" & checkout & "', days = '" & day & "' where listno = '" & list & "'"
            cmdUpdate.ExecuteNonQuery()

            Me.btnUpdate.Enabled = False
            Me.btnAdd.Enabled = True

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Updated successfully!")

            If Transaction.Visible Then
                Dim listsearch2 As String
                Dim cmdSearch As DB2Command
                Dim rdrSearch As DB2DataReader
                Dim cost As Decimal
                Dim total As Decimal

                listsearch2 = room
                cmdSearch = dbObject.CreateCommand
                cmdSearch.CommandText = "select cost from ROOM where roomid = '" & listsearch2 & "'"
                rdrSearch = cmdSearch.ExecuteReader
                If rdrSearch.HasRows Then
                    cost = rdrSearch("cost").ToString
                    MsgBox(cost.ToString)
                End If
                total = cost * day

                cmdUpdate = dbObject.CreateCommand
                cmdUpdate.CommandText = "update TRANSACTIONS set cost = '" & total & "' where billingno = '" & billing & "'"
                cmdUpdate.ExecuteNonQuery()

                Call Transaction.Populate_Grid()
            End If

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
            listno = Me.txtList.Text
            cmdUpdate = dbObject.CreateCommand
            cmdUpdate.CommandText = "delete from ROOMLISTING where listno = '" & listno & "'"

            cmdUpdate.ExecuteNonQuery()
            MsgBox("Record Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
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
            cmdSearch.CommandText = "select * from ROOMLISTING where listno = '" & listsearch & "' order by listno asc"
            rdrSearch = cmdSearch.ExecuteReader
            Me.dgtvLST.Rows.Clear()
            While rdrSearch.Read
                row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4), rdrSearch.GetString(5), rdrSearch.GetString(6)}
                Me.dgtvLST.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgtvLST_CellMousUp(sender As Object, e As EventArgs) Handles dgtvLST.MouseUp
        Try
            Me.txtList.Text = Me.dgtvLST.CurrentRow.Cells(0).Value
            Me.txtRoom.Text = Me.dgtvLST.CurrentRow.Cells(1).Value
            Me.txtDesig.Text = Me.dgtvLST.CurrentRow.Cells(2).Value
            Me.txtBill.Text = Me.dgtvLST.CurrentRow.Cells(5).Value



            Me.txtList.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnAdd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnPayed_Click(sender As Object, e As EventArgs) Handles btnPayed.Click
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()
        Try
            cmdSearch = dbObject.CreateCommand
            cmdSearch.CommandText = "select * from ROOMLISTING where billingno is null order by listno asc"
            rdrSearch = cmdSearch.ExecuteReader
            Me.dgtvLST.Rows.Clear()
            While rdrSearch.Read
                row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2), rdrSearch.GetString(3), rdrSearch.GetString(4), rdrSearch.GetString(5)}
                Me.dgtvLST.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtRoom_TextChanged(sender As Object, e As EventArgs) Handles txtRoom.MouseUp
        Room_Availability_Index.Show()
    End Sub

    Private Sub txtBill_TextChanged(sender As Object, e As EventArgs) Handles txtBill.MouseUp
        Transaction.Show()
    End Sub

    Private Sub txtBill_TextChanged_1(sender As Object, e As EventArgs) Handles txtBill.TextChanged
        If txtList.Text <> "" Then
            Transaction.Show()
        End If
    End Sub
End Class