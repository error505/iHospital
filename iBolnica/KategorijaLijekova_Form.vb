Public Class KategorijaLijekova_Form

    Private Sub Kategorije_lijekovaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Kategorije_lijekovaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Kategorije_lijekovaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub KategorijaLijekova_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.kategorije_lijekova' table. You can move, or remove it, as needed.
        Me.Kategorije_lijekovaTableAdapter.Fill(Me.IbolnicaDataSet.kategorije_lijekova)

    End Sub

    Private Sub BtnDodajLijek_Click(sender As Object, e As EventArgs) Handles BtnDodajLijek.Click
        Me.Validate()
        Me.Kategorije_lijekovaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Kategorije_lijekovaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNoviLijek_Click(sender As Object, e As EventArgs) Handles BtnNoviLijek.Click
        Try
            Me.Kategorije_lijekovaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Kategorije_lijekovaBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class