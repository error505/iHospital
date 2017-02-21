Public Class SestraLogin_Form

    Private Sub BtnPacijent_Click(sender As Object, e As EventArgs) Handles BtnPacijent.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijenti"
    End Sub

    Private Sub BtnBankaKrvi_Click(sender As Object, e As EventArgs) Handles BtnBankaKrvi.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnKrevet_Click(sender As Object, e As EventArgs) Handles BtnKrevet.Click
        Dim kr As New Kreveti_Form()
        kr.TopLevel = False
        Me.Panel1.Controls.Add(kr)
        kr.Show()
        Naslov.Text = "Kreveti"
    End Sub

    Private Sub BtnIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnIzvjestaj.Click
        Dim di As New DodajIzvjestaj_Form()
        di.TopLevel = False
        Me.Panel1.Controls.Add(di)
        di.Show()
        Naslov.Text = "Dodaj Izvjestaj"
    End Sub

    Private Sub BtnPacijenti1_Click(sender As Object, e As EventArgs) Handles BtnPacijenti1.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijenti"
    End Sub

    Private Sub BtnKreveti1_Click(sender As Object, e As EventArgs) Handles BtnKreveti1.Click
        Dim kr As New Kreveti_Form()
        kr.TopLevel = False
        Me.Panel1.Controls.Add(kr)
        kr.Show()
        Naslov.Text = "Kreveti"
    End Sub

    Private Sub BtnBankakrvipogled_Click(sender As Object, e As EventArgs) Handles BtnBankakrvipogled.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnDodajizvjestaj_Click(sender As Object, e As EventArgs) Handles BtnDodajizvjestaj.Click
        Dim di As New DodajIzvjestaj_Form()
        di.TopLevel = False
        Me.Panel1.Controls.Add(di)
        di.Show()
        Naslov.Text = "Dodaj Izvjestaj"
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub

    Private Sub SestraLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Sestra Menadzment"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub
End Class