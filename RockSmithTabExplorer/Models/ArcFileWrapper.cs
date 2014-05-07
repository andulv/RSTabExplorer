using AlphaTab.Model;
using Newtonsoft.Json;
using RockSmithTabExplorer.Utils;
using RocksmithToolkitLib;
using RocksmithToolkitLib.DLCPackage;
using RocksmithToolkitLib.DLCPackage.Manifest;
using RocksmithToolkitLib.PSARC;
using RocksmithToolkitLib.Sng2014HSL;
using RocksmithToolkitLib.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace RockSmithTabExplorer
{
    public class ArcFileWrapper : IDisposable
    {
        readonly PSARC _psarc;
        readonly string _archiveFile;

        public ArcFileWrapper(string archiveFile)
        {
            _psarc = new PSARC();
            _archiveFile = archiveFile;
            using (var inputStream = System.IO.File.OpenRead(archiveFile))
            {
                _psarc.Read(inputStream);
            }
        }


        //RockSmithTrack har flere levels, vi lager alphatab track utifra et bestemt level
        public IList<RSSongInfo> GetAllSongInfos()
        {
            var src = _psarc.Entries.Where(x => x.Name.StartsWith(@"manifests/songs") && x.Name.EndsWith(".json"))
                .OrderBy(x => x.Name);

            var retValue = new List<RSSongInfo>();
            RSSongInfo currentSongInfo = null;

            foreach (var entry in src)
            {
                var entryName = System.IO.Path.GetFileNameWithoutExtension(entry.Name);
                var splitPoint = entryName.LastIndexOf('_');
                var entrySongKey = entryName.Substring(0, splitPoint);
                var entryArrangmentName = entryName.Substring(splitPoint+1);

                if (currentSongInfo == null || entrySongKey != currentSongInfo.Key)
                {
                    string song_name, album_name, artist_name, song_year;
                    using (var wrappedStream = new NonClosingStreamWrapper(entry.Data))
                    {
                        using (var reader = new StreamReader(wrappedStream))
                        {
                            string json = reader.ReadToEnd();
                            JObject o = JObject.Parse(json);
                            var attributes = o["Entries"].First.Last["Attributes"];

                            song_name = attributes["SongName"].ToString();
                            album_name = attributes["AlbumName"].ToString();
                            artist_name = attributes["ArtistName"].ToString();
                            song_year = attributes["SongYear"].ToString();
                        }
                    }

                    currentSongInfo = new RSSongInfo() { Key = entrySongKey, TrackInfos = new List<RSTrackInfo>(), SongName = song_name, AlbumName = album_name, ArtistName = artist_name, SongYear = song_year };
                    retValue.Add(currentSongInfo);
                }
                var arrangmentInfo = new RSTrackInfo() { Name = entryArrangmentName, FileSize = entry.Length };
                currentSongInfo.TrackInfos.Add(arrangmentInfo);
            }

            return retValue;
        }

        public TrackDetail GetTrackDetail(string songKey, string arrangmentName)
        {
            var sngEntry=_psarc.Entries.FirstOrDefault(x =>x.Name == @"songs/bin/generic/" + songKey + "_" + arrangmentName + ".sng");
            var jsonEntry = _psarc.Entries.FirstOrDefault(x => x.Name.StartsWith(@"manifests/songs") && x.Name.EndsWith("/" + songKey + "_" + arrangmentName + ".json"));
            if (sngEntry == null || jsonEntry == null)
            {
                return null;
            }

            Attributes2014 att;
            using (var wrappedStream = new NonClosingStreamWrapper(jsonEntry.Data))
            {
                using (var reader = new StreamReader(wrappedStream))
                {
                    var manifest = JsonConvert.DeserializeObject<Manifest2014<Attributes2014>>(reader.ReadToEnd());
                    att = manifest.Entries.ToArray()[0].Value.ToArray()[0].Value;
                }               
            }

            Sng2014File sngFile;
            using (var wrappedStream = new NonClosingStreamWrapper(sngEntry.Data))
            {
                var platform = _archiveFile.GetPlatform();
                sngFile = Sng2014File.ReadSng(wrappedStream, platform);
            }
            var sngObject = new Song2014(sngFile,att);
            return new TrackDetail() { RockSmithSong = sngObject };
        }
        
        public void Dispose()
        {
        }
    }

    public class TrackDetail
    {
        public Song2014 RockSmithSong { get; set; }
    }

    public class RSSongInfo
    {
        public string Key { get; set; }
        public string SongName { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string SongYear { get; set; }

        public IList<RSTrackInfo> TrackInfos { get; set; }
    }

    public class RSTrackInfo
    {
        public string Name { get; set; }
        public ulong FileSize { get; set; }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }

}
