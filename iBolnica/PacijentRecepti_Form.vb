Public Class PacijentRecepti_Form

    Private Sub ReceptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceptBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub PacijentRecepti_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.recept' table. You can move, or remove it, as needed.
        Me.ReceptTableAdapter.Fill(Me.IbolnicaDataSet.recept)

    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class