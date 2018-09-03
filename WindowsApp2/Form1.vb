Imports Domino
Imports LogicaNegocio

Public Class Form1
    Dim _userService As New UserService


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'eventos del boton
        Dim usuarioAEnviar As Usuario = ObtenerUsuarioDelFormularioLogin()
        Dim usuarioALogear As Usuario = _userService.login(usuarioAEnviar)
        Dim ventanaPrincipal As New Form2
        If (usuarioALogear.rol.Equals("Admin")) Then
            ventanaPrincipal = AplicandoRolAdmin(ventanaPrincipal)
        ElseIf (usuarioALogear.rol.Equals("Peon")) Then

            Form2.Show()
        End If
    End Sub

    Private Shared Function AplicandoRolAdmin(ventanaPrincipal As Form2) As Form2

        Form2.Show()
        Return ventanaPrincipal
    End Function

    Private Function ObtenerUsuarioDelFormularioLogin() As Usuario
        Dim user As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim usuarioAEnviar As New Usuario
        usuarioAEnviar.nombre = user
        usuarioAEnviar.password = password
        Return usuarioAEnviar
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
