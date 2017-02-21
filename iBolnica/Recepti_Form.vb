Public Class Recepti_Form

    Private Sub ReceptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceptBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Recepti_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.farmaceut' table. You can move, or remove it, as needed.
        Me.FarmaceutTableAdapter.Fill(Me.IbolnicaDataSet.farmaceut)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.lijekovi' table. You can move, or remove it, as needed.
        Me.LijekoviTableAdapter.Fill(Me.IbolnicaDataSet.lijekovi)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.recept' table. You can move, or remove it, as needed.
        Me.ReceptTableAdapter.Fill(Me.IbolnicaDataSet.recept)

    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.ReceptBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.ReceptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNoviRecept_Click(sender As Object, e As EventArgs) Handles BtnNoviRecept.Click
        Try
            Me.ReceptBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajRecept_Click(sender As Object, e As EventArgs) Handles BtnDodajRecept.Click
        Me.Validate()
        Me.ReceptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

End Class