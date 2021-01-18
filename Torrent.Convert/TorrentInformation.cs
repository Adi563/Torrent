namespace Torrent.Convert
{
    public class TorrentInformation
    {
        public System.Collections.Generic.IEnumerable<byte> Hash { get; set; }
        public System.Collections.Generic.IEnumerable<string> Trackers { get; set; }
    }
}