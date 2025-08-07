using ANK18DbFirst.Models;
using Region = ANK18DbFirst.Models.Region;

namespace ANK18DbFirst
{
    public partial class Form1 : Form
    {
        Ank18NorthWindContext _db = new Ank18NorthWindContext();
        Employee secilenCalisan;
        public Form1()
        {
            InitializeComponent();
            CalisanlariGetir();
            //var bolgeler = _db.Regions.ToList(); Ayn�s�..

        }

        private void CalisanlariGetir()
        {
            dgvCalisanlar.DataSource = _db.Employees.ToList();

            for (int i = 0; i < dgvCalisanlar.Columns.Count; i++)
            {
                if (i > 2)
                    dgvCalisanlar.Columns[i].Visible = false;
            }

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            //butona bas�ld��� zaman �al��acak olan metot.

            //yeni bir �al��an ekleyelim

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                MessageBox.Show("L�tfen alanlar� doldurunuz");
            else
            {
                Employee employee = new Employee();
                employee.FirstName = txtAd.Text;
                employee.LastName = txtSoyad.Text;
                //Buraya kadar sadece isim soy isim ald�k. 

                _db.Employees.Add(employee);

                _db.SaveChanges();
                CalisanlariGetir();
                MessageBox.Show("Ba�ar�yla eklenmi�tir.");
                txtAd.Clear();
                txtSoyad.Clear();

            }

        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenCalisan = (Employee)dgvCalisanlar.SelectedRows[0].DataBoundItem;

            lblSecilen.Text = "Se�ilen Ki�i: " + secilenCalisan.FirstName + " " + secilenCalisan.LastName;

            txtAd.Text = secilenCalisan.FirstName;
            txtSoyad.Text = secilenCalisan.LastName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenCalisan != null)
            {
                _db.Employees.Remove(secilenCalisan);
                _db.SaveChanges();
                secilenCalisan = null;
                lblSecilen.Text = "Se�ilen Ki�i: ";
                CalisanlariGetir();

                MessageBox.Show("Ba�ar�yla silinmi�tir.");
            }
            else
                MessageBox.Show("L�tfen silinecek �al��an� se�iniz!");


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //G�ncelle butonuna bas�ld��� zaman yap�lacaklar yaz�lacak

            if (secilenCalisan != null)
            {
                secilenCalisan.FirstName = txtAd.Text;
                secilenCalisan.LastName = txtSoyad.Text;
                _db.SaveChanges();
                CalisanlariGetir();
                txtAd.Clear();
                txtSoyad.Clear();
                secilenCalisan = null;
                MessageBox.Show("Ba�ar�yla g�ncellenmi�tir.");

            }
            else
                MessageBox.Show("G�ncellenecek ki�iyi se�iniz!");
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            //Bu metot textboxtaki karakter/ler de�i�ti�i zaman �al���r.
            //Dolay�s�yla textboxtaki metinde ne olursa onun i�in arama yap�l�r.

            dgvCalisanlar.DataSource = _db.Employees.Where(e=>
            e.FirstName.Contains(txtAra.Text) || 
            e.LastName.Contains(txtAra.Text)).ToList();
        }
    }
}
