Public Class frmMain ' main form - Alex 16/09/19
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Clear()
        numShift.Value = 4
        lblOutput.Text = ""
    End Sub
    
    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click ' button to encrypt - josh 16/09/19
        Dim plainText As String = txtInput.Text.ToUpper()
        Dim cipherText As String = ""
        Dim cipherInChars(plainText.Length) As Char
        For i As Integer = 0 To plainText.Length - 1
            cipherInChars(i) = Convert.ToChar((Convert.ToInt32(Convert.ToChar(plainText(i))) + CInt(numShift.Value) - 65) Mod 26 + 65)
        Next
        lblOutput.Text = New String(cipherInChars)
    End Sub
End Class
