<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Send_Keys
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
    Me.webSendKeys = New System.Windows.Forms.WebBrowser()
    Me.SuspendLayout()
    '
    'webSendKeys
    '
    Me.webSendKeys.Dock = System.Windows.Forms.DockStyle.Fill
    Me.webSendKeys.Location = New System.Drawing.Point(0, 0)
    Me.webSendKeys.MinimumSize = New System.Drawing.Size(20, 20)
    Me.webSendKeys.Name = "webSendKeys"
    Me.webSendKeys.Size = New System.Drawing.Size(282, 255)
    Me.webSendKeys.TabIndex = 0
    '
    'View_Send_Keys
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 255)
    Me.Controls.Add(Me.webSendKeys)
    Me.Name = "View_Send_Keys"
    Me.Text = "View SendKey Codes"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents webSendKeys As System.Windows.Forms.WebBrowser
End Class
