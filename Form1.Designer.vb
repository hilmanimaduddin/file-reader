<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.lstFileContent = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearListBox = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(94, 63)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(530, 26)
        Me.txtFilePath.TabIndex = 0
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(655, 106)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(133, 37)
        Me.btnLoadFile.TabIndex = 2
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'lstFileContent
        '
        Me.lstFileContent.FormattingEnabled = True
        Me.lstFileContent.ItemHeight = 20
        Me.lstFileContent.Location = New System.Drawing.Point(16, 111)
        Me.lstFileContent.Name = "lstFileContent"
        Me.lstFileContent.Size = New System.Drawing.Size(608, 184)
        Me.lstFileContent.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Directory:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Reader"
        '
        'btnClearListBox
        '
        Me.btnClearListBox.Location = New System.Drawing.Point(655, 149)
        Me.btnClearListBox.Name = "btnClearListBox"
        Me.btnClearListBox.Size = New System.Drawing.Size(133, 37)
        Me.btnClearListBox.TabIndex = 7
        Me.btnClearListBox.Text = "Clear"
        Me.btnClearListBox.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(655, 63)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(133, 37)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnClearListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFileContent)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.txtFilePath)
        Me.Name = "Form1"
        Me.Text = "File Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnLoadFile As Button
    Friend WithEvents lstFileContent As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClearListBox As Button
    Friend WithEvents btnBrowse As Button
End Class
