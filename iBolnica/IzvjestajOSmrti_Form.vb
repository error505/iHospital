Public Class IzvjestajOSmrti_Form

    Private Sub Izvjestaj_smrtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Izvjestaj_smrtBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Izvjestaj_smrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub IzvjestajOSmrti_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_smrt' table. You can move, or remove it, as needed.
        Me.Izvjestaj_smrtTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_smrt)

    End Sub

    Private Sub BtnNovIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnNovIzvjestaj.Click
        Try
            Me.Izvjestaj_smrtBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnDodajIzvjestaj.Click
        Me.Validate()
        Me.Izvjestaj_smrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Izvjestaj_smrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Izvjestaj_smrtBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class