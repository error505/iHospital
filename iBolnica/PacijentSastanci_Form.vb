Public Class PacijentSastanci_Form

    Private Sub SastanciBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SastanciBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SastanciBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub PacijentSastanci_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.sastanci' table. You can move, or remove it, as needed.
        Me.SastanciTableAdapter.Fill(Me.IbolnicaDataSet.sastanci)

    End Sub

    Private Sub BtnZatvori_Click_1(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class