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
        Me.btnProcess = New System.Windows.Forms.Button
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.fldFrom = New System.Windows.Forms.FolderBrowserDialog
        Me.fldTo = New System.Windows.Forms.FolderBrowserDialog
        Me.btnFrom = New System.Windows.Forms.Button
        Me.btnTo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnProcess.Location = New System.Drawing.Point(197, 158)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(126, 23)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrom.Location = New System.Drawing.Point(71, 20)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(418, 20)
        Me.txtFrom.TabIndex = 1
        '
        'txtTo
        '
        Me.txtTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTo.Location = New System.Drawing.Point(71, 61)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(418, 20)
        Me.txtTo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 187)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(511, 17)
        Me.ProgressBar1.TabIndex = 5
        '
        'btnFrom
        '
        Me.btnFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrom.Location = New System.Drawing.Point(495, 16)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Size = New System.Drawing.Size(28, 23)
        Me.btnFrom.TabIndex = 6
        Me.btnFrom.Text = "..."
        Me.btnFrom.UseVisualStyleBackColor = True
        '
        'btnTo
        '
        Me.btnTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTo.Location = New System.Drawing.Point(495, 61)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(29, 23)
        Me.btnTo.TabIndex = 7
        Me.btnTo.Text = "..."
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(71, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(418, 20)
        Me.txtPassword.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 214)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.btnFrom)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.btnProcess)
        Me.Name = "Form1"
        Me.Text = "Encrypt PDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents fldFrom As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fldTo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnFrom As System.Windows.Forms.Button
    Friend WithEvents btnTo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox

End Class
