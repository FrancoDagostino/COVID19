<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarea2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GRA = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bGraficar = New System.Windows.Forms.Button()
        CType(Me.GRA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRA
        '
        Me.GRA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.GRA.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GRA.Legends.Add(Legend1)
        Me.GRA.Location = New System.Drawing.Point(28, 69)
        Me.GRA.Name = "GRA"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(1, Byte), True)
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.GRA.Series.Add(Series1)
        Me.GRA.Size = New System.Drawing.Size(1185, 476)
        Me.GRA.TabIndex = 0
        Me.GRA.Text = "Chart1"
        '
        'bGraficar
        '
        Me.bGraficar.Location = New System.Drawing.Point(28, 24)
        Me.bGraficar.Name = "bGraficar"
        Me.bGraficar.Size = New System.Drawing.Size(126, 23)
        Me.bGraficar.TabIndex = 3
        Me.bGraficar.Text = "GRAFICAR"
        Me.bGraficar.UseVisualStyleBackColor = True
        '
        'FrmTarea2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 575)
        Me.Controls.Add(Me.bGraficar)
        Me.Controls.Add(Me.GRA)
        Me.Name = "FrmTarea2"
        Me.Text = "Gráfico de barra de los 9 países con más casos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GRA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRA As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents bGraficar As System.Windows.Forms.Button
End Class
