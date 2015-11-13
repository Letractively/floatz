Last Update: July 27th, 2013

> 
---

> Note: this wiki page covers version 1.2.0.
> 
---


**Table of content**


floatz is available in the following download packages.

  * Production package
  * Development kit package
  * Module for Google Web Toolkit

# Production package #

The [production package](http://code.google.com/p/floatz/downloads/list) is especially prepared for use in **production** environments. It contains only those files that are really necessary and does not contain any comments, unnecessary whitespaces or line breaks. Because of its reduced readability, this package is **not recommended during development**.

Content of the production package:
| **Folder** | **Short Description** | **Details** |
|:-----------|:----------------------|:------------|
| floatz-1.2.0 | Root folder           | Root folder of the framework for easy [installation](GettingStarted#Step_2_-_Install.md). Contains one floatz CSS module in shrinked form for each layout mode as well as a copyright note |
| floatz-1.2.0/images | Image folder          | Contains background-images that are used e.g. for tabbed navigation |
| floatz-1.2.0/scripts | Script folder         | Contains shrinked version of javascript modules |

## Modules of production package ##

### CSS Modules of production package ###

Only one of the listed modules must be imported into your [project CSS file](GettingStarted#Step_3_-_Prepare.md) depending on the desired page layout. The **usage** column shows, what module is mandatory (must be used) or is optional (can be used). The last column shows if the modules have to be used in combination or instead of each other.

| **Usage** | **Module** | **Description** | |
|:----------|:-----------|:----------------|:|
| Mandatory | floatz.center.css | Shrinked and merged version of all floatz modules for center layout | OR |
| Mandatory | floatz.fixed.css | Shrinked and merged version of all floatz modules for fixed layout | OR |
| Mandatory | floatz.liquid.css | Shrinked and merged version of all floatz modules for liquid layout | |

### Javascript modules of production package ###

The load order column indicates the order in which each file has to be loaded. This sequence is very important, otherwise the scripts will not work properly.

| **Load Order** | **Usage** | **Module** | **Description** |
|:---------------|:----------|:-----------|:----------------|
| 1              | Optional  | less-1.4.1.min.js | Shrinked version of Less CSS |
| 2              | Mandatory | LAB-2.0.3.min.js | Shrinked version of LAB javascript module loader |
| 3              | Mandatory | jquery-1.8.2-min.js | Shrinked version of javascript DOM manipulation library that is used in floatz javascript modules |
| 4              | Mandatory | floatz.js  | Shrinked version of main module |
| 5              | Mandatory | floatz.browser.js | Shrinked version of browser detection module |
| 6              | Optional  | floatz.mobile.js | Shrinked version of mobile module that adds fixes when using webkit based mobile browsers |
| 7              | Optional  | floatz.skiplink.js | Shrinked version of skiplink module that adds fixes for skiplinks |

## Loading production modules ##

### Loading production CSS modules ###

Loading the CSS modules into your project is easy. It's only necessary to load one of the provided CSS modules depending on the layout mode you choose for your project. Use this module within your [project CSS file](GettingStarted#Step_3_-_Prepare.md) to load the entire framework:

```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.fixed.css)

   /* Project specific styles */
```

### Loading production Javascript modules ###

To load the javascript modules, you have to add the following code to the head section of your HTML page:

```
   <script type="text/javascript" src="styles/floatz-1.2.0/scripts/less-1.4.1.min.js"></script>
   <script type="text/javascript" src="styles/floatz-1.2.0/scripts/LAB-2.0.3.min.js"></script>
   <script type="text/javascript" src="scripts/MyProject.js"></script>
```

Then create a project specific script file (e.g. `C:\Projects\MyProject\scripts\MyProject.js`) and add the following lines of code:

```
   // Load jquery, less and floatz in correct order
   $LAB.script("./styles/floatz-1.2.0/scripts/jquery-1.8.2.min.js")
      .script("./styles/floatz-1.2.0/scripts/floatz.js").wait()
      .script("./styles/floatz-1.2.0/scripts/floatz.browser.js").wait()
      .script("./styles/floatz-1.2.0/scripts/floatz.mobile.js")
      .script("./styles/floatz-1.2.0/scripts/floatz.skiplink.js").wait(function() {
         $(document).ready(function() {

            // Start floatz modules
            floatz.start({
               debug : true,
               logLevel : floatz.LOGLEVEL.DEBUG,
               modules : [
                  "floatz.browser", 
                  "floatz.mobile", 
                  "floatz.skiplink"]
               });
            });
         });
```

## Affecting layouts in production mode ##

You can affect the kind of page layout that is used, by choosing one of the provided stylesheets depending on the desired layout mode. The following layout modes are supported. Each of them is represented by an according CSS file:

  * Fixed layout (default)
  * Centered layout
  * Liquid / fluid layout

For getting a deep knowledge about how to layout pages with floatz, see [Layouting Pages](LayoutingPages.md). The following examples are showing what kind of modules are necessary for each of the supported layout modes.

Load order for fixed layout (default):
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.fixed.css)

   /* Project specific styles */
```

Load order for liquid layout:
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.liquid.css)

   /* Project specific styles */
```

Load order for center layout:
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.center.css)

   /* Project specific styles */
```

# Development kit package #

The [development kit package](http://code.google.com/p/floatz/downloads/list) is provided for **development time**. It contains the frameworks CSS and Javascript modules as well as many other helpful utilities. The included CSS and Javascript files contain comments and line breaks that increase readability but also file size. They are **not recommended for use in production environments**.

Content of development kit package:
| **Folder** | **Short Description** | **Details** |
|:-----------|:----------------------|:------------|
| floatz.dev.kit-1.2.0 | Root folder           | Contains a changelog as well as a copyright notice |
| floatz.dev.kit-1.2.0/doc | Documentation folder  | Contains floatz documentation files |
| floatz.dev.kit-1.2.0/samples | Sample folder         | Contains different samples that show the use of floatz |
| floatz.dev.kit-1.2.0/src | Source folder         | Contains all floatz CSS modules |
| floatz.dev.kit-1.2.0/src/debug | Debug  folder         | Contains special floatz CSS modules that can be used for debugging |
| floatz.dev.kit-1.2.0/src/images | Image folder          | Contains background-images that are used e.g. for tabbed navigation |
| floatz.dev.kit-1.2.0/src/scripts | Script folder         | Contains javascript modules|
| floatz.dev.kit-1.2.0/templates | Template folder       | Contains templates for most common layout scenarios that can be used for project startup or as reference. The [Sourcecode Repository](http://code.google.com/p/floatz/source/browse/#svn/trunk/floatz.dev.kit/templates) shows a list of available layout templates |
| floatz.dev.kit-1.2.0/tests | Test folder           | Contains test pages that are used for module and browser compatibility tests. Can also be used to test your own project CSS and as reference |
| floatz.dev.kit-1.2.0/tools | Tools folder          | Contains some usefull utilities |
| floatz.dev.kit-1.2.0/tools/build | Tools folder          | Contains a build script to create CSS files in production folder and to update templates |
| floatz.dev.kit-1.2.0/tools/jsmin | Tools folder          | Contains javascript minifier tool for shrinking javascript module files |

## Modules of development kit package ##
### CSS Modules of development kit package ###

The **load order** column indicates the order in which each file has to be loaded. This sequence is very important, otherwise the CSS inheritance and thus the framework will not work properly. The **usage** column shows, what module is mandatory (must be used) or is optional (can be used). The last column indicates if the modules have to be used in combination or instead of each other.

| **Load Order** | **Usage** | **Module** | **Description** | |
|:---------------|:----------|:-----------|:----------------|:|
| 0              | Optional  | floatz.less | Loads all floatz modules in the correct order | AND |
| 1              | Mandatory | floatz.reset.meyer.less | Basic reset styles to get a common baseline for all browsers | AND |
| 2              | Mandatory | floatz.reset.less | Extends basic reset styles for floatz | AND |
| 3              | Mandatory | floatz.layout.less | Basic styles for layouting pages, content and web forms | AND |
| 4              | Optional  | floatz.form.less | Styles for build web forms | AND |
| 5              | Optional  | floatz.nav.less | Styles for creating navigation elements | AND |
| 6              | Optional  | floatz.layout.center.less | Extends basic layout styles for centered layout | AND |
| 6              | Optional  | floatz.layout.liquid.less | Extends basic layout styles for liquid layout | |

### Javascript modules of development kit package ###

Same modules as in production package (see above).

## Loading devlopment kit modules ##
### Loading development kit CSS modules ###

The easiest way to load the CSS modules into your project is by using the provided floatz.css file, that is added for convenience. It does not contain any CSS styles and is only responsible for loading the CSS modules in the correct order. Use this module within your [project CSS file](GettingStarted#Step_3_-_Prepare.md) to load the entire framework:

```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.less)

   /* Project specific styles */
