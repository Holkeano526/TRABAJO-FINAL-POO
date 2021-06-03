<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALENDARIO
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
        Me.calendariodate = New System.Windows.Forms.DateTimePicker()
        Me.calendarioMonth = New System.Windows.Forms.MonthCalendar()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.txtfin = New System.Windows.Forms.TextBox()
        Me.txtinicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calendariodate
        '
        Me.calendariodate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendariodate.Location = New System.Drawing.Point(149, 111)
        Me.calendariodate.Name = "calendariodate"
        Me.calendariodate.Size = New System.Drawing.Size(246, 22)
        Me.calendariodate.TabIndex = 2
        '
        'calendarioMonth
        '
        Me.calendarioMonth.Location = New System.Drawing.Point(149, 177)
        Me.calendarioMonth.Name = "calendarioMonth"
        Me.calendarioMonth.TabIndex = 3
        '
        'btnmostrar
        '
        Me.btnmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrar.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnmostrar.Location = New System.Drawing.Point(478, 296)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(175, 40)
        Me.btnmostrar.TabIndex = 11
        Me.btnmostrar.Text = "MOSTRAR"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'txtfin
        '
        Me.txtfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfin.ForeColor = System.Drawing.Color.Maroon
        Me.txtfin.Location = New System.Drawing.Point(487, 258)
        Me.txtfin.Name = "txtfin"
        Me.txtfin.Size = New System.Drawing.Size(151, 21)
        Me.txtfin.TabIndex = 8
        '
        'txtinicio
        '
        Me.txtinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtinicio.Location = New System.Drawing.Point(487, 203)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(151, 21)
        Me.txtinicio.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(487, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(487, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INICIO"
        '
        'txtfecha
        '
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.ForeColor = System.Drawing.Color.Red
        Me.txtfecha.Location = New System.Drawing.Point(487, 144)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(140, 21)
        Me.txtfecha.TabIndex = 10
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.Red
        Me.lblfecha.Location = New System.Drawing.Point(487, 125)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(53, 17)
        Me.lblfecha.TabIndex = 7
        Me.lblfecha.Text = "FECHA:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.home_white
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(681, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.peligro_white
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(641, 392)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CALENDARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.fondo_jose_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.txtfin)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.calendarioMonth)
        Me.Controls.Add(Me.calendariodate)
        Me.DoubleBuffered = True
        Me.Name = "CALENDARIO"
        Me.Text = "CALENDARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendariodate As DateTimePicker
    Friend WithEvents calendarioMonth As MonthCalendar
    Friend WithEvents btnmostrar As Button
    Friend WithEvents txtfin As TextBox
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents lblfecha As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
