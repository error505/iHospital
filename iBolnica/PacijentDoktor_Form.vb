Public Class PacijentDoktor_Form

    Private Sub DoktorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DoktorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoktorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub PacijentDoktor_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)

    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class