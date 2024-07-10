Imports System.Data.SqlClient

Public Class Cliente
    Private conexion As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Private strSQL As String
    Private ex As Object

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Try
            conexion = New SqlConnection("Server=DESKTOP-FLC9CU6\SQLEXPRESS; Database=cliente;User Id=sa; Password=tich;")

            'Comando para inserir novo registro
            strSQL = "INSERT INTO  CAD_CLIENTE (Nombre, Numero) VALUES (@Nombre, @Numero)"
            comando = New SqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            comando.Parameters.AddWithValue("@Numero", TxtNumero.Text)
            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            comando.Clone()
            comando = Nothing
            conexion = Nothing
            TxtID.Text = ""
            TxtNombre.Text = ""
            TxtNumero.Text = ""

        End Try
        MostrarInformacion()
    End Sub

    Private Sub BtnExibir_Click(sender As Object, e As EventArgs) Handles BtnExibir.Click
        MostrarInformacion()
    End Sub
    ' Aquí van los métodos, variables y propiedades del formulario

    ' Método que muestra un cuadro de mensaje
    Private Sub MostrarInformacion()
        Try
            conexion = New SqlConnection("Server=DESKTOP-FLC9CU6\SQLEXPRESS; Database=cliente;User Id=sa; Password=tich;")

            'Comando para inserir novo registro
            strSQL = "SELECT * FROM CAD_CLIENTE"

            comando = New SqlCommand(strSQL, conexion)
            da = New SqlDataAdapter(strSQL, conexion)
            conexion.Open()
            Dim ds As New DataSet
            da.Fill(ds)

            dgvDatos.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            comando.Clone()
            comando = Nothing
            conexion = Nothing
            TxtID.Text = ""
            TxtNombre.Text = ""
            TxtNumero.Text = ""

        End Try
    End Sub

    ' Otros eventos y métodos del formulario
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            conexion = New SqlConnection("Server=DESKTOP-FLC9CU6\SQLEXPRESS; Database=cliente;User Id=sa; Password=tich;")

            'Comando para inserir novo registro
            strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID"

            comando = New SqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@ID", TxtID.Text)
            conexion.Open()

            dr = comando.ExecuteReader

            Do While dr.Read
                TxtNombre.Text = dr("Nombre")
                TxtNumero.Text = dr("Numero")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            comando.Clone()
            comando = Nothing
            conexion = Nothing
            dr = Nothing
            TxtID.Text = ""
            TxtNombre.Text = ""
            TxtNumero.Text = ""
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            conexion = New SqlConnection("Server=DESKTOP-FLC9CU6\SQLEXPRESS; Database=cliente;User Id=sa; Password=tich;")

            'Comando para inserir novo registro
            strSQL = "UPDATE CAD_CLIENTE SET Nombre = @Nombre, Numero = @Numero WHERE id = @ID"

            comando = New SqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@ID", TxtID.Text)
            comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            comando.Parameters.AddWithValue("@Numero", TxtNumero.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            comando.Clone()
            comando = Nothing
            conexion = Nothing
            TxtID.Text = ""
            TxtNombre.Text = ""
            TxtNumero.Text = ""
            MostrarInformacion()
        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            conexion = New SqlConnection("Server=DESKTOP-FLC9CU6\SQLEXPRESS; Database=cliente;User Id=sa; Password=tich;")

            'Comando para inserir novo registro
            strSQL = "DELETE CAD_CLIENTE WHERE id = @ID"

            comando = New SqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@ID", TxtID.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            comando.Clone()
            comando = Nothing
            conexion = Nothing
            TxtID.Text = ""
            TxtNombre.Text = ""
            TxtNumero.Text = ""
            MostrarInformacion()
        End Try
    End Sub
End Class
