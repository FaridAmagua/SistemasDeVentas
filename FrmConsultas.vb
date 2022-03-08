Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmConsultas

    Dim Consulta As String
    Dim Operador As String
    Dim Cadena1 As String
    Dim Cadena2 As String
    Dim Cadena3 As String



    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedValue
            Case 0
                Operador = "="
            Case 1
                Operador = "!="
            Case 2
                Operador = "<"
            Case 3
                Operador = "<="
            Case 4
                Operador = "=="
            Case 5
                Operador = ">="
            Case 6
                Operador = "&&"
            Case 7
                Operador = "||"
            Case 8
                Operador = "!"

        End Select

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CmbTablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTablas.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

End Class