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
            //var bolgeler = _db.Regions.ToList(); Aynýsý..

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
            //butona basýldýðý zaman çalýþacak olan metot.

            //yeni bir çalýþan ekleyelim

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                MessageBox.Show("Lütfen alanlarý doldurunuz");
            else
            {
                Employee employee = new Employee();
                employee.FirstName = txtAd.Text;
                employee.LastName = txtSoyad.Text;
                //Buraya kadar sadece isim soy isim aldýk. 

                _db.Employees.Add(employee);

                _db.SaveChanges();
                CalisanlariGetir();
                MessageBox.Show("Baþarýyla eklenmiþtir.");
                txtAd.Clear();
                txtSoyad.Clear();

            }

        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenCalisan = (Employee)dgvCalisanlar.SelectedRows[0].DataBoundItem;

            lblSecilen.Text = "Seçilen Kiþi: " + secilenCalisan.FirstName + " " + secilenCalisan.LastName;

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
                lblSecilen.Text = "Seçilen Kiþi: ";
                CalisanlariGetir();

                MessageBox.Show("Baþarýyla silinmiþtir.");
            }
            else
                MessageBox.Show("Lütfen silinecek çalýþaný seçiniz!");


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Güncelle butonuna basýldýðý zaman yapýlacaklar yazýlacak

            if (secilenCalisan != null)
            {
                secilenCalisan.FirstName = txtAd.Text;
                secilenCalisan.LastName = txtSoyad.Text;
                _db.SaveChanges();
                CalisanlariGetir();
                txtAd.Clear();
                txtSoyad.Clear();
                secilenCalisan = null;
                MessageBox.Show("Baþarýyla güncellenmiþtir.");

            }
            else
                MessageBox.Show("Güncellenecek kiþiyi seçiniz!");
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            //Bu metot textboxtaki karakter/ler deðiþtiði zaman çalýþýr.
            //Dolayýsýyla textboxtaki metinde ne olursa onun için arama yapýlýr.

            dgvCalisanlar.DataSource = _db.Employees.Where(e=>
            e.FirstName.Contains(txtAra.Text) || 
            e.LastName.Contains(txtAra.Text)).ToList();
        }
    }
}
