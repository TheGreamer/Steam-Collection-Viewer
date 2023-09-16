#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamCollectionApp.Properties;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Security.Policy;
#endregion

namespace SteamCollectionApp
{
    public partial class MainForm : Form
    {
        #region Fields
        private int formWidth;
        private readonly Settings settings;
        private readonly List<string> urls;
        private readonly List<Control> controls;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            formWidth = Width;
            settings = new Settings();
            urls = new List<string>();
            controls = new List<Control> { labelCollectionName, labelFavCount, labelGeneratorName, labelItemCount, labelPostDate, labelUniqueFavCount, labelUpdateDate, labelVisitorCount, pictureBox, textBoxSearch, buttonSearch, buttonGoBack, webBrowser, listBoxItems };
        }
        #endregion

        #region Methods
        private void ClearControls(bool showMessage = true, string message = "Koleksiyon bulunamadı.")
        {
            pictureBox.Image = null;
            listBoxItems.Items.Clear();
            urls.Clear();

            foreach (Control control in controls.Where(c => c is Label))
            {
                control.Text = "...";
            }

            if (showMessage)
            {
                MessageBox.Show(message, "Steam Koleksiyon Görüntüleyici", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowControls(bool isVisible, string url = null)
        {
            foreach (Control control in Enumerable.Reverse(controls).Skip(3).Reverse().ToList())
            {
                control.Visible = isVisible;
            }

            foreach (Control control in controls.Where(c => (string)c.Tag == "Browser"))
            {
                control.Visible = !isVisible;
            }

            if (!isVisible)
            {
                webBrowser.Navigate(url);
            }
        }

        private void PlaceHolder(TextBox textBox, bool isEnabled, string placeHolderText)
        {
            if (isEnabled)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeHolderText;
                }
            }
            else
            {
                if (textBox.Text.Equals(placeHolderText) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Clear();
                }
            }
        }

        private async Task<bool> GetCollection(string collectionId)
        {
            int charCount = collectionId.Count();

            if (!(charCount > 8 && charCount < 11) || !collectionId.All(char.IsDigit))
            {
                MessageBox.Show("Bir koleksiyon numarası girmelisiniz.", "Steam Koleksiyon Görüntüleyici", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string url = $"https://steamcommunity.com/sharedfiles/filedetails/?id={collectionId}";
            HttpClient httpClient = new HttpClient();

            try
            {
                string html = await httpClient.GetStringAsync(url);
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                int counter = 0;
                string xpathForCreator = "//div[@class='friendBlockContent']";
                string xpathForPicture = "//*[@id=\"CollectionBackgroundImage\"]";
                string xpathForItems = "//div[@class='workshopItemTitle']";
                string xpathForLeftDetails = "//div[@class='detailsStatLeft']";
                string xpathForRightDetails = "//div[@class='detailsStatRight']";
                string xpathForItemUrls = "//div[contains(@id, 'sharedfile_')]/div[2]/a";
                string xpathForCollectionCheck = "//a[contains(@class, 'sectionTab  changelog')]";

                string creator = htmlDocument.DocumentNode.SelectSingleNode(xpathForCreator)?.InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("Online", " - Çevrimiçi").Replace("Offline", " - Çevrimdışı");
                string picture = htmlDocument.DocumentNode.SelectSingleNode(xpathForPicture)?.Attributes["src"].Value;
                HtmlNodeCollection items = htmlDocument.DocumentNode.SelectNodes(xpathForItems);
                HtmlNodeCollection leftDetails = htmlDocument.DocumentNode.SelectNodes(xpathForLeftDetails);
                HtmlNodeCollection rightDetails = htmlDocument.DocumentNode.SelectNodes(xpathForRightDetails);
                HtmlNodeCollection itemUrls = htmlDocument.DocumentNode.SelectNodes(xpathForItemUrls);
                HtmlNode collectionCheck = htmlDocument.DocumentNode.SelectSingleNode(xpathForCollectionCheck);

                foreach (HtmlNode itemUrl in itemUrls)
                {
                    urls.Add(itemUrl.Attributes["href"].Value);
                }

                if (items == null)
                {
                    MessageBox.Show("Aradığınız numaraya ait bir koleksiyon yoktur.", "Steam Koleksiyon Görüntüleyici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (collectionCheck != null)
                {
                    MessageBox.Show("Aradığınız numara bir koleksiyon değil atölye öğesidir.", "Steam Koleksiyon Görüntüleyici", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                labelGeneratorName.Text = $"Koleksiyon Sahibi: {creator}";
                labelItemCount.Text = $"Öğeler: {items.Count - 1}";
                labelVisitorCount.Text = $"Tekil Ziyaretçi: {leftDetails[0].InnerText}";
                labelFavCount.Text = $"Mevcut Favoriler: {leftDetails[1].InnerText}";
                labelUniqueFavCount.Text = $"Toplam Eşsiz Favori: {leftDetails[2].InnerText}";
                labelPostDate.Text = $"Gönderilme Tarihi: {rightDetails[3].InnerText.Replace("@", "")}";
                labelUpdateDate.Text = $"Güncellenme Tarihi: {rightDetails[4].InnerText.Replace("@", "")}";
                pictureBox.Image = picture == null ? null : Image.FromStream(WebRequest.Create(picture).GetResponse().GetResponseStream());

                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        string title = items[i].InnerText;

                        if (counter == 0)
                        {
                            labelCollectionName.Text = $"Koleksiyon Adı: {title}";
                            counter++;
                            continue;
                        }

                        listBoxItems.Items.Add(title);
                    }
                    return true;
                }
                else
                {
                    ClearControls();
                    return false;
                }
            }
            catch
            {
                ClearControls();
                return false;
            }
        }
        #endregion

        #region Events
        private void MainFormOnLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < settings.Numbers.Count; i++)
            {
                listBoxNumbers.Items.Add(settings.Numbers[i]);
            }
        }

        private void MainFormOnSizeChanged(object sender, EventArgs e)
        {
            listBoxItems.Width += Width - formWidth;
            formWidth = Width;
        }

        private void TextBoxSearchOnEnter(object sender, EventArgs e)
        {
            PlaceHolder(textBoxSearch, false, "Numara...");
        }

        private void TextBoxSearchOnLeave(object sender, EventArgs e)
        {
            PlaceHolder(textBoxSearch, true, "Numara...");
        }

        private void ListBoxItemsOnSelectedValueChanged(object sender, EventArgs e)
        {
            ShowControls(false, urls[listBoxItems.SelectedIndex]);
        }

        private void ListBoxNumbersOnSelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = listBoxNumbers.SelectedItem.ToString();
        }

        private void ButtonGoBackOnClick(object sender, EventArgs e)
        {
            ShowControls(true);
        }

        private async void ButtonSearchOnClick(object sender, EventArgs e)
        {
            ClearControls(false);
            string number = textBoxSearch.Text;
            bool state = await GetCollection(number);

            if (state)
            {
                if (!settings.Numbers.Contains(number))
                {
                    listBoxNumbers.Items.Add(number);
                    settings.Numbers.Add(number);
                    settings.Save();
                }
            }
        }
        #endregion
    }
}