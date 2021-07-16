<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnNuevoLong = New System.Windows.Forms.Button()
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVolCap = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnvolumen = New System.Windows.Forms.Button()
        Me.Btnsuperficie = New System.Windows.Forms.Button()
        Me.Btnlineal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnVolumenCapacidad = New System.Windows.Forms.Button()
        Me.BtnVol = New System.Windows.Forms.Button()
        Me.BtnSup = New System.Windows.Forms.Button()
        Me.BtnCapacidad = New System.Windows.Forms.Button()
        Me.BtnMasa = New System.Windows.Forms.Button()
        Me.BtnLongitud = New System.Windows.Forms.Button()
        Me.Txtresultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevoVolCap = New System.Windows.Forms.Button()
        Me.BtnNuevoVol = New System.Windows.Forms.Button()
        Me.BtnNuevoSup = New System.Windows.Forms.Button()
        Me.BtnNuevoCap = New System.Windows.Forms.Button()
        Me.BtnNuevoMasa = New System.Windows.Forms.Button()
        Me.TxtVerif = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevoLong
        '
        Me.BtnNuevoLong.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoLong.Name = "BtnNuevoLong"
        Me.BtnNuevoLong.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoLong.TabIndex = 0
        Me.BtnNuevoLong.Text = "Nuevo"
        Me.BtnNuevoLong.UseVisualStyleBackColor = True
        Me.BtnNuevoLong.Visible = False
        '
        'Txtnumero
        '
        Me.Txtnumero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txtnumero.Location = New System.Drawing.Point(15, 55)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(171, 23)
        Me.Txtnumero.TabIndex = 1
        Me.Txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLimpiar.Location = New System.Drawing.Point(17, 25)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 29)
        Me.BtnLimpiar.TabIndex = 3
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "¿Con qué deseas ejercitar?"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BtnVolCap)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Btnvolumen)
        Me.GroupBox1.Controls.Add(Me.Btnsuperficie)
        Me.GroupBox1.Controls.Add(Me.Btnlineal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(776, 131)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operación"
        '
        'BtnVolCap
        '
        Me.BtnVolCap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnVolCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolCap.Location = New System.Drawing.Point(550, 43)
        Me.BtnVolCap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnVolCap.Name = "BtnVolCap"
        Me.BtnVolCap.Size = New System.Drawing.Size(137, 29)
        Me.BtnVolCap.TabIndex = 8
        Me.BtnVolCap.Text = "Volumen/Capacidad"
        Me.BtnVolCap.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-153, -82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hola"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnvolumen
        '
        Me.Btnvolumen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btnvolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnvolumen.Location = New System.Drawing.Point(410, 43)
        Me.Btnvolumen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnvolumen.Name = "Btnvolumen"
        Me.Btnvolumen.Size = New System.Drawing.Size(126, 29)
        Me.Btnvolumen.TabIndex = 7
        Me.Btnvolumen.Text = "Volumen"
        Me.Btnvolumen.UseVisualStyleBackColor = False
        '
        'Btnsuperficie
        '
        Me.Btnsuperficie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btnsuperficie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsuperficie.Location = New System.Drawing.Point(267, 43)
        Me.Btnsuperficie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnsuperficie.Name = "Btnsuperficie"
        Me.Btnsuperficie.Size = New System.Drawing.Size(126, 29)
        Me.Btnsuperficie.TabIndex = 6
        Me.Btnsuperficie.Text = "Superficie"
        Me.Btnsuperficie.UseVisualStyleBackColor = False
        '
        'Btnlineal
        '
        Me.Btnlineal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btnlineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlineal.Location = New System.Drawing.Point(126, 43)
        Me.Btnlineal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnlineal.Name = "Btnlineal"
        Me.Btnlineal.Size = New System.Drawing.Size(126, 29)
        Me.Btnlineal.TabIndex = 5
        Me.Btnlineal.Text = "Magnitudes lineales"
        Me.Btnlineal.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnVolumenCapacidad)
        Me.GroupBox2.Controls.Add(Me.BtnVol)
        Me.GroupBox2.Controls.Add(Me.BtnSup)
        Me.GroupBox2.Controls.Add(Me.BtnCapacidad)
        Me.GroupBox2.Controls.Add(Me.BtnMasa)
        Me.GroupBox2.Controls.Add(Me.BtnLongitud)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 144)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(90, 170)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'BtnVolumenCapacidad
        '
        Me.BtnVolumenCapacidad.Location = New System.Drawing.Point(6, 66)
        Me.BtnVolumenCapacidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnVolumenCapacidad.Name = "BtnVolumenCapacidad"
        Me.BtnVolumenCapacidad.Size = New System.Drawing.Size(78, 20)
        Me.BtnVolumenCapacidad.TabIndex = 21
        Me.BtnVolumenCapacidad.Text = "Vol/cap"
        Me.BtnVolumenCapacidad.UseVisualStyleBackColor = True
        '
        'BtnVol
        '
        Me.BtnVol.Location = New System.Drawing.Point(5, 66)
        Me.BtnVol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnVol.Name = "BtnVol"
        Me.BtnVol.Size = New System.Drawing.Size(78, 20)
        Me.BtnVol.TabIndex = 20
        Me.BtnVol.Text = "Volumen"
        Me.BtnVol.UseVisualStyleBackColor = True
        Me.BtnVol.Visible = False
        '
        'BtnSup
        '
        Me.BtnSup.Location = New System.Drawing.Point(4, 64)
        Me.BtnSup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSup.Name = "BtnSup"
        Me.BtnSup.Size = New System.Drawing.Size(78, 20)
        Me.BtnSup.TabIndex = 19
        Me.BtnSup.Text = "Superficie"
        Me.BtnSup.UseVisualStyleBackColor = True
        Me.BtnSup.Visible = False
        '
        'BtnCapacidad
        '
        Me.BtnCapacidad.Location = New System.Drawing.Point(5, 96)
        Me.BtnCapacidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCapacidad.Name = "BtnCapacidad"
        Me.BtnCapacidad.Size = New System.Drawing.Size(78, 20)
        Me.BtnCapacidad.TabIndex = 2
        Me.BtnCapacidad.Text = "Capacidad"
        Me.BtnCapacidad.UseVisualStyleBackColor = True
        Me.BtnCapacidad.Visible = False
        '
        'BtnMasa
        '
        Me.BtnMasa.Location = New System.Drawing.Point(5, 64)
        Me.BtnMasa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnMasa.Name = "BtnMasa"
        Me.BtnMasa.Size = New System.Drawing.Size(78, 20)
        Me.BtnMasa.TabIndex = 1
        Me.BtnMasa.Text = "Masa"
        Me.BtnMasa.UseVisualStyleBackColor = True
        Me.BtnMasa.Visible = False
        '
        'BtnLongitud
        '
        Me.BtnLongitud.Location = New System.Drawing.Point(5, 34)
        Me.BtnLongitud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLongitud.Name = "BtnLongitud"
        Me.BtnLongitud.Size = New System.Drawing.Size(78, 20)
        Me.BtnLongitud.TabIndex = 0
        Me.BtnLongitud.Text = "Longitud"
        Me.BtnLongitud.UseVisualStyleBackColor = True
        Me.BtnLongitud.Visible = False
        '
        'Txtresultado
        '
        Me.Txtresultado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txtresultado.Location = New System.Drawing.Point(343, 55)
        Me.Txtresultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtresultado.Name = "Txtresultado"
        Me.Txtresultado.PlaceholderText = "2 cifras significativas"
        Me.Txtresultado.Size = New System.Drawing.Size(187, 23)
        Me.Txtresultado.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(198, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "H"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.BtnNuevoVolCap)
        Me.GroupBox3.Controls.Add(Me.BtnNuevoVol)
        Me.GroupBox3.Controls.Add(Me.BtnNuevoSup)
        Me.GroupBox3.Controls.Add(Me.BtnNuevoCap)
        Me.GroupBox3.Controls.Add(Me.BtnNuevoMasa)
        Me.GroupBox3.Controls.Add(Me.TxtVerif)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BtnOk)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Txtresultado)
        Me.GroupBox3.Controls.Add(Me.Txtnumero)
        Me.GroupBox3.Controls.Add(Me.BtnNuevoLong)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(115, 144)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(548, 170)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'BtnNuevoVolCap
        '
        Me.BtnNuevoVolCap.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoVolCap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevoVolCap.Name = "BtnNuevoVolCap"
        Me.BtnNuevoVolCap.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoVolCap.TabIndex = 24
        Me.BtnNuevoVolCap.Text = "Nuevo"
        Me.BtnNuevoVolCap.UseVisualStyleBackColor = True
        '
        'BtnNuevoVol
        '
        Me.BtnNuevoVol.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoVol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevoVol.Name = "BtnNuevoVol"
        Me.BtnNuevoVol.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoVol.TabIndex = 23
        Me.BtnNuevoVol.Text = "Nuevo"
        Me.BtnNuevoVol.UseVisualStyleBackColor = True
        '
        'BtnNuevoSup
        '
        Me.BtnNuevoSup.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoSup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevoSup.Name = "BtnNuevoSup"
        Me.BtnNuevoSup.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoSup.TabIndex = 22
        Me.BtnNuevoSup.Text = "Nuevo"
        Me.BtnNuevoSup.UseVisualStyleBackColor = True
        Me.BtnNuevoSup.Visible = False
        '
        'BtnNuevoCap
        '
        Me.BtnNuevoCap.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoCap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevoCap.Name = "BtnNuevoCap"
        Me.BtnNuevoCap.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoCap.TabIndex = 21
        Me.BtnNuevoCap.Text = "Nuevo"
        Me.BtnNuevoCap.UseVisualStyleBackColor = True
        Me.BtnNuevoCap.Visible = False
        '
        'BtnNuevoMasa
        '
        Me.BtnNuevoMasa.Location = New System.Drawing.Point(43, 116)
        Me.BtnNuevoMasa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNuevoMasa.Name = "BtnNuevoMasa"
        Me.BtnNuevoMasa.Size = New System.Drawing.Size(111, 23)
        Me.BtnNuevoMasa.TabIndex = 20
        Me.BtnNuevoMasa.Text = "Nuevo"
        Me.BtnNuevoMasa.UseVisualStyleBackColor = True
        Me.BtnNuevoMasa.Visible = False
        '
        'TxtVerif
        '
        Me.TxtVerif.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtVerif.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtVerif.Location = New System.Drawing.Point(343, 88)
        Me.TxtVerif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtVerif.Name = "TxtVerif"
        Me.TxtVerif.Size = New System.Drawing.Size(187, 23)
        Me.TxtVerif.TabIndex = 19
        Me.TxtVerif.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Resultado"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(343, 116)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(78, 23)
        Me.BtnOk.TabIndex = 17
        Me.BtnOk.Text = "Verificar"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(343, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Ingresa el valor y click en verificar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(246, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "A"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(277, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "P"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(17, 110)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 29)
        Me.BtnSalir.TabIndex = 17
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(680, 144)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(102, 170)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 324)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(776, 177)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Conversión de unidades de medida. Colegio de la Providencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnuevo As Button
    Friend WithEvents Txtnumero As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnVolCap As Button
    Friend WithEvents Btnvolumen As Button
    Friend WithEvents Btnsuperficie As Button
    Friend WithEvents Btnlineal As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnCapacidad As Button
    Friend WithEvents BtnMasa As Button
    Friend WithEvents BtnLongitud As Button
    Friend WithEvents Txtresultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevoLong As Button
    Friend WithEvents TxtVerif As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnNuevoMasa As Button
    Friend WithEvents BtnNuevoCap As Button
    Friend WithEvents BtnSup As Button
    Friend WithEvents BtnNuevoSup As Button
    Friend WithEvents BtnVol As Button
    Friend WithEvents BtnNuevoVol As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnNuevoVolCap As Button
    Friend WithEvents BtnVolumenCapacidad As Button
End Class
