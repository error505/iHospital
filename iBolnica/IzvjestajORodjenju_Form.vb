Public Class IzvjestajORodjenju_Form

    Private Sub Izvjestaj_o_rodjenjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Izvjestaj_o_rodjenjuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Izvjestaj_o_rodjenjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub IzvjestajORodjenju_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.izvjestaj_o_rodjenju' table. You can move, or remove it, as needed.
        Me.Izvjestaj_o_rodjenjuTableAdapter.Fill(Me.IbolnicaDataSet.izvjestaj_o_rodjenju)

    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Izvjestaj_o_rodjenjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnNovIzvjestaj.Click
        Try
            Me.Izvjestaj_o_rodjenjuBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajIzvjestaj_Click_1(sender As Object, e As EventArgs) Handles BtnDodajIzvjestaj.Click
        Me.Validate()
        Me.Izvjestaj_o_rodjenjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Izvjestaj_o_rodjenjuBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class