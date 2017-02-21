Public Class PacijentLogin_Form

    Private Sub Doktor_Click(sender As Object, e As EventArgs) Handles Doktor.Click
        Dim pd As New PacijentDoktor_Form()
        pd.TopLevel = False
        Me.Panel1.Controls.Add(pd)
        pd.Show()
        Naslov.Text = "Doktori"
    End Sub

    Private Sub BtnSastanci_Click(sender As Object, e As EventArgs) Handles BtnSastanci.Click
        Dim ps As New PacijentSastanci_Form()
        ps.TopLevel = False
        Me.Panel1.Controls.Add(ps)
        ps.Show()
        Naslov.Text = "Sastanci"
    End Sub

    Private Sub BtnBankaKrvi_Click(sender As Object, e As EventArgs) Handles BtnBankaKrvi.Click
        Dim pk As New PacijentKrv_Form()
        pk.TopLevel = False
        Me.Panel1.Controls.Add(pk)
        pk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnRecept_Click(sender As Object, e As EventArgs) Handles BtnRecept.Click
        Dim pr As New PacijentRecepti_Form()
        pr.TopLevel = False
        Me.Panel1.Controls.Add(pr)
        pr.Show()
        Naslov.Text = "Recepti"
    End Sub

    Private Sub BtnUredisastanke_Click(sender As Object, e As EventArgs) Handles BtnUredisastanke.Click
        Dim ps As New PacijentSastanci_Form()
        ps.TopLevel = False
        Me.Panel1.Controls.Add(ps)
        ps.Show()
        Naslov.Text = "Sastanci"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pr As New PacijentRecepti_Form()
        pr.TopLevel = False
        Me.Panel1.Controls.Add(pr)
        pr.Show()
        Naslov.Text = "Recepti"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pd As New PacijentDoktor_Form()
        pd.TopLevel = False
        Me.Panel1.Controls.Add(pd)
        pd.Show()
        Naslov.Text = "Doktori"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pk As New PacijentKrv_Form()
        pk.TopLevel = False
        Me.Panel1.Controls.Add(pk)
        pk.Show()
        Naslov.Text = "Banka Krvi"
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        MsgBox("Izlogovani ste iz sistema")
        Me.Close()
    End Sub

    Private Sub PacijentLogin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        Naslov.Text = "Pacijent"
        Dim obavijesti As New Obavijesti_form()
        obavijesti.TopLevel = False
        Me.Panel1.Controls.Add(obavijesti)
        obavijesti.Show()
    End Sub
End Class