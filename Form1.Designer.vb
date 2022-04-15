<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImagenHuella = New System.Windows.Forms.PictureBox()
        Me.vecesdedo = New System.Windows.Forms.Label()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TBNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TBSNOMBRE = New System.Windows.Forms.TextBox()
        Me.TBAPATERNO = New System.Windows.Forms.TextBox()
        Me.TBMATERNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBCONTROL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBHORARIO = New System.Windows.Forms.TextBox()
        Me.TBCARRERA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ImagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenHuella
        '
        Me.ImagenHuella.BackColor = System.Drawing.Color.White
        Me.ImagenHuella.Location = New System.Drawing.Point(12, 12)
        Me.ImagenHuella.Name = "ImagenHuella"
        Me.ImagenHuella.Size = New System.Drawing.Size(281, 361)
        Me.ImagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenHuella.TabIndex = 0
        Me.ImagenHuella.TabStop = False
        '
        'vecesdedo
        '
        Me.vecesdedo.AutoSize = True
        Me.vecesdedo.Location = New System.Drawing.Point(102, 409)
        Me.vecesdedo.Name = "vecesdedo"
        Me.vecesdedo.Size = New System.Drawing.Size(69, 13)
        Me.vecesdedo.TabIndex = 1
        Me.vecesdedo.Text = "Pasa el dedo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Enabled = False
        Me.BTNGUARDAR.Location = New System.Drawing.Point(791, 31)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 63)
        Me.BTNGUARDAR.TabIndex = 2
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'TBNOMBRE
        '
        Me.TBNOMBRE.Enabled = False
        Me.TBNOMBRE.Location = New System.Drawing.Point(459, 31)
        Me.TBNOMBRE.Name = "TBNOMBRE"
        Me.TBNOMBRE.Size = New System.Drawing.Size(273, 20)
        Me.TBNOMBRE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(313, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(791, 161)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 61)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TBSNOMBRE
        '
        Me.TBSNOMBRE.Enabled = False
        Me.TBSNOMBRE.Location = New System.Drawing.Point(459, 87)
        Me.TBSNOMBRE.Name = "TBSNOMBRE"
        Me.TBSNOMBRE.Size = New System.Drawing.Size(273, 20)
        Me.TBSNOMBRE.TabIndex = 6
        '
        'TBAPATERNO
        '
        Me.TBAPATERNO.Enabled = False
        Me.TBAPATERNO.Location = New System.Drawing.Point(459, 135)
        Me.TBAPATERNO.Name = "TBAPATERNO"
        Me.TBAPATERNO.Size = New System.Drawing.Size(273, 20)
        Me.TBAPATERNO.TabIndex = 7
        '
        'TBMATERNO
        '
        Me.TBMATERNO.Enabled = False
        Me.TBMATERNO.Location = New System.Drawing.Point(459, 193)
        Me.TBMATERNO.Name = "TBMATERNO"
        Me.TBMATERNO.Size = New System.Drawing.Size(273, 20)
        Me.TBMATERNO.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(313, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SEGUNDO NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(313, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "APELLIDO PATERNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(311, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "APELLIDO MATERNO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(311, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NUMERO DE CONTROL"
        '
        'TBCONTROL
        '
        Me.TBCONTROL.Enabled = False
        Me.TBCONTROL.Location = New System.Drawing.Point(459, 252)
        Me.TBCONTROL.Name = "TBCONTROL"
        Me.TBCONTROL.Size = New System.Drawing.Size(273, 20)
        Me.TBCONTROL.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(311, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID HORARIO"
        '
        'TBHORARIO
        '
        Me.TBHORARIO.Enabled = False
        Me.TBHORARIO.Location = New System.Drawing.Point(459, 304)
        Me.TBHORARIO.Name = "TBHORARIO"
        Me.TBHORARIO.Size = New System.Drawing.Size(273, 20)
        Me.TBHORARIO.TabIndex = 15
        '
        'TBCARRERA
        '
        Me.TBCARRERA.BackColor = System.Drawing.Color.White
        Me.TBCARRERA.Enabled = False
        Me.TBCARRERA.Location = New System.Drawing.Point(459, 350)
        Me.TBCARRERA.Name = "TBCARRERA"
        Me.TBCARRERA.Size = New System.Drawing.Size(273, 20)
        Me.TBCARRERA.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(311, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "CARRERA"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(791, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 63)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "NUEVO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 493)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBCARRERA)
        Me.Controls.Add(Me.TBHORARIO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBCONTROL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBMATERNO)
        Me.Controls.Add(Me.TBAPATERNO)
        Me.Controls.Add(Me.TBSNOMBRE)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNOMBRE)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.vecesdedo)
        Me.Controls.Add(Me.ImagenHuella)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Biometrico"
        CType(Me.ImagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenHuella As PictureBox
    Friend WithEvents vecesdedo As Label
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents TBNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TBSNOMBRE As TextBox
    Friend WithEvents TBAPATERNO As TextBox
    Friend WithEvents TBMATERNO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBCONTROL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBHORARIO As TextBox
    Friend WithEvents TBCARRERA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
End Class
