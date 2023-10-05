Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        Opacity = 0.95
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDO.Click
        Dim sum, n As Integer
        MyListBox.Items.Add("DO LOOP")
        MyListBox.Items.Add("---------------------------")
        MyListBox.Items.Add("n" & vbTab & vbTab & "Sum")
        MyListBox.Items.Add("---------------------------")
        Do
            n += 1
            sum += n
            MyListBox.Items.Add(n & vbTab & vbTab & sum)
            If n = 10 Then
                Exit Do
            End If
        Loop
        MyListBox.Items.Add("------OUT OF LOOP------")
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim sum, n As Integer
        MyListBox.Items.Add("WHILE END WHILE LOOP")
        MyListBox.Items.Add("------------------------------")
        MyListBox.Items.Add("n" & vbTab & vbTab & "sum")
        MyListBox.Items.Add("------------------------------")
        While n <> 10
            n += 1
            sum += n
            MyListBox.Items.Add(n & vbTab & vbTab & sum)
        End While
        MyListBox.Items.Add("------OUT OF LOOP------")
    End Sub
End Class
