using System.Collections;
namespace MusteriHizmetleriAramasi
{
    public partial class Form1 : Form
    {
        ArrayList bireyselmiticarimi = new ArrayList(), notlar = new ArrayList();
        bool bireysel1 = true, bireysel2 = true, ticari1 = true, ticari2 = true;
        string bireysel1isim, bireysel2isim, ticari1isim, ticari2isim;
        int bireyselsayac = 0, ticarisayac = 0;
        private void bitirBtnTicari2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(ticari2isim + "/" + DateTime.Now + " / " + notTxtTicari2.Text);
            button15.FlatAppearance.BorderColor = Color.LimeGreen;
            button15.ForeColor = Color.LimeGreen;
            ticari2 = true;
            ticari2isim = "";
            (sender as Button).Enabled = false;
            notlar.Add(notTxtTicari2.Text);
            notTxtTicari2.Text = "";
        }

        private void btnNotaGoreAra_Click(object sender, EventArgs e)
        {
            int arananindex = notlar.IndexOf(txtNotaGoreAra.Text);
            if (arananindex == -1)
                MessageBox.Show("Bulunamadý.");
            else
                listBox2.SelectedIndex = arananindex;
        }

        private void secilenBtnBireysel1_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            if (bireysel1)
            {
                if (secilen != -1)
                {
                    if (bireyselmiticarimi[secilen] == "Bireysel")
                    {
                        bitirBtnBireysel1_Click(null, null);
                        button3.FlatAppearance.BorderColor = Color.Red;
                        button3.ForeColor = Color.Red;
                        bireysel1 = false;
                        bitirBtnBireysel1.Enabled = true;
                        bireysel1isim = listBox1.Items[secilen].ToString();
                        listBox1.Items.RemoveAt(secilen);
                        bireyselmiticarimi.RemoveAt(secilen);
                    }
                    else
                        MessageBox.Show("Ticari bir arama Bireysel bir hatta baðlanamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen arama seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void secilenBtnBireysel2_Click(object sender, EventArgs e)
        {
            if (bireysel2)
            {
                int secilen = listBox1.SelectedIndex;
                if (secilen != -1)
                {
                    if (bireyselmiticarimi[secilen] == "Bireysel")
                    {
                        bitirBtnBireysel2_Click(null, null);
                        button5.FlatAppearance.BorderColor = Color.Red;
                        button5.ForeColor = Color.Red;
                        bireysel2 = false;
                        bitirBtnBireysel2.Enabled = true;
                        bireysel2isim = listBox1.Items[secilen].ToString();
                        listBox1.Items.RemoveAt(secilen);
                        bireyselmiticarimi.RemoveAt(secilen);
                    }
                    else
                        MessageBox.Show("Ticari bir arama Bireysel bir hatta baðlanamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen arama seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void secilenBtnTicari1_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            if (ticari1)
            {
                if (secilen != -1)
                {
                    if (bireyselmiticarimi[secilen] == "Ticari")
                    {
                        bitirBtnTicari1_Click(null, null);
                        button11.FlatAppearance.BorderColor = Color.Red;
                        button11.ForeColor = Color.Red;
                        ticari1 = false;
                        bitirBtnTicari1.Enabled = true;
                        ticari1isim = listBox1.Items[secilen].ToString();
                        listBox1.Items.RemoveAt(secilen);
                        bireyselmiticarimi.RemoveAt(secilen);
                    }
                    else
                        MessageBox.Show("Bireysel bir arama Ticari bir hatta baðlanamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen arama seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void secilenBtnTicari2_Click(object sender, EventArgs e)
        {
            if (ticari2)
            {
                int secilen = listBox1.SelectedIndex;
                if (secilen != -1)
                {
                    if (bireyselmiticarimi[secilen] == "Ticari")
                    {
                        bitirBtnTicari2_Click(null, null);
                        button15.FlatAppearance.BorderColor = Color.Red;
                        button15.ForeColor = Color.Red;
                        ticari2 = false;
                        bitirBtnTicari2.Enabled = true;
                        ticari2isim = listBox1.Items[secilen].ToString();
                        listBox1.Items.RemoveAt(secilen);
                        bireyselmiticarimi.RemoveAt(secilen);
                    }
                    else
                        MessageBox.Show("Bireysel bir arama Ticari bir hatta baðlanamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen arama seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bireyselmiticarimi.TrimToSize();
            if (bireysel1)
            {
                for (int i = 0; i < bireyselmiticarimi.Count; i++)
                {
                    if (bireyselmiticarimi[i] == "Bireysel")
                    {
                        button3.FlatAppearance.BorderColor = Color.Red;
                        button3.ForeColor = Color.Red;
                        bireysel1 = false;
                        bitirBtnBireysel1.Enabled = true;
                        bireysel1isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bireyselmiticarimi.TrimToSize();
            if (bireysel2)
            {
                for (int i = 0; i < bireyselmiticarimi.Count; i++)
                {
                    if (bireyselmiticarimi[i] == "Bireysel")
                    {
                        button5.FlatAppearance.BorderColor = Color.Red;
                        button5.ForeColor = Color.Red;
                        bireysel2 = false;
                        bitirBtnBireysel2.Enabled = true;
                        bireysel2isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bireyselmiticarimi.TrimToSize();
            if (ticari1)
            {
                for (int i = 0; i < bireyselmiticarimi.Count; i++)
                {
                    if (bireyselmiticarimi[i] == "Ticari")
                    {
                        button11.FlatAppearance.BorderColor = Color.Red;
                        button11.ForeColor = Color.Red;
                        ticari1 = false;
                        bitirBtnTicari1.Enabled = true;
                        ticari1isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bireyselmiticarimi.TrimToSize();
            if (ticari2)
            {
                for (int i = 0; i < bireyselmiticarimi.Count; i++)
                {
                    if (bireyselmiticarimi[i] == "Ticari")
                    {
                        button15.FlatAppearance.BorderColor = Color.Red;
                        button15.ForeColor = Color.Red;
                        ticari2 = false;
                        bitirBtnTicari2.Enabled = true;
                        ticari2isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Lütfen önce mevcut aramanýzý bitirin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bitirBtnTicari1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(ticari1isim + " / " + DateTime.Now + " / " + notTxtTicari1.Text);
            button11.FlatAppearance.BorderColor = Color.LimeGreen;
            button11.ForeColor = Color.LimeGreen;
            ticari1 = true;
            ticari1isim = "";
            (sender as Button).Enabled = false;
            notlar.Add(notTxtTicari1.Text);
            notTxtTicari1.Text = "";
        }
        private void bitirBtnBireysel2_Click(object sender, EventArgs e)
        {
                listBox2.Items.Add(bireysel2isim + "/" + DateTime.Now + " / " + notTxtBireysel2.Text);
                button5.FlatAppearance.BorderColor = Color.LimeGreen;
                button5.ForeColor = Color.LimeGreen;
                bireysel2 = true;
                bireysel2isim = "";
                (sender as Button).Enabled = false;
                notlar.Add(notTxtBireysel2.Text);
                notTxtBireysel2.Text = "";
        }

        private void bitirBtnBireysel1_Click(object sender, EventArgs e)
        {
                listBox2.Items.Add(bireysel1isim + "/" + DateTime.Now + " / " + notTxtBireysel1.Text);
                button3.FlatAppearance.BorderColor = Color.LimeGreen;
                button3.ForeColor = Color.LimeGreen;
                bireysel1 = true;
                bireysel1isim = "";
                (sender as Button).Enabled = false;
                notlar.Add(notTxtBireysel1.Text);
                notTxtBireysel1.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ticarisayac++;
                listBox1.Items.Add("Ticari Hat -"+ ticarisayac +"- / " + DateTime.Now);
                bireyselmiticarimi.Add("Ticari");
            }
            else if (radioButton2.Checked)
            {
                bireyselsayac++;
                listBox1.Items.Add("Bireysel Hat -" + bireyselsayac + "- / " + DateTime.Now);
                bireyselmiticarimi.Add("Bireysel");
            }
        }
        void Bagla()
        {
            bireyselmiticarimi.TrimToSize();
            for (int i = 0; i < bireyselmiticarimi.Count; i++)
            {
                if (bireyselmiticarimi[i] == "Bireysel")
                {
                    if (bireysel1)
                    {
                        button3.FlatAppearance.BorderColor = Color.Red;
                        button3.ForeColor = Color.Red;
                        bireysel1 = false;
                        bitirBtnBireysel1.Enabled = true;
                        bireysel1isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                    }
                    else if (bireysel2)
                    {
                        button5.FlatAppearance.BorderColor = Color.Red;
                        button5.ForeColor = Color.Red;
                        bireysel2 = false;
                        bitirBtnBireysel2.Enabled = true;
                        bireysel2isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                    }
                }
                else if (bireyselmiticarimi[i] == "Ticari")
                {
                    if (ticari1)
                    {
                        
                        button11.FlatAppearance.BorderColor = Color.Red;
                        button11.ForeColor = Color.Red;
                        ticari1 = false;
                        bitirBtnTicari1.Enabled = true;
                        ticari1isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                    }
                    else if (ticari2)
                    {
                        button15.FlatAppearance.BorderColor = Color.Red;
                        button15.ForeColor = Color.Red;
                        ticari2 = false;
                        bitirBtnTicari2.Enabled = true;
                        ticari2isim = listBox1.Items[i].ToString();
                        listBox1.Items.RemoveAt(i);
                        bireyselmiticarimi.RemoveAt(i);
                    }
                }
            }
        }
    }
}