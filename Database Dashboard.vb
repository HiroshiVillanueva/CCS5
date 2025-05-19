Imports IBM.Data.DB2
Public Class MENU
    Private dbOBJECT As Common.DbConnection

    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dbOBJECT = New DB2Connection("server=localhost;database=HOTELDB;" + "uid=HIROSHI; password=dylobro123")
            dbOBJECT.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        dbOBJECT.Close()
        Me.Close()
    End Sub

    Private Sub empShow_Click(sender As Object, e As EventArgs) Handles empShow.Click
        Employee_Information.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guest_Information.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Room_Availability_Index.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Room_Designation.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Transaction.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Room_Service.Show()
    End Sub
End Class
