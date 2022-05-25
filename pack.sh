#!/bin/sh
clear

SCRIPTFILE=$0

#Get the absolute path to the containing folder
PROJECTFOLDER=${SCRIPTFILE%/*}

cd ${PROJECTFOLDER}

pwd

rm *.mpack

PROJECTFOLDER="/Users/ivokrugers/Xamarin_Projects/VisualStudioMac.SimplePad"

mono /Applications/Visual\ Studio.app/Contents/Resources/lib/monodevelop/bin/vstool.exe setup pack ./VisualStudioMac.SimplePad/bin/VisualStudioMac.SimplePad.dll

/Applications/Visual\ Studio\ \(Preview\).app/Contents/MacOS/vstool setup uninstall VisualStudioMac.SimplePad -y

/Applications/Visual\ Studio\ \(Preview\).app/Contents/MacOS/vstool setup install "$PROJECTFOLDER/VisualStudioMac.SimplePad_17.0.mpack"