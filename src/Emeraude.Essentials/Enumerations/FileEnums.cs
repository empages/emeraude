namespace Emeraude.Essentials.Enumerations;

/// <summary>
/// Provides the main types of files.
/// </summary>
public enum FileTypes
{
    Text = 1,
    Audio = 2,
    Compressed = 3,
    Disc = 4,
    Data = 5,
    Executable = 6,
    Font = 7,
    Image = 8,
    InternetRelated = 9,
    Presentation = 10,
    Programming = 11,
    Spreadsheet = 12,
    SystemRelated = 13,
    Video = 14,
}

/// <summary>
/// Provides the main file extensions.
/// </summary>
public enum FileExtensions
{
    //Text
    _Doc = 1001, //.doc - Microsoft Word file
    _Docx = 1002, //.docx - Microsoft Word file
    _Odt = 1003, //.odt - OpenOffice Writer document file
    _Pdf = 1004, //.pdf - PDF file
    _Rtf = 1005, //.rtf - Rich Text Format
    _Tex = 1006, //.tex - A LaTeX document file
    _Txt = 1007, //.txt - Plain text file
    _Wks = 1008, //.wks - Microsoft Works file
    _Wps = 1009, //.wps - Microsoft Works file
    _Wpd = 1010, //.wpd - WordPerfect document

    //Audio
    _Aif = 1101, //.aif - AIF audio file
    _Cda = 1102, //.cda - CD audio track file
    _Mid = 1103, //.mid - MIDI audio file
    _Midi = 1104, //.midi - MIDI audio file
    _Mp3 = 1105, //.mp3 - MP3 audio file
    _Mpa = 1106, //.mpa - MPEG-2 audio file
    _Ogg = 1107, //.ogg - Ogg Vorbis audio file
    _Wav = 1108, //.wav - WAV file
    _Wma = 1109, //.wma - WMA audio file
    _Wpl = 1110, //.wpl - Windows Media Player playlist

    //Compressed
    _7z = 1201, //.7z - 7-Zip compressed file
    _Arj = 1202, //.arj - ARJ compressed file
    _Deb = 1203, //.deb - Debian software package file
    _Pkg = 1204, //.pkg - Package file
    _Rar = 1205, //.rar - RAR file
    _Rpm = 1206, //.rpm - Red Hat Package Manager
    _TarGz = 1207, //.tar.gz - Tarball compressed file
    _Z = 1208, //.z - Z compressed file
    _Zip = 1209, //.zip - Zip compressed file

    //Disc
    _Bin = 1301, //.bin - Binary disc image, Binary file
    _Dmg = 1302, //.dmg - macOS X disk image
    _Iso = 1303, //.iso - ISO disc image
    _Toast = 1304, //.toast - Toast disc image
    _Vcd = 1305, //.vcd - Virtual CD

    //Data
    _Csv = 1401, //.csv - Comma separated value file
    _Dat = 1402, //.dat - Data file
    _Db = 1403, //.db - Database file
    _Dbf = 1404, //.dbf - Database file
    _Log = 1405, //.log - Log file
    _Mdb = 1406, //.mdb - Microsoft Access database file
    _Sav = 1407, //.sav - Save file (e.g., game save file)
    _Sql = 1408, //.sql - SQL database file
    _Tar = 1409, //.tar - Linux / Unix tarball file archive
    _Xml = 1410, //.xml - XML file

    //Executable
    _Apk = 1501, //.apk - Android package file
    _Bat = 1502, //.bat - Batch file
    _Cgi = 1503, //.cgi - Perl script file
    _Pl = 1504, //.pl - Perl script file
    _Com = 1505, //.com - MS-DOS command file
    _Exe = 1506, //.exe - Executable file
    _Gadget = 1507, //.gadget - Windows gadget
    _Jar = 1508, //.jar - Java Archive file
    _Wsf = 1509, //.wsf - Windows Script File

    //Font
    _Fnt = 1601, //.fnt - Windows font file
    _Fon = 1602, //.fon - Generic font file
    _Otf = 1603, //.otf - Open type font file
    _Ttf = 1604, //.ttf - TrueType font file

