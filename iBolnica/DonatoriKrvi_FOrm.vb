Public Class DonatoriKrvi_FOrm
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub Donator_krviBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Donator_krviBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Donator_krviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub
    'Konekcija sa SQL bazom podataka.
    Private Sub DonatoriKrvi_FOrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.banka_krvi' table. You can move, or remove it, as needed.
        Me.Banka_krviTableAdapter.Fill(Me.IbolnicaDataSet.banka_krvi)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.donator_krvi' table. You can move, or remove it, as needed.
        Me.Donator_krviTableAdapter.Fill(Me.IbolnicaDataSet.donator_krvi)

    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub BtnDodajDavatelja_Click(sender As Object, e As EventArgs) Handles BtnDodajDavatelja.Click
        Me.Validate()
        Me.Donator_krviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNoviDavatelj_Click(sender As Object, e As EventArgs) Handles BtnNoviDavatelj.Click
        Try
            Me.Donator_krviBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub BtnUredi_Click_1(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Donator_krviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click_1(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Donator_krviBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
End Class