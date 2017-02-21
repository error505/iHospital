Public Class Podesavanja_Form

    Private Sub PodesavanjaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PodesavanjaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PodesavanjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Podesavanja_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)

    End Sub

    Private Sub BtnDodajPodatke_Click(sender As Object, e As EventArgs) Handles BtnDodajPodatke.Click
        Me.Validate()
        Me.PodesavanjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class