using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockSmithTabExplorer.ViewModel;
using RockSmithTabExplorer;

namespace RockSmithTabExplorerTests
{
    [TestClass]
    public class GuitarPathTests
    {
        private RSTrackInfo testPathWithTracks(string pathName, string[] tracks)
        {
            GuitarPath path = new GuitarPath(pathName);
            var trackList = new List<RSTrackInfo>();
            foreach(var track in tracks)
            {
                trackList.Add(new RSTrackInfo() { Name = track });
            }
            return path.pickTrack(trackList);
        }

        [TestMethod]
        public void ItReturnsBassWhenAvaliable()
        {
            var track = testPathWithTracks("bass", new string[] { "vocals", "combo","bass" });
            StringAssert.StartsWith(track.Name, "bass");
        }

        [TestMethod]
        public void ItDoesntFailWhenNoPreferenceFound()
        {
            var track = testPathWithTracks("bass", new string[] { "jimi_hendrix" });
            Assert.IsNotNull(track);
        }

        [TestMethod]
        public void ItUsesNextOptionWhenPreferenceMissing()
        {
            var track = testPathWithTracks("bass", new string[] { "vocals", "combo" });
            StringAssert.StartsWith(track.Name, "combo");
        }
    }
}
