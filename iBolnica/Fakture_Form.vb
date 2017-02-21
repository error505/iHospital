Public Class Fakture_Form

    Private Sub FakturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FakturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FakturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Fakture_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.faktura' table. You can move, or remove it, as needed.
        Me.FakturaTableAdapter.Fill(Me.IbolnicaDataSet.faktura)

    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.FakturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnDodajFakturu_Click(sender As Object, e As EventArgs) Handles BtnDodajFakturu.Click
        Me.Validate()
        Me.FakturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovaFaktura_Click(sender As Object, e As EventArgs) Handles BtnNovaFaktura.Click
        Try
            Me.FakturaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.FakturaBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class