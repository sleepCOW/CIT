# CIT (Comment insert tool)
 *The Tool that allows you to insert comments on top of your source files*
* * *

*   Quick Start
*   Usage
*   Contact me

# Quick Start
*To start you need either download executable(available for windows) or build programm from source.*

## 1. Download executable for Windows
Use this links:
> [**x64 version**](https://sourceforge.net/projects/commentinserttool/files/CIT_x64.rar/download)  
> [**x32 version**](https://sourceforge.net/projects/commentinserttool/files/CIT_x32.rar/download)  
<pre>
You can add path to your exectuable to PATH variables for conviency</pre>

## 2. Build sources
**Build using Visual Studio**
1. Clone or download project  
2. Launch .sln file (Visual studio solution)  
3. Make sure **C++17** is enabled `Project->Properties->Configuration Properties->General->C++ Language Standard`  
4. Ctrl + Shift + B to Build or  `Build->Build Solution`  

**Build from source**  
Coming soon...  
  

# Usage
 
## One or more files

CIT can insert into one or more exact files with following command:  
**Note! Due to how filesystem behaves you need to fill full path to your file or you must be in the same folder with needed file**
<pre>
CIT path/file1.extension path/file2.extension "Comment to paste" "Another comment"
</pre>
**Examples**
<pre>
PS F:\PetProjects\CIT_Release> CIT some.cpp "First line" "Second line"
</pre>
*Content of some.cpp file:*
<pre>
First line
Second line
----FILE CONTENT----
</pre>

## Work with directories
*Cit allows you to enter directories where lookup for files will be performed*  
**Note! If no directory entered current directory will be automatically added to search directories**
<pre>
CIT path1 path2 ...
</pre>
**Examples**
<pre>
PS F:\PetProjects\CIT_Release> CIT ./ ./folder .cpp "First line" "Second line"
</pre>

You can add `-r` options to make recursive search within all given directories
<pre>
PS F:\PetProjects\CIT_Release> CIT ./ -r .cpp .h "First line" "Second line"
</pre>
> CIT will scan "./" folder and all directories that "./" contain

## Work with exact extensions
*You can specify what extension to use*
<pre>
CIT ./ .extension1 .extension2 "comment"
</pre>
**Examples**
<pre>
PS F:\PetProjects\CIT_Release> CIT ./ .cpp .h "First line" "Second line"
</pre>

You can add `-a` options to add comments to any found files in the directory(all extension)
<pre>
PS F:\PetProjects\CIT_Release> CIT ./ -a "First line" "Second line"
</pre>  

# Contact me
*In case of any problems feel free to contact me or create an issue*  
*Or if you need any additional features*  
<olexthelake@gmail.com>
