![RSTabExplorer](/Screenshot1.JPG?raw=true "RSTabExplorer")

View Rocksmith 2014 songs (built in, DLC or custom DLC) as tablature

# Features
* Loads Rocksmith 2014 .psarc archives. Lists all songs and tracks (arrangements) present in archive.
* Displays track as tablature / score.

# Credits
* Uses alphaTab (https://github.com/CoderLine/alphaTab) for modeling and rendering of tracks
* Uses RocksmithToolkitLib from 'Rocksmith Custom Toolkit' to parse archives and songs (https://github.com/rscustom/rocksmith-custom-song-toolkit)
* The application itself is built upon GDI WPF sample application from alphaTab.
 
# Status (v0.0.4 - 2014-05-04)
* Working for most Rocksmith 2014 PC files
* Not much error handling. Will probably crash and burn at slighest hint of failure.
* No progress / busy indicators. UI locks up while rendering score
* Notes (fret/strings) should be mostly correct
* Rhytm notation is pretty bad. Prepare for weird combinations of eighth and quarter notes. :)
* Sustain (let ring, extended notes, etc.) is not supported (Sustain info from Rocksmith files are ignored)
* Some effects should be translated correctly (accent, slides) but most are ignored
* Hammerons / Pullofs are not fully supported. May be due to a bug in alphaTab. Bug report is filed.

# Dependencies
RocksmithToolkitLib 2.5 (and its dependencies) are in the lib\ folder.
AlphaTab dll is also in the lib folder.
NuGet is needed to load MvvmLightLibs, CommonServiceLocator (IoC), and Costura.Fody (Bakes all dlls into the main exe).

Solution should build on VS2010 or later with Framework 4.0 out of the box.
