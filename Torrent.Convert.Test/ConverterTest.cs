using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Torrent.Convert.Test
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void GetMagnetLinkByHashStringAndTrackers()
        {
            string magnetLink = Converter.GetMagnetLinkByHashAndTrackers("f8a98ae76f45883c61d185791c607d50609cbfab", new string[] { "udp://open.demonii.com:1337/announce", "http://tracker.torrenty.org:6969/announce" });

            Assert.AreEqual(@"magnet:?xt=urn:btih:f8a98ae76f45883c61d185791c607d50609cbfab&tr=udp://open.demonii.com:1337/announce&tr=http://tracker.torrenty.org:6969/announce", magnetLink);
        }

        [TestMethod]
        public void GetMagnetLinkByHashAndTrackers()
        {
            string magnetLink = Converter.GetMagnetLinkByHashAndTrackers(new byte[] { 0xF8, 0xA9, 0x8A, 0xE7, 0x6F, 0x45, 0x88, 0x3C, 0x61, 0xD1, 0x85, 0x79, 0x1C, 0x60, 0x7D, 0x50, 0x60, 0x9C, 0xBF, 0xAB }, new string[] { "udp://open.demonii.com:1337/announce", "http://tracker.torrenty.org:6969/announce" });

            Assert.AreEqual(@"magnet:?xt=urn:btih:f8a98ae76f45883c61d185791c607d50609cbfab&tr=udp://open.demonii.com:1337/announce&tr=http://tracker.torrenty.org:6969/announce", magnetLink);
        }

        [TestMethod]
        public void GetTorrentInformationByMagnetLink()
        {
            var torrentInformation = Converter.GetTorrentInformationByMagnetLink(@"magnet:?xt=urn:btih:06c2763be04597ee95eab3368b88387bd7648707&dn=KARAKARA.Incl.Adult.Only.Content-DARKSiDERS&tr=http%3A%2F%2Ftracker.trackerfix.com%3A80%2Fannounce&tr=udp%3A%2F%2F9.rarbg.me%3A2710&tr=udp%3A%2F%2F9.rarbg.to%3A2710");
        }
    }
}