Public Class Obavijesti_form

    Private Sub ObavjestenjaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ObavjestenjaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObavjestenjaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)

    End Sub

    Private Sub Obavijesti_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.obavjestenja' table. You can move, or remove it, as needed.
        Me.ObavjestenjaTableAdapter.Fill(Me.IbolnicaDataSet.obavjestenja)

    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ObavjestenjaBindingSource.MovePrevious()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObavjestenjaBindingSource.MoveNext()
    End Sub

End Class