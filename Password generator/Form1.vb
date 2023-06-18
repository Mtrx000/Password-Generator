Imports System.Reflection.Emit
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    '                                                               PG Project
    '                                                                          By Mtrx000
    '                                                               CONTACT ME ON DISCORD TO USE THIS CODE
    '                                                         Discord: r3vil_

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim passwordLength As Integer = Integer.Parse(TextBox1.Text)
        Dim includeSpecialChars As Boolean = CheckBox1.Checked
        Dim includeUpperCase As Boolean = CheckBox2.Checked

        Dim password As String = GeneratePassword(passwordLength, includeSpecialChars, includeUpperCase)
        Label3.Text = password
    End Sub

    '                                                               PG Project
    '                                                                          By Mtrx000
    '                                                               CONTACT ME ON DISCORD TO USE THIS CODE
    '                                                         Discord: r3vil_

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Clipboard.SetText(Label1.Text)
        MessageBox.Show("Copied To Clipboard !")
    End Sub

    '                                                               PG Project
    '                                                                          By Mtrx000
    '                                                               CONTACT ME ON DISCORD TO USE THIS CODE
    '                                                         Discord: r3vil_

    Private Function GeneratePassword(length As Integer, includeSpecialChars As Boolean, includeUpperCase As Boolean) As String
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim rnd As New Random()
        Dim password As New StringBuilder(length)

        If includeUpperCase Then
            chars &= "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If

        If includeSpecialChars Then
            chars &= "#@%$"
        End If

        For i As Integer = 1 To length
            Dim index As Integer = rnd.Next(0, chars.Length)
            password.Append(chars(index))
        Next

        Return password.ToString()
    End Function
End Class


'                                                               PG Project
'                                                                          By Mtrx000
'                                                               CONTACT ME ON DISCORD TO USE THIS CODE
'                                                         Discord: r3vil_
