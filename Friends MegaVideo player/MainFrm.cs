using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.Vesic.WinForms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;
using Microsoft.WindowsAPICodePack.Taskbar;


namespace Friends_from_MegaVideo_player
{
    public partial class MainFrm : Form
    {
        FormState frm = new FormState();

        public MainFrm()
        {
            InitializeComponent();
            CheckIfListExists();
            ZaznaczMenuItems();
            ZaładujComboBox();
            InitializeControls();
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.CmbBoxItemNumber != -1)   //Jeżeli przy zamknięciu programu nie były wyłączone wszystkie filtry
                cmbBox.SelectedItem = cmbBox.Items[Friends_from_MegaVideo_player.Properties.Settings.Default.CmbBoxItemNumber]; //zaznacz ostatni oglądany odcinek  
        }

        //Po wyjściu z trybu oglądania filmu okno będzie ustawione na początkowe rozmiary (poniżej)        
        const int Iwidth = 509;
        const int Iheight = 236;

        private ThumbnailToolbarButton buttonFirst, buttonSecond; //Przycisk w podglądzie Aero (Deklaracja)
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance; //Pasek zadań (Deklaracja)

        #region Czynności wykonywane przy uruchamianiu programu
        private void InitializeControls() //Ustaw kontrolki przy uruchomieniu programu
        {
            Stan.Items[0].Text = StatusStripChange(); //Pokaż na pasku stanu, które filtry są włączone            
            toolStripStatusLabel2.Text = Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath; //Pokaż na pasku stanu ścieżkę do listy
            toolStripStatusLabel2.ToolTipText = Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath; //Pokaż ścieżkę w dymku po zatrzymaniu kursora na tekście
            openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath); //Open Dialog domyślnie otwiera się w folderze z aplikacją             
            saveFileDialog.InitialDirectory = System.Environment.SpecialFolder.Desktop.ToString(); //Save File Dialog domyślnie zapisuje na pulpicie 
            this.BackgroundImage = Friends_from_MegaVideo_player.Properties.Resources.Friends_logo; //Ustaw obrazek tła                 
        }

        private void CheckIfListExists()
        {
            //Jak coś się nie uda zamknij program nie zapisując ustawień
            if (!System.IO.File.Exists(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath)) //Sprawdź, czy plik istnieje
            {
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = MessageBox.Show("Plik z listą odcinków nie został odnaleziony ",
                "Nie odnaleziono pliku!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == System.Windows.Forms.DialogResult.Retry)
                {
                    openFileDialog.ShowDialog();
                    Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath = openFileDialog.FileName;
                    Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
                }
                else
                    System.Threading.Thread.CurrentThread.Abort();
            }
        } //Sprawdź przy uruchomieniu, czy plik nadal istnieje  

        private void ZaznaczMenuItems() //Wczytaj z ustawień, które filtry były włączone przy zamykaniu programu
        {
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon1 == true)
                sezon1ToolStripMenuItem.Checked = true;
            else
                sezon1ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon2 == true)
                sezon2ToolStripMenuItem.Checked = true;
            else
                sezon2ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon3 == true)
                sezon3ToolStripMenuItem.Checked = true;
            else
                sezon3ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon4 == true)
                sezon4ToolStripMenuItem.Checked = true;
            else
                sezon4ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon5 == true)
                sezon5ToolStripMenuItem.Checked = true;
            else
                sezon5ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon6 == true)
                sezon6ToolStripMenuItem.Checked = true;
            else
                sezon6ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon7 == true)
                sezon7ToolStripMenuItem.Checked = true;
            else
                sezon7ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon8 == true)
                sezon8ToolStripMenuItem.Checked = true;
            else
                sezon8ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon9 == true)
                sezon9ToolStripMenuItem.Checked = true;
            else
                sezon9ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon10 == true)
                sezon10ToolStripMenuItem.Checked = true;
            else
                sezon10ToolStripMenuItem.Checked = false;
            if (Friends_from_MegaVideo_player.Properties.Settings.Default.Spec == true)
                odcSpecjalneToolStripMenuItem.Checked = true;
            else
                odcSpecjalneToolStripMenuItem.Checked = true;
        }
        #endregion

        #region Obsługa naciśnięć klawiszy
        private void Flash_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Control[] Cont = { btnPlay, cmbBox, linkLabel1, Stan, menuStrip1, btnToHTML, btnEpisodesList };

            //Przejdź w tryb pełnoekranowy
            if (e.KeyCode == Keys.F)
                if (Flash.Visible == true)
                {
                    frm.Maximize(this);
                    this.Focus();
                }
            //Wyłącz odtwarzanie i przywróć pierwotne rozmiary okna
            if (e.KeyCode == Keys.Escape)
            {
                if (Flash.Visible == true)
                {
                    frm.Restore(this);
                    this.Size = new Size(Iwidth, Iheight);
                    Flash.LoadMovie(0, "http://www.megavideo.com");//żeby nie odtwarzać filmu
                    KontrolkiVisible(true, Cont);
                    this.Text = "Przyjaciele Player";
                }
            }
            //Wyjście z trybu pełnoekranowego przy oglądaniu filmu
            if (e.KeyCode == Keys.W)
                if (Flash.Visible == true)
                    frm.Restore(this);
        }

        private void MainFrm_KeyUp_1(object sender, KeyEventArgs e)
        {
            Control[] Cont = { btnPlay, cmbBox, linkLabel1, Stan, menuStrip1, btnToHTML, btnEpisodesList };

            //Przejdź w tryb pełnoekranowy
            if (e.KeyCode == Keys.F)
                if (Flash.Visible == true)
                {
                    frm.Maximize(this);
                    this.Focus();                    
                }
            //Wyłącz odtwarzanie i przywróć pierwotne rozmiary okna
            if (e.KeyCode == Keys.Escape)
            {
                if (Flash.Visible == true)
                {
                    frm.Restore(this);
                    this.Size = new Size(Iwidth, Iheight);
                    Flash.LoadMovie(0, "http://www.megavideo.com");//żeby nie odtwarzać filmu
                    KontrolkiVisible(true, Cont);
                    this.Text = "Przyjaciele Player";
                }
            }
            //Wyjście z trybu pełnoekranowego przy oglądaniu filmu
            if (e.KeyCode == Keys.W)
                if (Flash.Visible == true)
                    frm.Restore(this);

            //Filtry
            if (e.KeyCode == Keys.D1)
                if (sezon1ToolStripMenuItem.Checked == true)
                    sezon1ToolStripMenuItem.Checked = false;
                else
                    sezon1ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D2)
                if (sezon2ToolStripMenuItem.Checked == true)
                    sezon2ToolStripMenuItem.Checked = false;
                else
                    sezon2ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D3)
                if (sezon3ToolStripMenuItem.Checked == true)
                    sezon3ToolStripMenuItem.Checked = false;
                else
                    sezon3ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D4)
                if (sezon4ToolStripMenuItem.Checked == true)
                    sezon4ToolStripMenuItem.Checked = false;
                else
                    sezon4ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D5)
                if (sezon5ToolStripMenuItem.Checked == true)
                    sezon5ToolStripMenuItem.Checked = false;
                else
                    sezon5ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D6)
                if (sezon6ToolStripMenuItem.Checked == true)
                    sezon6ToolStripMenuItem.Checked = false;
                else
                    sezon6ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D7)
                if (sezon7ToolStripMenuItem.Checked == true)
                    sezon7ToolStripMenuItem.Checked = false;
                else
                    sezon7ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D8)
                if (sezon8ToolStripMenuItem.Checked == true)
                    sezon8ToolStripMenuItem.Checked = false;
                else
                    sezon8ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D9)
                if (sezon9ToolStripMenuItem.Checked == true)
                    sezon9ToolStripMenuItem.Checked = false;
                else
                    sezon9ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.D0)
                if (sezon10ToolStripMenuItem.Checked == true)
                    sezon10ToolStripMenuItem.Checked = false;
                else
                    sezon10ToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.A)
                if (zaznaczWszystkieToolStripMenuItem.Checked == true)
                    zaznaczWszystkieToolStripMenuItem.Checked = false;
                else
                    zaznaczWszystkieToolStripMenuItem.Checked = true;
            if (e.KeyCode == Keys.Z)
                if (odznaczWszyskieToolStripMenuItem.Checked == true)
                    odznaczWszyskieToolStripMenuItem.Checked = false;
                else
                    odznaczWszyskieToolStripMenuItem.Checked = true;
        }
        #endregion

        private void ZaładujComboBox()
        {
            cmbBox.Items.Clear(); //Wyczyść, by wykluczyć możliwość wielokrotnego wyświetlania tych samych odcinków
            try
            {
                //Otwórz plik XML   
                System.Xml.XmlTextReader Xr = new System.Xml.XmlTextReader(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath);
                System.Xml.XmlDocument XDoc = new System.Xml.XmlDocument();
                XDoc.Load(Xr);
                Xr.Close();
                XmlNodeList nl = XDoc.SelectNodes("/Spis/Odcinek");  //Przetwarzaj po kolei całe odcinki  
                if (nl.Count == 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Plik z listą odcinków jest niewłaściwy\nOtwóz inny plik lub program zostanie zamknięty! ",
                    "Zły plik!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Retry)
                        zPlikuLokalnegoToolStripMenuItem.PerformClick();
                    else
                        System.Threading.Thread.CurrentThread.Abort();
                }
                foreach (XmlNode n in nl)
                {
                    //Jeżeli przetwarzany odcinek ma <NrSezonu> "1" i zaznaczony jest filtr na Sezon 1 wyświetl odcinek. Analogicznie pozostałe sezony       
                    if ((n.FirstChild.NextSibling.InnerText == "1") & (sezon1ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "2") & (sezon2ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText)).ToString();
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "3") & (sezon3ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "4") & (sezon4ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "5") & (sezon5ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "6") & (sezon6ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "7") & (sezon7ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "8") & (sezon8ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "9") & (sezon9ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "10") & (sezon10ToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Sezon {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                    if ((n.FirstChild.NextSibling.InnerText == "Specjalny") & (odcSpecjalneToolStripMenuItem.Checked == true))
                    {
                        cmbBox.Items.Add(String.Format("Odc. {0}, odc. {1} ({2}) - {3}", n.FirstChild.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.InnerText, n.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, n.FirstChild.InnerText));
                    }
                }
            }
            //Jak coś się nie uda zamknij program nie zapisując ustawień
            catch (NullReferenceException e)
            {
                MessageBox.Show("Błąd: " + e.InnerException + "\nAplikacja zostanie zamknięta!", "Wystąpił błąd!");
                System.Threading.Thread.CurrentThread.Abort();
            }
            if (cmbBox.Items.Count != 0)
                btnPlay.Enabled = true;
            else
                btnPlay.Enabled = false;
        }

        private string StatusStripChange() //Wyświetl filtry które są zaznaczone na pasku stanu
        {
            string s = "Filtry - Sezon: ";
            if (sezon1ToolStripMenuItem.Checked == true)
                s = s + "1, ";
            if (sezon2ToolStripMenuItem.Checked == true)
                s = s + "2, ";
            if (sezon3ToolStripMenuItem.Checked == true)
                s = s + "3, ";
            if (sezon4ToolStripMenuItem.Checked == true)
                s = s + "4, ";
            if (sezon5ToolStripMenuItem.Checked == true)
                s = s + "5, ";
            if (sezon6ToolStripMenuItem.Checked == true)
                s = s + "6, ";
            if (sezon7ToolStripMenuItem.Checked == true)
                s = s + "7, ";
            if (sezon8ToolStripMenuItem.Checked == true)
                s = s + "8, ";
            if (sezon9ToolStripMenuItem.Checked == true)
                s = s + "9, ";
            if (sezon10ToolStripMenuItem.Checked == true)
                s = s + "10, ";
            if (odcSpecjalneToolStripMenuItem.Checked == true)
                s = s + " Spec.";
            if (s == "Filtry - Sezon: ")
                s = "Brak filtrów";
            return s;
        }

        private void ZapiszUstawieniaMenuItems() //Zapisz w ustawieniach programu, które filtry były włączone przy zamykaniu programu
        {
            if (sezon1ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon1 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon1 = false;
            if (sezon2ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon2 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon2 = false;
            if (sezon3ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon3 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon3 = false;
            if (sezon4ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon4 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon4 = false;
            if (sezon5ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon5 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon5 = false;
            if (sezon6ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon6 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon6 = false;
            if (sezon7ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon7 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon7 = false;
            if (sezon8ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon8 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon8 = false;
            if (sezon9ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon9 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon9 = false;
            if (sezon10ToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon10 = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Sezon10 = false;
            if (odcSpecjalneToolStripMenuItem.Checked == true)
                Friends_from_MegaVideo_player.Properties.Settings.Default.Spec = true;
            else
                Friends_from_MegaVideo_player.Properties.Settings.Default.Spec = false;
            Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
        }

        private void PlayEpisode(int episode, AxShockwaveFlashObjects.AxShockwaveFlash FlashControl) //Odtwórz odcinek
        {
            Control[] Cont = { btnPlay, cmbBox, linkLabel1, Stan, menuStrip1, btnToHTML, btnEpisodesList };
            System.Xml.XmlTextReader XMLTxtReader = new System.Xml.XmlTextReader(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath);
            System.Xml.XmlDocument XMLDoc = new System.Xml.XmlDocument();
            XMLDoc.Load(XMLTxtReader);
            XMLTxtReader.Close();
            XmlNodeList nl = XMLDoc.SelectNodes("/Spis/Odcinek/NazwaOdcinka");
            Friends_from_MegaVideo_player.Properties.Settings.Default.Ostatni = episode;
            Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
            this.Focus();
            if ((episode < 239) | (episode > 0))
            {
                foreach (XmlNode n in nl)
                {
                    if (n.NextSibling.NextSibling.NextSibling.InnerText == episode.ToString()) //Szuka odcinka o takiej samej nazwie jak ta wyciągnięta z pliku XML
                    {
                        FlashControl.Movie = (n.NextSibling.NextSibling.NextSibling.NextSibling.InnerText); //Wyciągnięcie linku z pliku                    
                        this.Text = "Przyjaciele Player - " + n.InnerText + " (" + n.NextSibling.NextSibling.NextSibling.InnerText + ")"; //Ustawienie nagłówka
                        KontrolkiVisible(false, Cont);
                        this.ClientSize = new Size(640, 481);
                        FlashControl.Size = new Size(640, 481);
                        frm.Maximize(this);
                        this.Focus();
                        break;
                    }
                }
            }
            if (episode == 239)
            {
                MessageBox.Show("To był już ostatni odcinek!");
                Friends_from_MegaVideo_player.Properties.Settings.Default.Ostatni = 238;
                Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
            }
            if (episode == 0)
            {
                MessageBox.Show("To był pierwszy odcinek!");
                Friends_from_MegaVideo_player.Properties.Settings.Default.Ostatni = 1;
                Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
            }
            this.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int FirstOpeningBracket = (cmbBox.SelectedItem.ToString().IndexOf("(")) + 1;
            int FirstClosingBracket = (cmbBox.SelectedItem.ToString().IndexOf(")"));
            int nrOdcinka = Convert.ToInt32(cmbBox.SelectedItem.ToString().Substring(FirstOpeningBracket, FirstClosingBracket - FirstOpeningBracket));
            PlayEpisode(nrOdcinka, Flash);
        }

        private void KontrolkiVisible(bool b, Control[] controls) //Schowanie przycisków o CmbBoxa, ujawnienie FlashPlayera
        {
            if (b == true)
            {
                foreach (Control c in controls)
                {
                    c.Visible = true;
                }
                Flash.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;// zablokowanie możliwości zmiany rozmiaru formy                                
                this.BackgroundImage = Friends_from_MegaVideo_player.Properties.Resources.Friends_logo;
            }
            if (b == false)
            {
                foreach (Control c in controls)
                {
                    c.Visible = false;
                }
                Flash.Visible = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; //możliwość zmiany rozmiaru formy
                this.BackgroundImage = null;  //usunięcie obrazka z tła formy               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.ekino.tv/serial,przyjaciele.html"); //Otworzenie linku w domyślnej przeglądarce
        } //Otwórz link w domyślnej przeglądarce

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZapiszUstawieniaMenuItems();
            if (cmbBox.Items.Count == 0)
            {
                Friends_from_MegaVideo_player.Properties.Settings.Default.CmbBoxItemNumber = -1;
                Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
            }
            else
            {
                Friends_from_MegaVideo_player.Properties.Settings.Default.CmbBoxItemNumber = cmbBox.SelectedIndex;
                Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
            }
        } //Czynności wykonywane przy zamykaniu programu

        private void sezon1ToolStripMenuItem_CheckedChanged(object sender, EventArgs e) //Aktualizuj pasek stanu i ComboBox'a przy zmianie filtra
        {
            Stan.Items[0].Text = StatusStripChange();
            ZaładujComboBox();
            if (cmbBox.Items.Count != 0)
            {
                cmbBox.SelectedItem = cmbBox.Items[0];
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby uruchomić tryb pełnoekranowy naciśnij [F] \nAby wyłączyć tryb pełnoekranowy naciśnij [W] \nAby wyłączyć odtwarzanie naciśnij [ESC] \nAby przefiltrować sezony wciśnij klawisze od [1] do [0] \n[A] - zaznacz wszystkie filtry \n[Z] - odznacz wszystkie filtry"
                , "Skróty klawiszowe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zPlikuLokalnegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath = openFileDialog.FileName;
                Friends_from_MegaVideo_player.Properties.Settings.Default.Save();
                ZaładujComboBox();
                if (cmbBox.Items.Count != 0)
                    cmbBox.SelectedItem = cmbBox.Items[0];
            }
            toolStripStatusLabel2.Text = Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath;
        } //Otwórz plik i wyświetl odcinki w ComboBox'ie

        private void zaznaczWszystkieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem[] items = { sezon1ToolStripMenuItem, sezon2ToolStripMenuItem, sezon3ToolStripMenuItem, sezon4ToolStripMenuItem, sezon5ToolStripMenuItem,
                                             sezon6ToolStripMenuItem, sezon7ToolStripMenuItem, sezon8ToolStripMenuItem, sezon9ToolStripMenuItem, sezon10ToolStripMenuItem, odcSpecjalneToolStripMenuItem};
            foreach (ToolStripMenuItem i in items)
                i.Checked = true;
            odznaczWszyskieToolStripMenuItem.Checked = false;
        } //Zaznacz wszystkie filtry

        private void odznaczWszyskieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem[] items = { sezon1ToolStripMenuItem, sezon2ToolStripMenuItem, sezon3ToolStripMenuItem, sezon4ToolStripMenuItem, sezon5ToolStripMenuItem,
                                             sezon6ToolStripMenuItem, sezon7ToolStripMenuItem, sezon8ToolStripMenuItem, sezon9ToolStripMenuItem, sezon10ToolStripMenuItem, odcSpecjalneToolStripMenuItem};
            foreach (ToolStripMenuItem i in items)
                i.Checked = false;
            zaznaczWszystkieToolStripMenuItem.Checked = false;
        } //Odznacz wszystkie filtry

        private void btnEpisodesList_Click(object sender, EventArgs e)
        {
            XML_Viewer viewer = new XML_Viewer();
            viewer.ShowDialog();
        } //Pokaż listę odcinków z pliku XML

        private void btnToHTML_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                XPathDocument myXPathDoc = new XPathDocument(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath);
                XslTransform myXslTrans = new XslTransform(); //Musi być
                myXslTrans.Load(System.IO.Path.GetDirectoryName(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath) + @"\Przyjaciele.xsl");
                XmlTextWriter myWriter = new XmlTextWriter(saveFileDialog.FileName, Encoding.Unicode);
                myXslTrans.Transform(myXPathDoc, null, myWriter);
            }
        } //Eksportuj listę z pliku XML do HTML przy użyciu stylów z pliku XSL

        private void odtwórzNastęnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayEpisode(Friends_from_MegaVideo_player.Properties.Settings.Default.Ostatni + 1, Flash);
            this.Activate();
        } //Odtwórz kolejny odcinek (następny po ostatnio odtwarzanym)

        private void odtwórzPoprzedniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayEpisode(Friends_from_MegaVideo_player.Properties.Settings.Default.Ostatni - 1, Flash);
            this.Activate();
        }  //Odtwórz poprzedni odcinek (wcześniejszy niż ostatnio odtwarzany)      

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            string[] a = Environment.GetCommandLineArgs();
            //Przyciski Aero
            Size s = new Size(16, 16);
            buttonFirst = new ThumbnailToolbarButton(new Icon(Friends_from_MegaVideo_player.Properties.Resources.back_arrowICO, s), "Odtwórz poprzedni");
            buttonFirst.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(odtwórzPoprzedniToolStripMenuItem_Click);

            buttonSecond = new ThumbnailToolbarButton(new Icon(Friends_from_MegaVideo_player.Properties.Resources.Forward_ArrowICO, s), "Odtwórz następny");
            buttonSecond.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(odtwórzNastęnyToolStripMenuItem_Click);

            windowsTaskbar.ThumbnailToolbars.AddButtons(this.Handle, buttonFirst, buttonSecond);

            //JumpLista
            JumpList Lista = JumpList.CreateJumpList();

            IJumpListTask zadanie1 = new JumpListLink(@"E:\Gry\Moje dokumenty\Visual Studio 2010\Projects\Friends from MegaVideo player\Friends from MegaVideo player\bin\Debug\Friends from MegaVideo player.exe", "Uruchom notatnik")
            {
                IconReference = new Microsoft.WindowsAPICodePack.Shell.IconReference(@"E:\Gry\Moje dokumenty\Visual Studio 2010\Projects\Friends from MegaVideo player\Friends from MegaVideo player\bin\Debug\Friends from MegaVideo player.exe", 0),
                Title = @"c:\widnows\notepad.exe"
            };
            Lista.AddUserTasks(zadanie1);
            Lista.Refresh();
        }
    }
}