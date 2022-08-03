Imports System.Data.SqlClient

Module Module1
    Public cn As SqlConnection

    Public Sub LD()
        cn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\MP_ Works\VB @VTA_DIP_2019\Electricity Company\Electricity Company\ElectricityDB.mdf;Integrated Security=True")
    End Sub

End Module
