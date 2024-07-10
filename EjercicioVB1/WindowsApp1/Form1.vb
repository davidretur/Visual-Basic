Public Class Form1

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtproducto.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
        txtresulproducto.Text = ""
        txtimporte.Text = ""
        txtigv.Text = ""
        txttotal.Text = ""
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim nomproducto As String
        Dim cant As Integer
        Dim pre, importe, igv, total As Double
        nomproducto = txtproducto.Text
        pre = CDbl(txtprecio.Text)
        cant = CInt(txtcantidad.Text)
        importe = pre * cant
        igv = importe * 0.18 / 100
        total = importe + igv

        txtresulproducto.Text = nomproducto
        txtimporte.Text = FormatNumber(importe, 2)
        txtigv.Text = FormatNumber(igv, 2)
        txttotal.Text = FormatNumber(total, 2)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
