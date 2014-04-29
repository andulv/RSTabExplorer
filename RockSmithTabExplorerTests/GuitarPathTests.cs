using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockSmithTabExplorer.ViewModel;
using AlphaTab.src.alphatab.importer;

namespace RockSmithTabExplorerTests
{
    [TestClass]
    public class GuitarPathTests
    {
        [TestMethod]
        public void ItReturnsBassWhenAvaliable()
        {
            GuitarPath path = new GuitarPath("bass");
            var trackList = new List<RSTrackInfo> { new RSTrackInfo() { Name = "vocals" }, new RSTrackInfo() { Name = "bass" } };
            var track = path.pickTrack(trackList);
            StringAssert.StartsWith(track.Name, "bass");
        }

        [TestMethod]
        public void ItDoesntFailWhenNoPreferenceFound()
        {
            GuitarPath path = new GuitarPath("bass");
            var trackList = new List<RSTrackInfo> { new RSTrackInfo { Name = "jimi_hendrix" } };
            var track = path.pickTrack(trackList);
            Assert.IsNotNull(track);
        }
    }
}
