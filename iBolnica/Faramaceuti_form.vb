Public Class Faramaceuti_form

    Private Sub FarmaceutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FarmaceutBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FarmaceutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub Faramaceuti_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.farmaceut' table. You can move, or remove it, as needed.
        Me.FarmaceutTableAdapter.Fill(Me.IbolnicaDataSet.farmaceut)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.FarmaceutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.FarmaceutBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnNoviFarmaceut_Click(sender As Object, e As EventArgs) Handles BtnNoviFarmaceut.Click
        Try
            Me.FarmaceutBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajFarmaceuta_Click(sender As Object, e As EventArgs) Handles BtnDodajFarmaceuta.Click
        Me.Validate()
        Me.FarmaceutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
End Class