Public Class Obavjestenja_form

    Private Sub ObavjestenjaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ObavjestenjaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObavjestenjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Obavjestenja_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.obavjestenja' table. You can move, or remove it, as needed.
        Me.ObavjestenjaTableAdapter.Fill(Me.IbolnicaDataSet.obavjestenja)

    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.ObavjestenjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnDodajObavjestenje_Click(sender As Object, e As EventArgs) Handles BtnDodajObavjestenje.Click
        Me.Validate()
        Me.ObavjestenjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovoObavjestenje_Click(sender As Object, e As EventArgs) Handles BtnNovoObavjestenje.Click
        Try
            Me.ObavjestenjaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.ObavjestenjaBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class