Public Class PacijentKrv_Form

    Private Sub Banka_krviBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Banka_krviBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Banka_krviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub PacijentKrv_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.banka_krvi' table. You can move, or remove it, as needed.
        Me.Banka_krviTableAdapter.Fill(Me.IbolnicaDataSet.banka_krvi)

    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class