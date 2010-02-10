/**
 * floatz.js
 * 
 * Provides a common baseline as well as specific classes for form elements
 *
 * @project       floatz CSS Framework
 * @version       1.1.0
 * @see           http://code.google.com/p/floatz/
 * @author        Harald Humml
 * @copyright     Copyright (c) 1998-2010 by :humml:design
 * @link          http://design.humml.eu/toolbox/floatz
 * @license       Apache License 2.0 http://www.apache.org/licenses/LICENSE-2.0
 * @lastmodified  2010-02-10
 */

/**
 * Initializes floatz.
 *
 * @since 1.1.0
 */
function flz_initFloatz() {

   // Initialize skip links
   flz_initSkiplinks();
   
   // Initialize skip link anchors
   flz_initSkiplinkAnchors();
}        

/**
 * Initialize skip links.
 * 
 * Adds click event handlers to all skip links within flz_skipnav. The click event
 * handler sets the focus on skip link anchors when user clicks on skip link. This
 * works only if every skip link anchor has tabindex="-1" set.
 *
 * @affected Chrome, Safari (Webkit), Opera
 * @since 1.1.0
 */
function flz_initSkiplinks() {

   // Check if webkit or opera browser
   if ($.browser.webkit || $.browser.opera) {

      // Add click event handler for all hyperlinks within flz_skipnav
      $("div.flz_skipnav a").click(function(){

         // Set focus to skiplink anchor by parsing anchor id from skiplink's href
         // when user clicks on skip link
         $(this.href.substring(this.href.indexOf("#"), this.href.length)).focus();
      });
   }
}

/**
 * Initialize skip link anchors.
 *
 * Automatically adds tabindex attribute to every skip link anchor that is 
 * annotated with class flz_anchor. This is mandatory for setting focus on 
 * skip link anchors.
 *
 * @affected Chrome, Safari (Webkit), Opera
 * @since 1.1.0
 */
function flz_initSkiplinkAnchors() {

   // Check if webkit or opera browser
   if ($.browser.webkit || $.browser.opera) {
      
      // Add tabindex attribute to all elements with class flz_anchor
      $("a.flz_anchor").attr("tabindex", "-1");
      
      // Todo: check if its possible to manipulate anchors without flz_anchor
      // only via ids of the skip links
   }               
}
