Public Class Form1
    Private Sub PACIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PACIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PACIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NUTRI2023DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'NUTRI2023DataSet.PACIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.PACIENTESTableAdapter.Fill(Me.NUTRI2023DataSet.PACIENTES)

    End Sub
End Class
