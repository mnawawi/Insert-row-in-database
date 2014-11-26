Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuntingDataSet.gunting' table. You can move, or remove it, as needed.
        Me.GuntingTableAdapter.Fill(Me.GuntingDataSet.gunting)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        Label3.Text = My.Computer.Clock.LocalTime
        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)
        MessageBox.Show("Save")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GuntingBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        On Error GoTo SaveErr

        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)

SaveErr:
        Exit Sub

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        On Error GoTo SaveErr
        RadioButton1.Text = "Child"

        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GuntingBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        GuntingBindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        GuntingBindingSource.MoveNext()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = My.Computer.Clock.LocalTime
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        On Error GoTo SaveErr
        RadioButton3.Text = "Cut"
        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        On Error GoTo SaveErr
        RadioButton5.Text = "Cut & Shave"
        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        On Error GoTo SaveErr
        RadioButton4.Text = "Cut,Shave & Wash"

        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        On Error GoTo SaveErr
        RadioButton6.Text = "Child"

        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        On Error GoTo SaveErr
        RadioButton1.Text = "Adult"

        GuntingBindingSource.EndEdit()
        GuntingTableAdapter.Update(GuntingDataSet.gunting)


SaveErr:
        Exit Sub
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
