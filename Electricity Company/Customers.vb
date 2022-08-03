Imports System.Data.SqlClient

Public Class frmCustInfo

    Private Sub frmCustInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LD()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As SqlCommand

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        cmd = New SqlCommand("INSERT INTO Coustomers(Coustomer_No,Coustomer_Name,Address,NIC_No,Contact_No) VALUES('" & txtCustNo.Text & "','" & txtCustName.Text & "','" & txtAdrs.Text & "','" & txtNic.Text & "','" & txtConNo.Text & "')", cn)

        cn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Payment.Show()
    End Sub

End Class
