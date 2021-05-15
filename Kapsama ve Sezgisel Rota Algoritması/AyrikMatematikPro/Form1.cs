using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Threading.Tasks;

namespace AyrikMatematikPro
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct smallest
        {
            public double value;
            public int order;
        };

       
        public int totalCounter= 0;

        //FUNCTIONS

       

        public void rotaAlgoritmasi(DataGridView matris)
        {

            int satirSayi = matris.Rows.Count - 1;
            double[] weightValues = new double[satirSayi];

            smallest smallest; //enKucuk struct'indan bir nesne olusturuluyor.
            smallest.value = 0;
            smallest.order = 0;

            /*Ilk bulunan eleman en kucuk olarak ataniyor.*/
            for (int i = 0; i < satirSayi; i++)
            {

                if (Convert.ToDouble(matris.Rows[i].Cells["weight"].Value) > 0)
                {
                    smallest.value = Convert.ToDouble(matris.Rows[i].Cells["weight"].Value);
                    smallest.order = i;
                    break;
                }
            }

            for (int i = 0; i < satirSayi; i++)
            {
                if (Convert.ToDouble(matris.Rows[i].Cells["weight"].Value) > 0.0 && Convert.ToDouble(matris.Rows[i].Cells["weight"].Value) < smallest.value)
                {
                    smallest.value = Convert.ToDouble(matris.Rows[i].Cells["weight"].Value);
                    smallest.order = i;
                }
            }

            DataGridViewRow satirSilName = matris.Rows[smallest.order]; //Silinecek satir belirleniyor.

            if (matris == matris2)
            {
                totalCounter++;
                string text = null; ;
                history.Items.Add("ROTA Algoritması Uygulanıyor");
                text += "" + totalCounter + " ) Rota algoritması : " + satirSilName.HeaderCell.Value + " satırı en düşük ağırlık değerine sahip olduğu için silme işlemi yapıldı.";
                history.Items.Add(text);

            }

            matris.Rows.Remove(satirSilName); //Belirlenen en kucuk satir siliniyor.


        }
        public void createRandom(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1;
            int sutun = matris.Columns.Count - 1;

            Random rnd = new Random();

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris.Rows[i].Cells[j].Value = rnd.Next(0, 2); //0 ile 1 arasi random sayilar uretiliyor.
                    matris.Rows[i].Cells[j].ReadOnly = true; //Her hucre yazmaya korumali hale getiriliyor.
                }
            }

        }

        public void createData(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1;
            int sutun = matris.Columns.Count - 1;

            Random rnd = new Random();

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris.Rows[i].Cells[j].Value =0; //0 ile 1 arasi random sayilar uretiliyor.
                    //matris.Rows[i].Cells[j].Value = rnd.Next(0, 2); //0 ile 1 arasi random sayilar uretiliyor.
                    matris.Rows[i].Cells[j].ReadOnly = true; //Her hucre yazmaya korumali hale getiriliyor.
                }
            }


            /* //Values
            int column, row;
            row = matris.Rows.Count - 1; // -1 Weight Satırı Nedeniyle
            column = matris.Columns.Count - 1; // -1 Weight Sütunu Nedeniyle
            //Values

           //DefaultAtama
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matris.Rows[i].Cells[j].Value = 0;  //Döngü satırdan sütun gezer.
                }
            }
            //DefaultAtama */

        }

     

        public void tersiAl(DataGridView matris)
        {
            int value=Convert.ToInt32(matris.CurrentCell.Value);

            //Şart Yapısı - Açıklama : 0 ise 1 1 ise 0 yap.
            if ( value == 0)
            {
                matris.CurrentCell.Value = 1;
                matris.CurrentCell.Style.BackColor = Color.CornflowerBlue;
            }
            else
            {
                matris.CurrentCell.Value = 0;
                matris.CurrentCell.Style.BackColor = Color.Azure;
            }
            //Şart Yapısı

        }

        public void sutunSil(DataGridView matris)
        {
            int satirSayi, sutunSayi, zeroCount, i, j;

            satirSayi = matris.Rows.Count - 1;
            sutunSayi = matris.Columns.Count - 1;
            zeroCount = 0;

            for (i = 0; i < sutunSayi; i++)
            {
                for (j = 0; j < satirSayi; j++)
                {
                    if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) != 0) //ZeroChecker
                    {
                        break; //Sıfır harici değer bulunursa döngü kırılıyor.
                    }
                    else
                    {
                        zeroCount++;
                    }
                }
                if (zeroCount == satirSayi) //Eğer sıfırlar satır sayısı kadarsa sütun silinir.
                {
                    //Sütun silme işlemi
                    string columnDelete;
                    columnDelete= matris.Columns[i].Name;
                    matris.Columns.Remove(columnDelete);
                    sutunSayi--;
                    i = i - 1;
                    zeroCount = 0;
                    //Sütun silme işlemi
                }
                zeroCount = 0; //Counter Refresh
            }
        }
        public void kücükSutunAgirlikSatirAgirlik(DataGridView matris)
        {
            int satirSayi, sutunSayi, i, j;

            satirSayi = matris.Rows.Count - 1;
            sutunSayi = matris.Columns.Count - 1;

            int smallest = Convert.ToInt32(matris.Rows[satirSayi].Cells[0].Value);

            int[] columns = new int[sutunSayi];

            double total = 0;


            for (i = 0; i < sutunSayi; i++)
            {
                columns[i] = Convert.ToInt32(matris.Rows[satirSayi].Cells[i].Value);
                if (Convert.ToInt32(matris.Rows[satirSayi].Cells[i].Value) < smallest)
                {
                    smallest = Convert.ToInt32(matris.Rows[satirSayi].Cells[i].Value);
                }
            }


            for (i = 0; i < sutunSayi; i++)
            {
                if (Convert.ToInt32(matris.Rows[satirSayi].Cells[i].Value) == smallest)
                {
                    matris.Rows[satirSayi].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Green, ForeColor = Color.White };
                    for (j = 0; j < satirSayi; j++)
                    {
                        if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) == 1)
                        {
                            for (int a = 0; a < sutunSayi; a++)
                            {
                                if (Convert.ToInt32(matris.Rows[j].Cells[a].Value) == 1)
                                {
                                    total = total + (1 / Convert.ToDouble(columns[a]));
                                }
                            }
                            matris.Rows[j].Cells["weight"].Value = satirSayi * total;
                            matris.Rows[j].Cells["weight"].Style = new DataGridViewCellStyle { BackColor = Color.Green, ForeColor = Color.White };
                            total = 0;
                            //MessageBox.Show("Ilerle");
                        }
                    }
                }
            }



        }
        public void satirSil(DataGridView matris)
        {
            int satirSayi, sutunSayi, zeroCount,i,j;

            satirSayi = matris.Rows.Count - 1;
            sutunSayi = matris.Columns.Count - 1;
            zeroCount = 0;

            for (i = 0; i < satirSayi; i++)
            {
                for (j = 0; j < sutunSayi; j++)
                {
                    
                    if (Convert.ToInt32(matris.Rows[i].Cells[j].Value) != 0) //ZeroChecker
                    {
                        
                        //Sıfır harici değer bulunursa döngü kırılıyor.
                        break;
                    }
                    else
                    {
                        zeroCount++;    
                    }
                }
                if (zeroCount == sutunSayi) //Eğer sıfırlar sütun sayısı kadarsa satır silinir.
                {
                    //Satır silme işlemi
                    DataGridViewRow rowDelete = matris.Rows[i]; 
                    matris.Rows.Remove(rowDelete); 
                    satirSayi--; 
                    i = i - 1;
                    zeroCount = 0; 
                    //Satır silme işlemi
                }
                zeroCount = 0; //Counter Refresh
            }
        }

        public int mutlakSatirSutunSil(DataGridView matris)
        {
            int satirSayi, sutunSayi, mutlakSatir, mutlakSutun , ajan;

            satirSayi = matris.Rows.Count - 1; 
            sutunSayi = matris.Columns.Count - 1; 
            mutlakSatir = 0;  
            mutlakSutun= 0;
            ajan = 0;
            string text="";
            //Weight Column Tarama
            for (int i = 0; i < sutunSayi; i++)
            {
                if (Convert.ToInt32(matris.Rows[satirSayi].Cells[i].Value) == 1)
                {
                    mutlakSutun = i;
                    ajan++;
                    break;
                }
            }
            //Weight Column Tarama
            if (ajan == 0)
            {
                return 0; 
            }

           //Weight Row Tarama
            for (int i = 0; i < satirSayi; i++)
            {
                if (Convert.ToInt32(matris.Rows[i].Cells[mutlakSutun].Value) == 1)
                {
                    mutlakSatir = i;
                    break;
                }
            }
           //Weight Row Tarama

            DataGridViewRow satirAdi = matris.Rows[mutlakSatir]; 

            if (matris == matris2) // matris2 yazılacak
            {
                kapsamalar.Text += satirAdi.HeaderCell.Value + " "; //Kapsamalar yaziliyor.
                totalCounter++;
                text+="" + totalCounter + " )  Mutlak satır : " + satirAdi.HeaderCell.Value + " " + satirAdi.HeaderCell.Value + " satır ve ";


            }


            //Absolute Row içerisinde 1 içeren sütünların silinmesi
            for (int i = 0; i < matris.Columns.Count - 1; i++)
            {
                if (Convert.ToInt32(matris.Rows[mutlakSatir].Cells[i].Value) == 1)
                {
                    string sutunSilName = matris.Columns[i].Name;

                    if (matris == matris2)
                    {
                      text += " " + sutunSilName + " , ";
                    }

                    matris.Columns.Remove(sutunSilName);
                    i = i - 1; 
                }
            }
            //Absolute Row içerisinde 1 içeren sütünların silinmesi
             text +=" sütunlarını sildi.";
            history.Items.Add(text);
            matris.Rows.RemoveAt(mutlakSatir);
            return 1;
        }

        public int sutunKapsamasinaGoreSil(DataGridView matris)
        {
            int satirSayi, sutunSayi, soldanKapsama, sağdanKapsama, i, j, k;

            satirSayi = matris.Rows.Count - 1;
            sutunSayi = matris.Columns.Count - 1;
            soldanKapsama = 0;
            sağdanKapsama = 0;
            string text = null;

            //Karşılaştırma 
            for (i = 0; i < sutunSayi; i++)
            {
                for (j = i + 1; j < sutunSayi; j++)
                {
                    for (k = 0; k < satirSayi; k++)
                    {
                        if (Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 0)
                        {
                            soldanKapsama++;
                            if (sağdanKapsama > 0 || soldanKapsama > 1)
                                break;
                        }
                        else if (Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 1)
                        {
                        }
                        else if (Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 0)
                        {
                            sağdanKapsama++;
                            if (soldanKapsama > 0 || sağdanKapsama > 1)
                                break;
                        }
                    }
                    if (soldanKapsama == 1 && sağdanKapsama == 0)
                    {
                        string coveredColumnName = matris.Columns[j].Name;
                        string coveringColumnName = matris.Columns[i].Name;

                        if (matris == matris2)
                        {
                            totalCounter++;
                            text += "" + totalCounter + " ) Sütun Kapsama İşlemi : " + coveringColumnName + " sütunu " + coveredColumnName + " sütununu kapsadığı için  " + coveredColumnName + " sütunu silme işlemi yapıldı.";
                            history.Items.Add(text);
                        }

                        matris.Columns.Remove(coveringColumnName);
                        return 1;
                    }
                    else if (sağdanKapsama == 1 && soldanKapsama == 0)
                    {
                        string coveredColumnName = matris.Columns[i].Name;
                        string coveringColumnName = matris.Columns[j].Name;

                        if (matris == matris2)
                        {
                            totalCounter++;
                            text += "" + totalCounter + " ) Sütun Kapsama İşlemi " + coveringColumnName + " sütunu " + coveredColumnName + " sütununu kapsadığı için " + coveredColumnName + " sütunu silme işlemi yapıldı.";
                            history.Items.Add(text);
                        }

                        matris.Columns.Remove(coveringColumnName);

                        return 1;
                    }
                    else //Kapsama yoktur.
                    {
                        soldanKapsama = 0;
                        sağdanKapsama = 0;
                    }
                    soldanKapsama = 0;
                    sağdanKapsama = 0;
                }
            }
            //Karşılaştırma

            return 0; //Kapsanan sütun bulunamadi.
        }

        public void coloring(DataGridView matris ,int gelen)
        {
            matris.Rows[gelen].DefaultCellStyle.BackColor = Color.AntiqueWhite;
        }
        public void columnColoring(DataGridView matris, string gelen)
        {
            matris.Columns[gelen].DefaultCellStyle.BackColor = Color.BlanchedAlmond;
        }

        public int satirKapsamasinaGoreSil(DataGridView matris)
        {
            int satirSayi, sutunSayi, usttenKapsama, alttanKapsama, i, j, k;

            satirSayi= matris.Rows.Count - 1; 
            sutunSayi= matris.Columns.Count - 1; 
            usttenKapsama = 0;
            alttanKapsama = 0;
            string text = null;
            
            //Karşılaştırma 
            for (i = 0; i < satirSayi; i++)
            {
                for (j = i + 1; j < satirSayi; j++)
                {
                    for (k = 0; k < sutunSayi; k++)
                    {
                        if (Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 0)//Üst Kapsama Kontrol
                        {
                            usttenKapsama++; 
                            if (alttanKapsama > 0)
                                break;
                        }
                        else if (Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 1)
                        {
                        }
                        else if (Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 0)//Alt Kapsama Kontrol
                        {
                            alttanKapsama++;
                            if (usttenKapsama > 0)
                                break;                     
                        }
                    }
                    if (usttenKapsama> 0 && alttanKapsama == 0 || usttenKapsama == 0 && alttanKapsama == 0)
                    {
                        DataGridViewRow satirSilName = matris.Rows[j];
                        DataGridViewRow coveringRow = matris.Rows[i];

                        if (matris == matris2)
                        {
                            totalCounter++;
                            text += "" + totalCounter + " ) Satır Kapsama İşlemi: " + coveringRow.HeaderCell.Value + " satırı " + satirSilName.HeaderCell.Value + "satırını kapsadığı için " + satirSilName.HeaderCell.Value + " satırını silme işlemi yapıldı.";
                            history.Items.Add(text);

                        }


                        coloring(matrix, satirSilName.Index);
                        matris.Rows.Remove(satirSilName); 

                        return 1;
                    }
                    else if (alttanKapsama > 0 && usttenKapsama == 0)
                    {
                        DataGridViewRow satirSilName = matris.Rows[i]; 
                        DataGridViewRow coveringRow = matris.Rows[j];

                        if (matris == matris2)
                        {
                           totalCounter++;
                           text += "" + totalCounter + " ) Satır  Kapsama İşlemi : " + coveringRow.HeaderCell.Value + " satırı " + satirSilName.HeaderCell.Value + "satırını kapsadığı için " + satirSilName.HeaderCell.Value + " satırını silme işlemi yapıldı.";
                           history.Items.Add(text);
                           
                        }

                        coloring(matrix, satirSilName.Index);
                       
                        matris.Rows.Remove(satirSilName); 

                        return 1; 
                    }
                    else //Kapsama yoktur.
                    {
                        alttanKapsama = 0;
                        usttenKapsama = 0;
                    }
                    alttanKapsama = 0;
                    usttenKapsama = 0;
                }
            }
            //Karşılaştırma

            return 0; //Kapsanan satir bulunamadi.
        }

    
        public void sutunAgirlikHesapla(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; //satir sayisi tutulan degisken tanimlandi.
            int sutun = matris.Columns.Count - 1; //sutun sayisi tutulan degsiken tanimlandi.

            int toplam = 0;
            int i = 0;
            int j = 0;


            for (i = 0; i < sutun; i++)
            {
                for (j = 0; j < satir; j++)
                {
                    /*j.satir i.sutun diyerek kolon tarama gerçeklestirildi.*/
                    if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) == 1) //j.satir i.sutun daki kutunun degeri 1 e esitmi kontrol edildi.
                    {
                        toplam++;  //Toplam 1 arttirildi.
                        matris.Rows[j].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Blue, ForeColor = Color.White }; //Degeri 1 olan kolonlara yeni stil eklendi.
                    }
                }
                matris.Rows[satir].Cells[i].ReadOnly = true; //1 lerin sayisinin yazildigi sutun sadece okunabilir yapildi.
                matris.Rows[satir].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White }; //1 lerin yazıldıgı kolona yeni stil eklendi.
                matris.Rows[satir].Cells[i].Value = toplam;  //1 lerin sayisi en alt sutunlara yazildi.
                toplam = 0; //Toplam degiskeni diger degerlere bakabilmek icin sifirlandi.
            }

            /*int satirSayi, sutunSayi, total , i=0, j=0;

            satirSayi = matris.Rows.Count - 1;
            sutunSayi = matris.Columns.Count - 1;
            total = 0;

            //ScanMatrix
            for (i = 0; i < sutunSayi; i++)
            {
                for (j = 0; j < satirSayi; j++)
                {

                    if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) == 1)
                    {
                        total++;
                        matris.Rows[j].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Blue, ForeColor = Color.White };
                    }
                    matris.Rows[satirSayi].Cells[i].ReadOnly = true;
                    matris.Rows[satirSayi].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White };
                    matris.Rows[satirSayi].Cells[i].Value = total;
                    total = 0;
                }
                //ScanMatrix
            }*/
        }


        public void matrixTransfer(DataGridView m1, DataGridView m2)
        {

            int row, column;
            row = m1.Rows.Count - 1;
            column = m1.Columns.Count - 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    m2.Rows[i].Cells[j].Value = m1.Rows[i].Cells[j].Value; //matrix deki degerler Matris2 ye aktariliyor.
                }
            }
        }

        public void satirAgirlikTemizle(DataGridView matris)
        {
            int satirSayi = matris.Rows.Count - 1;

            for (int i = 0; i < satirSayi; i++)
            {
                matris.Rows[i].Cells["weight"].Value = null;
                matris.Rows[i].Cells["weight"].Style = new DataGridViewCellStyle { BackColor = Color.White, ForeColor = Color.Black };
            }
        }



        public void matrisOlustur(int row, int column, DataGridView matris) //matrisOlustur Func
        {

            for (int i = 0; i < column; i++) //Sütun Ekleme
            {
                matris.Columns.Add(i.ToString(), (i + 1).ToString());
                matris.Columns[i].Width = 20;
                // matris.Columns[i].Width = 460 / column;
                matris.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //Extra Column
            matris.Columns.Add("weight", "Ağırlık");
            matris.Columns["weight"].Width = 50;
            matris.Columns["weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Extra Column

            char letter = 'a';//Row Header Let
            for (int j = 0; j < row; j++)//Satır Ekleme
            {
                matris.Rows.Add();
                matris.Rows[j].Height = 20;
                // matris.Rows[j].Height = 460 / row;
                matris.Rows[j].HeaderCell.Value = letter.ToString(); //Satirlarin basina isim verildi.
                matris.Rows[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                matris.Rows[j].DefaultCellStyle.BackColor = Color.Azure;
                matris.Rows[j].DefaultCellStyle.ForeColor = Color.Black;
                letter++;
            }

            //Extra Row
            matris.RowHeadersWidth = 50;
            matris.Rows.Add();
            //Ekstra Row

            //Parameters
            matris.TopLeftHeaderCell.Value = "a/1";
            matris.AllowUserToAddRows = false;
            matris.AllowUserToDeleteRows = false;
            matris.SelectionMode = DataGridViewSelectionMode.CellSelect;
            matris.ReadOnly = true;
            matris.Visible = true;

            //Parameters      

            matris.BringToFront();
        }

        public void disable()
        {
            nValue.Enabled = false;
            mValue.Enabled = false;
            gonder.Enabled = false;

        }

        public int islemyap(DataGridView matris)
        {

            //İşlem Sonu Kontrolcü Yapı
            if ((matris.Rows.Count - 1) < 1 || (matris.Columns.Count - 1) < 1) 
            {
                if (matris == matris2)
                {
                    kapsamaYaz();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Yapılacak işlem kalmadı.", "İşlemler Bitti");
                    contiune.Enabled = false;
                    
                }
                   



                return 0;
            }
            else{ 
            satirSil(matris);
            sutunSil(matris);

            if (mutlakSatirSutunSil(matris) == 0)
            {
                if (matris == matris2) history.Items.Add("Mutlak sütun yok");
                if (satirKapsamasinaGoreSil(matris) == 0)
                {
                    if (matris == matris2) history.Items.Add("Kapsanan satır yok");
                    if (sutunKapsamasinaGoreSil(matris) == 0)
                    {
                        if (matris == matris2) history.Items.Add("Kapsanan sütun yok");
                        sutunAgirlikHesapla(matris);
                        kücükSutunAgirlikSatirAgirlik(matris); //Rota algoritmasinin calisabilmesi icin satir agirliklari hesaplanmali.
                        rotaAlgoritmasi(matris); //Hicbir fonksiyon calismadiysa rota algoritmasina gore en dusuk agirligi olan satir siliniyor.
                        sutunAgirlikHesapla(matris); //Bir sonraki islemde hata alamamak icin , islemden sonra agirliklar tekrar hesaplaniyor.
                        satirAgirlikTemizle(matris);

                        return 1; //Islem gerceklestigi icin 1 degeri geri donduruyor.
                    }
                    else
                    {
                        return 1; //Islem gerceklestigi icin 1 degeri geri donduruyor.
                    }
                }
                else
                {
                    return 1; //Islem gerceklestigi icin 1 degeri geri donduruyor.
                }
            }
            else
            {
                return 1; //Islem gerceklestigi icin 1 degeri geri donduruyor.
            }
            }
        }
   
        public void kapsamaYaz()
        {
            string kelime = kapsamalar.Text;
            char[] ayir = kelime.ToCharArray();

            Array.Sort(ayir);
            kapsamalar.Text = "";
            kapsamalar.Text += "π ={ ";

            foreach (char eleman in ayir)
            {
                if (eleman == ayir.Last())
                {
                    kapsamalar.Text += eleman;
                    break;
                }


                if (eleman != ' ')
                    kapsamalar.Text += eleman + " , ";
            }
            kapsamalar.Text += " }";
            kapsamalar.Visible = true;
            DevExpress.XtraEditors.XtraMessageBox.Show(kapsamalar.Text, "Kapsamalar");
        }
        //EVENTS


            //Burada İşin Yok
        private void gonder_Click(object sender, EventArgs e)
        {
           
            try {
                if (Convert.ToInt32(mValue.Text) < 0 || Convert.ToInt32(nValue.Text) < 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Doğal sayı giriniz.", "Uyarı");
                }
                else {

                    matrisOlustur(Convert.ToInt32(mValue.Text), Convert.ToInt32(nValue.Text), matrix);
                    createData(matrix);
                    disable();
                }
                   
                
           

                /*matrix.Rows.Clear();
                matrix.Columns.Clear();

                */
            }
            catch 
            {

                DevExpress.XtraEditors.XtraMessageBox.Show("Doğal sayı giriniz.", "Uyarı");
            }




        }

        private void matris_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tersiAl(matrix);
        }

        private void matrix_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tersiAl(matrix);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            track.Enabled = false;
            contiune.Enabled = false;
            random.Enabled = false;
            disable();
            int satir = matrix.Rows.Count - 1;
            int sutun = matrix.Columns.Count - 1;

            sutunAgirlikHesapla(matrix); //Satir sutun agirliklari hesaplandi.

            /*Ikinci matris olusturuluyor ve 1.Matrisdeki degelerler 2.Matrise aktariliyor.*/
            matrisOlustur(satir, sutun, matris3); //Matris olusturma fonksiyonu cagirilip 3.Matris olusturuluyor.
            matrixTransfer(matrix, matris3); //matrix deki degerler Matris3 ye aktarildi.

            int x = matrix.Width; //1.Matrisin genislik degeri bulunuyor.
            matrisOlustur(satir, sutun, matris2); //Matris olusturma fonksiyonu cagirilip 2.Matris olusturuluyor.
            matrixTransfer(matrix, matris2); //matrix deki degerler Matris2 ye aktarildi.
            sutunAgirlikHesapla(matris2); //Satir sutun agirliklari hesaplandi.

           
           // sutunAgirlikHesapla(matris3); //Matris3 deki agirliklar hesaplaniyor

            islemyap(matris2); //Matris2'nin onden gidebilmesi icin islemler onceden basliyor.
            sutunAgirlikHesapla(matris2); //Bir sonraki islemde hata alamamak icin , islemden sonra agirliklar tekrar hesaplaniyor.


            while (islemyap(matris2) == 1) //2.Matriste sonuc bulunmamis ise diger matriste islem yapiliyor.
            {
                sutunAgirlikHesapla(matris2);
                islemyap(matrix);
                sutunAgirlikHesapla(matrix);
            }
        }

    
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            direct.Enabled = false;
            track.Enabled = false;
            random.Enabled = false;
            disable();
            groupControl2.Text = "İşlem Öncesi";
            groupControl6.Text = "İşlem Sonrası";
            groupControl7.Text = "Matris";
            sutunAgirlikHesapla(matrix); //Satir sutun agirliklari hesaplandi.

            /*Ikinci matris olusturuluyor ve 1.Matrisdeki degelerler 2.Matrise aktariliyor.*/
            int satir = matrix.Rows.Count - 1;
            int sutun = matrix.Columns.Count - 1;
            int x = matrix.Width; //1.Matrisin genislik degeri bulunuyor.
            matrisOlustur(satir, sutun, matris2); //Matris olusturma fonksiyonu cagirilip 2.Matris olusturuluyor.
            matrixTransfer(matrix, matris2); //matrix deki degerler Matris2 ye aktarildi.
            sutunAgirlikHesapla(matris2); //Satir sutun agirliklari hesaplandi.

            matrisOlustur(satir, sutun, matris3); //Matris olusturma fonksiyonu cagirilip 3.Matris olusturuluyor.
            matrixTransfer(matrix, matris3); //matrix deki degerler Matris3 ye aktarildi.
            sutunAgirlikHesapla(matris3); //Matris3 deki agirliklar hesaplaniyor

            islemyap(matris2); //Matris2'nin onden gidebilmesi icin islemler onceden basliyor.
            sutunAgirlikHesapla(matris2); //Bir sonraki islemde hata alamamak icin , islemden sonra agirliklar tekrar hesaplaniyor.

          
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (islemyap(matris2) == 1) //2.Matriste sonuc bulunmamis ise diger matriste islem yapiliyor.
            {
                sutunAgirlikHesapla(matris2);
                islemyap(matrix);
                sutunAgirlikHesapla(matrix);
            }
        }

        //PASSIVE

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            createRandom(matrix);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kapsamalar.Visible = false;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}







