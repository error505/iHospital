Public Class Sastanci_Form

    Private Sub SastanciBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SastanciBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SastanciBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Sastanci_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.sastanci' table. You can move, or remove it, as needed.
        Me.SastanciTableAdapter.Fill(Me.IbolnicaDataSet.sastanci)

    End Sub

    Private Sub BtnNovSastanak_Click(sender As Object, e As EventArgs) Handles BtnNovSastanak.Click
        Try
            Me.SastanciBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajSastanak_Click(sender As Object, e As EventArgs) Handles BtnDodajSastanak.Click
        Me.Validate()
        Me.SastanciBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub

    Private Sub BtnUredi_Click_1(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.SastanciBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click_1(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.SastanciBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub
End Class