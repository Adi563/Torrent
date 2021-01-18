namespace Torrent.Convert
{
    using System.Linq;

    public class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="torrentInformation"></param>
        /// <returns></returns>
        public static string GetMagnetLinkByTorrentInformation(TorrentInformation torrentInformation)
        {
            return GetMagnetLinkByHashAndTrackers(torrentInformation.Hash, torrentInformation.Trackers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="trackers"></param>
        /// <returns></returns>
        public static string GetMagnetLinkByHashAndTrackers(System.Collections.Generic.IEnumerable<byte> hash, System.Collections.Generic.IEnumerable<string> trackers)
        {
            if (hash.Count() != 20) { throw new System.ArgumentException("Hash length must be 20", "hash"); }

            var hashString = string.Concat(hash.Select(h => h.ToString("X2")).ToArray());

            return GetMagnetLinkByHashAndTrackers(hashString, trackers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="trackers"></param>
        /// <returns></returns>
        public static string GetMagnetLinkByHashAndTrackers(string hash, System.Collections.Generic.IEnumerable<string> trackers)
        {
            const string pattern = "magnet:?xt=urn:btih:{0}{1}";
            
            System.Collections.Generic.IEnumerable<string> trackersEscaped = trackers.Select(t => "&tr=" + System.Uri.EscapeUriString(t));
            string trackersJoined = string.Concat(trackersEscaped.ToArray());

            string magnetUrl = string.Format(pattern, hash, trackersJoined);

            return magnetUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="magnetLink"></param>
        /// <returns></returns>
        public static TorrentInformation GetTorrentInformationByMagnetLink(string magnetLink)
        {
            var uri = new System.Uri(magnetLink);

            var elements = uri.PathAndQuery.Split(new string[] { "?", "&" }, System.StringSplitOptions.RemoveEmptyEntries);

            const string hashTag = "xt=urn:btih:";
            var elementHash = elements.First(e => e.StartsWith(hashTag));
            string hashString = elementHash.Substring(hashTag.Length).ToUpper();
            var hash = StringToByteArray(hashString);


            const string trackerTag = "tr=";
            var elementsTracker = elements.Where(e => e.StartsWith(trackerTag)).Select(e => e.Substring(trackerTag.Length)).Select(e => System.Uri.UnescapeDataString(e));

            return new TorrentInformation
            {
                Hash = hash,
                Trackers = elementsTracker
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static System.Collections.Generic.IEnumerable<byte> StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => System.Convert.ToByte(hex.Substring(x, 2), 16));
        }
    }
}