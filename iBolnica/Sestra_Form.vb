Public Class Sestra_Form

    Private Sub SestraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SestraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SestraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Sestra_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.sestra' table. You can move, or remove it, as needed.
        Me.SestraTableAdapter.Fill(Me.IbolnicaDataSet.sestra)

    End Sub

    Private Sub BtnDodajSestru_Click(sender As Object, e As EventArgs) Handles BtnDodajSestru.Click
        Me.Validate()
        Me.SestraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovaSestra_Click(sender As Object, e As EventArgs) Handles BtnNovaSestra.Click
        Try
            Me.SestraBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.SestraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.SestraBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class