Public Class LaborantLogin_Form

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub

    Private Sub BtnBankKrvi_Click(sender As Object, e As EventArgs) Handles BtnBankKrvi.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnBankakrvipogled_Click(sender As Object, e As EventArgs) Handles BtnBankakrvipogled.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnIzvjestajDijagnoza_Click(sender As Object, e As EventArgs) Handles BtnIzvjestajDijagnoza.Click
        Dim izd As New IzvjestajODiagnozi_Form()
        izd.TopLevel = False
        Me.Panel1.Controls.Add(izd)
        izd.Show()
        Naslov.Text = "Izvjestaj O Dijagnozi"
    End Sub

    Private Sub BtnDonatorKrvi_Click(sender As Object, e As EventArgs) Handles BtnDonatorKrvi.Click
        Dim dk As New DonatoriKrvi_FOrm()
        dk.TopLevel = False
        Me.Panel1.Controls.Add(dk)
        dk.Show()
        Naslov.Text = "Donatori Krvi"
    End Sub

    Private Sub BtnIzvjestajDijagnoza1_Click(sender As Object, e As EventArgs) Handles BtnIzvjestajDijagnoza1.Click
        Dim izd As New IzvjestajODiagnozi_Form()
        izd.TopLevel = False
        Me.Panel1.Controls.Add(izd)
        izd.Show()
        Naslov.Text = "Izvjestaj O Dijagnozi"
    End Sub

    Private Sub BtnDonatorKrvi1_Click(sender As Object, e As EventArgs) Handles BtnDonatorKrvi1.Click
        Dim dk As New DonatoriKrvi_FOrm()
        dk.TopLevel = False
        Me.Panel1.Controls.Add(dk)
        dk.Show()
        Naslov.Text = "Donatori Krvi"
    End Sub

    Private Sub LaborantLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Laborant Menadzment"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub
End Class