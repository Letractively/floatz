@echo off

cd ..\shrink

echo.
echo Building floatz.fixed ...
shrink /p:../build/floatz.fixed.profile /o:../../../floatz/floatz.fixed.css

echo.
echo Building floatz.liquid ...
shrink /p:../build/floatz.liquid.profile /o:../../../floatz/floatz.liquid.css

echo.
echo Building floatz.fixed ...
shrink /p:../build/floatz.center.profile /o:../../../floatz/floatz.center.css

echo.
echo Build floatz.js ...
echo tbd

echo.
echo Updating templates ...
echo floatz.fixed.css
copy ..\..\..\floatz\floatz.fixed.css  ..\..\templates\layout.010.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.fixed.css  ..\..\templates\layout.011.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.fixed.css  ..\..\templates\layout.111.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.fixed.css  ..\..\templates\layout.110.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.fixed.css  ..\..\templates\layout.empty\styles\floatz-1.1.0\ > nul

echo floatz.liquid.css
copy ..\..\..\floatz\floatz.liquid.css  ..\..\templates\layout.010.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.liquid.css  ..\..\templates\layout.011.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.liquid.css  ..\..\templates\layout.111.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.liquid.css  ..\..\templates\layout.110.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.liquid.css  ..\..\templates\layout.empty\styles\floatz-1.1.0\ > nul

echo floatz.center.css
copy ..\..\..\floatz\floatz.center.css  ..\..\templates\layout.010.center\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.center.css  ..\..\templates\layout.011.center\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.center.css  ..\..\templates\layout.111.center\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.center.css  ..\..\templates\layout.110.center\styles\floatz-1.1.0\ > nul
copy ..\..\..\floatz\floatz.center.css  ..\..\templates\layout.empty\styles\floatz-1.1.0\ > nul

echo floatz.js
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.010.fixed\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.011.fixed\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.111.fixed\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.110.fixed\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.010.liquid\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.011.liquid\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.111.liquid\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.110.liquid\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.010.center\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.011.center\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.111.center\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.110.center\styles\floatz-1.1.0\scripts\ > nul
copy ..\..\..\floatz\scripts\floatz.js ..\..\templates\layout.empty\styles\floatz-1.1.0\scripts\ > nul

echo NOTICE.txt
copy ..\..\NOTICE.txt ..\..\templates\layout.010.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.011.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.111.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.110.fixed\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.010.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.011.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.111.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.110.liquid\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.010.center\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.011.center\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.111.center\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.110.center\styles\floatz-1.1.0\ > nul
copy ..\..\NOTICE.txt ..\..\templates\layout.empty\styles\floatz-1.1.0\ > nul

cd ../build
