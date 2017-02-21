Public Class Doktor_Forma

    Private Sub Doktor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.odjeljenje' table. You can move, or remove it, as needed.
        Me.OdjeljenjeTableAdapter.Fill(Me.IbolnicaDataSet.odjeljenje)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)

    End Sub

    Private Sub BtnNoviDoktor_Click(sender As Object, e As EventArgs) Handles BtnNoviDoktor.Click
        Try
            Me.DoktorBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnDodajDoktora_Click(sender As Object, e As EventArgs) Handles BtnDodajDoktora.Click
        Me.Validate()
        Me.DoktorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.DoktorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.DoktorBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()
    End Sub

End Class