Imports IBM.Data.DB2
Public Class Room_Designation
    Private dbObject As Common.DbConnection

    Private Sub Room_Designation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbObject = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbObject.Open()
            Call Populate_Grid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Populate_Grid()
        Dim cmdEmp As DB2Command
        Dim rdrEmp As DB2DataReader
        Dim row As String()
        Try
            cmdEmp = dbObject.CreateCommand
            cmdEmp.CommandText = "select * from ROOMDESIGNATION"
            rdrEmp = cmdEmp.ExecuteReader
            Me.dgtvDES.Rows.Clear()
            While rdrEmp.Read
                row = New String() {rdrEmp.GetString(0), rdrEmp.GetString(1), rdrEmp.GetString(2), rdrEmp.GetString(3), rdrEmp.GetString(4), rdrEmp.GetString(5)}
                Me.dgtvDES.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_PopulateGrid_Click(sender As Object, e As EventArgs) Handles btn_PopulateGrid.Click
        Call clear_screen()
        Call Populate_Grid()
        Me.txtSearch.Text = ""
        Me.txtGuest.Clear()
    End Sub

    Private Sub clear_screen()
        Me.txtDesigNo.Clear()
        Me.txtGuest.Clear()
        Me.txtSearch.Clear()
        Me.txtEmp.Clear()
        Me.txtDesigNo.Focus()
    End Sub

    Private Sub txtGuest_TextChanged(sender As Object, e As EventArgs) Handles txtGuest.MouseClick
        Guest_Information.Show()
    End Sub

    Private Sub txtEmp_TextChanged(sender As Object, e As EventArgs) Handles txtEmp.MouseClick
        Employee_Information.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim designo As String
        Dim gst As String
        Dim emp As String
        Dim cmdInsert As DB2Command

        designo = Me.txtDesigNo.Text
        gst = Me.txtGuest.Text
        emp = Me.txtEmp.Text

        Try
            cmdInsert = dbObject.CreateCommand
            cmdInsert.CommandText = "insert into ROOMDESIGNATION values('" & designo & "', '" & gst & "', '" & emp & "')"
            cmdInsert.ExecuteNonQuery()
            MsgBox("Data saved successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim designo As String
        Dim cmdDelete As DB2Command

        designo = Me.txtDesigNo.Text

        Try
            cmdDelete = dbObject.CreateCommand
            cmdDelete.CommandText = "delete from ROOMDESIGNATION where designo = '" & designo & "'"
            cmdDelete.ExecuteNonQuery()
            MsgBox("Data Deleted successfully!")
            Call Populate_Grid()
            Call clear_screen()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgtvDES_CellmouseUp(sender As Object, e As EventArgs) Handles dgtvDES.MouseUp

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim designo As String
        Dim cmdSearch As DB2Command
        Dim rdrSearch As DB2DataReader
        Dim row As String()

        Try
            designo = Me.txtSearch.Text

            cmdSearch = dbObject.CreateCommand
            cmdSearch.CommandText = "select * from ROOMDESIGNATION where designo = '" & designo & "' order by designo asc"
            rdrSearch = cmdSearch.ExecuteReader
            Me.dgtvDES.Rows.Clear()
            While rdrSearch.Read
                row = New String() {rdrSearch.GetString(0), rdrSearch.GetString(1), rdrSearch.GetString(2)}
                Me.dgtvDES.Rows.Add(row)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOpenList_Click(sender As Object, e As EventArgs) Handles btnOpenList.Click
        Room_Listing.Show()
    End Sub

End Class