Public Class Pacijenti

   
    Private Sub PacijentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacijentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacijentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub Pacijenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.banka_krvi' table. You can move, or remove it, as needed.
        Me.Banka_krviTableAdapter.Fill(Me.IbolnicaDataSet.banka_krvi)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)

    End Sub

    Private Sub BtnNoviPacijent_Click(sender As Object, e As EventArgs) Handles BtnNoviPacijent.Click
        Try
            Me.PacijentBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajPacijenta_Click(sender As Object, e As EventArgs) Handles BtnDodajPacijenta.Click
        Me.Validate()
        Me.PacijentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PacijentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs)
        Try
            Me.PacijentBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.PacijentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click_1(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.PacijentBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
End Class