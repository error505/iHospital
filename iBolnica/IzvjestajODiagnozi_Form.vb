Public Class IzvjestajODiagnozi_Form

    Private Sub Dijagnoza_izvjestajBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Dijagnoza_izvjestajBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dijagnoza_izvjestajBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        TextBox1.Clear()


    End Sub

    Private Sub IzvjestajODiagnozi_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.laborant' table. You can move, or remove it, as needed.
        Me.LaborantTableAdapter.Fill(Me.IbolnicaDataSet.laborant)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.recept' table. You can move, or remove it, as needed.
        Me.ReceptTableAdapter.Fill(Me.IbolnicaDataSet.recept)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.dijagnoza_izvjestaj' table. You can move, or remove it, as needed.
        Me.Dijagnoza_izvjestajTableAdapter.Fill(Me.IbolnicaDataSet.dijagnoza_izvjestaj)

    End Sub

    Private Sub BtnDodajObavjestenje_Click(sender As Object, e As EventArgs) Handles BtnDodajIzvjestaj.Click
        Me.Validate()
        Me.Dijagnoza_izvjestajBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnUredi_Click(sender As Object, e As EventArgs) Handles BtnUredi.Click
        Me.Validate()
        Me.Dijagnoza_izvjestajBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
    End Sub

    Private Sub BtnIzbrisi_Click(sender As Object, e As EventArgs) Handles BtnIzbrisi.Click
        Try
            Me.Dijagnoza_izvjestajBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.IbolnicaDataSet)
        Catch ex As Exception
            MsgBox("Morate selektovati sva polja")
        End Try
    End Sub

    Private Sub BtnNoviIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnNoviIzvjestaj.Click
        Try
            Me.Dijagnoza_izvjestajBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("Morate unijeti sva polja")
        End Try
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.ShowDialog()
            TextBox1.Text = OpenFileDialog1.FileName
            Ime_fajlaTextEdit.Text = OpenFileDialog1.SafeFileName
            SlikaPictureBox.Image = Image.FromFile(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Sva polja moraju biti unesena.")
        End Try
        
    End Sub

End Class