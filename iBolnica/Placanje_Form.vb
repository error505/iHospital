Public Class Placanje_Form

    Private Sub PlacanjeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlacanjeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlacanjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Placanje_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.faktura' table. You can move, or remove it, as needed.
        Me.FakturaTableAdapter.Fill(Me.IbolnicaDataSet.faktura)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.placanje' table. You can move, or remove it, as needed.
        Me.PlacanjeTableAdapter.Fill(Me.IbolnicaDataSet.placanje)

    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.PlacanjeBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.PlacanjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

    Private Sub BtnNovoPlacanje_Click(sender As Object, e As EventArgs) Handles BtnNovoPlacanje.Click
        Try
            Me.PlacanjeBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajUplatu_Click(sender As Object, e As EventArgs) Handles BtnDodajUplatu.Click
        Me.Validate()
        Me.PlacanjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
End Class