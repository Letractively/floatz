floatz.mobile = (function() {

	////////////////////////////////////////////////////
	// Public interface

	var self = {
			
		/* Fields */
		module : {
			name : "floatz.mobile",
			version : "1.2.0",
			start : start
		}			
	};
	
	////////////////////////////////////////////////////
	// Private variables

	var module = self.module;
	
	////////////////////////////////////////////////////
	// Private functions
	
	function start() {

		// Optimize mobile webkit behavior
		if(floatz.browser.isMobileWebkit()) {

			////////
			// TODO - Check if -webkit-text-size-adjust: 100% would solve that problem directly in CSS?
			////////
			
			// Prevent unpredictable automatic resizing of fonts on iOS devices
			// See: http://blog.55minutes.com/2012/04/iphone-text-resizing/
			floatz.log(floatz.LOGLEVEL.DEBUG, "Adding -webkit-text-size-adjust: none to * in mobile webkit", module.name);		
			document.styleSheets[0].addRule("*", "-webkit-text-size-adjust: none;");

			// Smooth scrolling for scrollable panels on mobile iOS devices
			// See: http://johanbrook.com/browsers/native-momentum-scrolling-ios-5/
			floatz.log(floatz.LOGLEVEL.DEBUG, "Adding -webkit-overflow-scrolling: touch to flz_scrollbar, flz_scrollbox on mobile webkit", module.name);		
			floatz.log(floatz.LOGLEVEL.DEBUG, "Adding overflow:scroll to flz_scrollpanel, flz_scrollbox on mobile webkit", module.name);		
			$(".flz_scrollpanel, .flz_scrollbox").css("-webkit-overflow-scrolling", "touch").css("overflow", "scroll");
		}
		
		floatz.log(floatz.LOGLEVEL.INFO, "Module " + module.name + " started", module.name);		
	}
		
	////////////////////////////////////////////////////
	// Init code
	
	floatz.loadedModules.push(module);
	floatz.log(floatz.LOGLEVEL.INFO, "Module " + module.name + " loaded", module.name);
	
	// Return public interface
	return self;
}());
