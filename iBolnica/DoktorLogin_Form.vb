Public Class DoktorLogin_Form
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnPacijent_Click(sender As Object, e As EventArgs) Handles BtnPacijent.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijenti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnBankaKrvi_Click(sender As Object, e As EventArgs) Handles BtnBankaKrvi.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnSastanci_Click(sender As Object, e As EventArgs) Handles BtnSastanci.Click
        Dim sa As New Sastanci_Form()
        sa.TopLevel = False
        Me.Panel1.Controls.Add(sa)
        sa.Show()
        Naslov.Text = "Sastanci"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnKrv_Click(sender As Object, e As EventArgs) Handles BtnKrv.Click
        Dim kr As New Kreveti_Form()
        kr.TopLevel = False
        Me.Panel1.Controls.Add(kr)
        kr.Show()
        Naslov.Text = "Kreveti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnIzvjestaj_Click(sender As Object, e As EventArgs) Handles BtnIzvjestaj.Click
        Dim di As New DodajIzvjestaj_Form()
        di.TopLevel = False
        Me.Panel1.Controls.Add(di)
        di.Show()
        Naslov.Text = "Dodaj Izvjestaj"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnUredisastanke_Click(sender As Object, e As EventArgs) Handles BtnUredisastanke.Click
        Dim sa As New Sastanci_Form()
        sa.TopLevel = False
        Me.Panel1.Controls.Add(sa)
        sa.Show()
        Naslov.Text = "Sastanci"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnDodajrecept_Click(sender As Object, e As EventArgs) Handles BtnDodajrecept.Click
        Dim r As New Recepti_Form()
        r.TopLevel = False
        Me.Panel1.Controls.Add(r)
        r.Show()
        Naslov.Text = "Dodaj Recepte"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnKreveti1_Click(sender As Object, e As EventArgs) Handles BtnKreveti1.Click
        Dim kr As New Kreveti_Form()
        kr.TopLevel = False
        Me.Panel1.Controls.Add(kr)
        kr.Show()
        Naslov.Text = "Kreveti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnBankakrvipogled_Click(sender As Object, e As EventArgs) Handles BtnBankakrvipogled.Click
        Dim bk As New BankaKrvi_Form()
        bk.TopLevel = False
        Me.Panel1.Controls.Add(bk)
        bk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnDodajizvjestaj_Click(sender As Object, e As EventArgs) Handles BtnDodajizvjestaj.Click
        Dim di As New DodajIzvjestaj_Form()
        di.TopLevel = False
        Me.Panel1.Controls.Add(di)
        di.Show()
        Naslov.Text = "Dodaj Izvjestaj"
    End Sub
    'Dugme za izlazak iz sistema.
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub
    'Prikazivanje naslova Glavne forme i forme obavjestena u panelu.
    Private Sub DoktorLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Doktor Menadzment"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub

    Private Sub BtnPacijenti1_Click(sender As Object, e As EventArgs) Handles BtnPacijenti1.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijenti"
    End Sub
End Class