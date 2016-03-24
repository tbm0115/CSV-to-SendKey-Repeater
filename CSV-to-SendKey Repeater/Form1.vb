Public Class Main

  Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
    Dim fil As String
    Dim opn As New OpenFileDialog
    opn.Title = "Select a CSV file..."
    opn.Filter = "Comma Separated Values (CSV)|*.csv"
    opn.ShowDialog()
    fil = opn.FileName

    If Not String.IsNullOrEmpty(fil) And IO.File.Exists(fil) Then
      Dim vals As String()
      For Each ln As String In IO.File.ReadAllLines(fil)
        If ln.Contains(",") Then
          vals = ln.Split(",")
          If lstImport.Columns.Count < vals.Length Then
            For i = 0 To vals.Length - 1 Step 1
              lstImport.Columns.Add("Column" & (i + 1).ToString)
            Next
          End If
          Dim li As New ListViewItem((lstImport.Items.Count + 1).ToString & ")")
          For Each Val As String In vals
            li.SubItems.Add(Val)
          Next
          lstImport.Items.Add(li)
        End If
      Next
      MsgBox("Added '" & lstImport.Items.Count.ToString & "' items!")
      txtImport.Text = fil
    End If
  End Sub

  Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
    Dim rn As New Run(txtImport.Text)
    rn.ShowDialog()
  End Sub

  Private Sub btnViewSendKeys_Click(sender As Object, e As EventArgs) Handles btnViewSendKeys.Click
    If View_Send_Keys.Visible Then
      View_Send_Keys.Focus()
    Else
      View_Send_Keys.Show()
    End If
  End Sub
End Class
