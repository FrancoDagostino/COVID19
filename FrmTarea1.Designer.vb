<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarea1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.bConsultar = New System.Windows.Forms.Button()
        Me.GRILLA = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCasos = New System.Windows.Forms.Label()
        Me.lblMuertes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.asdasd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGION"
        '
        'cbRegion
        '
        Me.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Location = New System.Drawing.Point(135, 28)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(260, 21)
        Me.cbRegion.TabIndex = 1
        '
        'bConsultar
        '
        Me.bConsultar.Location = New System.Drawing.Point(435, 26)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(126, 23)
        Me.bConsultar.TabIndex = 2
        Me.bConsultar.Text = "CONSULTAR"
        Me.bConsultar.UseVisualStyleBackColor = True
        '
        'GRILLA
        '
        Me.GRILLA.AllowUserToAddRows = False
        Me.GRILLA.AllowUserToDeleteRows = False
        Me.GRILLA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRILLA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asdasd, Me.Column1, Me.Column2})
        Me.GRILLA.Location = New System.Drawing.Point(33, 122)
        Me.GRILLA.Name = "GRILLA"
        Me.GRILLA.ReadOnly = True
        Me.GRILLA.Size = New System.Drawing.Size(868, 384)
        Me.GRILLA.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CASOS TOTALES"
        '
        'lblCasos
        '
        Me.lblCasos.BackColor = System.Drawing.Color.Black
        Me.lblCasos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasos.ForeColor = System.Drawing.Color.White
        Me.lblCasos.Location = New System.Drawing.Point(136, 75)
        Me.lblCasos.Name = "lblCasos"
        Me.lblCasos.Size = New System.Drawing.Size(129, 23)
        Me.lblCasos.TabIndex = 5
        Me.lblCasos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMuertes
        '
        Me.lblMuertes.BackColor = System.Drawing.Color.Black
        Me.lblMuertes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuertes.ForeColor = System.Drawing.Color.White
        Me.lblMuertes.Location = New System.Drawing.Point(432, 75)
        Me.lblMuertes.Name = "lblMuertes"
        Me.lblMuertes.Size = New System.Drawing.Size(129, 23)
        Me.lblMuertes.TabIndex = 7
        Me.lblMuertes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "MUERTES TOTALES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'asdasd
        '
        Me.asdasd.HeaderText = "Paises"
        Me.asdasd.Name = "asdasd"
        Me.asdasd.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Casos"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Muertes"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'FrmTarea1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 546)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMuertes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCasos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GRILLA)
        Me.Controls.Add(Me.bConsultar)
        Me.Controls.Add(Me.cbRegion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTarea1"
        Me.Text = "Consulta de casos y muertes por región"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbRegion As System.Windows.Forms.ComboBox
    Friend WithEvents bConsultar As System.Windows.Forms.Button
    Friend WithEvents GRILLA As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCasos As System.Windows.Forms.Label
    Friend WithEvents lblMuertes As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents asdasd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
