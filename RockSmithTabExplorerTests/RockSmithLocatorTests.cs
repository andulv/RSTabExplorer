using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using RockSmithTabExplorer;

namespace RockSmithTabExplorerTests
{
    /// <summary>
    /// Test that the locator can find the main steam folder, steam library folders, and Rocksmith2014 folder.
    /// </summary>
    [TestClass]
    public class RockSmithLocatorTests
    {
        public RockSmithLocatorTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ItFindsSteamFolder()
        {
            Assert.IsNotNull(RocksmithLocator.SteamFolder(), "No key found");
            StringAssert.Matches(RocksmithLocator.SteamFolder(), new Regex("steam", RegexOptions.IgnoreCase));
        }

        [TestMethod]
        public void ItFindsMainFolder()
        {
            Assert.IsNotNull(RocksmithLocator.LibraryFolders().FirstOrDefault(p => p.Contains("Program Files")));
        }

        [TestMethod]
        public void ItFindsSecondaryLibraryFolder()
        {
            Assert.IsNotNull(RocksmithLocator.LibraryFolders().FirstOrDefault(p => p.Contains("SteamLibrary")));
        }

        [TestMethod]
        public void ItFindsRocksmith2014Folder()
        {
            StringAssert.Matches(RocksmithLocator.Rocksmith2014Folder(), new Regex("Rocksmith2014"));
        }
    }
}
