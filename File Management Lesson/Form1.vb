Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText("Hello.txt")

        outFile.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("Hello.txt")

        outFile.WriteLine("First line")
        outFile.WriteLine("Second line")

        outFile.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inFile As IO.StreamReader

        If IO.File.Exists("Hello.txt") Then
            inFile = IO.File.OpenText("Hello.txt")

            Dim strLine As String
            Do Until inFile.Peek = -1
                strLine = inFile.ReadLine
                lblOutputFile.Text = lblOutputFile.Text & ControlChars.NewLine & strLine
            Loop

            inFile.Close()
        Else
            MsgBox("File not found.")
        End If


    End Sub
End Class
