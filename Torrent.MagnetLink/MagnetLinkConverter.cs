using System;
using System.Linq;
using System.Windows.Forms;

namespace Torrent.MagnetLink
{
    public partial class MagnetLinkConverter : Form
    {
        public MagnetLinkConverter()
        {
            InitializeComponent();
        }

        private void buttonConvertMagnetLinkToTorrentInformation_Click(object sender, EventArgs e)
        {
            var torrentInformation = Convert.Converter.GetTorrentInformationByMagnetLink(textBoxMagnetLink.Text);

            textBoxHash.Text = string.Concat(torrentInformation.Hash.Select(h => h.ToString("X2")).ToArray());

            textBoxTrackers.Text = string.Join("\r\n", torrentInformation.Trackers);
        }

        private void buttonConvertTorrentInformationToMagnetLink_Click(object sender, EventArgs e)
        {
            var hash = Convert.Converter.StringToByteArray(textBoxHash.Text);
            var trackers = textBoxTrackers.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            string magnetLink = Convert.Converter.GetMagnetLinkByHashAndTrackers(hash, trackers);

            textBoxMagnetLink.Text = magnetLink;
        }
    }
}
