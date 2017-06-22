Imports System.Threading

Public Class Form1

    Dim entrada As String
    Dim valido As Boolean
    Dim test As Integer

    Dim Frec_input As Integer

    Dim cambio As Boolean
    Dim envio As Boolean

    Dim contador As Integer
    Dim dac As Double



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Timer.Enabled = False
        Testear_Puertos()  ' Puertos Disponibles
        'PuertosComboBox.SelectedItem = PuertosComboBox.Items.Item(0)
        Puerto.Encoding = System.Text.Encoding.GetEncoding(1252)
        seno.Checked = True
        Label3.Text = Frecuencia.Value
        Timer.Start()
        envio = False

        dac = 0
        contador = 0

    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        If PuertosComboBox.SelectedItem <> Nothing Then
            If Conectar.Text = "Conectar" Then
                Conectar.Text = "Desconectar " & PuertosComboBox.SelectedItem
                PuertosComboBox.Visible = False
                valido = False
                For Each PuertoSerial As String In My.Computer.Ports.SerialPortNames
                    If PuertoSerial = PuertosComboBox.SelectedItem Then
                        valido = True   'valida que el puerto este libre antes de abrirlo
                    End If
                Next
                If valido = True Then
                    Puerto.PortName = PuertosComboBox.SelectedItem
                    Puerto.Open()
                    Puerto.DiscardInBuffer()

                    'Activar lo necesario
                    TestPuertos.Visible = False
                    Timer.Enabled = True

                Else
                    Testear_Puertos()   ' No esta disponible revalida los puestos
                End If
            Else
                Puerto.Close()
                PuertosComboBox.Visible = True
                Conectar.Text = "Conectar"
                Testear_Puertos()  ' Testear Puertos :)

                'Desactivar lo necesario
                TestPuertos.Visible = True


            End If
        End If
    End Sub

    Private Sub Testear_Puertos_habiles() Handles PuertosComboBox.MouseEnter
        'Rutina de Testear Puertos :) - Cuando este inahibitados (para mejor carga)
        If My.Computer.Ports.SerialPortNames.Count <> 0 Then
            PuertosComboBox.Items.Clear()
            For Each PuertoSerial As String In My.Computer.Ports.SerialPortNames
                PuertosComboBox.Items.Add(PuertoSerial)
            Next
        End If
    End Sub

    Private Sub Testear_Puertos() Handles PuertosComboBox.Click

        'Rutina de Testear Puertos :) -Cada que abre el menu de selección o inicia Formulario
        PuertosComboBox.Items.Clear()
        If My.Computer.Ports.SerialPortNames.Count <> 0 Then
            For Each PuertoSerial As String In My.Computer.Ports.SerialPortNames
                PuertosComboBox.Items.Add(PuertoSerial)
            Next
            Conectar.Enabled = True
        Else
            MsgBox("NO HAY PUERTOS DISPONIBLES EN EL PC")
            Conectar.Enabled = False
        End If
    End Sub

    Private Sub TestPuertos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestPuertos.Click
        Testear_Puertos()
    End Sub


    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        If Conectar.Text <> "Conectar" Then

            If cambio Then
                Puerto.Write("0")
                Puerto.Write(Chr(Frecuencia.Value))
                If seno.Checked = True Then
                    Puerto.Write(Chr(0))
                Else
                    Puerto.Write(Chr(1))
                End If
            End If

            If envio = False Then
                Puerto.DiscardInBuffer()
                Puerto.Write("1")
                envio = True
            End If

            If (Puerto.BytesToRead > 3) And envio = True Then
                envio = False
                entrada = Puerto.ReadExisting

                Frec_input = Asc(Mid(entrada, 1, 1)) * 256 + Asc(Mid(entrada, 2, 1))
                Label5.Text = (60 * Frec_input)
                Label5.Text += "  RPM"

                If Asc(Mid(entrada, 3, 1)) = 0 Then
                    Label7.Text = "Horario"
                Else
                    Label7.Text = "Anti - Horario"
                End If

                dac = Asc(Mid(entrada, 4, 1)) * 5 / 255

                Chart1.Series(0).Points.AddXY(contador, dac)
                contador += 1
                If contador >= Chart1.ChartAreas(0).Axes(0).Maximum() Then
                    Chart1.ChartAreas(0).Axes(0).Maximum = contador + 1
                    Chart1.ChartAreas(0).Axes(0).Minimum = Chart1.ChartAreas(0).Axes(0).Maximum() - 50
                End If

                Label8.Text = "DAC = " + Str(dac) + " V"

            End If
        End If
    End Sub


    Private Sub seno_Click(sender As Object, e As EventArgs) Handles seno.Click
        If seno.Checked = False Then
            seno.Checked = True
            trian.Checked = False
            cambio = True
        Else
            seno.Checked = False
            trian.Checked = True
        End If
    End Sub

    Private Sub trian_Click(sender As Object, e As EventArgs) Handles trian.Click
        If trian.Checked = False Then
            trian.Checked = True
            seno.Checked = False
            cambio = True
        Else
            seno.Checked = True
            trian.Checked = False
        End If
    End Sub

    Private Sub Frecuencia_ValueChanged(sender As Object, e As EventArgs) Handles Frecuencia.ValueChanged
        Label3.Text = Frecuencia.Value
        cambio = True
    End Sub

End Class
