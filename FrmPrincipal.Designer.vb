<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TareasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem, Me.GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem, Me.GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TareasToolStripMenuItem.Text = "Tareas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem
        '
        Me.ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem.Name = "ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem"
        Me.ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem.Text = "Consulta de casos y muertes por región"
        '
        'GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem
        '
        Me.GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem.Name = "GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem"
        Me.GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem.Text = "Gráfico de barra de los 9 países con más casos"
        '
        'GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem
        '
        Me.GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem.Name = "GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem"
        Me.GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem.Text = "Gráfico de torta por región con total de muertes"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 285)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "COVID19"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TareasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeCasosYMuertesPorRegiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GráficoDeBarraDeLos9PaísesConMásCasosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GráficoDeTortaPorRegiónConTotalDeMuertesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