    //Image
    _Ai = 1701, //.ai - Adobe Illustrator file
    _Bmp = 1702, //.bmp - Bitmap image
    _Gif = 1703, //.gif - GIF image
    _Ico = 1704, //.ico - Icon file
    _Jpeg = 1705, //.jpeg - JPEG image
    _Jpg = 1706, //.jpg - JPEG image
    _Png = 1707, //.png - PNG image
    _Ps = 1708, //.ps - PostScript file
    _Psd = 1709, //.psd - PSD image
    _Svg = 1710, //.svg - Scalable Vector Graphics file
    _Tif = 1711, //.tif - TIFF image
    _Tiff = 1712, //.tiff - TIFF image
    _Eps = 1713, //.eps - Encapsulated PostScript

    //Internet related
    _Asp = 1801, //.asp - Active Server Page file
    _Aspx = 1802, //.aspx - Active Server Page file
    _Cer = 1803, //.cer - Internet security certificate
    _Cfm = 1804, //.cfm - ColdFusion Markup file
    _Css = 1805, //.css - Cascading Style Sheet file
    _Htm = 1806, //.htm - HTML file
    _Html = 1807, //.html - HTML file
    _Js = 1808, //.js - JavaScript file
    _Jsp = 1809, //.jsp - Java Server Page file
    _Part = 1810, //.part - Partially downloaded file
    _Php = 1811, //.php - PHP file
    _Py = 1812, //.py - Python file
    _Rss = 1813, //.rss - RSS file
    _Xhtml = 1814, //.xhtml - XHTML file

    //Presentation
    _Key = 1901, //.key - Keynote presentation
    _Odp = 1902, //.odp - OpenOffice Impress presentation file
    _Pps = 1903, //.pps - PowerPoint slide show
    _Ppt = 1904, //.ppt - PowerPoint presentation
    _Pptx = 1905, //.pptx - PowerPoint Open XML presentation

    //Programming
    _C = 2001, //.c - C and C++ source code file
    _Class = 2002, //.class - Java class file
    _Cpp = 2003, //.cpp - C++ source code file
    _Cs = 2004, //.cs - Visual C# source code file
    _H = 2005, //.h - C, C++, and Objective-C header file
    _Java = 2006, //.java - Java Source code file
    _Sh = 2007, //.sh - Bash shell script
    _Swift = 2008, //.swift - Swift source code file
    _Vb = 2009, //.vb - Visual Basic file

    //Spreadsheet
    _Ods = 2101, //.ods - OpenOffice Calc spreadsheet file
    _Xlr = 2102, //.xlr - Microsoft Works spreadsheet file
    _Xls = 2103, //.xls - Microsoft Excel file
    _Xlsx = 2104, //.xlsx - Microsoft Excel Open XML spreadsheet file

    //System related
    _Bak = 2201, //.bak - Backup file
    _Cab = 2202, //.cab - Windows Cabinet file
    _Cfg = 2203, //.cfg - Configuration file
    _Cpl = 2204, //.cpl - Windows Control panel file
    _Cur = 2205, //.cur - Windows cursor file
    _Dll = 2206, //.dll - DLL file
    _Dmp = 2207, //.dmp - Dump file
    _Drv = 2208, //.drv - Device driver file
    _Icns = 2209, //.icns - macOS X icon resource file
    _Ini = 2210, //.ini - Initialization file
    _Lnk = 2211, //.lnk - Windows shortcut file
    _Msi = 2212, //.msi - Windows installer package
    _Sys = 2213, //.sys - Windows system file
    _Tmp = 2214, //.tmp - Temporary file

    //Video
    _3g2 = 2301, //.3g2 - 3GPP2 multimedia file
    _3gp = 2302, //.3gp - 3GPP multimedia file
    _Avi = 2303, //.avi - AVI file
    _Flv = 2304, //.flv - Adobe Flash file
    _H264 = 2305, //.h264 - H.264 video file
    _M4v = 2306, //.m4v - Apple MP4 video file
    _Mkv = 2307, //.mkv - Matroska Multimedia Container
    _Mov = 2308, //.mov - Apple QuickTime movie file
    _Mp4 = 2309, //.mp4 - MPEG4 video file
    _Mpg = 2310, //.mpg - MPEG video file
    _Mpeg = 2311, //.mpeg - MPEG video file
    _Rm = 2312, //.rm - RealMedia file
    _Swf = 2313, //.swf - Shockwave flash file
    _Vob = 2314, //.vob - DVD Video Object
    _Wmv = 2315, //.wmv - Windows Media Video file
}