```

Of course, it is also possible to import the modules directly from your project CSS file:

> 
---

> Note: In this case you have to take care that the modules are loaded in the correct order as indicated in the load order column of the module table above.
> 
---


```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.reset.meyer.less);
   @import url(floatz-1.2.0/floatz.reset.less);
   @import url(floatz-1.2.0/floatz.layout.less);
   @import url(floatz-1.2.0/floatz.form.less);
   @import url(floatz-1.2.0/floatz.nav.less);

   /* Project specific styles */
```

### Loading development kit Javascript modules ###

Same as for loading them in production package (see above).

## Affecting layouts in development mode ##

You can affect the kind of page layout that is used, depending on what additional layout module you load. The following layout modes are supported:

  * Fixed layout (default)
  * Centered layout
  * Liquid / fluid layout

For getting a better understanding about how to layout pages with floatz, see [Layouting Pages](LayoutingPages.md). The following examples are showing what kinds of modules are necessary for each of the supported layout modes.

Load order for fixed layout (default):
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.reset.meyer.less);
   @import url(floatz-1.2.0/floatz.reset.less);
   @import url(floatz-1.2.0/floatz.layout.less);
   @import url(floatz-1.2.0/floatz.form.less);
   @import url(floatz-1.2.0/floatz.nav.less);

   /* Project specific styles */
```

