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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblOutputFile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create a File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(381, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit a File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 81)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Read a File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblOutputFile
        '
        Me.lblOutputFile.AutoSize = True
        Me.lblOutputFile.Location = New System.Drawing.Point(76, 113)
        Me.lblOutputFile.Name = "lblOutputFile"
        Me.lblOutputFile.Size = New System.Drawing.Size(107, 16)
        Me.lblOutputFile.TabIndex = 3
        Me.lblOutputFile.Text = "Contents of a file:"
        Me.lblOutputFile.UseMnemonic = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 395)
        Me.Controls.Add(Me.lblOutputFile)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblOutputFile As Label
End Class
