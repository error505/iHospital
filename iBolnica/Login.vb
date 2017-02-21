Public Class Login
    'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            If Not QueriesTableAdapter1.AdminQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Admin" Then
                    KontrolnaTabla.Show()
                    Me.Hide()
                End If
            End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.DoktorQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Doktor" Then
                DoktorLogin_Form.Show()
                Me.Hide()
            End If
        End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.SestraQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Sestra" Then
                SestraLogin_Form.Show()
                Me.Hide()
            End If
        End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.FarmaceutQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Farmaceut" Then
                FarmaceutLogin_Form.Show()
                Me.Hide()
            End If
        End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.LaborantQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Laborant" Then
                LaborantLogin_Form.Show()
                Me.Hide()
            End If
        End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.MenadzmentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Menadzer" Then
                MenadzerLogin_Form.Show()
                Me.Hide()
            End If
        End If
        'Funkcija za dugme koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
        If Not QueriesTableAdapter1.PacijentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
            If TipNaloga.Text = "Pacijent" Then
                PacijentLogin_Form.Show()
                Me.Hide()
            End If
        End If
    End Sub
    'Dugme za izlaz iz forme.
    Private Sub BtnIzlaz_Click(sender As Object, e As EventArgs) Handles BtnIzlaz.Click
        Me.Close()
    End Sub

    'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
                If Not QueriesTableAdapter1.AdminQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Admin" Then
                        KontrolnaTabla.Show()
                        Me.Hide()
                    End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.DoktorQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Doktor" Then
                    DoktorLogin_Form.Show()
                    Me.Hide()
                End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.SestraQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Sestra" Then
                    SestraLogin_Form.Show()
                    Me.Hide()
                End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.FarmaceutQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Farmaceut" Then
                    FarmaceutLogin_Form.Show()
                    Me.Hide()
                End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.LaborantQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Laborant" Then
                    LaborantLogin_Form.Show()
                    Me.Hide()
                End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.MenadzmentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Menadzer" Then
                    MenadzerLogin_Form.Show()
                    Me.Hide()
                End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
            If Not QueriesTableAdapter1.PacijentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                If TipNaloga.Text = "Pacijent" Then
                    PacijentLogin_Form.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub
    'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
            If e.KeyCode = Keys.Enter Then
                If Not QueriesTableAdapter1.AdminQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Admin" Then
                        KontrolnaTabla.Show()
                        Me.Hide()
                    End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.DoktorQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Doktor" Then
                        DoktorLogin_Form.Show()
                        Me.Hide()
                    End If
                End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.SestraQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Sestra" Then
                        SestraLogin_Form.Show()
                        Me.Hide()
                    End If
                End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.FarmaceutQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Farmaceut" Then
                        FarmaceutLogin_Form.Show()
                        Me.Hide()
                    End If
                End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.LaborantQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Laborant" Then
                        LaborantLogin_Form.Show()
                        Me.Hide()
                    End If
                End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.MenadzmentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Menadzer" Then
                        MenadzerLogin_Form.Show()
                        Me.Hide()
                    End If
            End If
            'Funkcija za pritiskanje entera na tastaturi koja pregleda u tabeli da li postoji uneseni mail i pasword, ako postoji otvara formu koja je predvidjenja za odredjeni tip naloga.
                If Not QueriesTableAdapter1.PacijentQuery(TextBox1.Text, TextBox2.Text) = Nothing Then
                    If TipNaloga.Text = "Pacijent" Then
                        PacijentLogin_Form.Show()
                        Me.Hide()
                    End If
                End If
            End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IbolnicaDataSet.podesavanja' table. You can move, or remove it, as needed.
        Me.PodesavanjaTableAdapter.Fill(Me.IbolnicaDataSet.podesavanja)
        If TipNaloga.Text = "admin" Then
            PictureBox1.Image = My.Resources.adminico
        End If
    End Sub
    'Ako se izabere neki od tipova naloga u comboboxu shodno tome se mijenja i slika koja odgovara tom tipu naloga.
    Private Sub TipNaloga_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipNaloga.SelectedIndexChanged
        If TipNaloga.Text = "Admin" Then
            PictureBox1.Image = My.Resources.adminico1
        End If
        If TipNaloga.Text = "Doktor" Then
            PictureBox1.Image = My.Resources.doktorico
        End If
        If TipNaloga.Text = "Sestra" Then
            PictureBox1.Image = My.Resources.sestraico
        End If
        If TipNaloga.Text = "Farmaceut" Then
            PictureBox1.Image = My.Resources.farmaceutico
        End If
        If TipNaloga.Text = "Laborant" Then
            PictureBox1.Image = My.Resources.laborantico
        End If
        If TipNaloga.Text = "Menadzer" Then
            PictureBox1.Image = My.Resources.menadzerico
        End If
        If TipNaloga.Text = "Pacijent" Then
            PictureBox1.Image = My.Resources.pacijentico
        End If
    End Sub
End Class