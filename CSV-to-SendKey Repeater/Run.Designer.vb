<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Run
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Run))
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.rtbStatus = New System.Windows.Forms.RichTextBox()
    Me.progress = New System.Windows.Forms.ProgressBar()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.btnComplete = New System.Windows.Forms.Button()
    Me.btnSaveReport = New System.Windows.Forms.Button()
    Me.countDown = New System.Windows.Forms.Timer(Me.components)
    Me.timInterval = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = True
    Me.lblStatus.Location = New System.Drawing.Point(12, 9)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(73, 17)
    Me.lblStatus.TabIndex = 0
    Me.lblStatus.Text = "Running..."
    '
    'rtbStatus
    '
    Me.rtbStatus.Location = New System.Drawing.Point(13, 30)
    Me.rtbStatus.Name = "rtbStatus"
    Me.rtbStatus.ReadOnly = True
    Me.rtbStatus.Size = New System.Drawing.Size(352, 196)
    Me.rtbStatus.TabIndex = 1
    Me.rtbStatus.Text = ""
    '
    'progress
    '
    Me.progress.Location = New System.Drawing.Point(15, 233)
    Me.progress.Name = "progress"
    Me.progress.Size = New System.Drawing.Size(350, 23)
    Me.progress.TabIndex = 2
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(290, 287)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 3
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'btnComplete
    '
    Me.btnComplete.Location = New System.Drawing.Point(96, 263)
    Me.btnComplete.Name = "btnComplete"
    Me.btnComplete.Size = New System.Drawing.Size(188, 47)
    Me.btnComplete.TabIndex = 4
    Me.btnComplete.Text = "Okay"
    Me.btnComplete.UseVisualStyleBackColor = True
    '
    'btnSaveReport
    '
    Me.btnSaveReport.Location = New System.Drawing.Point(15, 284)
    Me.btnSaveReport.Name = "btnSaveReport"
    Me.btnSaveReport.Size = New System.Drawing.Size(75, 23)
    Me.btnSaveReport.TabIndex = 5
    Me.btnSaveReport.Text = "Save"
    Me.btnSaveReport.UseVisualStyleBackColor = True
    '
    'countDown
    '
    Me.countDown.Enabled = True
    Me.countDown.Interval = 1000
    '
    'timInterval
    '
    '
    'Run
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(377, 319)
    Me.Controls.Add(Me.btnSaveReport)
    Me.Controls.Add(Me.btnComplete)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.progress)
    Me.Controls.Add(Me.rtbStatus)
    Me.Controls.Add(Me.lblStatus)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Run"
    Me.Text = "Run"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents rtbStatus As System.Windows.Forms.RichTextBox
  Friend WithEvents progress As System.Windows.Forms.ProgressBar
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnComplete As System.Windows.Forms.Button
  Friend WithEvents btnSaveReport As System.Windows.Forms.Button
  Friend WithEvents countDown As System.Windows.Forms.Timer
  Friend WithEvents timInterval As System.Windows.Forms.Timer
End Class
