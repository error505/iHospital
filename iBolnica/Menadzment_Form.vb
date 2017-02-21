Public Class Menadzment_Form

    Private Sub MenadzmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MenadzmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MenadzmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Menadzment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.menadzment' table. You can move, or remove it, as needed.
        Me.MenadzmentTableAdapter.Fill(Me.IbolnicaDataSet.menadzment)

    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.MenadzmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnDodajMenadzera_Click(sender As Object, e As EventArgs) Handles BtnDodajMenadzera.Click
        Me.Validate()
        Me.MenadzmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnNoviMenadzer_Click(sender As Object, e As EventArgs) Handles BtnNoviMenadzer.Click
        Try
            Me.MenadzmentBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.MenadzmentBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub
End Class