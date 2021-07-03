Imports System.Data.OleDb


Public Class cRegiones
    Dim Cadena As String = "provider=microsoft.jet.oledb.4.0;data source=COVID19.mdb"
    Dim Conector As New OleDbConnection(Cadena)



    Dim CRegion As New OleDbCommand
    Dim AdapRegion As New OleDbDataAdapter(CRegion)
    Dim TablaRegion As New DataTable


    Dim CPais As New OleDbCommand
    Dim AdapPais As New OleDbDataAdapter(CPais)
    Dim TablaPais As New DataTable




    Dim CCovid As New OleDbCommand
    Dim AdapCovid As New OleDbDataAdapter(CCovid)
    Dim TablaCovid As New DataTable

    Public Sub New()
        CRegion.Connection = Conector
        CRegion.CommandType = CommandType.TableDirect
        CRegion.CommandText = "Regiones"
        AdapRegion.Fill(TablaRegion)
        Dim VDCRegion(1) As DataColumn
        VDCRegion(0) = TablaRegion.Columns("idregion")
        TablaRegion.PrimaryKey = VDCRegion



        CPais.Connection = Conector
        CPais.CommandType = CommandType.TableDirect
        CPais.CommandText = "Paises"
        AdapPais.Fill(TablaPais)
        Dim VDCPais(1) As DataColumn
        VDCPais(0) = TablaPais.Columns("idpais")
        TablaPais.PrimaryKey = VDCPais




        CCovid.Connection = Conector
        CCovid.CommandType = CommandType.Text

        CCovid.CommandText = "SELECT * FROM Covids ORDER BY casos desc"
        AdapCovid.Fill(TablaCovid)
        Dim VDCCovid(1) As DataColumn
        VDCCovid(0) = TablaCovid.Columns("idpais")
        TablaCovid.PrimaryKey = VDCCovid


    End Sub

    Public Sub llenarCombo(ByVal COMBO As ComboBox)

        'Dim Regiones() As DataRow = Tabla.Select
        COMBO.DisplayMember = "nombre"
        COMBO.ValueMember = "idregion"
        COMBO.DataSource = TablaRegion



    End Sub



    Function llenarGridView(ByVal Grid As DataGridView, numeroregion As Integer, ByVal casos As Integer, ByVal muertes As Integer) As Integer

        Grid.Rows.Clear()

        For Each RPais As DataRow In TablaPais.Rows
            If (RPais("idregion")) = numeroregion Then

                For Each RCovid As DataRow In TablaCovid.Rows
                    If (RPais("idpais")) = (RCovid("idpais")) Then
                       
                        Grid.Rows.Add(RPais("nombre"), RCovid("casos"), RCovid("muertes"))

                    End If
                Next
            End If
        Next

        Return casos


    End Function

    Function muertesCovid(numeroregion As Integer) As Integer

        Dim muerte As Integer
        Dim acumulador As Integer
        For Each Rpais As DataRow In TablaPais.Rows
                For Each Rcovid As DataRow In TablaCovid.Rows
                    If (Rpais("idpais")) = (Rcovid("idpais")) And (Rpais("idregion")) = numeroregion Then
                    muerte = (Rcovid("muertes"))
                End If
                acumulador = acumulador + muerte
                muerte = 0
            Next
            Next


        Return acumulador

    End Function


    Function casosCovid(numeroregion As Integer) As Integer

        Dim casosguardados(200) As Integer

        Dim casos As Integer
        Dim acumulador As Integer
        For Each Rpais As DataRow In TablaPais.Rows
            For Each Rcovid As DataRow In TablaCovid.Rows
                For i = 0 To casosguardados(200)
                    If (Rpais("idpais")) = (Rcovid("idpais")) And (Rpais("idregion")) = numeroregion Then
                        casos = (Rcovid("casos"))
                        casosguardados(i) = (Rcovid("casos"))
                        i = i + 1
                    End If
                    acumulador = acumulador + casos
                    casos = 0
                Next
            Next
            Next


        Dim aux As Integer


        

        Return acumulador

    End Function


    '    'Dim muertes As Integer
    '    For Each RPais As DataRow In TablaPais.Rows
    '        If (RPais("idregion")) = numeroregion Then
    '            For Each RCovid As DataRow In TablaCovid.Rows
    '                If (RPais("idpais")) = (RCovid("idpais")) Then
    '                    muertes = (RCovid("muertes"))
    '                End If
    '            Next
    '        End If
    '    Next

    '    Return muertes


    'End Function

    ' for Each RCovid as DataRow In Tablacovid.rows
    ' if (RPais("idpais") = RCovid("idpais)) then
    ' muertes
    ' For Each RPais As DataRow In TablaPais.Rows
    ' If (RPais("idregion")) = numeroregion Then
    '
    '
    '
    '*

    '*
    Public Function obtenernombre(idpais As Long) As String
        Dim nombre As String = ""
        Dim dr As DataRow
        Dim valor(0) As Object
        valor(0) = idpais
        dr = TablaPais.Rows.Find(valor)
        If dr IsNot Nothing Then
            nombre = dr("nombre")
        End If

        Return nombre

    End Function




    Public Sub graficar(graf As DataVisualization.Charting.Chart)
        Dim i As Integer = 0
        Dim d As Integer = 0
        Dim j As Integer = 0
        Dim aux As Integer = 0
        Dim f As Integer
        Dim p As Integer = 0

        Dim c As Integer = 0

        Dim constante = 0


        Dim variable1 As Integer = 9

        Dim casosguardados(234) As Integer
        For Each Rcovid As DataRow In TablaCovid.Rows
            For i = 0 To casosguardados(234)
                casosguardados(d) = (Rcovid("casos"))
                d = d + 1

            Next
        Next



        While i < casosguardados.Length - 1

            While j < casosguardados.Length - 1

                If casosguardados(j) < casosguardados(j + 1) Then
                    aux = casosguardados(j)
                    casosguardados(j) = casosguardados(j + 1)
                    casosguardados(j + 1) = aux
                End If
                j = j + 1
            End While
            i = i + 1
            j = 0
        End While

        graf.Series.Clear()
        graf.Series.Add("LOS 9 PAISES CON MAS CASOS DE COVID")
        graf.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column


            For Each dr As DataRow In TablaCovid.Rows

            graf.Series(0).Points.Add(dr("casos"))
            graf.Series(0).Points(p).AxisLabel = obtenernombre(dr("idpais"))
            If c >= 8 Then
                Exit For
            End If
            p = p + 1
            f = f + 1
            c += 1
        Next

            Dim variablep As Integer = p

    End Sub

    Public Sub graficar2(graf As DataVisualization.Charting.Chart)
        Dim i As Integer = 0
        Dim d As Integer = 0
        Dim j As Integer = 0
        Dim aux As Integer = 0
        Dim f As Integer
        Dim p As Integer = 0

        Dim c As Integer = 0


        Dim colores() As Color = {Color.Blue, Color.Orange, Color.Green, Color.Red, Color.BlueViolet,
                                 Color.Yellow, Color.White, Color.DarkRed, Color.Black}




        Dim casosguardados(234) As Integer
        For Each Rcovid As DataRow In TablaCovid.Rows
            For i = 0 To casosguardados(234)
                casosguardados(d) = (Rcovid("casos"))
                d = d + 1

            Next
        Next

        i = 0
        j = 0
        While i < casosguardados.Length - 1

            While j < casosguardados.Length - 1

                If casosguardados(j) < casosguardados(j + 1) Then
                    aux = casosguardados(j)
                    casosguardados(j) = casosguardados(j + 1)
                    casosguardados(j + 1) = aux
                End If
                j = j + 1
            End While
            i = i + 1
            j = 0
        End While

        graf.Series.Clear()
        graf.Series.Add("LOS 9 PAISES CON MAS CASOS DE COVID")
        graf.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        For i = 0 To 8
            For Each dr As DataRow In TablaCovid.Rows
                If casosguardados(f) = (dr("casos")) Then

                    graf.Series(0).Points.Add(casosguardados(f))
                    graf.Series(0).Points(p).AxisLabel = obtenernombre(dr("idpais"))

                    f = f + 1
                    p = p + 1
                    c = c + 1
                End If
            Next
            i = i + 1
        Next



    End Sub

End Class



'i = 0
'  j = 0
'  While i < casosguardados.Length - 1

'      While j < casosguardados.Length - 1

'          If casosguardados(j) > casosguardados(j + 1) Then
'              aux = casosguardados(j)
'              casosguardados(j) = casosguardados(j + 1)
'              casosguardados(j + 1) = aux
'          End If
'          j = j + 1
'      End While
'      i = i + 1
'      j = 0
'  End While