<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.pnlImport = New System.Windows.Forms.Panel()
    Me.txtImport = New System.Windows.Forms.TextBox()
    Me.btnBrowse = New System.Windows.Forms.Button()
    Me.pnlSettings = New System.Windows.Forms.Panel()
    Me.btnSend = New System.Windows.Forms.Button()
    Me.pnlExternalKey = New System.Windows.Forms.Panel()
    Me.lstImport = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lblInterval = New System.Windows.Forms.Label()
    Me.numInterval = New System.Windows.Forms.NumericUpDown()
    Me.btnViewSendKeys = New System.Windows.Forms.Button()
    Me.pnlImport.SuspendLayout()
    Me.pnlSettings.SuspendLayout()
    Me.pnlExternalKey.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlImport
    '
    Me.pnlImport.Controls.Add(Me.txtImport)
    Me.pnlImport.Controls.Add(Me.btnBrowse)
    Me.pnlImport.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlImport.Location = New System.Drawing.Point(0, 0)
    Me.pnlImport.Name = "pnlImport"
    Me.pnlImport.Size = New System.Drawing.Size(482, 75)
    Me.pnlImport.TabIndex = 0
    '
    'txtImport
    '
    Me.txtImport.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtImport.Location = New System.Drawing.Point(0, 39)
    Me.txtImport.MinimumSize = New System.Drawing.Size(4, 34)
    Me.txtImport.Name = "txtImport"
    Me.txtImport.ReadOnly = True
    Me.txtImport.Size = New System.Drawing.Size(482, 34)
    Me.txtImport.TabIndex = 1
    Me.txtImport.Text = "Select a file..."
    '
    'btnBrowse
    '
    Me.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top
    Me.btnBrowse.Location = New System.Drawing.Point(0, 0)
    Me.btnBrowse.Name = "btnBrowse"
    Me.btnBrowse.Size = New System.Drawing.Size(482, 39)
    Me.btnBrowse.TabIndex = 0
    Me.btnBrowse.Text = "Browse..."
    Me.btnBrowse.UseVisualStyleBackColor = True
    '
    'pnlSettings
    '
    Me.pnlSettings.Controls.Add(Me.Panel1)
    Me.pnlSettings.Controls.Add(Me.btnSend)
    Me.pnlSettings.Controls.Add(Me.pnlExternalKey)
    Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlSettings.Location = New System.Drawing.Point(0, 355)
    Me.pnlSettings.Name = "pnlSettings"
    Me.pnlSettings.Size = New System.Drawing.Size(482, 200)
    Me.pnlSettings.TabIndex = 1
    '
    'btnSend
    '
    Me.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.btnSend.Location = New System.Drawing.Point(0, 147)
    Me.btnSend.Name = "btnSend"
    Me.btnSend.Size = New System.Drawing.Size(482, 53)
    Me.btnSend.TabIndex = 2
    Me.btnSend.Text = "Begin"
    Me.btnSend.UseVisualStyleBackColor = True
    '
    'pnlExternalKey
    '
    Me.pnlExternalKey.Controls.Add(Me.btnViewSendKeys)
    Me.pnlExternalKey.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlExternalKey.Location = New System.Drawing.Point(0, 0)
    Me.pnlExternalKey.Name = "pnlExternalKey"
    Me.pnlExternalKey.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlExternalKey.Size = New System.Drawing.Size(482, 57)
    Me.pnlExternalKey.TabIndex = 1
    '
    'lstImport
    '
    Me.lstImport.Activation = System.Windows.Forms.ItemActivation.OneClick
    Me.lstImport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
    Me.lstImport.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstImport.FullRowSelect = True
    Me.lstImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lstImport.HoverSelection = True
    Me.lstImport.Location = New System.Drawing.Point(0, 75)
    Me.lstImport.MultiSelect = False
    Me.lstImport.Name = "lstImport"
    Me.lstImport.Size = New System.Drawing.Size(482, 280)
    Me.lstImport.TabIndex = 2
    Me.lstImport.UseCompatibleStateImageBehavior = False
    Me.lstImport.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Line#"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.numInterval)
    Me.Panel1.Controls.Add(Me.lblInterval)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 57)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
    Me.Panel1.Size = New System.Drawing.Size(482, 43)
    Me.Panel1.TabIndex = 3
    '
    'lblInterval
    '
    Me.lblInterval.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblInterval.Location = New System.Drawing.Point(5, 5)
    Me.lblInterval.Name = "lblInterval"
    Me.lblInterval.Size = New System.Drawing.Size(185, 33)
    Me.lblInterval.TabIndex = 0
    Me.lblInterval.Text = "Interval (in seconds)"
    '
    'numInterval
    '
    Me.numInterval.Dock = System.Windows.Forms.DockStyle.Fill
    Me.numInterval.Location = New System.Drawing.Point(190, 5)
    Me.numInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numInterval.Name = "numInterval"
    Me.numInterval.Size = New System.Drawing.Size(287, 34)
    Me.numInterval.TabIndex = 1
    Me.numInterval.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.numInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
    '
    'btnViewSendKeys
    '
    Me.btnViewSendKeys.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnViewSendKeys.Location = New System.Drawing.Point(5, 5)
    Me.btnViewSendKeys.Name = "btnViewSendKeys"
    Me.btnViewSendKeys.Size = New System.Drawing.Size(472, 47)
    Me.btnViewSendKeys.TabIndex = 3
    Me.btnViewSendKeys.Text = "View SendKey Codes"
    Me.btnViewSendKeys.UseVisualStyleBackColor = True
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(482, 555)
    Me.Controls.Add(Me.lstImport)
    Me.Controls.Add(Me.pnlSettings)
    Me.Controls.Add(Me.pnlImport)
    Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Main"
    Me.Text = "CSV-to-SendKey Repeater"
    Me.pnlImport.ResumeLayout(False)
    Me.pnlImport.PerformLayout()
    Me.pnlSettings.ResumeLayout(False)
    Me.pnlExternalKey.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlImport As System.Windows.Forms.Panel
  Friend WithEvents txtImport As System.Windows.Forms.TextBox
  Friend WithEvents btnBrowse As System.Windows.Forms.Button
  Friend WithEvents pnlSettings As System.Windows.Forms.Panel
  Friend WithEvents pnlExternalKey As System.Windows.Forms.Panel
  Friend WithEvents btnSend As System.Windows.Forms.Button
  Friend WithEvents lstImport As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblInterval As System.Windows.Forms.Label
  Friend WithEvents numInterval As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnViewSendKeys As System.Windows.Forms.Button

End Class
