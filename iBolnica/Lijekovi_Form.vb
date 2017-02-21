Public Class Lijekovi_Form

    Private Sub LijekoviBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LijekoviBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LijekoviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Lijekovi_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.kategorije_lijekova' table. You can move, or remove it, as needed.
        Me.Kategorije_lijekovaTableAdapter.Fill(Me.IbolnicaDataSet.kategorije_lijekova)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.lijekovi' table. You can move, or remove it, as needed.
        Me.LijekoviTableAdapter.Fill(Me.IbolnicaDataSet.lijekovi)

    End Sub

    Private Sub BtnDodajLijek_Click(sender As Object, e As EventArgs) Handles BtnDodajLijek.Click
        Me.Validate()
        Me.LijekoviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNovLijek_Click(sender As Object, e As EventArgs) Handles BtnNovLijek.Click
        Try
            Me.LijekoviBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.LijekoviBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.LijekoviBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

    Private Sub BtnKategorija_Click(sender As Object, e As EventArgs) Handles BtnKategorija.Click
        Try
            Me.KategorijelijekovaBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodaj_Click(sender As Object, e As EventArgs) Handles BtnDodaj.Click
        Me.Validate()
        Me.KategorijelijekovaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub
End Class