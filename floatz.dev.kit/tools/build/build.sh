#!/bin/bash

# --------------------- Function definitions ---------------------
cleanup() {
	#Remove variables
	if [ -f *.css.tmp ] 
	then 
		rm *.css.tmp
	fi
	#if [ -f *.js.tmp ] 
	#then 
	#	rm *.js.tmp
	#fi
}

function updateTemplate() {
	
	if [ -z $1 ]
	then
		echo "floatz.build | INFO  | Updating template layout.$2" 
		template="layout.$2"
	else
		echo "floatz.build | INFO  | Updating template layout.$2.$1"
		template="layout.$2.$1"
	fi
	
	rm -rf ../../templates/$template/styles/floatz*
	mkdir ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
	mkdir ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts
	
	if [ -z $1 ]
	then
		cp ../../../floatz/floatz.center.css ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
		cp ../../../floatz/floatz.fixed.css ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
		cp ../../../floatz/floatz.liquid.css ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
	else	
		cp ../../../floatz/floatz.$1.css ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
	fi
	
	cp ../../../floatz/scripts/floatz.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../../floatz/scripts/floatz.browser.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../../floatz/scripts/floatz.skiplink.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../../floatz/scripts/floatz.mobile.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../src/scripts/jquery-$JQUERY_VERSION.min.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../src/scripts/LAB-$LAB_VERSION.min.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../src/scripts/less-$LESS_VERSION.min.js ../../templates/$template/styles/floatz-$FLOATZ_VERSION/scripts/
	cp ../../NOTICE.txt ../../templates/$template/styles/floatz-$FLOATZ_VERSION/
}

# -------------------------- Script body -------------------------
#stop on first error 
set -e 

#define cleanup function on interrupt / termination / exit
trap "cleanup" INT TERM EXIT

#Set variables for later user
FLOATZ_VERSION=1.2.0
JQUERY_VERSION=1.8.2
LAB_VERSION=2.0.3
LESS_VERSION=1.3.3

LESSC=/usr/local/bin/lessc
JSMIN="../jsmin/jsmin"

if [ -x $LESSC ]
then
	#Create minified css
	echo "floatz.build | INFO  | Creating minified version of floatz.fixed.css"
	lessc --compress ../../src/floatz.reset.meyer.css > floatz.fixed.css.tmp
	lessc --compress ../../src/floatz.reset.css >> floatz.fixed.css.tmp
	lessc --compress ../../src/floatz.layout.css >> floatz.fixed.css.tmp
	lessc --compress ../../src/floatz.nav.css >> floatz.fixed.css.tmp
	lessc --compress ../../src/floatz.form.css >> floatz.fixed.css.tmp
	mv floatz.fixed.css.tmp ../../../floatz/floatz.fixed.css

	echo "floatz.build | INFO  | Creating minified version of floatz.liquid.css"
	lessc --compress ../../src/floatz.reset.meyer.css > floatz.liquid.css.tmp
	lessc --compress ../../src/floatz.reset.css >> floatz.liquid.css.tmp
	lessc --compress ../../src/floatz.layout.css >> floatz.liquid.css.tmp
	lessc --compress ../../src/floatz.layout.liquid.css >> floatz.liquid.css.tmp
	lessc --compress ../../src/floatz.nav.css >> floatz.liquid.css.tmp
	lessc --compress ../../src/floatz.form.css >> floatz.liquid.css.tmp
	mv floatz.liquid.css.tmp ../../../floatz/floatz.liquid.css

	echo "floatz.build | INFO  | Creating minified version of floatz.center.css"
	lessc --compress ../../src/floatz.reset.meyer.css > floatz.center.css.tmp
	lessc --compress ../../src/floatz.reset.css >> floatz.center.css.tmp
	lessc --compress ../../src/floatz.layout.css >> floatz.center.css.tmp
	lessc --compress ../../src/floatz.layout.center.css >> floatz.center.css.tmp
	lessc --compress ../../src/floatz.nav.css >> floatz.center.css.tmp
	lessc --compress ../../src/floatz.form.css >> floatz.center.css.tmp
	mv floatz.center.css.tmp ../../../floatz/floatz.center.css

else
	echo "floatz.build | ERROR | Less compiler could not be found. Please install less compiler before build."
fi

if [ -x $JSMIN ]
then
	#Create minified js
	echo "floatz.build | INFO  | Creating minified version of floatz.js"
	../jsmin/jsmin < ../../src/scripts/floatz.js > floatz.js.tmp
	mv floatz.js.tmp ../../../floatz/scripts/floatz.js

	echo "floatz.build | INFO  | Creating minified version of floatz.browser.js"
	../jsmin/jsmin < ../../src/scripts/floatz.browser.js > floatz.browser.js.tmp
	mv floatz.browser.js.tmp ../../../floatz/scripts/floatz.browser.js

	echo "floatz.build | INFO  | Creating minified version of floatz.skiplink.js"
	../jsmin/jsmin < ../../src/scripts/floatz.skiplink.js > floatz.skiplink.js.tmp
	mv floatz.skiplink.js.tmp ../../../floatz/scripts/floatz.skiplink.js

	echo "floatz.build | INFO  | Creating minified version of floatz.mobile.js"
	../jsmin/jsmin < ../../src/scripts/floatz.mobile.js > floatz.mobile.js.tmp
	mv floatz.mobile.js.tmp ../../../floatz/scripts/floatz.mobile.js
else
	echo "floatz.build | ERROR | Jsmin compiler could not be found. Please get full floatz.dev.kit and retry."
fi

#Template empty
updateTemplate "" "empty"

#Template fixed
updateTemplate "fixed" "010"
updateTemplate "fixed" "011"
updateTemplate "fixed" "110"
updateTemplate "fixed" "111"

#Template liquid
updateTemplate "liquid" "010"
updateTemplate "liquid" "011"
updateTemplate "liquid" "110"
updateTemplate "liquid" "111"

#Template center
updateTemplate "center" "010"
updateTemplate "center" "011"
updateTemplate "center" "110"
updateTemplate "center" "111"
