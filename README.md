![RSTabExplorer](https://raw.githubusercontent.com/andulv/RSTabExplorer/master/Screenshot1.JPG "RSTabExplorer")

View Rocksmith 2014 songs (built in, DLC or custom DLC) as tablature

# Features
* Loads Rocksmith 2014 .psarc archives. Lists all songs and tracks (arrangements) present in archive.
* Displays track as tablature / score.

# Credits
* Uses alphaTab (https://github.com/CoderLine/alphaTab) for modeling and rendering of tracks
* Uses RocksmithToolkitLib from 'Rocksmith Custom Toolkit' to parse archives and songs (https://github.com/rscustom/rocksmith-custom-song-toolkit)
* The application itself is built upon GDI WPF sample application from alphaTab.
 
# Status (v0.1 - 2014-04-19)
* Is basically working for almost all Rocksmith 2014 PC files I have tested with
* No error handling. Will probably crash and burn at slighest hint of failure.
* Single threaded, and no progress / busy indicators. UI locks up while performing operations (parsing .psarc, rendering score, etc.)
* Notes (fret/strings) should be correct. 
* Notes also appear in the right bar (measure) in the right sequence.
* But rhytm notation is pretty bad. Prepare for weird combinations of eighth and quarter notes. :)
* Sustain (let ring, extended notes, etc.) is not supported (Sustain info from Rocksmith files are ignored)
* Some effects should be translated correctly (accent, slides) but most are ignored
* Hammerons / Pullofs are not supported. May be due to a bug in alphaTab. Bug report is filed.

# Dependencies
RocksmithToolkitLib 2.5 (and its dependencies) are in the lib\ folder.
alphaTab core is included as C# source. Taken from https://github.com/CoderLine/alphaTab/releases/download/v0.3.0/DotNet.zip
(I have made one minor patch to the sourcecode, to fix a memory leak).

No additional dependencies. Solution should build on VS2012 with Framework 4.5 out of the box.
