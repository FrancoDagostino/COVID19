Imports System.Data.OleDb
Public Class Covids
    Dim Cadena As String = "provider=microsoft.jet.oledb.4.0;data source=COVID19.mdb"
    Dim Conector As New OleDbConnection(Cadena)
    Dim Comando As New OleDbCommand
    Dim Adaptador As New OleDbDataAdapter(Comando)
    Dim Tabla As New DataTable


    Public Sub New()
        Comando.Connection = Conector
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Covids"
        Adaptador.Fill(Tabla)
        Dim VDC(1) As DataColumn
        VDC(0) = Tabla.Columns("idpais")
        Tabla.PrimaryKey = VDC


    End Sub
End Class
