Public Class Run
  Private _fil As String
  Private lines As String()
  Private MaxIndex As Integer

  Public Sub New(ByVal FilePath As String)
    InitializeComponent()

    _fil = FilePath '' CSV File Path

    If IO.File.Exists(_fil) Then
      lines = IO.File.ReadAllLines(_fil)
      MaxIndex = lines.Length - 1
    End If

    btnComplete.Enabled = False
    btnSaveReport.Enabled = False

    timInterval.Interval = (Main.numInterval.Value * 1000) '' Set the interval in terms of Milliseconds
  End Sub

  Const CountDownMax As Integer = 10
  Private Sub countDown_Tick(sender As Object, e As EventArgs) Handles countDown.Tick
    Static count As Integer = -1
    count += 1
    If count = CountDownMax Then
      countDown.Stop()
      count = -1
      '' Set progress bar
      progress.Minimum = 0
      progress.Maximum = MaxIndex + 1
      progress.Value = 0
      '' Start timer
      timInterval.Enabled = True
      timInterval.Start()
    Else
      lblStatus.Text = "SendKeys will begin in " & (CountDownMax - count).ToString & " seconds. Please focus your cursor in the window you wish to send commands."
    End If
  End Sub

  Private Sub timInterval_Tick(sender As Object, e As EventArgs) Handles timInterval.Tick
    Static currentLine As Integer = 0

    Dim strRead As String = lines(currentLine)
    rtbStatus.AppendText("Reading '" & strRead & "'..." & vbLf)
    If strRead.Contains(",") Then
      For Each cmd As String In strRead.Split(",")
        SendKeys.SendWait(cmd)
        rtbStatus.AppendText(vbTab & "Sent '" & cmd & "'" & vbLf)
        Application.DoEvents()
      Next
    Else
      SendKeys.SendWait(strRead)
      rtbStatus.AppendText(vbTab & "Sent '" & strRead & "'" & vbLf)
      Application.DoEvents()
    End If
    progress.Increment(1)
    rtbStatus.ScrollToCaret()

    If currentLine = MaxIndex Then
      timInterval.Stop()

      Dim ts As New TimeSpan(0, 0, (MaxIndex * Main.numInterval.Value))
      lblStatus.Text = "Complete!"
      rtbStatus.AppendText("Completed! Took " & ts.ToString & " for " & lines.Length.ToString & " lines")

      btnComplete.Enabled = True
      btnSaveReport.Enabled = True
      btnCancel.Enabled = False
      currentLine = 0
    Else
      currentLine += 1
    End If
  End Sub

  Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
    Me.Close()
  End Sub

  Private Sub btnSaveReport_Click(sender As Object, e As EventArgs) Handles btnSaveReport.Click
    Dim sav As New SaveFileDialog
    sav.Title = "Save report log..."
    sav.FileName = "CSV-to-SendKey Repeater Report.rtf"
    sav.Filter = "Rich Text Format (.rtf)|*.rtf"
    sav.CheckPathExists = True
    sav.OverwritePrompt = True
    sav.ShowDialog()

    rtbStatus.SaveFile(sav.FileName)
    Try
      Process.Start(sav.FileName)
    Catch ex As Exception
      MsgBox("Could not open saved report due to error..." & vbLf & ex.Message)
    End Try
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    timInterval.Stop()
    btnCancel.Enabled = False
    btnSaveReport.Enabled = True
    lblStatus.Text = "Stopped..."
    rtbStatus.AppendText("Stopped Manually...")
  End Sub
End Class