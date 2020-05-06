Imports System.Security.Cryptography

Public Class clsCrypto

    Private Des As New TripleDESCryptoServiceProvider

    Private Function TruncHash(ByVal key As String, ByVal length As Integer) As Byte()
        'We have options between SHA1, SHA256, and SHA512.
        'The problem with SHA1 is that it's basically defunct.
        'SHA256 is still good, but not as good as SHA512.
        Dim sha As New SHA256CryptoServiceProvider

        Dim keyBytes() As Byte = Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha.ComputeHash(keyBytes)

        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        Des.Key = TruncHash(key, Des.KeySize \ 8)
        Des.IV = TruncHash("", Des.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plainText As String) As String
        Dim plainTextBytes() As Byte = Text.Encoding.Unicode.GetBytes(plainText)

        Dim memStream As New IO.MemoryStream

        Dim encStream As New CryptoStream(memStream, Des.CreateEncryptor(), CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)

        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(memStream.ToArray)
    End Function

    Public Function DecryptData(ByVal encryptedText As String) As String
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedText)

        Dim memStream As New IO.MemoryStream

        Dim decStream As New CryptoStream(memStream, Des.CreateDecryptor(), CryptoStreamMode.Write)

        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)

        decStream.FlushFinalBlock()

        Return Text.Encoding.Unicode.GetString(memStream.ToArray)
    End Function
End Class

