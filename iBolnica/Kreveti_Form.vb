Public Class Kreveti_Form

    Private Sub KrevetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KrevetBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KrevetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Kreveti_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.krevet' table. You can move, or remove it, as needed.
        Me.KrevetTableAdapter.Fill(Me.IbolnicaDataSet.krevet)

    End Sub

    Private Sub BtnDodajIzvjestaj_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnDodajKrevet_Click(sender As Object, e As EventArgs) Handles BtnDodajKrevet.Click
        Me.Validate()
        Me.KrevetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.KrevetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNoviKrevet_Click(sender As Object, e As EventArgs) Handles BtnNoviKrevet.Click
        Try
            Me.KrevetBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.KrevetBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub
End Class