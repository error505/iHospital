Public Class KontrolnaTabla

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.sestra' table. You can move, or remove it, as needed.
        Me.SestraTableAdapter.Fill(Me.IbolnicaDataSet.sestra)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.pacijent' table. You can move, or remove it, as needed.
        Me.PacijentTableAdapter.Fill(Me.IbolnicaDataSet.pacijent)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.odjeljenje' table. You can move, or remove it, as needed.
        Me.OdjeljenjeTableAdapter.Fill(Me.IbolnicaDataSet.odjeljenje)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'TODO: This line of code loads data into the 'IbolnicaDataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.IbolnicaDataSet.doktor)
        'Naslov za formu u labelu pod imenom Naslov.
        Naslov.Text = "Kontrolna Tabla"
        'Pravljenje nove forme za obavijesti i prikazivanje u panelu kao dijete.
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
        'Brojanje koloko ima doktora u bazi.
        LblDoktoriCount.Text = DoktorBindingSource.Count
        'Brojanje koloko ima pacijenata u bazi.
        LblPacijentiCount.Text = PacijentBindingSource.Count
        'Brojanje koloko ima sestara u bazi.
        LblSestreCount.Text = SestraBindingSource.Count
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub Doktor_Click(sender As Object, e As EventArgs) Handles Doktor.Click
        Dim d As New Doktor_Forma()
        d.TopLevel = False
        Me.Panel1.Controls.Add(d)
        d.Show()
        Naslov.Text = "Doktori"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnPacijent_Click(sender As Object, e As EventArgs) Handles BtnPacijent.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijent"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnSestra_Click(sender As Object, e As EventArgs) Handles BtnSestra.Click
        Dim s As New Sestra_Form()
        s.TopLevel = False
        Me.Panel1.Controls.Add(s)
        s.Show()
        Naslov.Text = "Sestre"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnRecepti_Click(sender As Object, e As EventArgs) Handles BtnRecepti.Click
        Dim r As New Recepti_Form()
        r.TopLevel = False
        Me.Panel1.Controls.Add(r)
        r.Show()
        Naslov.Text = "Recepti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnFarmaceuti_Click(sender As Object, e As EventArgs) Handles BtnFarmaceuti.Click
        Dim f As New Faramaceuti_form()
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
        Naslov.Text = "Farmaceuti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnLaboratorija_Click(sender As Object, e As EventArgs) Handles BtnLaboratorija.Click
        Dim l As New Laboratorija_Form()
        l.TopLevel = False
        Me.Panel1.Controls.Add(l)
        l.Show()
        Naslov.Text = "Laboratorija"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnLoginK_Click(sender As Object, e As EventArgs)
        Login.Show()
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim pl As New Placanje_Form()
        pl.TopLevel = False
        Me.Panel1.Controls.Add(pl)
        pl.Show()
        Naslov.Text = "Uplate"
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
    Private Sub BtnLijkovi_Click(sender As Object, e As EventArgs) Handles BtnLijkovi.Click
        Dim li As New Lijekovi_Form()
        li.TopLevel = False
        Me.Panel1.Controls.Add(li)
        li.Show()
        Naslov.Text = "Lijekovi"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sa As New Sastanci_Form()
        sa.TopLevel = False
        Me.Panel1.Controls.Add(sa)
        sa.Show()
        Naslov.Text = "Sastanci"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnRodjenje_Click(sender As Object, e As EventArgs) Handles BtnRodjenje.Click
        Dim ir As New IzvjestajORodjenju_Form()
        ir.TopLevel = False
        Me.Panel1.Controls.Add(ir)
        ir.Show()
        Naslov.Text = "Izvjestaj O Rodjenju"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnOperacija_Click(sender As Object, e As EventArgs) Handles BtnOperacija.Click
        Dim io As New IzvjestajSaOperacija_Form()
        io.TopLevel = False
        Me.Panel1.Controls.Add(io)
        io.Show()
        Naslov.Text = "Izvjestaj Sa Opracija"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnSmrt_Click(sender As Object, e As EventArgs) Handles BtnSmrt.Click
        Dim ism As New IzvjestajOSmrti_Form()
        ism.TopLevel = False
        Me.Panel1.Controls.Add(ism)
        ism.Show()
        Naslov.Text = "Izvjestaj O Smrti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnKrevet_Click(sender As Object, e As EventArgs) Handles BtnKrevet.Click
        Dim kr As New Kreveti_Form()
        kr.TopLevel = False
        Me.Panel1.Controls.Add(kr)
        kr.Show()
        Naslov.Text = "Kreveti"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnMenadzment_Click(sender As Object, e As EventArgs) Handles BtnMenadzment.Click
        Dim mn As New Menadzment_Form()
        mn.TopLevel = False
        Me.Panel1.Controls.Add(mn)
        mn.Show()
        Naslov.Text = "Menadzment"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnObavjestenja_Click(sender As Object, e As EventArgs) Handles BtnObavjestenja.Click
        Dim ob As New Obavjestenja_form()
        ob.TopLevel = False
        Me.Panel1.Controls.Add(ob)
        ob.Show()
        Naslov.Text = "Obavjestenja"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnOdjeljenja_Click(sender As Object, e As EventArgs) Handles BtnOdjeljenja.Click
        Dim odj As New Odjeljenja_Form()
        odj.TopLevel = False
        Me.Panel1.Controls.Add(odj)
        odj.Show()
        Naslov.Text = "Odjeli"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnDoktori1_Click(sender As Object, e As EventArgs) Handles BtnDoktori1.Click
        Dim d As New Doktor_Forma()
        d.TopLevel = False
        Me.Panel1.Controls.Add(d)
        d.Show()
        Naslov.Text = "Doktori"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnPacijenti1_Click(sender As Object, e As EventArgs) Handles BtnPacijenti1.Click
        Dim p As New Pacijenti()
        p.TopLevel = False
        Me.Panel1.Controls.Add(p)
        p.Show()
        Naslov.Text = "Pacijent"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles BtnSestre1.Click
        Dim s As New Sestra_Form()
        s.TopLevel = False
        Me.Panel1.Controls.Add(s)
        s.Show()
        Naslov.Text = "Sestre"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnLijekovi1_Click(sender As Object, e As EventArgs) Handles BtnLijekovi1.Click
        Dim li As New Lijekovi_Form()
        li.TopLevel = False
        Me.Panel1.Controls.Add(li)
        li.Show()
        Naslov.Text = "Lijekovi"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnLaboratorija1_Click(sender As Object, e As EventArgs) Handles BtnLaboratorija1.Click
        Dim l As New Laboratorija_Form()
        l.TopLevel = False
        Me.Panel1.Controls.Add(l)
        l.Show()
        Naslov.Text = "Laboratorija"
    End Sub
    'Dugme za prikazivanje Forme u panelu.
    Private Sub BtnMenadzment1_Click(sender As Object, e As EventArgs) Handles BtnMenadzment1.Click
        Dim mn As New Menadzment_Form()
        mn.TopLevel = False
        Me.Panel1.Controls.Add(mn)
        mn.Show()
        Naslov.Text = "Menadzment"
    End Sub

    Private Sub BtnPodesavanja_Click(sender As Object, e As EventArgs) Handles BtnPodesavanja.Click
        Dim pod As New Podesavanja_Form()
        pod.TopLevel = False
        Me.Panel1.Controls.Add(pod)
        pod.Show()
        Naslov.Text = "Podesavanja Sistema"
    End Sub

    Private Sub BtnPodesavanja1_Click(sender As Object, e As EventArgs) Handles BtnPodesavanja1.Click
        Dim pod As New Podesavanja_Form()
        pod.TopLevel = False
        Me.Panel1.Controls.Add(pod)
        pod.Show()
        Naslov.Text = "Podesavanja Sistema"
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        MsgBox("Funkcija je u izradi!")
    End Sub
End Class
