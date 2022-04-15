
Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class Busqueda
    Implements DPFP.Capture.EventHandler
    Private Captura As DPFP.Capture.Capture
    Private template As DPFP.Template
    Private verificador As DPFP.Verification.Verification

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                verificador = New Verification.Verification()
                template = New Template()
            Else
                MessageBox.Show("No se pudo instanciar la catura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub
    Protected Sub Iniciarcaptura()

        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub
    Protected Sub Pararcaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se puede detener la captura")
            End Try
        End If
    End Sub
    Private Sub PonerImagen(ByVal bmp)
        ImagenHuella.Image = bmp
    End Sub
    Protected Function ConvertirBmp(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim b As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, b)
        Return b
    End Function
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
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        PonerImagen(ConvertirBmp(Sample))
        Dim caracteristicas As DPFP.FeatureSet = Extraer(Sample, DPFP.Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()
            Dim builderconex As New MySqlConnectionStringBuilder With {
                .Server = "sql10.freemysqlhosting.net",
            .UserID = "sql10253980",
            .Database = "sql10253980",
            .Password = "zDpNbbEbTz",
            .SslMode = "0"
            }



            Dim conexion As New MySqlConnection(builderconex.ToString())
            conexion.Open()
            Dim cmd As New MysqlCommand()
            cmd = conexion.CreateCommand
            cmd.CommandText = "Select * FROM profesor"
            Dim read As MysqlDataReader
            read = cmd.ExecuteReader()
            Dim verificado As Boolean = False
            Dim nombre As String = ""

            While (read.Read())
                nombre = read("N_Control")

                Dim memoria As New MemoryStream(CType(read("Huella_Digital"), Byte()))
                template.DeSerialize(memoria.ToArray())
                verificador.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    nombre = read("N_Control")
                    verificado = True




                    Exit While
                End If
            End While



            If (verificado) Then
                Dim conexion1 As New MySqlConnection(builderconex.ToString())
                conexion1.Open()
                Dim cmd1 As New MySqlCommand()
                cmd1 = conexion1.CreateCommand
                Dim Fecha As DateTime = DateTime.Now.ToLongDateString
                Dim Hora As DateTime = DateTime.Now.ToLongTimeString




                cmd1.CommandText = "INSERT INTO registro(N_Control,Fecha,Hora) VALUES(?,?,?)"

                cmd1.Parameters.AddWithValue("N_Control", nombre)
                cmd1.Parameters.AddWithValue("Fecha", Fecha)
                cmd1.Parameters.AddWithValue("Hora", Hora)

                cmd1.ExecuteNonQuery()
                cmd1.Dispose()


                MessageBox.Show("Se realizo el registro del Numero de control: " & nombre & " Hora: " & Hora & " Fecha: " & Fecha)

            Else
                MessageBox.Show("No se encontro ningun registro")
            End If

            read.Dispose()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        End If
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
    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        Iniciarcaptura()
    End Sub

    Private Sub Busqueda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Pararcaptura()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Fecha As DateTime = DateTime.Now.ToLongDateString
        Dim Hora As DateTime = DateTime.Now.ToLongTimeString
        Label1.Text = Hora
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = TimeOfDay.TimeOfDay.ToString


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Close()

    End Sub
End Class