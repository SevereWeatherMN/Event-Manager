# Change Log
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/) 
and this project adheres to [Semantic Versioning](http://semver.org/).

## 0.4.2 - 2017-9-27
### Added
- Date section on Field Note Generator is a series of dropdown menus
- Time Zone selected in settings now shows up in exported text file

### Changed
- Network directory error is more specific

### Known Problems
- Location service extrmely unreliable, works 1/3 times, will need work
- The program may overwrite server files
- Date Does not show up in text file, will be worked out soon

## 0.4.1 - 2017-9-24
### Changed
- Formatted Time Zone List, does not yet update text file, will soon

## 0.4.0 - 2017-9-24
### Added
- Automatic location detection to add to text file in Field Note Generator. Must have location service enabled to function correctly.
- Automatic time detection - takes system time and adds to text file. Time zone should be selected in settings. Doesn't write to text file yet, will soon.

### Changed
- Modified Field Note Generator GUI, more updates pending for better workflow

## 0.3.3 - 2017-4-10
### Added
- Attempted to prevent overwriting field notes that already exist on the server - however, this doesn't function properly yet 

### Changed
- Adjusted descriptions in Weather Event Archive Builder and Field Note Generator
- Adjusted tooltips in archive builder

## 0.3.2 - 2017-4-9
### Added
- Try-Catch block to account for unavailable network location (More exceptions need to be caught)
- Obsolete tooltips adjusted to describe field notes instead of storm reports
- Added icons to forms that didn't have them
- Named help form "Weather Event Manager Help", no valid name previously entered
- Added tooltips and more information in settings window to streamline its use


## 0.3.1 - 2017-3-13
### Added
- Saved input on field note generator
- FTP Uploading works correctly on field note generator


## 0.3.0 - 2017-3-13
### Added
- Got uploading on Archive Builder straightened out and finished
- Got uploading on Field Note Generator straightened out as well (for the most part)
- Credentials saved in Archive Builder

## 0.2.7 - 2017-1-15
### Added
- New Icon: black tornado, blue-green background
- Adjusted the contents of the help page
- Adjusted tooltips
- Added default name format template in settings
- Added source code for printing, doesn't work quite yet

## 0.2.6 - 2017-1-7
### Added
- Navigation buttons to main forms
- Tooltips on Field Note Generator

### Changed
- Renamed Storm Report Generator to Field Note Generator; this offers a more flexible platform of data collections
- Issues arose with file compression and management in archive manager

## 0.2.5 - 2016-12-30
### Added
- Full functionality to archive builder-uploads work 
- Settings window has full functionality
- Minor text output file changes in Storm Report Generator

### Changed

## 0.2.1 - 2016-12-27
### Added
- Help window has been designed and has all the required information
- Help buttons now work on all forms
- Minor changes to output text file in Storm Report Generator
- Updated date and version in "about" form
- Printer dialog shows up in help form, however it doesn't print properly

### Changed
- Fixed nonworking file --> exit buttons

## 0.2.0 - 2016-12-27
### Added
- Zip file is produced with name set in settings, all information selected is included
- Home buttons added under "file" in all forms-they bring you back to the welcome window and work properly
- Added FTP server functionality, address must be entered in code and files to be transferred is not set up yet

## 0.1.0 - 2016-12-26
### Added
- Archive creator now copies selected files to c:/tmp
- Exit button functions on Archive Creator
- New option in settings window: default archive name format
- Name is assigned to the archive
- Added "home" button under file menu to let the user return to the welcome window

### Changed
- Minor error fixed due to multiple voids of Archive_Builder_Load

## 0.0.8 - 2016-12-13
### Added
- Output Filename text box in Archive Builder

### Changed
- Error discovered in the line that deactivates the browse buttons when the form runs- glitch allowed it to go unnoticed, needs correction


## 0.0.7 - 2016-12-08
### Added
-
### Removed
- Storm Report Generator - removed browse button on "Select Network Location"
### Changed
- Storm Report Generator - Changed "Select Network Location" to "Enter Network Location"
- Storm Report Generator - Changed Print button on menu bar to a settings button, as print will likely not be used
- About window - Updated build, finally changed date

## 0.0.6 - 2016-12-07
### Added
- Toolbar to Archive creator - settings button is functional
- changed Storm report generator to set the text file location
- Changed output text file slightly

## 0.0.5 - 2016-12-06
### Added
- Settings window now has a functionless GUI
- Data Archive Creator's browse buttons function properly

[Unreleased]: Unreleased
[0.0.1]: No location for application yet
