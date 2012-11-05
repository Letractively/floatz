/**
 * floatz.js
 * 
 * Base module that manages all floatz specific modules and provides some utility methods.
 *
 * Note: This file contains optional javascript code that progressively enhances browser 
 * capabilities in circumstances where no HTML & CSS only solution is available.
 *
 * Depends on: jQuery
 * 
 * @project       floatz CSS Framework
 * @version       1.2.0
 * @since         1.2.0
 * @see           http://code.google.com/p/floatz/
 * @author        Harald Humml
 * @copyright     Copyright (c) 1998-2012 by :humml:design
 * @link          http://www.floatzcss.com
 * @license       Apache License 2.0 http://www.apache.org/licenses/LICENSE-2.0
 * @lastmodified  2012-11-05
 */

 var floatz = (function() {
	
	////////////////////////////////////////////////////
	// Public interface

	var self = {

		/* Enumarations */
		LOGLEVEL : {
			ERROR : 0,
			WARN : 1,
			INFO : 2,
			DEBUG : 3
		},

		/* Fields */
		loadedModules : new Array(),
		module : {
			name : "floatz",
			version : "1.2.0"
		},

		/* Methods */
		start : start,
		log : log,
		
		/* String utilities */
		string : {
			lpad : lpad,
			rpad : rpad
		}
	};

	////////////////////////////////////////////////////
	// Private variables
	
	var LOGLEVEL = self.LOGLEVEL;
	var loadedModules = self.loadedModules;
	var module = self.module;
	var config = {
		debug : false,
		logLevel : LOGLEVEL.DEBUG, /* Use only in dev mode */
	};
	
	////////////////////////////////////////////////////
	// Private functions
	
	/**
	 * Start floatz and all configured modules.
	 * 
	 * start();
	 * start(<config>);
	 * 
	 * @param config Configuration options {
	 * 			[debug : true|false][,]
	 * 			[logLevel : floatz.LOGLEVEL.<level>][,]
	 * 			[modules : { <modulename> [,<modulname>]}]
	 * 		  }
	 * 
	 * @since 1.2.0
	 */
	function start(options) {

		// Mix options and defaults
		$.extend(config, options);
		
		// Find modules to start
		log(LOGLEVEL.INFO, "Module " + module.name + " started", module.name);
		for(var i in loadedModules) {
			
			// Start all loaded modules if nothing is configured
			var start = config.modules === undefined;
			if(! start) {

				// Check if module is configured to be started
				for(var j in config.modules) {
					if(loadedModules[i].name === config.modules[j]) {
						start = true;
						break;
					}
				}
			}
			
			// Start module
			if(start) {
				loadedModules[i].start();
			}
		}
		
		// Show all modules in config that could not be loaded
		for(var i in config.modules) {
			var found = false;
			for(var j in loadedModules) {
				if(config.modules[i] === loadedModules[j].name) {
					found = true;
				}
			}		

			if(! found) {
				log(LOGLEVEL.ERROR, "Module " + config.modules[i] + " is invalid or not loaded", module.name);
			}
		}		
	}
	
	/**
	 * Log into browser console.
	 * 
	 * @param level Log level
	 * @param msg Log message
	 * @param context Context (e.g. module name)
	 * @since 1.2.0
	 */
	function log(level, msg, context) {
		
		// Check if console is available (IE 8 and below) and log level is allowed
		if(window.console !== undefined && level <= config.logLevel) {
			console.log(rpad(context, " ", 20) + " | " + module.version + " | " + 
				rpad(logLevelName(level), " ", 6) + " | " + msg);
		}
	}

	/**
	 * Get readable name for log level.
	 * 
	 * @param Log level
	 * @return Name for log level
	 * @since 1.2.0
	 */
	// Get name for log level
	function logLevelName(level) {
		return level === LOGLEVEL.ERROR ? "ERROR" : 
			   level === LOGLEVEL.WARN  ? "WARN" : 
			   level === LOGLEVEL.INFO  ? "INFO" : 
			   level === LOGLEVEL.DEBUG ? "DEBUG" : "UNKOWN";
	}
	
	/**
	 * Right pad a string.
	 * 
	 * @param str Original string
	 * @param char Padding character
	 * @param len Target length of the returned string
	 * @return Padded string
	 * @since 1.2.0
	 */
	function rpad(str, char, len) {
		if (! str || ! char || str.length >= len) {
			return str;
		}
		
		var pstr = str;
		var max = (len - str.length) / char.length;
		for (var i = 0; i < max; i++) {
			pstr += char;
		}		
		return pstr;
	}
	
	/**
	 * Left pad a string.
	 * 
	 * @param str Original string
	 * @param char Padding character
	 * @param len Target length of the returned string
	 * @return Padded string 
	 * @since 1.2.0
	 */
	function lpad(str, char, len) {
		if (! str || ! char || str.length >= len) {
			return str;
		}
		
		var pstr = str;
		var max = (len - str.length) / char.length;
		for (var i = 0; i < max; i++) {
			pstr = char + pstr;
		}
		return pstr;
	}

	////////////////////////////////////////////////////
	// Init code
	
	log(LOGLEVEL.INFO, "Module " + module.name + " loaded", module.name);
	
	// Return public interface
	return self;
}());