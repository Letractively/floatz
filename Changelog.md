Last Update: July 17th, 2012

> 
---

> Note: this wiki page covers version 1.2.0
> 
---


**Table of content**


# Version 1.2.0 #
This version is a minor feature release as well as a larger maintenance release, that fixes some bugs. The highlights are:

  * Support for layouting desktop like web applications
  * Modulariziation of javascript functionality
  * Javascript module for browser detection
  * Integration of and reimplementation with Less CSS
  * Support for smooth scrolling on iOS devices
  * Migration to jQuery 1.8.2 and Meyer CSS 2.0

## Summary of changes ##
### New ###
The following items are new

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.`*`.css | NEW  | [Issue 51](https://code.google.com/p/floatz/issues/detail?id=51) | Add less css support to floatz  (all css modules are using less and are thus renamed to `*`.less)|
| floatz.layout.less | NEW  | [Issue 47](https://code.google.com/p/floatz/issues/detail?id=47) | Provide mechanism for layouting desktop applications |
| floatz.`*`.js | NEW  | [Issue 56](https://code.google.com/p/floatz/issues/detail?id=56) | Add javascript module support to prepare for future releases |
| floatz.browser.js | NEW  | [Issue 50](https://code.google.com/p/floatz/issues/detail?id=50) | Add javascript solution for detecting browsers and platforms |
| floatz.mobile.js, floatz.mobile.webkit.less | NEW  | [Issue 54](https://code.google.com/p/floatz/issues/detail?id=54) | Add support for smooth scrolling on iOS devices |
| floatz.dev.kit/templates | NEW  | [Issue 73](https://code.google.com/p/floatz/issues/detail?id=73) | Add print css to templates and examples as well as for use in panels |

### Changed ###
The following items have been changed

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.reset.meyer.less | NEW  | [Issue 53](https://code.google.com/p/floatz/issues/detail?id=53) | Migrate to Meyer CSS reset 2.0 |
| floatz.reset.less | FIX  | [Issue 48](https://code.google.com/p/floatz/issues/detail?id=48) |  Scaling web pages with Strg+/- is not possible in Chrome and Safari |
| floatz.form.less | CHANGE | [Issue 49](https://code.google.com/p/floatz/issues/detail?id=49) |  Input fields overlap spacers in mobile safari |
| floatz.form.less | CHANGE | [Issue 58](https://code.google.com/p/floatz/issues/detail?id=58) | Button tag must also have vertical-align: middle as input type button |
| floatz.form.less | FIX  | [Issue 66](https://code.google.com/p/floatz/issues/detail?id=66) | flz\_combobox does not work correctly in IE6 |
| floatz.nav.less | FIX  | [Issue 68](https://code.google.com/p/floatz/issues/detail?id=68) | Disabled and selected items in flz\_vmenu are not highlighted in IE6 |
| floatz.nav.less | FIX  |       | Styling of menu items changed from `li a` to `ul li a` |
| floatz.`*`.js | NEW  | [Issue 55](https://code.google.com/p/floatz/issues/detail?id=55) | Migrate to jQuery 1.8.2 |

### Deprecated ###
None

### Removed ###
The following items have been removed

| floatz.reset.less | REMOVED | [Issue 59](https://code.google.com/p/floatz/issues/detail?id=59) | Remove outline correction of anchors that was caused by old meyer reset |
|:------------------|:--------|:-----------------------------------------------------------------|:------------------------------------------------------------------------|

# Version 1.1.2 #

## Highlights ##
This version is a small maintenance release that implements some requests from existing projects.

## Summary of changes ##
### New ###
The following items are new

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.gwt | NEW  | [Issue 30](https://code.google.com/p/floatz/issues/detail?id=30) | Releasing floatz for Google Web Toolit. Now you can use floatz as CSS bundle within GWT applications (from code and from UI binders). See [Layouting in Google Webtoolkit](LayoutingInGoogleWebToolkit.md)|

### Changed ###
The following items have been changed

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.form.css | CHANGE | [Issue 40](https://code.google.com/p/floatz/issues/detail?id=40) | Removing .flz\_form context from button styles to harmonize specifity. Now all buttons can be styled without .flz\_form context. |
| floatz.form.css | NEW  | [Issue 46](https://code.google.com/p/floatz/issues/detail?id=46) | Adding whitespace (1em) below fieldsets |
| floatz.nav.css | FIX  | [Issue 35](https://code.google.com/p/floatz/issues/detail?id=35) | Changing style for selected listnav item. Otherwise separator is also bold when selected.|
| floatz.nav.css | NEW  | [Issue 37](https://code.google.com/p/floatz/issues/detail?id=37) | Removing distance between active tab and tab container. Now the active tab overlaps the border of the underlying container to increase the effect of selection.|
| floatz.nav.css | FIX  | [Issue 41](https://code.google.com/p/floatz/issues/detail?id=41) | Reducing left margin of vertical menu items. Now they start at 1em.|
| floatz.reset.css | FIX  | [Issue 43](https://code.google.com/p/floatz/issues/detail?id=43) | Adding -webkit-text-size-adjust: none to all elements, otherwise fonts are unprecitable increased on Webkit based smartphones.|
| -      | CHANGE | [Issue 38](https://code.google.com/p/floatz/issues/detail?id=38) | Using latest version of jQuery (1.7.2)|

### Deprecated ###
None

### Removed ###
None

# Version 1.1.1 #

## Highlights ##
Version 1.1.1 is a maintenance release that introduces some changes for easing menu customization and for usability/accessibility as well as consistency reasons.

## Summary of changes ##
### New ###
The following items are new

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.nav.css | NEW  | [Issue 29](https://code.google.com/p/floatz/issues/detail?id=29) | Adding flz\_disabled to flz\_listnav, flz\_breadcrumb, flz\_topnav, flz\_toolbar, flz\_vmenu, flz\_hmenu, flz\_htabmenu, flz\_htabmenu\_bottom for supporting disabled navigation items |

### Changed ###
The following items have been changed

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.form.css | CHANGE | [Issue 18](https://code.google.com/p/floatz/issues/detail?id=18) | Replacing flz\_button in browser hacks for IE 7 with input`[`type=button`]` and input`[`type=submit`]` for consistency reasons. flz\_button thus is not necessary at all when using IE7 (only when IE6 should also be supported) |
| floatz.form.css | CHANGE | [Issue 19](https://code.google.com/p/floatz/issues/detail?id=19) | Replacing flz\_combifield with flz\_combobox for consistence with well known UI concepts |
| floatz.form.css | FIX    | [Issue 25](https://code.google.com/p/floatz/issues/detail?id=25) | Adding outline to `flz_combobox` image witing anchor with focus. Otherwise the active anchor is not visible (because of absolute position of image - all browsers are concerned) |
| floatz.form.css | CHANGE | [Issue 27](https://code.google.com/p/floatz/issues/detail?id=27) | Adding same styles for button and reset tag, as for input`[`type=button`]`}. Adding separate CSS class flz\_custombutton to remove unneccessary styles like borders and backgrounds from button tags with custom markup |
| floatz.form.css | CHANGE | [Issue 28](https://code.google.com/p/floatz/issues/detail?id=28) | Adding styles for input`[`type=password`]` as exists for input`[`type=button`]` |
| floatz.form.css | FIX  | [Issue 31](https://code.google.com/p/floatz/issues/detail?id=31) | Adding outline to `flz_combobox` image witing anchor with focus. Otherwise the active anchor is not visible (because of absolute position of image - all browsers are concerned) |
| floatz.form.css | FIX  | [Issue 32](https://code.google.com/p/floatz/issues/detail?id=32) | Reworking markup and CSS for `flz_combobox` completely to show outline and allow focusing the image anchor with the TAB keys. Please check your code after updating to this version, to see if it works as mentioned. |
| floatz.nav.css | CHANGE | [Issue 22](https://code.google.com/p/floatz/issues/detail?id=22) | Removing most of all pre-defined customizations in flz\_vmenu and flz\_hmenu to avoid problems in customizations and to reduce CSS code. See wiki how to customize the menus. Please check your code after updating to this version, to see if it works as mentioned |
| floatz.reset.meyer.css | CHANGE | [Issue 25](https://code.google.com/p/floatz/issues/detail?id=25) | Uncommenting :focus { outline: 0; } for accessbility/usability reasons. Otherwise navigable elements like buttons, selects, etc. would not be visibile if they get the keyboard focus |
| -      | CHANGE | [Issue 17](https://code.google.com/p/floatz/issues/detail?id=17) | Correcting wrong directory names in floatz.dev.kit/templates as well as wiki examples |
| -      | FIX  | [Issue 23](https://code.google.com/p/floatz/issues/detail?id=23) | Fixing bug in \tools\shrink\shrink.exe. Streamwriter for file merge was not closed correctly on error |
| -      | CHANGE | -     | Changing \tools\build\build.bat for easier version handling during floatz builds |
| -      | NEW  | [Issue 33](https://code.google.com/p/floatz/issues/detail?id=33) | Adding new test page test.layout.center.liquid.html to dev kit, to show how CSS must be corrected to solve this issue |

### Deprecated ###
None

### Removed ###
None

# Version 1.1.0 #

## Highlights ##

Version 1.1.0 is a minor feature release as well as a larger maintenance release, that fixes some bugs. The highlights are:

  * Shrinked and merged floatz CSS file to reduce bandwidth and HTTP requests
  * Use of CSS sprites images to reduce HTTP requests
  * New skiplink navigation for accessibility
  * New horizontal bottom-aligned tab menu
  * Ready-to-use layout templates

### Shrinked and merged floatz CSS file to reduce bandwidth ###

floatz introduces a new shrink and merge utility for CSS files. This allows to remove all unnecessary content (comments, linebreaks, whitespace) from all CSS modules and merges them into only one CSS file. This decreases the file size and saves bandwidth as well as file requests. The shrink utility also supports profiling, that makes it possible to define the set of CSS modules that should be shrinked and merged.

Future releases of floatz will use much more fine-grained CSS modules. The shrink and merge utility gives designers and programmers the ability to choose only what they really want to use, by creating their own profiles and generating their custom floatz CSS.

This addresses (and solves) two major critisisms of CSS frameworks (see [Wikipedia](http://en.wikipedia.org/wiki/CSS_framework))

  * Bloated source code
  * Additional HTTP requests for multiple files

without loosing the modularity of the CSS framework.

See also: WhatsInside.

### Use of CSS sprites images to reduce HTTP requests ###

To reduce the amount of HTTP requests, the current version uses CSS sprites images when ever possible.

### New skiplink navigation for accessibility ###

This version comes with cross browser support for skip links that are a must have for websites that are serious about accessibility support.

> 
---

> Note: This feature introduces something that is really new and maybe unexpected for a CSS framework. It introduces javascript code for DOM manipulation. While currently, this is optional and only necessary if you want to use skiplinks (recommended), future releases of floatz will utilize this powerfull kind of progressive enhancement much more.
> 
---


### New horizontal bottom aligned tab menu ###

A horizontal bottom aligned tab menu is added to the navigation module.

> 
---

> Note: The implementation of the bottom aligned tab menu demonstrated the constraints of the CSS sprites image approach and (again) lead to single image files. See [sandbox](http://code.google.com/p/floatz/source/browse/#svn/trunk/floatz.dev.kit/sandbox/sprites)
> 
---


### Ready-to-use layout templates ###

floatz.dev.kit now ships with a set of predefined and ready-to-use layout templates.

See also: WhatsInside, GettingStarted

## Summary of changes ##

### New ###

The following items are new.

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.nav.css | NEW  | [Issue 2](https://code.google.com/p/floatz/issues/detail?id=2) | Adding flz\_htabmenu\_bottom for bottom aligned horizontal tabmenu. |
| floatz.nav.css | NEW  | [Issue 15](https://code.google.com/p/floatz/issues/detail?id=15) | Adding skip link navigation for improving accessibility. Adding .flz\_skipnav as skiplink container, .flz\_skiplink for skiplinks, .flz\_anchor for skiplink targets. All hyperlinks with flz\_skiplink are only visible to users of screen readers. If they get keyboard focus (e.g. navigation via TAB key) they also get visible for screen users. |
| -      | NEW  | -     | Adding diverse test pages to \tests in floatz.dev.kit |
| -      | NEW  | -     | Adding debug CSS floatz.layout.debug.css to \src\debug in floatz.dev.kit |
| -      | NEW  | -     | Add skip link for improving accessibility. Adding src/scripts/floatz.js and src/scripts/jquery1.4.1.js to floatz. This is the only available solution to move keyboard focus in Chrome, Safari and Opera |
| -      | NEW  | [Issue 3](https://code.google.com/p/floatz/issues/detail?id=3) | Combine production CSS files to only one CSS file and shrink remove CR/LFs. Adding shrink tool to tools/shrink and profiles to build one-file-versions of floatz. |
| -      | NEW  | [Issue 15](https://code.google.com/p/floatz/issues/detail?id=15) | Adding \templates for the following layouts (nav,content,sidebar) 010, 011, 110, 111 to floatz.dev.kit |
| -      | NEW  | [Issue 15](https://code.google.com/p/floatz/issues/detail?id=15) | Adding build.bat script to \tools for creating shrinked version of floatz and for updating all templates |

### Changed ###

The following items have been changed.

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.form.css | FIX    | [Issue 7](https://code.google.com/p/floatz/issues/detail?id=7) | Different FIELDSET handling in floatz for IE 5.5,6,7 does not work with IE8. Fixed by adding specific corrections with IE8 hack. |
| floatz.form.css | FIX    | [Issue 9](https://code.google.com/p/floatz/issues/detail?id=9) | Button height in IE is different to other browsers. Adjusting visual appearance for all browsers. Using browser specific hacks for IE. |
| floatz.form.css | FIX    | [Issue 12](https://code.google.com/p/floatz/issues/detail?id=12) | Image in flz\_combifield is not correctly aligned in all spacers. Setting padding-top only for labels and inputs (see comment in issue tracker). |
| floatz.form.css | CHANGE | -     | Adding border to flz\_textbox, select and textarea to get same baseline of visual appearance. |
| floatz.form.css | CHANGE | -     | Renaming flz\_blockform to flz\_form. Removing (unnecessary) flz\_checkbox, flz\_radio. Adding CSS2 selectors for input fields (all browsers but IE5,6). Leaving flz\_inline only for IE 5,6 support and when label comes before radio, checkbox. |
| floatz.layout.css | FIX  | -     | Adding margin-right: -5px for flz\_r10 (otherwise box wraps to next line, as observed in tests/test.layout.layouter.html. See [IE Floated Columns Totaling 100% Bug](http://jacksleight.com/old/blog/2008/01/20/ie-floated-columns-totaling-100-percent-bug). |
| floatz.layout.css | FIX  | -     | Adding overflow: hidden to flz\_page for IE5, 6, 7 that is caused by corrections of width to solve sub-pixel-bug. |
| floatz.nav.css | CHANGE | [Issue 1](https://code.google.com/p/floatz/issues/detail?id=1) | Using CSS sprite image for flz\_tabmenu.  Removing all images and replacing it with tab\_menu.gif sprites image. Changing name of flz\_tabmenu to flz\_htabmenu and preparing it to use CSS sprite image. |
| floatz.nav.css | CHANGE | [Issue 13](https://code.google.com/p/floatz/issues/detail?id=13) | Use flz\_selected only for LI tags. Changing styles to use flz\_selected with LI an not with A for consistency with flz\_htabmenu. Adding workaround to support nested child selector in IE 5,6 for flz\_vmenu. |
| floatz.nav.css | CHANGE | -     | Changing top/bottom margin/padding of flz\_hmenu, flz\_vmenu, flz\_htabmenu, flz\_htabmenu\_bottom from 0.25 to 0.5em |
| floatz.reset.css | FIX  | -     | Text of input field slips under visible area at the bottom of the input field. Removing line-height and adding same font-size as in meyer CSS for global defaults on |
| floatz.reset.css | CHANGE | -     | Activating outline for a:focus (that was originally reset in meyer css) for accessibiliy & usability reasons.Each navigable element should be highlighted if it gets keyboard focus. |
| floatz.reset.css | CHANGE | -     | Adding "Arial" as common font for all elements. |
| floatz.reset.meyer.css | FIX  | [Issue 5](https://code.google.com/p/floatz/issues/detail?id=5) | Text of input field slips under visible area at the bottom of the input field. Changed line-height: 1 to auto due to cropped labels (e.g. y, p, j, ...) |

### Deprecated ###

None

### Removed ###

The following items have been removed.

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.form.css | FIX  | [Issue 6](https://code.google.com/p/floatz/issues/detail?id=6) | Hidden dialog and suggestion boxes in GWT because of z-index. Removing all occurences of z-index. |
| floatz.form.css | CHANGE | -     | Removing (unnecessary) flz\_checkbox, flz\_radio. |
| floatz.layout.css | FIX  | [Issue 6](https://code.google.com/p/floatz/issues/detail?id=6) | Hidden dialog and suggestion boxes in GWT because of z-index. Removing all occurences of z-index. |
| floatz.layout.center.css | FIX  | [Issue 6](https://code.google.com/p/floatz/issues/detail?id=6) | Hidden dialog and suggestion boxes in GWT because of z-index. Removing all occurences of z-index. |
| floatz.layout.liquid.css | FIX  | [Issue 6](https://code.google.com/p/floatz/issues/detail?id=6) | Hidden dialog and suggestion boxes in GWT because of z-index. Removing all occurences of z-index. |
| floatz.nav.css | CHANGE | [Issue 1](https://code.google.com/p/floatz/issues/detail?id=1) | Removing all images and replacing it with htabmenu.gif sprites image. |
| floatz.reset.css | CHANGE | -     | Removing style for ADDRESS that overrides meyer reset |

# Version 1.0.1 #

Version 1.0.1 is only a minor maintenance release.

## Summary of changes ##

### Changed ###

| Module | Type | Issue | Description |
|:-------|:-----|:------|:------------|
| floatz.form.css | CHANGE | -     | Replacing all styles that where directly bound to input, select and textarea (e.g. input.flz\_mandatory to .flz\_mandatory) |
| floatz.layout.css | CHANGE | -     | Removing duplicate of .flz\_clear |