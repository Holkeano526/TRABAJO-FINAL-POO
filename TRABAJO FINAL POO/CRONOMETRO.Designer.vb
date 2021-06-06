<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRONOMETRO
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
        Me.components = New System.ComponentModel.Container()
        Me.lblseg = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnparar = New System.Windows.Forms.Button()
        Me.btnlim = New System.Windows.Forms.Button()
        Me.btnInicia = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblseg
        '
        Me.lblseg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblseg.AutoSize = True
        Me.lblseg.BackColor = System.Drawing.Color.Transparent
        Me.lblseg.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseg.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblseg.Location = New System.Drawing.Point(495, 93)
        Me.lblseg.Name = "lblseg"
        Me.lblseg.Size = New System.Drawing.Size(194, 142)
        Me.lblseg.TabIndex = 14
        Me.lblseg.Text = "00"
        '
        'lblmin
        '
        Me.lblmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmin.AutoSize = True
        Me.lblmin.BackColor = System.Drawing.Color.Transparent
        Me.lblmin.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblmin.Location = New System.Drawing.Point(308, 93)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(194, 142)
        Me.lblmin.TabIndex = 13
        Me.lblmin.Text = "00"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblHora.Location = New System.Drawing.Point(119, 93)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(194, 142)
        Me.lblHora.TabIndex = 12
        Me.lblHora.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'btnparar
        '
        Me.btnparar.BackColor = System.Drawing.Color.SlateBlue
        Me.btnparar.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.pause__1_
        Me.btnparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnparar.FlatAppearance.BorderSize = 0
        Me.btnparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnparar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnparar.Location = New System.Drawing.Point(359, 303)
        Me.btnparar.Name = "btnparar"
        Me.btnparar.Size = New System.Drawing.Size(99, 54)
        Me.btnparar.TabIndex = 17
        Me.btnparar.UseVisualStyleBackColor = False
        '
        'btnlim
        '
        Me.btnlim.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnlim.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.recycle
        Me.btnlim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlim.FlatAppearance.BorderSize = 0
        Me.btnlim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlim.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnlim.Location = New System.Drawing.Point(543, 303)
        Me.btnlim.Name = "btnlim"
        Me.btnlim.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnlim.Size = New System.Drawing.Size(102, 54)
        Me.btnlim.TabIndex = 16
        Me.btnlim.UseVisualStyleBackColor = False
        '
        'btnInicia
        '
        Me.btnInicia.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnInicia.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.play_button
        Me.btnInicia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInicia.FlatAppearance.BorderSize = 0
        Me.btnInicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicia.ForeColor = System.Drawing.Color.Transparent
        Me.btnInicia.Location = New System.Drawing.Point(167, 303)
        Me.btnInicia.Name = "btnInicia"
        Me.btnInicia.Size = New System.Drawing.Size(90, 54)
        Me.btnInicia.TabIndex = 15
        Me.btnInicia.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.peligro
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(636, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 28)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.home
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(676, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(273, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 132)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label2.Location = New System.Drawing.Point(459, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 132)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = ":"
        '
        'CRONOMETRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TRABAJO_FINAL_POO.My.Resources.Resources.alberto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnparar)
        Me.Controls.Add(Me.btnlim)
        Me.Controls.Add(Me.btnInicia)
        Me.Controls.Add(Me.lblseg)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.lblHora)
        Me.Name = "CRONOMETRO"
        Me.Text = "CRONOMETRO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnparar As Button
    Friend WithEvents btnlim As Button
    Friend WithEvents btnInicia As Button
    Private WithEvents lblseg As Label
    Private WithEvents lblmin As Label
    Private WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
End Class
