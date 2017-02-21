Public Class FarmaceutLogin_Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim li As New Lijekovi_Form()
        li.TopLevel = False
        Me.Panel1.Controls.Add(li)
        li.Show()
        Naslov.Text = "Lijekovi"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim li As New Lijekovi_Form()
        li.TopLevel = False
        Me.Panel1.Controls.Add(li)
        li.Show()
        Naslov.Text = "Lijekovi"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As New Recepti_Form()
        r.TopLevel = False
        Me.Panel1.Controls.Add(r)
        r.Show()
        Naslov.Text = "Recepti"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r As New Recepti_Form()
        r.TopLevel = False
        Me.Panel1.Controls.Add(r)
        r.Show()
        Naslov.Text = "Recepti"
    End Sub

    Private Sub BtnKategorija_Click(sender As Object, e As EventArgs) Handles BtnKategorija.Click
        Dim kl As New KategorijaLijekova_Form()
        kl.TopLevel = False
        Me.Panel1.Controls.Add(kl)
        kl.Show()
        Naslov.Text = "Kategorija Lijekova"
    End Sub

    Private Sub BtnKreveti1_Click(sender As Object, e As EventArgs) Handles BtnKreveti1.Click
        Dim kl As New KategorijaLijekova_Form()
        kl.TopLevel = False
        Me.Panel1.Controls.Add(kl)
        kl.Show()
        Naslov.Text = "Kategorija Lijekova"
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()

    End Sub

    Private Sub FarmaceutLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Farmaceuti Menadzment"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub
End Class