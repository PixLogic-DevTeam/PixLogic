#Informations#

To use debug or release dlls of *Ribbon* and *RibbonGenerator*, simply copy the files of the one backup repository to the main repository.

**Currect version used**: debug dlls

_______

#Use *RibbonGenerator* into VS2013#

##Register *RibbonGenerator* to the Global Assembly Cache (GAC)##

	- Install Windows SDK for Windows 7 (download link: https://www.microsoft.com/en-us/download/details.aspx?id=18950)
	- Run Windows Command Prompt.bat as administrator,  then: 
		> chdir C:\Program Files\Microsoft SDKs\Windows\v7.0\bin\
		> gacutil.exe /i [your\_path\_to\_the\_dll]\RibbonGenerator.dll

##Register *RibbonGenerator* as Custom Tool for Windows 32 bits##
	- Execute RegisterCustomTool_VS2013_x86_Part1.reg as administrator
	- Execute RegisterCustomTool_VS2013_x86_Part2.reg as current user

**Or alternatively**

##Register *RibbonGenerator* as Custom Tool for Windows 64 bits##
	- Execute RegisterCustomTool_VS2013_x64_Part1.reg as administrator
	- Execute RegisterCustomTool_VS2013_x64_Part2.reg as current user