/* floatz CSS Framework v1.2.0
   Copyright (c) 1998-2013 by :humml:design
   Apache License 2.0 http://www.apache.org/licenses/LICENSE-2.0 */

window.floatz.browser=(function(){"use strict";var userAgent=navigator.userAgent.toLowerCase();var self={module:{name:"floatz.browser",version:"1.2.0",start:start},android:/android/.test(userAgent),androidVersion:""+(userAgent.match(/.+(?:android)[\/: ]([\d.]+)/)||[0,0])[1],chrome:/chrome/.test(userAgent),firefox:/firefox/.test(userAgent),gecko:/[^like]{4} gecko/.test(userAgent),ipad:/ipad/.test(userAgent),ipadVersion:(userAgent.match(/.+(?:cpu\ os)[\/: ]([\d_]+)/)||[0,0])[1].toString().split('_').join('.'),iphone:/iphone|ipod/.test(userAgent),iphoneVersion:(userAgent.match(/.+(?:iphone\ os)[\/: ]([\d_]+)/)||[0,0])[1].toString().split('_').join('.'),mozilla:/mozilla/.test(userAgent)&&!/(compatible|webkit)/.test(userAgent),msie:/msie/.test(userAgent)&&!/opera/.test(userAgent),opera:/opera/.test(userAgent),presto:/presto/.test(userAgent),safari:/webkit/.test(userAgent)&&!/chrome/.test(userAgent),version:(userAgent.match(/.+(?:rv|it|ra|ie|me|ve)[\/: ]([\d.]+)/)||[])[1],webkit:$.browser.webkit===undefined?false:$.browser.webkit,winPhone:/Windows\ Phone/.test(userAgent),winPhoneVersion:""+(userAgent.match(/.+(?:windows\ phone\ os)[\/: ]([\d_]+)/)||[0,0])[1],isMobileWebkit:isMobileWebkit,isMobile:isMobile};var floatz=window.floatz;var module=self.module;function start(){floatz.log(floatz.LOGLEVEL.DEBUG,userAgent,module.name);floatz.log(floatz.LOGLEVEL.INFO,"Module "+module.name+" started",module.name);}
function isMobileWebkit(){return self.webkit&&(self.android||self.iphone||self.ipad);}
function isMobile(){return self.android||self.iphone||self.ipad||self.winPhone;}
floatz.loadedModules.push(module);floatz.log(floatz.LOGLEVEL.INFO,"Module "+module.name+" loaded",module.name);return self;}());