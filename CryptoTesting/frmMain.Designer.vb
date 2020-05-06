<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblHash = New System.Windows.Forms.Label()
        Me.cbHash = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.grpEncryption = New System.Windows.Forms.GroupBox()
        Me.lblValKey = New System.Windows.Forms.Label()
        Me.lblValHash = New System.Windows.Forms.Label()
        Me.valKey = New System.Windows.Forms.Label()
        Me.valHash = New System.Windows.Forms.Label()
        Me.grpPlain2Encrypted = New System.Windows.Forms.GroupBox()
        Me.grpEncrypted2Plain = New System.Windows.Forms.GroupBox()
        Me.lblFromPlain = New System.Windows.Forms.Label()
        Me.lblToEncrypted = New System.Windows.Forms.Label()
        Me.txtFromPlain = New System.Windows.Forms.TextBox()
        Me.txtToEncrypted = New System.Windows.Forms.TextBox()
        Me.cmdEncrypt = New System.Windows.Forms.Button()
        Me.cmdDecrypt = New System.Windows.Forms.Button()
        Me.txtFromEncrypted = New System.Windows.Forms.TextBox()
        Me.txtToPlain = New System.Windows.Forms.TextBox()
        Me.lblFromEncrypted = New System.Windows.Forms.Label()
        Me.lblToPlain = New System.Windows.Forms.Label()
        Me.grpLogin.SuspendLayout()
        Me.grpEncryption.SuspendLayout()
        Me.grpPlain2Encrypted.SuspendLayout()
        Me.grpEncrypted2Plain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.btnContinue)
        Me.grpLogin.Controls.Add(Me.btnCancel)
        Me.grpLogin.Controls.Add(Me.cbHash)
        Me.grpLogin.Controls.Add(Me.lblHash)
        Me.grpLogin.Controls.Add(Me.txtKey)
        Me.grpLogin.Controls.Add(Me.lblKey)
        Me.grpLogin.Controls.Add(Me.lblDesc)
        Me.grpLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(455, 158)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Key Setup"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(28, 28)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(398, 26)
        Me.lblDesc.TabIndex = 0
        Me.lblDesc.Text = "In order to begin, first enter a key. This will be used to encrypt and decrypt." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Keys are used to secure hashes. Please also select the hash you would like to te" &
    "st."
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(15, 70)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(28, 13)
        Me.lblKey.TabIndex = 1
        Me.lblKey.Text = "Key:"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(49, 67)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(382, 20)
        Me.txtKey.TabIndex = 2
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.Location = New System.Drawing.Point(8, 99)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(35, 13)
        Me.lblHash.TabIndex = 3
        Me.lblHash.Text = "Hash:"
        '
        'cbHash
        '
        Me.cbHash.Items.AddRange(New Object() {"SHA1", "SHA256", "SHA516"})
        Me.cbHash.Location = New System.Drawing.Point(49, 96)
        Me.cbHash.Name = "cbHash"
        Me.cbHash.Size = New System.Drawing.Size(382, 21)
        Me.cbHash.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(116, 129)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(272, 129)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'grpEncryption
        '
        Me.grpEncryption.Controls.Add(Me.grpEncrypted2Plain)
        Me.grpEncryption.Controls.Add(Me.grpPlain2Encrypted)
        Me.grpEncryption.Controls.Add(Me.valHash)
        Me.grpEncryption.Controls.Add(Me.valKey)
        Me.grpEncryption.Controls.Add(Me.lblValHash)
        Me.grpEncryption.Controls.Add(Me.lblValKey)
        Me.grpEncryption.Location = New System.Drawing.Point(12, 176)
        Me.grpEncryption.Name = "grpEncryption"
        Me.grpEncryption.Size = New System.Drawing.Size(573, 304)
        Me.grpEncryption.TabIndex = 1
        Me.grpEncryption.TabStop = False
        '
        'lblValKey
        '
        Me.lblValKey.AutoSize = True
        Me.lblValKey.Location = New System.Drawing.Point(22, 27)
        Me.lblValKey.Name = "lblValKey"
        Me.lblValKey.Size = New System.Drawing.Size(28, 13)
        Me.lblValKey.TabIndex = 0
        Me.lblValKey.Text = "Key:"
        '
        'lblValHash
        '
        Me.lblValHash.AutoSize = True
        Me.lblValHash.Location = New System.Drawing.Point(15, 51)
        Me.lblValHash.Name = "lblValHash"
        Me.lblValHash.Size = New System.Drawing.Size(35, 13)
        Me.lblValHash.TabIndex = 1
        Me.lblValHash.Text = "Hash:"
        '
        'valKey
        '
        Me.valKey.AutoSize = True
        Me.valKey.Location = New System.Drawing.Point(56, 27)
        Me.valKey.Name = "valKey"
        Me.valKey.Size = New System.Drawing.Size(24, 13)
        Me.valKey.TabIndex = 2
        Me.valKey.Text = "key"
        '
        'valHash
        '
        Me.valHash.AutoSize = True
        Me.valHash.Location = New System.Drawing.Point(56, 51)
        Me.valHash.Name = "valHash"
        Me.valHash.Size = New System.Drawing.Size(30, 13)
        Me.valHash.TabIndex = 3
        Me.valHash.Text = "hash"
        '
        'grpPlain2Encrypted
        '
        Me.grpPlain2Encrypted.Controls.Add(Me.cmdEncrypt)
        Me.grpPlain2Encrypted.Controls.Add(Me.txtToEncrypted)
        Me.grpPlain2Encrypted.Controls.Add(Me.txtFromPlain)
        Me.grpPlain2Encrypted.Controls.Add(Me.lblToEncrypted)
        Me.grpPlain2Encrypted.Controls.Add(Me.lblFromPlain)
        Me.grpPlain2Encrypted.Location = New System.Drawing.Point(11, 73)
        Me.grpPlain2Encrypted.Name = "grpPlain2Encrypted"
        Me.grpPlain2Encrypted.Size = New System.Drawing.Size(556, 103)
        Me.grpPlain2Encrypted.TabIndex = 4
        Me.grpPlain2Encrypted.TabStop = False
        Me.grpPlain2Encrypted.Text = "Plain Text to Encrypted Text"
        '
        'grpEncrypted2Plain
        '
        Me.grpEncrypted2Plain.Controls.Add(Me.cmdDecrypt)
        Me.grpEncrypted2Plain.Controls.Add(Me.txtFromEncrypted)
        Me.grpEncrypted2Plain.Controls.Add(Me.txtToPlain)
        Me.grpEncrypted2Plain.Controls.Add(Me.lblToPlain)
        Me.grpEncrypted2Plain.Controls.Add(Me.lblFromEncrypted)
        Me.grpEncrypted2Plain.Location = New System.Drawing.Point(11, 182)
        Me.grpEncrypted2Plain.Name = "grpEncrypted2Plain"
        Me.grpEncrypted2Plain.Size = New System.Drawing.Size(556, 103)
        Me.grpEncrypted2Plain.TabIndex = 5
        Me.grpEncrypted2Plain.TabStop = False
        Me.grpEncrypted2Plain.Text = "Encrypted Text to Plain Text"
        '
        'lblFromPlain
        '
        Me.lblFromPlain.AutoSize = True
        Me.lblFromPlain.Location = New System.Drawing.Point(31, 22)
        Me.lblFromPlain.Name = "lblFromPlain"
        Me.lblFromPlain.Size = New System.Drawing.Size(33, 13)
        Me.lblFromPlain.TabIndex = 0
        Me.lblFromPlain.Text = "Plain:"
        '
        'lblToEncrypted
        '
        Me.lblToEncrypted.AutoSize = True
        Me.lblToEncrypted.Location = New System.Drawing.Point(6, 48)
        Me.lblToEncrypted.Name = "lblToEncrypted"
        Me.lblToEncrypted.Size = New System.Drawing.Size(58, 13)
        Me.lblToEncrypted.TabIndex = 1
        Me.lblToEncrypted.Text = "Encrypted:"
        '
        'txtFromPlain
        '
        Me.txtFromPlain.Location = New System.Drawing.Point(70, 19)
        Me.txtFromPlain.Name = "txtFromPlain"
        Me.txtFromPlain.Size = New System.Drawing.Size(480, 20)
        Me.txtFromPlain.TabIndex = 2
        '
        'txtToEncrypted
        '
        Me.txtToEncrypted.Location = New System.Drawing.Point(70, 45)
        Me.txtToEncrypted.Name = "txtToEncrypted"
        Me.txtToEncrypted.Size = New System.Drawing.Size(480, 20)
        Me.txtToEncrypted.TabIndex = 3
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.Location = New System.Drawing.Point(16, 71)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.Size = New System.Drawing.Size(525, 23)
        Me.cmdEncrypt.TabIndex = 4
        Me.cmdEncrypt.Text = "Encrypt Plain Text Entry"
        Me.cmdEncrypt.UseVisualStyleBackColor = True
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.Location = New System.Drawing.Point(16, 71)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(525, 23)
        Me.cmdDecrypt.TabIndex = 9
        Me.cmdDecrypt.Text = "Decrypt Encrypted Text Entry"
        Me.cmdDecrypt.UseVisualStyleBackColor = True
        '
        'txtFromEncrypted
        '
        Me.txtFromEncrypted.Location = New System.Drawing.Point(70, 19)
        Me.txtFromEncrypted.Name = "txtFromEncrypted"
        Me.txtFromEncrypted.Size = New System.Drawing.Size(480, 20)
        Me.txtFromEncrypted.TabIndex = 8
        '
        'txtToPlain
        '
        Me.txtToPlain.Location = New System.Drawing.Point(70, 45)
        Me.txtToPlain.Name = "txtToPlain"
        Me.txtToPlain.Size = New System.Drawing.Size(480, 20)
        Me.txtToPlain.TabIndex = 7
        '
        'lblFromEncrypted
        '
        Me.lblFromEncrypted.AutoSize = True
        Me.lblFromEncrypted.Location = New System.Drawing.Point(6, 22)
        Me.lblFromEncrypted.Name = "lblFromEncrypted"
        Me.lblFromEncrypted.Size = New System.Drawing.Size(58, 13)
        Me.lblFromEncrypted.TabIndex = 6
        Me.lblFromEncrypted.Text = "Encrypted:"
        '
        'lblToPlain
        '
        Me.lblToPlain.AutoSize = True
        Me.lblToPlain.Location = New System.Drawing.Point(31, 48)
        Me.lblToPlain.Name = "lblToPlain"
        Me.lblToPlain.Size = New System.Drawing.Size(33, 13)
        Me.lblToPlain.TabIndex = 5
        Me.lblToPlain.Text = "Plain:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 508)
        Me.Controls.Add(Me.grpEncryption)
        Me.Controls.Add(Me.grpLogin)
        Me.Name = "frmMain"
        Me.Text = "Crypto Testing"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.grpEncryption.ResumeLayout(False)
        Me.grpEncryption.PerformLayout()
        Me.grpPlain2Encrypted.ResumeLayout(False)
        Me.grpPlain2Encrypted.PerformLayout()
        Me.grpEncrypted2Plain.ResumeLayout(False)
        Me.grpEncrypted2Plain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLogin As Windows.Forms.GroupBox
    Friend WithEvents btnContinue As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents cbHash As Windows.Forms.ComboBox
    Friend WithEvents lblHash As Windows.Forms.Label
    Friend WithEvents txtKey As Windows.Forms.TextBox
    Friend WithEvents lblKey As Windows.Forms.Label
    Friend WithEvents lblDesc As Windows.Forms.Label
    Friend WithEvents grpEncryption As Windows.Forms.GroupBox
    Friend WithEvents valHash As Windows.Forms.Label
    Friend WithEvents valKey As Windows.Forms.Label
    Friend WithEvents lblValHash As Windows.Forms.Label
    Friend WithEvents lblValKey As Windows.Forms.Label
    Friend WithEvents grpEncrypted2Plain As Windows.Forms.GroupBox
    Friend WithEvents cmdDecrypt As Windows.Forms.Button
    Friend WithEvents txtFromEncrypted As Windows.Forms.TextBox
    Friend WithEvents txtToPlain As Windows.Forms.TextBox
    Friend WithEvents lblToPlain As Windows.Forms.Label
    Friend WithEvents lblFromEncrypted As Windows.Forms.Label
    Friend WithEvents grpPlain2Encrypted As Windows.Forms.GroupBox
    Friend WithEvents cmdEncrypt As Windows.Forms.Button
    Friend WithEvents txtToEncrypted As Windows.Forms.TextBox
    Friend WithEvents txtFromPlain As Windows.Forms.TextBox
    Friend WithEvents lblToEncrypted As Windows.Forms.Label
    Friend WithEvents lblFromPlain As Windows.Forms.Label
End Class
