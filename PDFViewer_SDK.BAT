@echo off
set "target=PDFViewerSDK"

if not exist "%target%" (
    mkdir "%target%"
)

xcopy "..\common" "%target%\common\" /s /e /y
xcopy "..\pdfviewer" "%target%\pdfviewer\" /s /e /y
xcopy "..\samplebrowser" "%target%\samplebrowser\" /s /e /y
xcopy "..\showcase\succinctly series" "%target%\showcase\succinctly series\" /s /e /y
xcopy "..\targets" "%target%\targets\" /s /e /y

copy "..\Assemblies.xml" "%target%\" /y
copy "..\Directory.Build.props" "%target%\" /y
copy "..\PDFViewerSDK_BAT_File\PDFViewer_SDK.BAT" "%target%\" /y
copy "..\SyncfusionLicense.txt" "%target%\" /y

echo All folders and files copied to "%target%" successfully.

set "base=PDFViewerSDK"

del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_47.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_47.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_excelsdk.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_excelsdk.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_fileformat_47.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_fileformat_47.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_docxeditorsdk.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_docxeditorsdk.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_documentsdk.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_documentsdk.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_documentsdk_47.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_documentsdk_47.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_store_47.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_test.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_test.sln"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_wordeditorsdk.csproj"
del /q "%base%\samplebrowser\syncfusion.samplebrowser.wpf_wordeditorsdk.sln"
del /q "%base%\samplebrowser\wpf-wordeditor-sdk-splash-screen.png"
del /q "%base%\samplebrowser\wpf-excel-sdk-splash-screen.png"
del /q "%base%\samplebrowser\wpf-documentsdk-splash-screen.png"
del /q "%base%\samplebrowser\wpf-docxeditor-sdk-splash-screen.png"
del /q "%base%\targets\DocumentSDK.targets"
del /q "%base%\targets\Docxeditorsdk.targets""

rmdir /s /q "%base%/common\Assets\Gadgets"
rmdir /s /q "%base%/common\Assets\Movie"
echo Folder deleted successfully.
echo Folder cleanup inside "%base%" completed.

pause