


Public Class Form1



    Dim contador As Integer = 1
    'Public dunidades(,)

    Private conca As String

    Private Sub Btngenera_Click(sender As Object, e As EventArgs) Handles BtnNuevoLong.Click
        TxtVerif.Visible = False
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        unidad1 = ((1 - 7) * Rnd() + 7)

        If (unidad1 = 1) Then
            Label3.Text = "Km"

        ElseIf (unidad1 = 2) Then
            Label3.Text = "Hm"

        ElseIf (unidad1 = 3) Then
            Label3.Text = "Dm"

        ElseIf (unidad1 = 4) Then
            Label3.Text = "m"

        ElseIf (unidad1 = 5) Then
            Label3.Text = "dm"

        ElseIf (unidad1 = 6) Then
            Label3.Text = "cm"
        ElseIf (unidad1 = 7) Then
            Label3.Text = "mm"
        End If


        Randomize()
        unidad2 = ((1 - 7) * Rnd() + 7)
        If (unidad2 = 1) Then
            Label5.Text = "Km ="
            conca = " Km"
        ElseIf (unidad2 = 2) Then
            Label5.Text = "Hm ="
            conca = " Hm"
        ElseIf (unidad2 = 3) Then
            Label5.Text = "Dm ="
            conca = " Dm"
        ElseIf (unidad2 = 4) Then
            Label5.Text = "m ="
            conca = " m"
        ElseIf (unidad2 = 5) Then
            Label5.Text = "dm ="
            conca = " dm"
        ElseIf (unidad2 = 6) Then
            Label5.Text = "cm ="
            conca = " cm"
        ElseIf (unidad2 = 7) Then
            Label5.Text = "mm ="
            conca = " mm"
        End If


        Dim final As Double


        contador += 1

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Decimal
        Randomize()
        numero1 = ((0 - 1000) * Rnd() + 1000)
        numero2 = ((0 - 1000) * Rnd() + 1000)
        'numero2 = 1
        resultado = numero1 / numero2
        If (contador = 1) Then
            resultado = resultado / 1000
        ElseIf (contador = 2) Then
            resultado = resultado * 1000
        ElseIf (contador = 3) Then
            resultado = resultado / 10000
        ElseIf (contador = 4) Then
            resultado = resultado * 10
        ElseIf (contador = 5) Then
            resultado = resultado + 1000
        ElseIf (contador = 6) Then
            resultado = resultado * 100000000
        ElseIf (contador = 7) Then
            resultado = resultado / 100000
        ElseIf (contador = 8) Then
            resultado = resultado * 100
        ElseIf (contador = 9) Then
            resultado = resultado / 1000
        ElseIf (contador = 10) Then
            resultado = resultado * 100
        ElseIf (contador = 11) Then
            resultado = resultado / 10
        ElseIf (contador = 12) Then
            resultado = resultado + 10000
        ElseIf (contador = 13) Then
            resultado = resultado + 10
        ElseIf (contador = 14) Then
            resultado = resultado * 10
        ElseIf (contador = 15) Then
            resultado = resultado / 10000
        ElseIf (contador = 16) Then
            resultado = resultado * 1
        ElseIf (contador = 17) Then
            resultado = resultado / 1000
        ElseIf (contador = 18) Then
            resultado = resultado * 1000
        ElseIf (contador = 19) Then
            resultado = resultado / 50000
        ElseIf (contador = 20) Then
            resultado = resultado * 10
        ElseIf (contador = 21) Then
            resultado = resultado + 1000
        ElseIf (contador = 22) Then
            resultado = resultado * 100000000
        ElseIf (contador = 23) Then
            resultado = resultado / 100000
        ElseIf (contador = 24) Then
            resultado = resultado * 100
        ElseIf (contador = 25) Then
            resultado = resultado / 1000
        ElseIf (contador = 26) Then
            resultado = resultado * 100
        ElseIf (contador = 27) Then
            resultado = resultado / 10
        ElseIf (contador = 28) Then
            resultado = resultado + 10000
        ElseIf (contador = 29) Then
            resultado = resultado + 10
        ElseIf (contador = 30) Then
            resultado = resultado * 10
        ElseIf (contador = 31) Then
            resultado = resultado / 10000
        ElseIf (contador = 32) Then
            resultado = resultado * 1
        End If
        If (resultado >= 1) Then
            Txtnumero.Text = Math.Round(resultado, 2)
        Else

            Txtnumero.Text = Math.Round(resultado, 7)

        End If

        'ReDim Preserve dunidades(6, 6)
        ' Dim j As Integer = 0
        'For i As Integer = 0 To 6 Step 1
        'While (j <= 6)
        'dunidades(j, i) = 10 ^ i
        'j = j + 1
        'End While
        'j = 0
        'txt1.Text = dunidades(0, 0)
        'Txt2.Text = dunidades(0, 1)
        'Txt3.Text = dunidades(0, 2)
        'Txt4.Text = dunidades(0, 3)
        'Txt5.Text = dunidades(0, 4)
        'Txt6.Text = dunidades(0, 5)
        'Txt7.Text = dunidades(2, 6)
        ' txt1.Text = dunidades(2, 0)
        '2.Text = dunidades(2, 1)
        'Txt3.Text = dunidades(2, 2)
        'Txt4.Text = dunidades(2, 3)
        'Txt5.Text = dunidades(2, 4)
        'Txt6.Text = dunidades(2, 5)
        'Txt7.Text = dunidades(2, 6)
        'Next




        If (unidad1 = 1 And unidad2 = 1) Then
            final = resultado * 1
        ElseIf (unidad1 = 1 And unidad2 = 2) Then
            final = resultado * 10
        ElseIf (unidad1 = 1 And unidad2 = 3) Then
            final = resultado * 100
        ElseIf (unidad1 = 1 And unidad2 = 4) Then
            final = resultado * 1000
        ElseIf (unidad1 = 1 And unidad2 = 5) Then
            final = resultado * 10000
        ElseIf (unidad1 = 1 And unidad2 = 6) Then
            final = resultado * 100000
        ElseIf (unidad1 = 1 And unidad2 = 7) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 2 And unidad2 = 1) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 2 And unidad2 = 2) Then
            final = resultado * 1
        ElseIf (unidad1 = 2 And unidad2 = 3) Then
            final = resultado * 10
        ElseIf (unidad1 = 2 And unidad2 = 4) Then
            final = resultado * 100
        ElseIf (unidad1 = 2 And unidad2 = 5) Then
            final = resultado * 1000
        ElseIf (unidad1 = 2 And unidad2 = 6) Then
            final = resultado * 10000
        ElseIf (unidad1 = 2 And unidad2 = 7) Then
            final = resultado * 100000
        ElseIf (unidad1 = 3 And unidad2 = 1) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 3 And unidad2 = 2) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 3 And unidad2 = 3) Then
            final = resultado * 1
        ElseIf (unidad1 = 3 And unidad2 = 4) Then
            final = resultado * 10
        ElseIf (unidad1 = 3 And unidad2 = 5) Then
            final = resultado * 100
        ElseIf (unidad1 = 3 And unidad2 = 6) Then
            final = resultado * 1000
        ElseIf (unidad1 = 3 And unidad2 = 7) Then
            final = resultado * 10000
        ElseIf (unidad1 = 4 And unidad2 = 1) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 4 And unidad2 = 2) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 4 And unidad2 = 3) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 4 And unidad2 = 4) Then
            final = resultado * 1
        ElseIf (unidad1 = 4 And unidad2 = 5) Then
            final = resultado * 10
        ElseIf (unidad1 = 4 And unidad2 = 6) Then
            final = resultado * 100
        ElseIf (unidad1 = 4 And unidad2 = 7) Then
            final = resultado * 1000
        ElseIf (unidad1 = 5 And unidad2 = 1) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 5 And unidad2 = 2) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 5 And unidad2 = 3) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 5 And unidad2 = 4) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 5 And unidad2 = 5) Then
            final = resultado * 1
        ElseIf (unidad1 = 5 And unidad2 = 6) Then
            final = resultado * 10
        ElseIf (unidad1 = 5 And unidad2 = 7) Then
            final = resultado * 100
        ElseIf (unidad1 = 6 And unidad2 = 1) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 6 And unidad2 = 2) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 6 And unidad2 = 3) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 6 And unidad2 = 4) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 6 And unidad2 = 5) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 6 And unidad2 = 6) Then
            final = resultado * 1
        ElseIf (unidad1 = 6 And unidad2 = 7) Then
            final = resultado * 10
        ElseIf (unidad1 = 7 And unidad2 = 1) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 7 And unidad2 = 2) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 7 And unidad2 = 3) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 7 And unidad2 = 4) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 7 And unidad2 = 5) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 7 And unidad2 = 6) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 7 And unidad2 = 7) Then
            final = resultado * 1
        End If

        If (resultado >= 1) Then
            TxtVerif.Text = Math.Round(final, 9) & conca
        Else

            TxtVerif.Text = Math.Round(final, 11) & conca

        End If







    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        contador = 0

        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlineal.Click
        GroupBox2.Visible = True
        GroupBox2.Text = "Selecciona"
        BtnLongitud.Visible = True
        BtnMasa.Visible = True
        BtnCapacidad.Visible = True
        BtnSup.Visible = False
        BtnVol.Visible = False
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False
        BtnVolumenCapacidad.Visible = False
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False
        BtnVolumenCapacidad.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtresultado.TextChanged

    End Sub

    Private Sub BtnLongitud_Click(sender As Object, e As EventArgs) Handles BtnLongitud.Click
        GroupBox3.Text = "Medidas de longitud"
        BtnNuevoLong.Visible = True
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False


        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()



    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        TxtVerif.Visible = True
    End Sub

    Private Sub BtnMasa_Click(sender As Object, e As EventArgs) Handles BtnMasa.Click
        GroupBox3.Text = "Medidas de masa"

        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = True
        BtnNuevoCap.Visible = False
        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()

    End Sub

    Private Sub BtnCapacidad_Click(sender As Object, e As EventArgs) Handles BtnCapacidad.Click
        GroupBox3.Text = "Medidas de capacidad"

        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = True
        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub

    Private Sub BtnNuevoMasa_Click(sender As Object, e As EventArgs) Handles BtnNuevoMasa.Click
        TxtVerif.Visible = False
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        unidad1 = ((1 - 7) * Rnd() + 7)

        If (unidad1 = 1) Then
            Label3.Text = "Kg"

        ElseIf (unidad1 = 2) Then
            Label3.Text = "Hg"

        ElseIf (unidad1 = 3) Then
            Label3.Text = "Dg"

        ElseIf (unidad1 = 4) Then
            Label3.Text = "g"

        ElseIf (unidad1 = 5) Then
            Label3.Text = "dg"

        ElseIf (unidad1 = 6) Then
            Label3.Text = "cg"
        ElseIf (unidad1 = 7) Then
            Label3.Text = "mg"
        End If

        'Dim conca As String
        Randomize()
        unidad2 = ((1 - 7) * Rnd() + 7)
        If (unidad2 = 1) Then
            Label5.Text = "Kg ="
            conca = " Kg"
        ElseIf (unidad2 = 2) Then
            Label5.Text = "Hg ="
            conca = " Hg"
        ElseIf (unidad2 = 3) Then
            Label5.Text = "Dg ="
            conca = " Dg"
        ElseIf (unidad2 = 4) Then
            Label5.Text = "g ="
            conca = " g"
        ElseIf (unidad2 = 5) Then
            Label5.Text = "dg ="
            conca = " dg"
        ElseIf (unidad2 = 6) Then
            Label5.Text = "cg ="
            conca = " cg"
        ElseIf (unidad2 = 7) Then
            Label5.Text = "mg ="
            conca = " mg"
        End If


        Dim final As Double


        contador = contador + 1

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Decimal
        Randomize()
        numero1 = ((0 - 1000) * Rnd() + 1000)
        numero2 = ((0 - 1000) * Rnd() + 1000)
        'numero2 = 1
        resultado = numero1 / numero2
        If (contador = 1) Then
            resultado = resultado / 1000
        ElseIf (contador = 2) Then
            resultado = resultado * 1000
        ElseIf (contador = 3) Then
            resultado = resultado / 10000
        ElseIf (contador = 4) Then
            resultado = resultado * 10
        ElseIf (contador = 5) Then
            resultado = resultado + 1000
        ElseIf (contador = 6) Then
            resultado = resultado * 100000000
        ElseIf (contador = 7) Then
            resultado = resultado / 100000
        ElseIf (contador = 8) Then
            resultado = resultado * 100
        ElseIf (contador = 9) Then
            resultado = resultado / 1000
        ElseIf (contador = 10) Then
            resultado = resultado * 100
        ElseIf (contador = 11) Then
            resultado = resultado / 10
        ElseIf (contador = 12) Then
            resultado = resultado + 10000
        ElseIf (contador = 13) Then
            resultado = resultado + 10
        ElseIf (contador = 14) Then
            resultado = resultado * 10
        ElseIf (contador = 15) Then
            resultado = resultado / 10000
        ElseIf (contador = 16) Then
            resultado = resultado * 1
        ElseIf (contador = 17) Then
            resultado = resultado / 1000
        ElseIf (contador = 18) Then
            resultado = resultado * 1000
        ElseIf (contador = 19) Then
            resultado = resultado / 50000
        ElseIf (contador = 20) Then
            resultado = resultado * 10
        ElseIf (contador = 21) Then
            resultado = resultado + 1000
        ElseIf (contador = 22) Then
            resultado = resultado * 100000000
        ElseIf (contador = 23) Then
            resultado = resultado / 100000
        ElseIf (contador = 24) Then
            resultado = resultado * 100
        ElseIf (contador = 25) Then
            resultado = resultado / 1000
        ElseIf (contador = 26) Then
            resultado = resultado * 100
        ElseIf (contador = 27) Then
            resultado = resultado / 10
        ElseIf (contador = 28) Then
            resultado = resultado + 10000
        ElseIf (contador = 29) Then
            resultado = resultado + 10
        ElseIf (contador = 30) Then
            resultado = resultado * 10
        ElseIf (contador = 31) Then
            resultado = resultado / 10000
        ElseIf (contador = 32) Then
            resultado = resultado * 1
        End If
        If (resultado >= 1) Then
            Txtnumero.Text = Math.Round(resultado, 2)
        Else

            Txtnumero.Text = Math.Round(resultado, 7)

        End If





        If (unidad1 = 1 And unidad2 = 1) Then
            final = resultado * 1
        ElseIf (unidad1 = 1 And unidad2 = 2) Then
            final = resultado * 10
        ElseIf (unidad1 = 1 And unidad2 = 3) Then
            final = resultado * 100
        ElseIf (unidad1 = 1 And unidad2 = 4) Then
            final = resultado * 1000
        ElseIf (unidad1 = 1 And unidad2 = 5) Then
            final = resultado * 10000
        ElseIf (unidad1 = 1 And unidad2 = 6) Then
            final = resultado * 100000
        ElseIf (unidad1 = 1 And unidad2 = 7) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 2 And unidad2 = 1) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 2 And unidad2 = 2) Then
            final = resultado * 1
        ElseIf (unidad1 = 2 And unidad2 = 3) Then
            final = resultado * 10
        ElseIf (unidad1 = 2 And unidad2 = 4) Then
            final = resultado * 100
        ElseIf (unidad1 = 2 And unidad2 = 5) Then
            final = resultado * 1000
        ElseIf (unidad1 = 2 And unidad2 = 6) Then
            final = resultado * 10000
        ElseIf (unidad1 = 2 And unidad2 = 7) Then
            final = resultado * 100000
        ElseIf (unidad1 = 3 And unidad2 = 1) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 3 And unidad2 = 2) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 3 And unidad2 = 3) Then
            final = resultado * 1
        ElseIf (unidad1 = 3 And unidad2 = 4) Then
            final = resultado * 10
        ElseIf (unidad1 = 3 And unidad2 = 5) Then
            final = resultado * 100
        ElseIf (unidad1 = 3 And unidad2 = 6) Then
            final = resultado * 1000
        ElseIf (unidad1 = 3 And unidad2 = 7) Then
            final = resultado * 10000
        ElseIf (unidad1 = 4 And unidad2 = 1) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 4 And unidad2 = 2) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 4 And unidad2 = 3) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 4 And unidad2 = 4) Then
            final = resultado * 1
        ElseIf (unidad1 = 4 And unidad2 = 5) Then
            final = resultado * 10
        ElseIf (unidad1 = 4 And unidad2 = 6) Then
            final = resultado * 100
        ElseIf (unidad1 = 4 And unidad2 = 7) Then
            final = resultado * 1000
        ElseIf (unidad1 = 5 And unidad2 = 1) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 5 And unidad2 = 2) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 5 And unidad2 = 3) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 5 And unidad2 = 4) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 5 And unidad2 = 5) Then
            final = resultado * 1
        ElseIf (unidad1 = 5 And unidad2 = 6) Then
            final = resultado * 10
        ElseIf (unidad1 = 5 And unidad2 = 7) Then
            final = resultado * 100
        ElseIf (unidad1 = 6 And unidad2 = 1) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 6 And unidad2 = 2) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 6 And unidad2 = 3) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 6 And unidad2 = 4) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 6 And unidad2 = 5) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 6 And unidad2 = 6) Then
            final = resultado * 1
        ElseIf (unidad1 = 6 And unidad2 = 7) Then
            final = resultado * 10
        ElseIf (unidad1 = 7 And unidad2 = 1) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 7 And unidad2 = 2) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 7 And unidad2 = 3) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 7 And unidad2 = 4) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 7 And unidad2 = 5) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 7 And unidad2 = 6) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 7 And unidad2 = 7) Then
            final = resultado * 1
        End If

        If (resultado >= 1) Then
            TxtVerif.Text = Math.Round(final, 9) & conca

            TxtVerif.Text = Math.Round(final, 11) & conca

        End If
    End Sub

    Private Sub BtnNuevoCap_Click(sender As Object, e As EventArgs) Handles BtnNuevoCap.Click
        TxtVerif.Visible = False
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        unidad1 = ((1 - 7) * Rnd() + 7)

        If (unidad1 = 1) Then
            Label3.Text = "Kl"

        ElseIf (unidad1 = 2) Then
            Label3.Text = "Hl"

        ElseIf (unidad1 = 3) Then
            Label3.Text = "Dl"

        ElseIf (unidad1 = 4) Then
            Label3.Text = "l"

        ElseIf (unidad1 = 5) Then
            Label3.Text = "dl"

        ElseIf (unidad1 = 6) Then
            Label3.Text = "cl"
        ElseIf (unidad1 = 7) Then
            Label3.Text = "ml"
        End If

        'Dim conca As String
        Randomize()
        unidad2 = ((1 - 7) * Rnd() + 7)
        If (unidad2 = 1) Then
            Label5.Text = "Kl ="
            conca = " Kl"
        ElseIf (unidad2 = 2) Then
            Label5.Text = "Hl ="
            conca = " Hl"
        ElseIf (unidad2 = 3) Then
            Label5.Text = "Dl ="
            conca = " Dl"
        ElseIf (unidad2 = 4) Then
            Label5.Text = "l ="
            conca = " l"
        ElseIf (unidad2 = 5) Then
            Label5.Text = "dl ="
            conca = " dl"
        ElseIf (unidad2 = 6) Then
            Label5.Text = "cl ="
            conca = " cl"
        ElseIf (unidad2 = 7) Then
            Label5.Text = "ml ="
            conca = " ml"
        End If


        Dim final As Double


        contador = contador + 1

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Decimal
        Randomize()
        numero1 = ((0 - 1000) * Rnd() + 1000)
        numero2 = ((0 - 1000) * Rnd() + 1000)
        'numero2 = 1
        resultado = numero1 / numero2
        If (contador = 1) Then
            resultado = resultado / 1000
        ElseIf (contador = 2) Then
            resultado = resultado * 1000
        ElseIf (contador = 3) Then
            resultado = resultado / 10000
        ElseIf (contador = 4) Then
            resultado = resultado * 10
        ElseIf (contador = 5) Then
            resultado = resultado + 1000
        ElseIf (contador = 6) Then
            resultado = resultado * 100000000
        ElseIf (contador = 7) Then
            resultado = resultado / 100000
        ElseIf (contador = 8) Then
            resultado = resultado * 100
        ElseIf (contador = 9) Then
            resultado = resultado / 1000
        ElseIf (contador = 10) Then
            resultado = resultado * 100
        ElseIf (contador = 11) Then
            resultado = resultado / 10
        ElseIf (contador = 12) Then
            resultado = resultado + 10000
        ElseIf (contador = 13) Then
            resultado = resultado + 10
        ElseIf (contador = 14) Then
            resultado = resultado * 10
        ElseIf (contador = 15) Then
            resultado = resultado / 10000
        ElseIf (contador = 16) Then
            resultado = resultado * 1
        ElseIf (contador = 17) Then
            resultado = resultado / 1000
        ElseIf (contador = 18) Then
            resultado = resultado * 1000
        ElseIf (contador = 19) Then
            resultado = resultado / 50000
        ElseIf (contador = 20) Then
            resultado = resultado * 10
        ElseIf (contador = 21) Then
            resultado = resultado + 1000
        ElseIf (contador = 22) Then
            resultado = resultado * 100000000
        ElseIf (contador = 23) Then
            resultado = resultado / 100000
        ElseIf (contador = 24) Then
            resultado = resultado * 100
        ElseIf (contador = 25) Then
            resultado = resultado / 1000
        ElseIf (contador = 26) Then
            resultado = resultado * 100
        ElseIf (contador = 27) Then
            resultado = resultado / 10
        ElseIf (contador = 28) Then
            resultado = resultado + 10000
        ElseIf (contador = 29) Then
            resultado = resultado + 10
        ElseIf (contador = 30) Then
            resultado = resultado * 10
        ElseIf (contador = 31) Then
            resultado = resultado / 10000
        ElseIf (contador = 32) Then
            resultado = resultado * 1
        End If
        If (resultado >= 1) Then
            Txtnumero.Text = Math.Round(resultado, 2)
        Else

            Txtnumero.Text = Math.Round(resultado, 7)

        End If





        If (unidad1 = 1 And unidad2 = 1) Then
            final = resultado * 1
        ElseIf (unidad1 = 1 And unidad2 = 2) Then
            final = resultado * 10
        ElseIf (unidad1 = 1 And unidad2 = 3) Then
            final = resultado * 100
        ElseIf (unidad1 = 1 And unidad2 = 4) Then
            final = resultado * 1000
        ElseIf (unidad1 = 1 And unidad2 = 5) Then
            final = resultado * 10000
        ElseIf (unidad1 = 1 And unidad2 = 6) Then
            final = resultado * 100000
        ElseIf (unidad1 = 1 And unidad2 = 7) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 2 And unidad2 = 1) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 2 And unidad2 = 2) Then
            final = resultado * 1
        ElseIf (unidad1 = 2 And unidad2 = 3) Then
            final = resultado * 10
        ElseIf (unidad1 = 2 And unidad2 = 4) Then
            final = resultado * 100
        ElseIf (unidad1 = 2 And unidad2 = 5) Then
            final = resultado * 1000
        ElseIf (unidad1 = 2 And unidad2 = 6) Then
            final = resultado * 10000
        ElseIf (unidad1 = 2 And unidad2 = 7) Then
            final = resultado * 100000
        ElseIf (unidad1 = 3 And unidad2 = 1) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 3 And unidad2 = 2) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 3 And unidad2 = 3) Then
            final = resultado * 1
        ElseIf (unidad1 = 3 And unidad2 = 4) Then
            final = resultado * 10
        ElseIf (unidad1 = 3 And unidad2 = 5) Then
            final = resultado * 100
        ElseIf (unidad1 = 3 And unidad2 = 6) Then
            final = resultado * 1000
        ElseIf (unidad1 = 3 And unidad2 = 7) Then
            final = resultado * 10000
        ElseIf (unidad1 = 4 And unidad2 = 1) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 4 And unidad2 = 2) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 4 And unidad2 = 3) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 4 And unidad2 = 4) Then
            final = resultado * 1
        ElseIf (unidad1 = 4 And unidad2 = 5) Then
            final = resultado * 10
        ElseIf (unidad1 = 4 And unidad2 = 6) Then
            final = resultado * 100
        ElseIf (unidad1 = 4 And unidad2 = 7) Then
            final = resultado * 1000
        ElseIf (unidad1 = 5 And unidad2 = 1) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 5 And unidad2 = 2) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 5 And unidad2 = 3) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 5 And unidad2 = 4) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 5 And unidad2 = 5) Then
            final = resultado * 1
        ElseIf (unidad1 = 5 And unidad2 = 6) Then
            final = resultado * 10
        ElseIf (unidad1 = 5 And unidad2 = 7) Then
            final = resultado * 100
        ElseIf (unidad1 = 6 And unidad2 = 1) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 6 And unidad2 = 2) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 6 And unidad2 = 3) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 6 And unidad2 = 4) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 6 And unidad2 = 5) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 6 And unidad2 = 6) Then
            final = resultado * 1
        ElseIf (unidad1 = 6 And unidad2 = 7) Then
            final = resultado * 10
        ElseIf (unidad1 = 7 And unidad2 = 1) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 7 And unidad2 = 2) Then
            final = resultado * 0.00001
        ElseIf (unidad1 = 7 And unidad2 = 3) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 7 And unidad2 = 4) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 7 And unidad2 = 5) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 7 And unidad2 = 6) Then
            final = resultado * 0.1
        ElseIf (unidad1 = 7 And unidad2 = 7) Then
            final = resultado * 1
        End If

        If (resultado >= 1) Then
            TxtVerif.Text = Math.Round(final, 9) & conca
        Else

            TxtVerif.Text = Math.Round(final, 11) & conca


        End If
    End Sub

    Private Sub Btnsuperficie_Click(sender As Object, e As EventArgs) Handles Btnsuperficie.Click
        GroupBox2.Visible = True
        GroupBox2.Text = "Selecciona"
        BtnSup.Visible = True
        BtnLongitud.Visible = False
        BtnMasa.Visible = False
        BtnCapacidad.Visible = False
        BtnVol.Visible = False
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False
        BtnVolumenCapacidad.Visible = False
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()

    End Sub

    Private Sub BtnSup_Click(sender As Object, e As EventArgs) Handles BtnSup.Click
        GroupBox3.Text = "Medidas de superficie"
        BtnNuevoSup.Visible = True
        BtnNuevoVol.Visible = False
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoVolCap.Visible = False




        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub

    Private Sub BtnNuevoSup_Click(sender As Object, e As EventArgs) Handles BtnNuevoSup.Click
        TxtVerif.Visible = False
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        unidad1 = ((1 - 7) * Rnd() + 7)
        'Dim conca As String
        If (unidad1 = 1) Then
            Label3.Text = "Km2"

        ElseIf (unidad1 = 2) Then
            Label3.Text = "Hm2"

        ElseIf (unidad1 = 3) Then
            Label3.Text = "Dm2"

        ElseIf (unidad1 = 4) Then
            Label3.Text = "m2"

        ElseIf (unidad1 = 5) Then
            Label3.Text = "dm2"

        ElseIf (unidad1 = 6) Then
            Label3.Text = "cm2"
        ElseIf (unidad1 = 7) Then
            Label3.Text = "mm2"
        End If


        Randomize()
        unidad2 = ((1 - 7) * Rnd() + 7)
        If (unidad2 = 1) Then
            Label5.Text = "Km2 ="
            conca = "km2"
        ElseIf (unidad2 = 2) Then
            Label5.Text = "Hm2 ="
            conca = "Hm2"
        ElseIf (unidad2 = 3) Then
            Label5.Text = "Dm2 ="
            conca = "Dm2"
        ElseIf (unidad2 = 4) Then
            Label5.Text = "m2 ="
            conca = "m2"
        ElseIf (unidad2 = 5) Then
            Label5.Text = "dm2 ="
            conca = "dm2"
        ElseIf (unidad2 = 6) Then
            Label5.Text = "cm2 ="
            conca = "cm2"
        ElseIf (unidad2 = 7) Then
            Label5.Text = "mm2 ="
            conca = "mm2"
        End If


        Dim final As Double


        contador = contador + 1

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Decimal
        Randomize()
        numero1 = ((0 - 1000) * Rnd() + 1000)
        numero2 = ((0 - 1000) * Rnd() + 1000)
        'numero2 = 1
        resultado = numero1 / numero2
        If (contador = 1) Then
            resultado = resultado / 1000
        ElseIf (contador = 2) Then
            resultado = resultado * 1000
        ElseIf (contador = 3) Then
            resultado = resultado / 10000
        ElseIf (contador = 4) Then
            resultado = resultado * 10
        ElseIf (contador = 5) Then
            resultado = resultado + 1000
        ElseIf (contador = 6) Then
            resultado = resultado * 100000000
        ElseIf (contador = 7) Then
            resultado = resultado / 100000
        ElseIf (contador = 8) Then
            resultado = resultado * 100
        ElseIf (contador = 9) Then
            resultado = resultado / 1000
        ElseIf (contador = 10) Then
            resultado = resultado * 100
        ElseIf (contador = 11) Then
            resultado = resultado / 10
        ElseIf (contador = 12) Then
            resultado = resultado + 10000
        ElseIf (contador = 13) Then
            resultado = resultado + 10
        ElseIf (contador = 14) Then
            resultado = resultado * 10
        ElseIf (contador = 15) Then
            resultado = resultado / 10000
        ElseIf (contador = 16) Then
            resultado = resultado * 1
        ElseIf (contador = 17) Then
            resultado = resultado / 1000
        ElseIf (contador = 18) Then
            resultado = resultado * 1000
        ElseIf (contador = 19) Then
            resultado = resultado / 50000
        ElseIf (contador = 20) Then
            resultado = resultado * 10
        ElseIf (contador = 21) Then
            resultado = resultado + 1000
        ElseIf (contador = 22) Then
            resultado = resultado * 100000000
        ElseIf (contador = 23) Then
            resultado = resultado / 100000
        ElseIf (contador = 24) Then
            resultado = resultado * 100
        ElseIf (contador = 25) Then
            resultado = resultado / 1000
        ElseIf (contador = 26) Then
            resultado = resultado * 100
        ElseIf (contador = 27) Then
            resultado = resultado / 10
        ElseIf (contador = 28) Then
            resultado = resultado + 10000
        ElseIf (contador = 29) Then
            resultado = resultado + 10
        ElseIf (contador = 30) Then
            resultado = resultado * 10
        ElseIf (contador = 31) Then
            resultado = resultado / 10000
        ElseIf (contador = 32) Then
            resultado = resultado * 1
        End If
        If (resultado >= 1) Then
            Txtnumero.Text = Math.Round(resultado, 2)
        Else

            Txtnumero.Text = Math.Round(resultado, 15)
        End If

        If (unidad1 = 1 And unidad2 = 1) Then
            final = resultado * 1
        ElseIf (unidad1 = 1 And unidad2 = 2) Then
            final = resultado * 100
        ElseIf (unidad1 = 1 And unidad2 = 3) Then
            final = resultado * 10000
        ElseIf (unidad1 = 1 And unidad2 = 4) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 1 And unidad2 = 5) Then
            final = resultado * 100000000
        ElseIf (unidad1 = 1 And unidad2 = 6) Then
            final = resultado * 10000000000
        ElseIf (unidad1 = 1 And unidad2 = 7) Then
            final = resultado * 1000000000000
        ElseIf (unidad1 = 2 And unidad2 = 1) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 2 And unidad2 = 2) Then
            final = resultado * 1
        ElseIf (unidad1 = 2 And unidad2 = 3) Then
            final = resultado * 100
        ElseIf (unidad1 = 2 And unidad2 = 4) Then
            final = resultado * 10000
        ElseIf (unidad1 = 2 And unidad2 = 5) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 2 And unidad2 = 6) Then
            final = resultado * 100000000
        ElseIf (unidad1 = 2 And unidad2 = 7) Then
            final = resultado * 10000000000
        ElseIf (unidad1 = 3 And unidad2 = 1) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 3 And unidad2 = 2) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 3 And unidad2 = 3) Then
            final = resultado * 1
        ElseIf (unidad1 = 3 And unidad2 = 4) Then
            final = resultado * 100
        ElseIf (unidad1 = 3 And unidad2 = 5) Then
            final = resultado * 10000
        ElseIf (unidad1 = 3 And unidad2 = 6) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 3 And unidad2 = 7) Then
            final = resultado * 100000000
        ElseIf (unidad1 = 4 And unidad2 = 1) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 4 And unidad2 = 2) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 4 And unidad2 = 3) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 4 And unidad2 = 4) Then
            final = resultado * 1
        ElseIf (unidad1 = 4 And unidad2 = 5) Then
            final = resultado * 100
        ElseIf (unidad1 = 4 And unidad2 = 6) Then
            final = resultado * 10000
        ElseIf (unidad1 = 4 And unidad2 = 7) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 5 And unidad2 = 1) Then
            final = resultado * 0.00000001
        ElseIf (unidad1 = 5 And unidad2 = 2) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 5 And unidad2 = 3) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 5 And unidad2 = 4) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 5 And unidad2 = 5) Then
            final = resultado * 1
        ElseIf (unidad1 = 5 And unidad2 = 6) Then
            final = resultado * 100
        ElseIf (unidad1 = 5 And unidad2 = 7) Then
            final = resultado * 10000
        ElseIf (unidad1 = 6 And unidad2 = 1) Then
            final = resultado * 0.0000000001
        ElseIf (unidad1 = 6 And unidad2 = 2) Then
            final = resultado * 0.00000001
        ElseIf (unidad1 = 6 And unidad2 = 3) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 6 And unidad2 = 4) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 6 And unidad2 = 5) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 6 And unidad2 = 6) Then
            final = resultado * 1
        ElseIf (unidad1 = 6 And unidad2 = 7) Then
            final = resultado * 100
        ElseIf (unidad1 = 7 And unidad2 = 1) Then
            final = resultado * 0.000000000001
        ElseIf (unidad1 = 7 And unidad2 = 2) Then
            final = resultado * 0.0000000001
        ElseIf (unidad1 = 7 And unidad2 = 3) Then
            final = resultado * 0.00000001
        ElseIf (unidad1 = 7 And unidad2 = 4) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 7 And unidad2 = 5) Then
            final = resultado * 0.0001
        ElseIf (unidad1 = 7 And unidad2 = 6) Then
            final = resultado * 0.01
        ElseIf (unidad1 = 7 And unidad2 = 7) Then
            final = resultado * 1
        End If

        If (resultado >= 1) Then
            TxtVerif.Text = Math.Round(final, 9) & " " & conca
        Else

            TxtVerif.Text = final & " " & conca
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Btnvolumen_Click(sender As Object, e As EventArgs) Handles Btnvolumen.Click
        GroupBox2.Visible = True
        BtnLongitud.Visible = False
        BtnMasa.Visible = False
        BtnCapacidad.Visible = False
        BtnSup.Visible = False
        BtnVol.Visible = True
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False
        BtnVolumenCapacidad.Visible = False
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub

    Private Sub BtnVol_Click(sender As Object, e As EventArgs) Handles BtnVol.Click
        GroupBox3.Text = "Medidas de volumen"
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoVol.Visible = True
        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub

    Private Sub BtnNuevoVol_Click(sender As Object, e As EventArgs) Handles BtnNuevoVol.Click
        TxtVerif.Visible = False
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        unidad1 = ((1 - 7) * Rnd() + 7)
        'Dim conca As String
        If (unidad1 = 1) Then
            Label3.Text = "Km3"

        ElseIf (unidad1 = 2) Then
            Label3.Text = "Hm3"

        ElseIf (unidad1 = 3) Then
            Label3.Text = "Dm3"

        ElseIf (unidad1 = 4) Then
            Label3.Text = "m3"

        ElseIf (unidad1 = 5) Then
            Label3.Text = "dm3"

        ElseIf (unidad1 = 6) Then
            Label3.Text = "cm3"
        ElseIf (unidad1 = 7) Then
            Label3.Text = "mm3"
        End If


        Randomize()
        unidad2 = ((1 - 7) * Rnd() + 7)
        If (unidad2 = 1) Then
            Label5.Text = "Km3 ="
            conca = " km3"
        ElseIf (unidad2 = 2) Then
            Label5.Text = "Hm3 ="
            conca = " Hm3"
        ElseIf (unidad2 = 3) Then
            Label5.Text = "Dm3 ="
            conca = " Dm3"
        ElseIf (unidad2 = 4) Then
            Label5.Text = "m3 ="
            conca = " m3"
        ElseIf (unidad2 = 5) Then
            Label5.Text = "dm3 ="
            conca = " dm3"
        ElseIf (unidad2 = 6) Then
            Label5.Text = "cm3 ="
            conca = " cm3"
        ElseIf (unidad2 = 7) Then
            Label5.Text = "mm3 ="
            conca = " mm3"
        End If


        Dim final As Double


        contador = contador + 1

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Decimal
        Randomize()
        numero1 = ((0 - 1000) * Rnd() + 1000)
        numero2 = ((0 - 1000) * Rnd() + 1000)
        'numero2 = 1
        resultado = numero1 / numero2
        If (contador = 1) Then
            resultado = resultado / 10
        ElseIf (contador = 2) Then
            resultado = resultado * 10
        ElseIf (contador = 3) Then
            resultado = resultado / 10
        ElseIf (contador = 4) Then
            resultado = resultado
        ElseIf (contador = 5) Then
            resultado = resultado + 1000
        ElseIf (contador = 6) Then
            resultado = resultado * 100
        ElseIf (contador = 7) Then
            resultado = resultado / 100
        ElseIf (contador = 8) Then
            resultado = resultado * 100
        ElseIf (contador = 9) Then
            resultado = resultado / 1000
        ElseIf (contador = 10) Then
            resultado = resultado * 100
        ElseIf (contador = 11) Then
            resultado = resultado / 10
        ElseIf (contador = 12) Then
            resultado = resultado + 10000
        ElseIf (contador = 13) Then
            resultado = resultado + 10
        ElseIf (contador = 14) Then
            resultado = resultado * 10
        ElseIf (contador = 15) Then
            resultado = resultado / 1000
        ElseIf (contador = 16) Then
            resultado = resultado * 1
        ElseIf (contador = 17) Then
            resultado = resultado / 1000
        ElseIf (contador = 18) Then
            resultado = resultado * 1000
        ElseIf (contador = 19) Then
            resultado = resultado / 500
        ElseIf (contador = 20) Then
            resultado = resultado * 10
        ElseIf (contador = 21) Then
            resultado = resultado + 1000
        ElseIf (contador = 22) Then
            resultado = resultado * 1000
        ElseIf (contador = 23) Then
            resultado = resultado / 10000
        ElseIf (contador = 24) Then
            resultado = resultado * 100
        ElseIf (contador = 25) Then
            resultado = resultado / 1000
        ElseIf (contador = 26) Then
            resultado = resultado * 100
        ElseIf (contador = 27) Then
            resultado = resultado / 10
        ElseIf (contador = 28) Then
            resultado = resultado + 10000
        ElseIf (contador = 29) Then
            resultado = resultado + 10
        ElseIf (contador = 30) Then
            resultado = resultado * 10
        ElseIf (contador = 31) Then
            resultado = resultado / 100
        ElseIf (contador = 32) Then
            resultado = resultado * 1
        End If
        If (resultado >= 1) Then
            Txtnumero.Text = Math.Round(resultado, 2)
        Else

            Txtnumero.Text = Math.Round(resultado, 25)
        End If

        If (unidad1 = 1 And unidad2 = 1) Then
            final = resultado * 1
        ElseIf (unidad1 = 1 And unidad2 = 2) Then
            final = resultado * 1000
        ElseIf (unidad1 = 1 And unidad2 = 3) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 1 And unidad2 = 4) Then
            final = resultado * 1000000000
        ElseIf (unidad1 = 1 And unidad2 = 5) Then
            final = resultado * 1000000000000
        ElseIf (unidad1 = 1 And unidad2 = 6) Then
            final = resultado * 1000000000000000
        ElseIf (unidad1 = 1 And unidad2 = 7) Then
            final = resultado * 1000000000000000000
        ElseIf (unidad1 = 2 And unidad2 = 1) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 2 And unidad2 = 2) Then
            final = resultado * 1
        ElseIf (unidad1 = 2 And unidad2 = 3) Then
            final = resultado * 1000
        ElseIf (unidad1 = 2 And unidad2 = 4) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 2 And unidad2 = 5) Then
            final = resultado * 1000000000
        ElseIf (unidad1 = 2 And unidad2 = 6) Then
            final = resultado * 1000000000000
        ElseIf (unidad1 = 2 And unidad2 = 7) Then
            final = resultado * 1000000000000000
        ElseIf (unidad1 = 3 And unidad2 = 1) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 3 And unidad2 = 2) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 3 And unidad2 = 3) Then
            final = resultado * 1
        ElseIf (unidad1 = 3 And unidad2 = 4) Then
            final = resultado * 1000
        ElseIf (unidad1 = 3 And unidad2 = 5) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 3 And unidad2 = 6) Then
            final = resultado * 1000000000
        ElseIf (unidad1 = 3 And unidad2 = 7) Then
            final = resultado * 1000000000000
        ElseIf (unidad1 = 4 And unidad2 = 1) Then
            final = resultado * 0.000000001
        ElseIf (unidad1 = 4 And unidad2 = 2) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 4 And unidad2 = 3) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 4 And unidad2 = 4) Then
            final = resultado * 1
        ElseIf (unidad1 = 4 And unidad2 = 5) Then
            final = resultado * 1000
        ElseIf (unidad1 = 4 And unidad2 = 6) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 4 And unidad2 = 7) Then
            final = resultado * 1000000000
        ElseIf (unidad1 = 5 And unidad2 = 1) Then
            final = resultado * 0.000000000001
        ElseIf (unidad1 = 5 And unidad2 = 2) Then
            final = resultado * 0.000000001
        ElseIf (unidad1 = 5 And unidad2 = 3) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 5 And unidad2 = 4) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 5 And unidad2 = 5) Then
            final = resultado * 1
        ElseIf (unidad1 = 5 And unidad2 = 6) Then
            final = resultado * 1000
        ElseIf (unidad1 = 5 And unidad2 = 7) Then
            final = resultado * 1000000
        ElseIf (unidad1 = 6 And unidad2 = 1) Then
            final = resultado * 0.000000000000001
        ElseIf (unidad1 = 6 And unidad2 = 2) Then
            final = resultado * 0.000000000001
        ElseIf (unidad1 = 6 And unidad2 = 3) Then
            final = resultado * 0.000000001
        ElseIf (unidad1 = 6 And unidad2 = 4) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 6 And unidad2 = 5) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 6 And unidad2 = 6) Then
            final = resultado * 1
        ElseIf (unidad1 = 6 And unidad2 = 7) Then
            final = resultado * 1000
        ElseIf (unidad1 = 7 And unidad2 = 1) Then
            final = resultado * 1.0E-18
        ElseIf (unidad1 = 7 And unidad2 = 2) Then
            final = resultado * 0.000000000000001
        ElseIf (unidad1 = 7 And unidad2 = 3) Then
            final = resultado * 0.000000000001
        ElseIf (unidad1 = 7 And unidad2 = 4) Then
            final = resultado * 0.000000001
        ElseIf (unidad1 = 7 And unidad2 = 5) Then
            final = resultado * 0.000001
        ElseIf (unidad1 = 7 And unidad2 = 6) Then
            final = resultado * 0.001
        ElseIf (unidad1 = 7 And unidad2 = 7) Then
            final = resultado * 1
        End If

        If (resultado >= 1) Then
            TxtVerif.Text = final & conca
        Else

            TxtVerif.Text = final & conca
        End If
    End Sub

    Private Sub BtnNuevoVolCap_Click(sender As Object, e As EventArgs) Handles BtnNuevoVolCap.Click
        TxtVerif.Visible = False
        'Dim conca As String
        Dim unidad1 As Integer
        Dim unidad2 As Integer
        Dim invierte As Integer
        Label6.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Randomize()
        invierte = (1 - 2) * Rnd() + 2
        If invierte = 1 Then

            Randomize()
            unidad1 = ((1 - 7) * Rnd() + 7)

            If (unidad1 = 1) Then
                Label3.Text = "Km3"

            ElseIf (unidad1 = 2) Then
                Label3.Text = "Hm3"

            ElseIf (unidad1 = 3) Then
                Label3.Text = "Dm3"

            ElseIf (unidad1 = 4) Then
                Label3.Text = "m3"

            ElseIf (unidad1 = 5) Then
                Label3.Text = "dm3"

            ElseIf (unidad1 = 6) Then
                Label3.Text = "cm3"

            ElseIf (unidad1 = 7) Then
                Label3.Text = "mm3"

            End If

            Randomize()
            unidad2 = (1 - 7) * Rnd() + 7

            If (unidad2 = 1) Then
                Label5.Text = "Kl ="
                conca = " Kl"
            ElseIf (unidad2 = 2) Then
                Label5.Text = "Hl ="
                conca = " Hl"
            ElseIf (unidad2 = 3) Then
                Label5.Text = "Dl ="
                conca = " Dl"
            ElseIf (unidad2 = 4) Then
                Label5.Text = "l ="
                conca = " l"
            ElseIf (unidad2 = 5) Then
                Label5.Text = "dl ="
                conca = " dl"
            ElseIf (unidad2 = 6) Then
                Label5.Text = "cl ="
                conca = " cl"
            ElseIf (unidad2 = 7) Then
                Label5.Text = "ml ="
                conca = " ml="
            End If

            contador = contador + 1
            Dim final As Double
            Dim numero1 As Double
            Dim numero2 As Double
            Dim resultado As Decimal
            Randomize()
            numero1 = ((0 - 1000) * Rnd() + 1000)
            numero2 = ((0 - 1000) * Rnd() + 1000)
            'numero2 = 1
            resultado = numero1 / numero2
            If (contador = 1) Then
                resultado = resultado / 10
            ElseIf (contador = 2) Then
                resultado = resultado * 10
            ElseIf (contador = 3) Then
                resultado = resultado / 10
            ElseIf (contador = 4) Then
                resultado = resultado * 1
            ElseIf (contador = 5) Then
                resultado = resultado + 1000
            ElseIf (contador = 6) Then
                resultado = resultado * 100
            ElseIf (contador = 7) Then
                resultado = resultado / 100
            ElseIf (contador = 8) Then
                resultado = resultado * 100
            ElseIf (contador = 9) Then
                resultado = resultado / 1000
            ElseIf (contador = 10) Then
                resultado = resultado * 100
            ElseIf (contador = 11) Then
                resultado = resultado / 10
            ElseIf (contador = 12) Then
                resultado = resultado + 10000
            ElseIf (contador = 13) Then
                resultado = resultado + 10
            ElseIf (contador = 14) Then
                resultado = resultado * 10
            ElseIf (contador = 15) Then
                resultado = resultado / 1000
            ElseIf (contador = 16) Then
                resultado = resultado * 1
            ElseIf (contador = 17) Then
                resultado = resultado / 1000
            ElseIf (contador = 18) Then
                resultado = resultado * 1000
            ElseIf (contador = 19) Then
                resultado = resultado / 500
            ElseIf (contador = 20) Then
                resultado = resultado * 10
            ElseIf (contador = 21) Then
                resultado = resultado + 1000
            ElseIf (contador = 22) Then
                resultado = resultado * 1000
            ElseIf (contador = 23) Then
                resultado = resultado / 10000
            ElseIf (contador = 24) Then
                resultado = resultado * 100
            ElseIf (contador = 25) Then
                resultado = resultado / 1000
            ElseIf (contador = 26) Then
                resultado = resultado * 100
            ElseIf (contador = 27) Then
                resultado = resultado / 10
            ElseIf (contador = 28) Then
                resultado = resultado + 10000
            ElseIf (contador = 29) Then
                resultado = resultado + 10
            ElseIf (contador = 30) Then
                resultado = resultado * 10
            ElseIf (contador = 31) Then
                resultado = resultado / 100
            ElseIf (contador = 32) Then
                resultado = resultado * 1
            End If
            If (resultado >= 1) Then
                Txtnumero.Text = Math.Round(resultado, 2)
            Else

                Txtnumero.Text = Math.Round(resultado, 25)
            End If

            If (unidad1 = 1 And unidad2 = 1) Then
                final = resultado * 1000000000
            ElseIf (unidad1 = 1 And unidad2 = 2) Then
                final = resultado * 10000000000
            ElseIf (unidad1 = 1 And unidad2 = 3) Then
                final = resultado * 100000000000
            ElseIf (unidad1 = 1 And unidad2 = 4) Then
                final = resultado * 1000000000000
            ElseIf (unidad1 = 1 And unidad2 = 5) Then
                final = resultado * 10000000000000
            ElseIf (unidad1 = 1 And unidad2 = 6) Then
                final = resultado * 100000000000000
            ElseIf (unidad1 = 1 And unidad2 = 7) Then
                final = resultado * 1000000000000000
            ElseIf (unidad1 = 2 And unidad2 = 1) Then
                final = resultado * 1000000
            ElseIf (unidad1 = 2 And unidad2 = 2) Then
                final = resultado * 10000000
            ElseIf (unidad1 = 2 And unidad2 = 3) Then
                final = resultado * 100000000
            ElseIf (unidad1 = 2 And unidad2 = 4) Then
                final = resultado * 1000000000
            ElseIf (unidad1 = 2 And unidad2 = 5) Then
                final = resultado * 10000000000
            ElseIf (unidad1 = 2 And unidad2 = 6) Then
                final = resultado * 100000000000
            ElseIf (unidad1 = 2 And unidad2 = 7) Then
                final = resultado * 1000000000000
            ElseIf (unidad1 = 3 And unidad2 = 1) Then
                final = resultado * 1000
            ElseIf (unidad1 = 3 And unidad2 = 2) Then
                final = resultado * 10000
            ElseIf (unidad1 = 3 And unidad2 = 3) Then
                final = resultado * 100000
            ElseIf (unidad1 = 3 And unidad2 = 4) Then
                final = resultado * 1000000
            ElseIf (unidad1 = 3 And unidad2 = 5) Then
                final = resultado * 10000000
            ElseIf (unidad1 = 3 And unidad2 = 6) Then
                final = resultado * 100000000
            ElseIf (unidad1 = 3 And unidad2 = 7) Then
                final = resultado * 1000000000
            ElseIf (unidad1 = 4 And unidad2 = 1) Then
                final = resultado * 1
            ElseIf (unidad1 = 4 And unidad2 = 2) Then
                final = resultado * 10
            ElseIf (unidad1 = 4 And unidad2 = 3) Then
                final = resultado * 100
            ElseIf (unidad1 = 4 And unidad2 = 4) Then
                final = resultado * 1000
            ElseIf (unidad1 = 4 And unidad2 = 5) Then
                final = resultado * 10000
            ElseIf (unidad1 = 4 And unidad2 = 6) Then
                final = resultado * 100000
            ElseIf (unidad1 = 4 And unidad2 = 7) Then
                final = resultado * 1000000
            ElseIf (unidad1 = 5 And unidad2 = 1) Then
                final = resultado * 0.001
            ElseIf (unidad1 = 5 And unidad2 = 2) Then
                final = resultado * 0.01
            ElseIf (unidad1 = 5 And unidad2 = 3) Then
                final = resultado * 0.1
            ElseIf (unidad1 = 5 And unidad2 = 4) Then
                final = resultado * 1
            ElseIf (unidad1 = 5 And unidad2 = 5) Then
                final = resultado * 10
            ElseIf (unidad1 = 5 And unidad2 = 6) Then
                final = resultado * 100
            ElseIf (unidad1 = 5 And unidad2 = 7) Then
                final = resultado * 1000
            ElseIf (unidad1 = 6 And unidad2 = 1) Then
                final = resultado * 0.000001
            ElseIf (unidad1 = 6 And unidad2 = 2) Then
                final = resultado * 0.00001
            ElseIf (unidad1 = 6 And unidad2 = 3) Then
                final = resultado * 0.0001
            ElseIf (unidad1 = 6 And unidad2 = 4) Then
                final = resultado * 0.001
            ElseIf (unidad1 = 6 And unidad2 = 5) Then
                final = resultado * 0.01
            ElseIf (unidad1 = 6 And unidad2 = 6) Then
                final = resultado * 0.1
            ElseIf (unidad1 = 6 And unidad2 = 7) Then
                final = resultado * 1
            ElseIf (unidad1 = 7 And unidad2 = 1) Then
                final = resultado * 0.000000001
            ElseIf (unidad1 = 7 And unidad2 = 2) Then
                final = resultado * 0.00000001
            ElseIf (unidad1 = 7 And unidad2 = 3) Then
                final = resultado * 0.0000001
            ElseIf (unidad1 = 7 And unidad2 = 4) Then
                final = resultado * 0.000001
            ElseIf (unidad1 = 7 And unidad2 = 5) Then
                final = resultado * 0.00001
            ElseIf (unidad1 = 7 And unidad2 = 6) Then
                final = resultado * 0.0001
            ElseIf (unidad1 = 7 And unidad2 = 7) Then
                final = resultado * 0.001
            End If

            If (resultado >= 1) Then
                TxtVerif.Text = final & conca
            Else

                TxtVerif.Text = final & conca
            End If


        Else
            Randomize()
            unidad1 = ((1 - 7) * Rnd() + 7)

            If (unidad1 = 1) Then
                Label3.Text = "Kl ="
                conca = "kl "
            ElseIf (unidad1 = 2) Then
                Label3.Text = "Hl ="
                conca = " Hl"
            ElseIf (unidad1 = 3) Then
                Label3.Text = "Dl ="
                conca = " Dl"
            ElseIf (unidad1 = 4) Then
                Label3.Text = "l ="
                conca = "l"
            ElseIf (unidad1 = 5) Then
                Label3.Text = "dl ="
                conca = " dl"
            ElseIf (unidad1 = 6) Then
                Label3.Text = "cl ="
                conca = " cl"
            ElseIf (unidad1 = 7) Then
                Label3.Text = "ml ="
                conca = " ml"
            End If

            Randomize()
            unidad2 = ((1 - 7) * Rnd() + 7)

            If (unidad2 = 1) Then
                Label5.Text = "Km3"

            ElseIf (unidad2 = 2) Then
                Label5.Text = "Hm3"

            ElseIf (unidad2 = 3) Then
                Label5.Text = "Dm3"

            ElseIf (unidad2 = 4) Then
                Label5.Text = "m3"

            ElseIf (unidad2 = 5) Then
                Label5.Text = "dm3"

            ElseIf (unidad2 = 6) Then
                Label5.Text = "cm3"
            ElseIf (unidad2 = 7) Then
                Label5.Text = "mm3"
            End If


            contador = contador + 1
            Dim final As Double
            Dim numero1 As Double
            Dim numero2 As Double
            Dim resultado As Decimal
            Randomize()
            numero1 = ((0 - 1000) * Rnd() + 1000)
            numero2 = ((0 - 1000) * Rnd() + 1000)
            'numero2 = 1
            resultado = numero1 / numero2
            If (contador = 1) Then
                resultado = resultado / 10
            ElseIf (contador = 2) Then
                resultado = resultado * 10
            ElseIf (contador = 3) Then
                resultado = resultado / 10
            ElseIf (contador = 4) Then
                resultado = resultado
            ElseIf (contador = 5) Then
                resultado = resultado + 1000
            ElseIf (contador = 6) Then
                resultado = resultado * 100
            ElseIf (contador = 7) Then
                resultado = resultado / 100
            ElseIf (contador = 8) Then
                resultado = resultado * 100
            ElseIf (contador = 9) Then
                resultado = resultado / 1000
            ElseIf (contador = 10) Then
                resultado = resultado * 100
            ElseIf (contador = 11) Then
                resultado = resultado / 10
            ElseIf (contador = 12) Then
                resultado = resultado + 10000
            ElseIf (contador = 13) Then
                resultado = resultado + 10
            ElseIf (contador = 14) Then
                resultado = resultado * 10
            ElseIf (contador = 15) Then
                resultado = resultado / 1000
            ElseIf (contador = 16) Then
                resultado = resultado * 1
            ElseIf (contador = 17) Then
                resultado = resultado / 1000
            ElseIf (contador = 18) Then
                resultado = resultado * 1000
            ElseIf (contador = 19) Then
                resultado = resultado / 500
            ElseIf (contador = 20) Then
                resultado = resultado * 10
            ElseIf (contador = 21) Then
                resultado = resultado + 1000
            ElseIf (contador = 22) Then
                resultado = resultado * 1000
            ElseIf (contador = 23) Then
                resultado = resultado / 10000
            ElseIf (contador = 24) Then
                resultado = resultado * 100
            ElseIf (contador = 25) Then
                resultado = resultado / 1000
            ElseIf (contador = 26) Then
                resultado = resultado * 100
            ElseIf (contador = 27) Then
                resultado = resultado / 10
            ElseIf (contador = 28) Then
                resultado = resultado + 10000
            ElseIf (contador = 29) Then
                resultado = resultado + 10
            ElseIf (contador = 30) Then
                resultado = resultado * 10
            ElseIf (contador = 31) Then
                resultado = resultado / 100
            ElseIf (contador = 32) Then
                resultado = resultado * 1
            End If
            If (resultado >= 1) Then
                Txtnumero.Text = Math.Round(resultado, 2)
            Else

                Txtnumero.Text = Math.Round(resultado, 25)
            End If

            If (unidad1 = 1 And unidad2 = 1) Then
                final = resultado * 0.000000001
            ElseIf (unidad1 = 1 And unidad2 = 2) Then
                final = resultado * 0.000001
            ElseIf (unidad1 = 1 And unidad2 = 3) Then
                final = resultado * 0.001
            ElseIf (unidad1 = 1 And unidad2 = 4) Then
                final = resultado * 1
            ElseIf (unidad1 = 1 And unidad2 = 5) Then
                final = resultado * 1000
            ElseIf (unidad1 = 1 And unidad2 = 6) Then
                final = resultado * 1000000
            ElseIf (unidad1 = 1 And unidad2 = 7) Then
                final = resultado * 1000000000
            ElseIf (unidad1 = 2 And unidad2 = 1) Then
                final = resultado * 0.0000000001
            ElseIf (unidad1 = 2 And unidad2 = 2) Then
                final = resultado * 0.0000001
            ElseIf (unidad1 = 2 And unidad2 = 3) Then
                final = resultado * 0.0001
            ElseIf (unidad1 = 2 And unidad2 = 4) Then
                final = resultado * 0.1
            ElseIf (unidad1 = 2 And unidad2 = 5) Then
                final = resultado * 100
            ElseIf (unidad1 = 2 And unidad2 = 6) Then
                final = resultado * 100000
            ElseIf (unidad1 = 2 And unidad2 = 7) Then
                final = resultado * 100000000
            ElseIf (unidad1 = 3 And unidad2 = 1) Then
                final = resultado * 0.00000000001
            ElseIf (unidad1 = 3 And unidad2 = 2) Then
                final = resultado * 0.00000001
            ElseIf (unidad1 = 3 And unidad2 = 3) Then
                final = resultado * 0.00001
            ElseIf (unidad1 = 3 And unidad2 = 4) Then
                final = resultado * 0.01
            ElseIf (unidad1 = 3 And unidad2 = 5) Then
                final = resultado * 10
            ElseIf (unidad1 = 3 And unidad2 = 6) Then
                final = resultado * 10000
            ElseIf (unidad1 = 3 And unidad2 = 7) Then
                final = resultado * 10000000
            ElseIf (unidad1 = 4 And unidad2 = 1) Then
                final = resultado * 0.000000000001
            ElseIf (unidad1 = 4 And unidad2 = 2) Then
                final = resultado * 0.000000001
            ElseIf (unidad1 = 4 And unidad2 = 3) Then
                final = resultado * 0.000001
            ElseIf (unidad1 = 4 And unidad2 = 4) Then
                final = resultado * 0.001
            ElseIf (unidad1 = 4 And unidad2 = 5) Then
                final = resultado * 1
            ElseIf (unidad1 = 4 And unidad2 = 6) Then
                final = resultado * 1000
            ElseIf (unidad1 = 4 And unidad2 = 7) Then
                final = resultado * 1000000
            ElseIf (unidad1 = 5 And unidad2 = 1) Then
                final = resultado * 0.0000000000001
            ElseIf (unidad1 = 5 And unidad2 = 2) Then
                final = resultado * 0.0000000001
            ElseIf (unidad1 = 5 And unidad2 = 3) Then
                final = resultado * 0.0000001
            ElseIf (unidad1 = 5 And unidad2 = 4) Then
                final = resultado * 0.0001
            ElseIf (unidad1 = 5 And unidad2 = 5) Then
                final = resultado * 0.1
            ElseIf (unidad1 = 5 And unidad2 = 6) Then
                final = resultado * 100
            ElseIf (unidad1 = 5 And unidad2 = 7) Then
                final = resultado * 100000
            ElseIf (unidad1 = 6 And unidad2 = 1) Then
                final = resultado * 0.00000000000001
            ElseIf (unidad1 = 6 And unidad2 = 2) Then
                final = resultado * 0.00000000001
            ElseIf (unidad1 = 6 And unidad2 = 3) Then
                final = resultado * 0.00000001
            ElseIf (unidad1 = 6 And unidad2 = 4) Then
                final = resultado * 0.00001
            ElseIf (unidad1 = 6 And unidad2 = 5) Then
                final = resultado * 0.01
            ElseIf (unidad1 = 6 And unidad2 = 6) Then
                final = resultado * 10
            ElseIf (unidad1 = 6 And unidad2 = 7) Then
                final = resultado * 10000
            ElseIf (unidad1 = 7 And unidad2 = 1) Then
                final = resultado * 0.000000000000001
            ElseIf (unidad1 = 7 And unidad2 = 2) Then
                final = resultado * 0.000000000001
            ElseIf (unidad1 = 7 And unidad2 = 3) Then
                final = resultado * 0.000000001
            ElseIf (unidad1 = 7 And unidad2 = 4) Then
                final = resultado * 0.000001
            ElseIf (unidad1 = 7 And unidad2 = 5) Then
                final = resultado * 0.001
            ElseIf (unidad1 = 7 And unidad2 = 6) Then
                final = resultado * 1
            ElseIf (unidad1 = 7 And unidad2 = 7) Then
                final = resultado * 1000
            End If

            If (resultado >= 1) Then
                TxtVerif.Text = final & conca
            Else

                TxtVerif.Text = final & conca
            End If
        End If

    End Sub

    Private Sub BtnVolCap_Click(sender As Object, e As EventArgs) Handles BtnVolCap.Click

        GroupBox2.Visible = True
        BtnVolumenCapacidad.Visible = True
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVolCap.Visible = False
        BtnVol.Visible = False
        BtnLongitud.Visible = False
        BtnCapacidad.Visible = False
        BtnMasa.Visible = False
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub

    Private Sub BtnVolumenCapacidad_Click(sender As Object, e As EventArgs) Handles BtnVolumenCapacidad.Click
        GroupBox3.Text = "Relación entre unidades de volumen y capacidad"
        BtnNuevoVolCap.Visible = True
        BtnNuevoLong.Visible = False
        BtnNuevoMasa.Visible = False
        BtnNuevoCap.Visible = False
        BtnNuevoSup.Visible = False
        BtnNuevoVol.Visible = False
        BtnNuevoVol.Visible = False
        Label6.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label6.Text = "a"
        Txtnumero.Clear()
        Txtresultado.Clear()
        TxtVerif.Clear()
    End Sub
End Class
