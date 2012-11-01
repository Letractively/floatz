floatz.browser = (function() {

	////////////////////////////////////////////////////
	// Private variables

	var userAgent = navigator.userAgent.toLowerCase();
	
	////////////////////////////////////////////////////
	// Public interface

	var self = {
			
		/* Fields */
		module : {
			name : "floatz.browser",
			version : "1.2.0",
			start : function() {
				floatz.log(floatz.LOGLEVEL.INFO, "Module " + module.name + " started", module.name);
			}
		},

		/* Fields to indicate browsers and devices */
		android: /android/.test(userAgent),
		androidVersion: "" + (userAgent.match(/.+(?:android)[\/: ]([\d.]+)/) || [0,0])[1],
		chrome: /chrome/.test(userAgent),
		firefox: /firefox/.test(userAgent),
		gecko: /[^like]{4} gecko/.test(userAgent),
		ipad: /ipad/.test(userAgent),
		ipadVersion: (userAgent.match( /.+(?:cpu\ os)[\/: ]([\d_]+)/) || [0,0])[1].toString().split('_').join('.'),
		iphone: /iphone|ipod/.test(userAgent),
		iphoneVersion: (userAgent.match(/.+(?:iphone\ os)[\/: ]([\d_]+)/) || [0,0])[1].toString().split('_').join('.'),
		mozilla: /mozilla/.test(userAgent) && !/(compatible|webkit)/.test(userAgent),
		msie: /msie/.test(userAgent) && !/opera/.test(userAgent),
		opera: /opera/.test(userAgent),
		presto: /presto/.test(userAgent),
		safari: /webkit/.test(userAgent) && !/chrome/.test(userAgent),
		version : (userAgent.match( /.+(?:rv|it|ra|ie|me|ve)[\/: ]([\d.]+)/) || [])[1],
		webkit: $.browser.webkit === undefined ? false : $.browser.webkit,
		winPhone: /Windows\ Phone/.test(userAgent),
		winPhoneVersion: "" + (userAgent.match( /.+(?:windows\ phone\ os)[\/: ]([\d_]+)/ ) || [0,0])[1],
		isMobileWebkit : isMobileWebkit
	};
	
	////////////////////////////////////////////////////
	// Private variables

	var module = self.module;
	
	////////////////////////////////////////////////////
	// Private functions
	
	/**
	 * Check if mobile webkit browser.
	 * 
	 * @return true if mobile webkit, false if not
	 */
	function isMobileWebkit() {
		return self.webkit && (self.android || self.iphone || self.ipad);
	}
		
	////////////////////////////////////////////////////
	// Init code
	
	floatz.loadedModules.push(module);
	floatz.log(floatz.LOGLEVEL.INFO, "Module " + module.name + " loaded", module.name);
	floatz.log(floatz.LOGLEVEL.INFO, userAgent, module.name);
	
	// Return public interface
	return self;
}());
