Public Class MenadzerLogin_Form
    'Izlazak iz forme i prikazivanje poruke.
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnIzvjestajDijagnoza_Click(sender As Object, e As EventArgs) Handles BtnIzvjestajDijagnoza.Click
        Dim pl As New Placanje_Form()
        pl.TopLevel = False
        Me.Panel1.Controls.Add(pl)
        pl.Show()
        Naslov.Text = "Uplate"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnIzvjestajDijagnoza1_Click(sender As Object, e As EventArgs) Handles BtnIzvjestajDijagnoza1.Click
        Dim pl As New Placanje_Form()
        pl.TopLevel = False
        Me.Panel1.Controls.Add(pl)
        pl.Show()
        Naslov.Text = "Uplate"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fk As New Fakture_Form()
        fk.TopLevel = False
        Me.Panel1.Controls.Add(fk)
        fk.Show()
        Naslov.Text = "Fakture"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnBankakrvipogled_Click(sender As Object, e As EventArgs) Handles BtnBankakrvipogled.Click
        Dim fk As New Fakture_Form()
        fk.TopLevel = False
        Me.Panel1.Controls.Add(fk)
        fk.Show()
        Naslov.Text = "Fakture"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub MenadzerLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Menadzment"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub
End Class