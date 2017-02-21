Public Class Laboratorija_Form

    Private Sub LaborantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LaborantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LaborantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub Laboratorija_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.laborant' table. You can move, or remove it, as needed.
        Me.LaborantTableAdapter.Fill(Me.IbolnicaDataSet.laborant)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.LaborantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.LaborantBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

    Private Sub BtnNoviLaborant_Click(sender As Object, e As EventArgs) Handles BtnNoviLaborant.Click
        Try
            Me.LaborantBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajLaboranta_Click(sender As Object, e As EventArgs) Handles BtnDodajLaboranta.Click
        Me.Validate()
        Me.LaborantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
End Class