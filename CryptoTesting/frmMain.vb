Imports System.Windows.Forms

Public Class frmMain
    Dim strKey As String
    Dim strHash As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpEncryption.Location = defLoc
        Me.Size = frmSize1
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtKey.Text = "" Or cbHash.Text = "" Then
            MessageBox.Show("Neither of the values can be left blank. Please make sure to fill out a key and select a hash.", "Blank Input Error")
        Else
            strKey = txtKey.Text
            strHash = cbHash.Text

            InitializeCrypto(strKey, strHash)
            UseCrypto()
        End If
    End Sub

    Sub UseCrypto()
        valKey.Text = strKey
        valHash.Text = strHash

        grpLogin.Visible = False
        grpEncryption.Visible = True
        Me.Size = frmSize2
    End Sub

    Private Sub cmdEncrypt_Click(sender As Object, e As EventArgs) Handles cmdEncrypt.Click
        Dim plainText As String = txtFromPlain.Text
        txtToEncrypted.Text = EncryptData(plainText)
    End Sub

    Private Sub cmdDecrypt_Click(sender As Object, e As EventArgs) Handles cmdDecrypt.Click
        Dim encryptedText As String = txtFromEncrypted.Text
        Try
            txtToPlain.Text = DecryptData(encryptedText)
        Catch ex As Exception
            MessageBox.Show("You are trying to decrypt a value that was encrypted with a different sha or key.", "Invalid Sha or Key")
        End Try
    End Sub
End Class