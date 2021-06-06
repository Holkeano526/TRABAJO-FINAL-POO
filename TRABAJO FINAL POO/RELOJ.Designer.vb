<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RELOJ
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblAm = New System.Windows.Forms.Label()
        Me.lblseg = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.HorayFecha = New System.Windows.Forms.Timer(Me.components)
        Me.AmyPm = New System.Windows.Forms.Timer(Me.components)
        Me.lblmin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAm
        '
        Me.lblAm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAm.AutoSize = True
        Me.lblAm.BackColor = System.Drawing.Color.Transparent
        Me.lblAm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAm.Location = New System.Drawing.Point(550, 157)
        Me.lblAm.Name = "lblAm"
        Me.lblAm.Size = New System.Drawing.Size(69, 39)
        Me.lblAm.TabIndex = 26
        Me.lblAm.Text = "AM"
        '
        'lblseg
        '
        Me.lblseg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblseg.AutoSize = True
        Me.lblseg.BackColor = System.Drawing.Color.Transparent
        Me.lblseg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblseg.Location = New System.Drawing.Point(553, 222)
        Me.lblseg.Name = "lblseg"
        Me.lblseg.Size = New System.Drawing.Size(34, 24)
        Me.lblseg.TabIndex = 25
        Me.lblseg.Text = "00"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFecha.Location = New System.Drawing.Point(233, 266)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(121, 40)
        Me.lblFecha.TabIndex = 23
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHora.Location = New System.Drawing.Point(160, 124)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(194, 142)
        Me.lblHora.TabIndex = 22
        Me.lblHora.Text = "00"
        '
        'HorayFecha
        '
        Me.HorayFecha.Enabled = True
        Me.HorayFecha.Interval = 1
        '
        'AmyPm
        '
        Me.AmyPm.Enabled = True
        Me.AmyPm.Interval = 1
        '
        'lblmin
        '
        Me.lblmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmin.AutoSize = True
        Me.lblmin.BackColor = System.Drawing.Color.Transparent
        Me.lblmin.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblmin.Location = New System.Drawing.Point(377, 124)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(194, 142)
        Me.lblmin.TabIndex = 24
        Me.lblmin.Text = "00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(328, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 96)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = ":"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.peligro
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(610, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.home
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(650, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RELOJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.fondo_visual_arreglado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAm)
        Me.Controls.Add(Me.lblseg)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.DoubleBuffered = True
        Me.Name = "RELOJ"
        Me.Text = "RELOJ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblAm As Label
    Private WithEvents lblseg As Label
    Private WithEvents lblFecha As Label
    Private WithEvents lblHora As Label
    Friend WithEvents HorayFecha As Timer
    Friend WithEvents AmyPm As Timer
    Private WithEvents lblmin As Label
    Private WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
