Public Class IzvjestajSaOperacija_Form

    Private Sub Izvjestaj_operacijaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Izvjestaj_operacijaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Izvjestaj_operacijaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub IzvjestajSaOperacija_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_operacija' table. You can move, or remove it, as needed.
        Me.Izvjestaj_operacijaTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_operacija)

    End Sub
    'Dugme za uredjivanje i dodavanje modifikacija u tabeli.
    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Izvjestaj_operacijaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme koje ima funkciju da oslobodi polja da bi se mogao dodati novi unos u bazu podataka
    Private Sub BtnNovIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnNovIzvjestaj.Click
        Try
            Me.Izvjestaj_operacijaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub BtnDodajIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnDodajIzvjestaj.Click
        Me.Validate()
        Me.Izvjestaj_operacijaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme za brisanje svih selektovanih polja u tabeli.
    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Izvjestaj_operacijaBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
    'Dugme za zatvaranje forme.
    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class