Load order for liquid layout:
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.reset.meyer.less);
   @import url(floatz-1.2.0/floatz.reset.less);
   @import url(floatz-1.2.0/floatz.layout.less);
   @import url(floatz-1.2.0/floatz.layout.liquid.less);
   @import url(floatz-1.2.0/floatz.form.less);
   @import url(floatz-1.2.0/floatz.nav.less);

   /* Project specific styles */
```

Load order for center layout:
```
   /* Framework specific styles */
   @import url(floatz-1.2.0/floatz.reset.meyer.less);
   @import url(floatz-1.2.0/floatz.reset.less);
   @import url(floatz-1.2.0/floatz.layout.less);
   @import url(floatz-1.2.0/floatz.layout.center.less);
   @import url(floatz-1.2.0/floatz.form.less);
   @import url(floatz-1.2.0/floatz.nav.less);

   /* Project specific styles */
```

# Module for Google Web Toolkit #

floatz is also available as JAR file for use in Google Web Toolkit based web applications. This section describes how you can integrate it into your project. More information about using floatz in GWT can be found under [Layouting in Google Web Toolkit](LayoutingInGoogleWebToolkit.md).

## Adding floatz to the class path ##

Before you start, copy the [latest version](http://code.google.com/p/floatz/downloads/list) of the floatz JAR file to the `WEB-INF/lib` folder of your web application and add it to the class path.

## Referencing floatz in your module descriptor ##

Next add a reference to floatz into your module descriptor by adding the following `inherits` tag.

```
   ...
  <!-- Other module inherits                                      -->
  <inherits name='com.floatzcss.gwt.Css'/>
   ...
  <script src="floatz-1.2.0/scripts/jquery-1.8.2.min.js"/>
  <script src="floatz-1.2.0/scripts/floatz.js"/>
  <script src="floatz-1.2.0/scripts/floatz.browser.js"/>
  <script src="floatz-1.2.0/scripts/floatz.mobile.js"/>
  <script src="floatz-1.2.0/scripts/floatz.skiplink.js"/>
```

## Loading Javascript modules ##

Now add the following code to your GWT entry point class to load the desired javascript modules.

```
   public void onModuleLoad() {

      // Start floatz modules
      ModuleManager.start(false, LogLevel.INFO, "floatz.browser", "floatz.mobile");

      ...
   }
```

## Affecting layouts ##

You can affect the kind of page layout that is used, by choosing one of the provided CSS bundles depending on the desired layout mode. The following layout modes are supported. Each of them is represented by an according CSS bundle:

  * Fixed layout (default)
  * Centered layout
  * Liquid / fluid layout

For getting a deep knowledge about how to layout pages with floatz, see [Layouting Pages](LayoutingPages.md). The following examples are showing what kinds of modules are necessary for each of the supported layout modes.

> 
---

> Note: Inject the layout module directly in the `onLoadModule` method of your web application.
> 
---


Code for liquid layout:
```
   private static final Floatz FLOATZ = Floatz.INSTANCE;

   public void onModuleLoad() {
      ...	
      FLOATZ.layoutLiquid().ensureInjected();
      ...
   }
```

Code for center layout:
```
   private static final Floatz FLOATZ = Floatz.INSTANCE;

   public void onModuleLoad() {
      ...	
      FLOATZ.layoutCenter().ensureInjected();
      ...
   }
```

**Further readings**

The following wiki articles contain further information about how to use floatz in pratice:

  * [Getting started](GettingStarted.md)
  * [Basic Concepts](BasicConcepts.md)