@echo off

echo Building floatz.fixed
shrink /p:floatz.fixed.profile /o:../../../floatz/floatz.fixed.css

echo Building floatz.liquid
shrink /p:floatz.liquid.profile /o:../../../floatz/floatz.liquid.css

echo Building floatz.fixed
shrink /p:floatz.center.profile /o:../../../floatz/floatz.center.css
