Public Class Odjeljenja_Form

    Private Sub OdjeljenjeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OdjeljenjeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdjeljenjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Odjeljenja_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.odjeljenje' table. You can move, or remove it, as needed.
        Me.OdjeljenjeTableAdapter.Fill(Me.IbolnicaDataSet.odjeljenje)

    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.OdjeljenjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnDodajOdjeljenje_Click(sender As Object, e As EventArgs) Handles BtnDodajOdjeljenje.Click
        Me.Validate()
        Me.OdjeljenjeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovoOdjeljenje_Click(sender As Object, e As EventArgs) Handles BtnNovoOdjeljenje.Click
        Try
            Me.OdjeljenjeBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.OdjeljenjeBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class