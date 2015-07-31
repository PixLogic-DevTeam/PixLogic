#Informations#

#Use *RibbonGenerator* into VS2013#

##Register *RibbonGenerator* to the Global Assembly Cache (GAC)##

	- Install Windows SDK for Windows 7 (download link: https://www.microsoft.com/en-us/download/details.aspx?id=18950)
	- Install Windows SDK for Windows 8.1 (download link: https://msdn.microsoft.com/en-us/windows/desktop/bg162891.aspx)
	- Run Windows Command Prompt.bat as administrator,  then: 
		> "C:\Program Files\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\gacutil.exe" /i ".\RibbonGenerator.dll"

##Register *RibbonGenerator* as Custom Tool on 32 bits Windows system##
	- Execute RegisterCustomTool_VS2013_x86_Part1.reg as administrator
	- Execute RegisterCustomTool_VS2013_x86_Part2.reg as current user

**Or alternatively**

##Register *RibbonGenerator* as Custom Tool on 64 bits Windows system##
	- Execute RegisterCustomTool_VS2013_x64_Part1.reg as administrator
	- Execute RegisterCustomTool_VS2013_x64_Part2.reg as current user