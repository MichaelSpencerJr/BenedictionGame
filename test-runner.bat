@ECHO OFF
DEL /S /Q testruns\latest
mkdir testruns\latest
cd testruns\latest
C:\ProgramData\chocolatey\bin\nunit3-console.exe ..\..\src\Testing\Specflow\bin\Debug\Testing.Specflow.dll --result=report.txt;transform=..\..\..\nunit-transforms\nunit3-summary\text-report.xslt --result=report.html;transform=..\..\..\nunit-transforms\nunit3-summary\html-report.xslt --result=readme.md;transform=..\md-report.xslt --result=TestResult.xml
cd ..\..