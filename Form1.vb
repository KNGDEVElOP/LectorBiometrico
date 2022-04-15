'IMPORTACION DE LIBRERIAS'

Imports System.Text
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form1
    'PROCEDIMIENTOS'


    Implements DPFP.Capture.EventHandler
    Private Captura As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    Private Delegate Sub delegadoMuestra(ByVal text As String)
    Private Delegate Sub delegadoControles()
    Private template As DPFP.Template


    Private Sub Mostrarveces(ByVal texto As String)
        If (vecesdedo.InvokeRequired) Then
            Dim Del As New delegadoMuestra(AddressOf Mostrarveces)
            Me.Invoke(Del, New Object() {texto})
        Else
            vecesdedo.Text = texto
        End If
    End Sub


    Private Sub Modificarcontroles()
        If (BTNGUARDAR.InvokeRequired) Then
            Dim deleg As New delegadoControles(AddressOf Modificarcontroles)
            Me.Invoke(deleg, New Object() {})
        Else
            Button3.Enabled = True
            BTNGUARDAR.Enabled = True
            TBNOMBRE.Enabled = True
            TBAPATERNO.Enabled = True
            TBCARRERA.Enabled = True
            TBCONTROL.Enabled = True
            TBMATERNO.Enabled = True
            TBSNOMBRE.Enabled = True
            TBHORARIO.Enabled = True








        End If
    End Sub



    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                Enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Pasa el dedo {0} veces", Enroller.FeaturesNeeded)
                vecesdedo.Text = text.ToString()
            Else
                MessageBox.Show("No Captura Perro Sarnoso")



            End If


        Catch ex As Exception

            MessageBox.Show("No Captura Perro Sarnoso y la cagaste feo")

        End Try
    End Sub


    Protected Sub Iniciarcaptura()

        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()


            Catch ex As Exception
                MessageBox.Show("No se puede iniciar")
            End Try



        End If
    End Sub



    Protected Sub Pararcaptura()

        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()


            Catch ex As Exception
                MessageBox.Show("No se pueden parar tus estupideces homs")
            End Try



        End If
    End Sub



    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete


        PonerImagen(ConvertirBmp(Sample))
        Procesar(Sample)

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch




    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        Iniciarcaptura()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Pararcaptura()

    End Sub

    'Es Una variable de tipo conversor de un DPFP.Sample a bitmmap'

    Protected Function ConvertirBmp(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim b As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, b)
        Return b


    End Function
    Private Sub PonerImagen(ByVal bmp)
        ImagenHuella.Image = bmp
    End Sub

    Protected Function Extraer(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet

        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function

    Protected Sub Procesar(ByVal sample As DPFP.Sample)
        Dim Caracteristicas As DPFP.FeatureSet = Extraer(sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not Caracteristicas Is Nothing) Then
            Try
                Enroller.AddFeatures(Caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Pasa el dedo {0} veces", Enroller.FeaturesNeeded)
                Mostrarveces(text.ToString())
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = Enroller.Template
                        Pararcaptura()
                        Modificarcontroles()

                    Case DPFP.Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        Pararcaptura()
                        Iniciarcaptura()

                End Select
            End Try
        End If
    End Sub

    Private Sub ImagenHuella_Click(sender As Object, e As EventArgs) Handles ImagenHuella.Click


    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click

        Dim builderconex As New MySqlConnectionStringBuilder With {
            .Server = "sql10.freemysqlhosting.net",
            .UserID = "sql10253980",
            .Database = "sql10253980",
            .Password = "zDpNbbEbTz",
            .SslMode = "0"
        }
        Dim conexion As New MySqlConnection(builderconex.ToString())
            conexion.Open()
            MsgBox("Conexion Realizada")




        Dim cmd As New MySqlCommand()
        cmd = conexion.CreateCommand
        If (TBNOMBRE.Text.ToString().Equals("") Or TBHORARIO.Text.ToString().Equals("")) Then
            MessageBox.Show("Debes de llenar los campos Obligatorios")
        Else
            cmd.CommandText = "INSERT INTO profesor(Nombre,Huella_Digital,Id_Horario,Segundo_Nombre,Apellido_Paterno,Apellido_Materno,Carrera,N_Control) VALUES(?,?,?,?,?,?,?,?)"
            cmd.Parameters.AddWithValue("Nombre", TBNOMBRE.Text.ToString())
            Using fm As New MemoryStream(template.Bytes)
                cmd.Parameters.AddWithValue("Huella_Digital", fm.ToArray())
            End Using
            cmd.Parameters.AddWithValue("Id_Horario", TBHORARIO.Text.ToString())
            cmd.Parameters.AddWithValue("Segundo_Nombre", TBSNOMBRE.Text.ToString())
            cmd.Parameters.AddWithValue("Apellido_Paterno", TBAPATERNO.Text.ToString())
            cmd.Parameters.AddWithValue("Apellido_Materno", TBMATERNO.Text.ToString())
            cmd.Parameters.AddWithValue("Carrera", TBCARRERA.Text.ToString())
            cmd.Parameters.AddWithValue("N_Control", TBCONTROL.Text.ToString())


            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            MessageBox.Show("OK")
            Button3.Enabled = True
            BTNGUARDAR.Enabled = False
            TBNOMBRE.Enabled = False
            TBHORARIO.Enabled = False



        End If

    End Sub

    Private Sub TBNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TBNOMBRE.TextChanged

    End Sub

    Private Sub TBSNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TBSNOMBRE.TextChanged

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Pararcaptura()
        Dim ventanaBuscar As New Busqueda()
        ventanaBuscar.ShowDialog()


    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Pararcaptura()
    End Sub

    Private Sub TBHORARIO_TextChanged(sender As Object, e As EventArgs) Handles TBHORARIO.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
        Application.ExitThread()

    End Sub
End Class
