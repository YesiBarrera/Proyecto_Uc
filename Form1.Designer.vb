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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Puerto = New System.IO.Ports.SerialPort(Me.components)
        Me.Conectar = New System.Windows.Forms.Button()
        Me.PuertosComboBox = New System.Windows.Forms.ComboBox()
        Me.TestPuertos = New System.Windows.Forms.Button()
        Me.seno = New System.Windows.Forms.RadioButton()
        Me.trian = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frecuencia = New System.Windows.Forms.TrackBar()
        Me.frec = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Frecuencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 25
        '
        'Conectar
        '
        Me.Conectar.Location = New System.Drawing.Point(12, 12)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(122, 25)
        Me.Conectar.TabIndex = 2
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'PuertosComboBox
        '
        Me.PuertosComboBox.FormattingEnabled = True
        Me.PuertosComboBox.Location = New System.Drawing.Point(140, 15)
        Me.PuertosComboBox.Name = "PuertosComboBox"
        Me.PuertosComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PuertosComboBox.TabIndex = 3
        '
        'TestPuertos
        '
        Me.TestPuertos.Location = New System.Drawing.Point(12, 43)
        Me.TestPuertos.Name = "TestPuertos"
        Me.TestPuertos.Size = New System.Drawing.Size(121, 23)
        Me.TestPuertos.TabIndex = 4
        Me.TestPuertos.Text = "Test"
        Me.TestPuertos.UseVisualStyleBackColor = True
        '
        'seno
        '
        Me.seno.AutoCheck = False
        Me.seno.AutoSize = True
        Me.seno.Location = New System.Drawing.Point(12, 83)
        Me.seno.Name = "seno"
        Me.seno.Size = New System.Drawing.Size(14, 13)
        Me.seno.TabIndex = 5
        Me.seno.TabStop = True
        Me.seno.UseVisualStyleBackColor = True
        '
        'trian
        '
        Me.trian.AutoCheck = False
        Me.trian.AutoSize = True
        Me.trian.Location = New System.Drawing.Point(12, 102)
        Me.trian.Name = "trian"
        Me.trian.Size = New System.Drawing.Size(14, 13)
        Me.trian.TabIndex = 6
        Me.trian.TabStop = True
        Me.trian.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Senoidal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Triangular"
        '
        'Frecuencia
        '
        Me.Frecuencia.Location = New System.Drawing.Point(108, 96)
        Me.Frecuencia.Maximum = 255
        Me.Frecuencia.Name = "Frecuencia"
        Me.Frecuencia.Size = New System.Drawing.Size(164, 45)
        Me.Frecuencia.TabIndex = 9
        '
        'frec
        '
        Me.frec.AutoSize = True
        Me.frec.Location = New System.Drawing.Point(137, 80)
        Me.frec.Name = "frec"
        Me.frec.Size = New System.Drawing.Size(60, 13)
        Me.frec.TabIndex = 10
        Me.frec.Text = "Frecuencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Velocidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sentido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Horario"
        '
        'Chart1
        '
        ChartArea1.AxisX.Maximum = 50.0R
        ChartArea1.AxisX.Minimum = 0.0R
        ChartArea1.AxisY.Maximum = 5.0R
        ChartArea1.AxisY.Minimum = 0.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(272, 14)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(357, 164)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "DAC = "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 212)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.frec)
        Me.Controls.Add(Me.Frecuencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trian)
        Me.Controls.Add(Me.seno)
        Me.Controls.Add(Me.TestPuertos)
        Me.Controls.Add(Me.PuertosComboBox)
        Me.Controls.Add(Me.Conectar)
        Me.Name = "Form1"
        Me.Text = "I2C - GUI"
        CType(Me.Frecuencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Puerto As System.IO.Ports.SerialPort
    Friend WithEvents Conectar As System.Windows.Forms.Button
    Friend WithEvents PuertosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TestPuertos As System.Windows.Forms.Button
    Friend WithEvents seno As System.Windows.Forms.RadioButton
    Friend WithEvents trian As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Frecuencia As System.Windows.Forms.TrackBar
    Friend WithEvents frec As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
