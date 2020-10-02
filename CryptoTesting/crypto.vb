Imports System.Security.Cryptography

Module crypto
    Private CSP As New TripleDESCryptoServiceProvider
    Dim sha1 As New SHA1CryptoServiceProvider
    Dim sha256 As New SHA256CryptoServiceProvider
    Dim sha512 As New SHA512CryptoServiceProvider

    Private Function Truncate(ByVal key As String, ByVal sha As String, ByVal length As Integer) As Byte()
        Dim thisSha As Object

        Select Case sha
            Case "SHA1"
                thisSha = New SHA1CryptoServiceProvider

            Case "SHA256"
                thisSha = New SHA256CryptoServiceProvider

            Case "SHA512"
                thisSha = New SHA512CryptoServiceProvider
        End Select

        Dim keyBytes() As Byte = Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = thisSha.ComputeHash(keyBytes)

        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub InitializeCrypto(ByVal key As String, ByVal sha As String)
        CSP.Key = Truncate(key, sha, CSP.KeySize \ 8)
        CSP.IV = Truncate("", sha, CSP.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plainText As String) As String
        Dim plainTextBytes() As Byte = Text.Encoding.Unicode.GetBytes(plainText)

        Dim memStream As New IO.MemoryStream

        Dim encStream As New CryptoStream(memStream, CSP.CreateEncryptor(), CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)

        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(memStream.ToArray)
    End Function

    Public Function DecryptData(ByVal encryptedText As String) As String
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedText)

        Dim memStream As New IO.MemoryStream

        Dim decStream As New CryptoStream(memStream, CSP.CreateDecryptor(), CryptoStreamMode.Write)

        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)

        decStream.FlushFinalBlock()

        Return Text.Encoding.Unicode.GetString(memStream.ToArray)
    End Function
End Module
