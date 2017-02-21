Public Class DodajIzvjestaj_Form
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub Izvjestaj_operacijaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Izvjestaj_operacijaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Izvjestaj_operacijaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub
    'Konekcija sa SQL bazom podataka.
    Private Sub DodajIzvjestaj_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_smrt' table. You can move, or remove it, as needed.
        Me.Izvjestaj_smrtTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_smrt)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_o_rodjenju' table. You can move, or remove it, as needed.
        Me.Izvjestaj_o_rodjenjuTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_o_rodjenju)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_operacija' table. You can move, or remove it, as needed.
        Me.Izvjestaj_operacijaTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_operacija)

    End Sub
    'Dugme za uredjivanje i dodavanje modifikacija u tabeli.
    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
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
    'Dugme za uredjivanje i dodavanje modifikacija u tabeli.
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Izvjestaj_o_rodjenjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme za brisanje svih selektovanih polja u tabeli.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Izvjestaj_o_rodjenjuBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.Izvjestaj_smrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme za brisanje svih selektovanih polja u tabeli.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Izvjestaj_smrtBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
    'Dugme koje ima funkciju da oslobodi polja da bi se mogao dodati novi unos u bazu podataka.
    Private Sub BtnNovaOperacija_Click(sender As Object, e As EventArgs) Handles BtnNovaOperacija.Click
        Try
            Me.Izvjestaj_operacijaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub BtnDodajObavjestenje_Click(sender As Object, e As EventArgs) Handles BtnDodajObavjestenje.Click
        Me.Validate()
        Me.Izvjestaj_operacijaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme koje ima funkciju da oslobodi polja da bi se mogao dodati novi unos u bazu podataka.
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Izvjestaj_o_rodjenjuBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Validate()
        Me.Izvjestaj_o_rodjenjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme koje ima funkciju da oslobodi polja da bi se mogao dodati novi unos u bazu podataka.
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Me.Izvjestaj_smrtBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub
    'Dugme za dodavanje u bazu svih polja koja su unesena.
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Validate()
        Me.Izvjestaj_smrtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
    'Dugme za zatvaranje forme.
    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class