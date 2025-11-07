Imports System.IO

Public Class Form1
    Private NumbersList As New List(Of Integer)


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If IsNumeric(txtNumber.Text) Then
            NumbersList.Add(CInt(txtNumber.Text))
            lstSorted.Items.Add(txtNumber.Text)
            txtNumber.Clear()
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim writer As New StreamWriter("numbers.txt")

        For Each num As Integer In NumbersList
            writer.WriteLine(num)
        Next

        writer.Close()
        MessageBox.Show("Numbers saved to file!")
    End Sub
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        lstSorted.Items.Clear()


        Dim lines() As String = File.ReadAllLines("numbers.txt")


        Dim sortedNumbers = lines.Select(Function(x) CInt(x)).OrderBy(Function(x) x)


        For Each num As Integer In sortedNumbers
            lstSorted.Items.Add(num)
            Console.WriteLine(num)
        Next
    End Sub
End Class
