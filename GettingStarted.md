Last Update: July 29th, 2013

> 
---

> Note: this wiki page covers version 1.2.0
> 
---


**Table of content**



# Download #
First of all you have to download floatz from http://code.google.com/p/floatz/. The latest version is offered directly on the project home under "featured downloads" on the right side of the page. Alternatively check the [download section](http://code.google.com/p/floatz/downloads/list) if you are interested in another version.

floatz is available in two separate download packages:

  * floatz-1.2.0.zip
  * floatz.dev.kit-1.2.0.zip

The first package is thought for use in production environment and contains only what is really necessary. The second package contains additional files that are only interesting during development phase. The current tutorial considers only the production package. See [What's inside](WhatsInside.md) for more information about the content of each package.

# Install #
Installation is very easy. Only unzip the downloaded file into a desired folder on your computer (e.g. into `C:\Program Files\floatz`). During installation, a separate subfolder is created, that contains also the version number of floatz (e.g. `C:\Program Files\floatz\floatz-1.2.0`).

# Setup a project #
Before you can start using floatz, you have to setup your project environment. The easiest way to achieve this, is by using one of the provided floatz templates or manually if you prefer starting with a blank file.

## Prepare your project by using a floatz template ##
The floatz development kit ships with a set of ready-to-use templates for different layouts as well as an empty layout template (see [What's inside](WhatsInside.md) for an overview). The following instruction uses the empty layout template.

  * Create a project folder (e.g. `C:\Projects\MyProject`)
  * Copy the whole content of the desired template folder (e.g. `C:\Program Files\floatz\floatz.dev.kit-1.2.0\templates\layout.empty\*.*`) into your project folder (e.g. `C:\Projects\MyProject`)
  * Rename the provided project stylesheet `C:\Projects\MyProject\styles\project.css` to `C:\Projects\MyProject\styles\MyProject.css`
  * Rename the provided project script file `C:\Projects\MyProject\scripts\project.js` to  `C:\Projects\MyProject\scripts\MyProject.js`
  * Change the stylesheet import in `C:\Projects\MyProject\index.html` from `styles/project.css` to `styles/MyProject.css`. The code should look like this

```
<link rel="stylesheet" type="text/css" href="styles/MyProject.css" />
```
  * Change the script import in `C:\Projects\MyProject\index.html` from `scripts/project.js` to `scripts/MyProject.js`. The code will look like this

```
<script type="text/javascript" src="scripts/MyProject.js"></script>
```

  * Optional: Open the project stylesheet `C:\Projects\MyProject\styles\MyProject.css` and change the imported floatz CSS file from `floatz.liquid.css` to the desired layout stylesheet (e.g. `floatz.fixed.css` for fixed layout). The import should look like this:

```
@import url(floatz.1.2.0/floatz.fixed.css);
```

  * Delete the floatz stylesheets from `C:\Projects\MyProject\styles\floatz.1.2.0` you do not need (see `C:\Projects\MyProject\styles\MyProject.css` what is imported).

That's it. Now you can start to [layout your pages](LayoutingPages.md).

## Setup your project manually ##

If you want to setup your project manually, here's what you have to do:

  * Create a project folder (e.g. `C:\Projects\MyProject`)
  * Create your projects CSS folder (e.g. `C:\Projects\MyProject\styles`)
  * Copy floatz from its installation directory (see above) into your project CSS folder (e.g. `C:\Projects\MyProject\styles\floatz-1.2.0`)
  * Create your projects stylesheet within your projects CSS folder (e.g. `C:\Projects\MyProject\styles\MyProject.css`) and add the following lines to it

```
/* Framework specific styles */
@import url(floatz-1.2.0/floatz.fixed.css)

/* Project specific styles */
```

> 
---

> Note: floatz comes in three different layout modes, each represented by its own stylesheet. Change the import statement to the particular file if you want to use liquid or center layout. Delete the ones you do not need from `C:\Projects\MyProject\styles\floatz.1.2.0`
> 
---


  * Create your project start page (e.g. `C:\Projects\MyProject\index.html` and link to your project stylesheet.

```
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>MyProject</title>
<meta http-equiv="content-type" content="text/html; CHARSET=utf-8" />
<meta http-equiv="content-script-type" content="text/javascript" />
<meta http-equiv="content-style-type" content="text/css" />
<meta http-equiv="content-language" content="en" />
<meta name="author" content="" />
<meta name="robots" content="index,follow" />
<meta name="description" content="" />
<!-- Load project CSS without less -->
<!-- <link rel="stylesheet" type="text/css" href="styles/MyProject.css" /> -->
<!-- Load project CSS with less -->
<link rel="stylesheet/less" type="text/css" href="styles/MyProject.less" />
<script type="text/javascript" src="styles/floatz-1.2.0/scripts/less-1.4.1.min.js"></script>
<!-- -->
<script type="text/javascript" src="styles/floatz-1.2.0/scripts/LAB-2.0.3.min.js"></script>
<script type="text/javascript" src="scripts/MyProject.js"></script>
</head>
<body>
   <!-- page -->
   <div id="flz_page">
      Hello World!
   </div>
</body>
</html>
```

  * Create a project specific javascript file (e.g. `C:\Projects\MyProject\scripts\MyProject.js`), add the following code to load the desired Javascript modules.

```
// Load jquery, less and floatz in correct order
$LAB.script("./styles/floatz-1.2.0/scripts/jquery-1.8.2.min.js")
   .script("./styles/floatz-1.2.0/scripts/floatz.js").wait()
   .script("./styles/floatz-1.2.0/scripts/floatz.browser.js").wait()
   .script("./styles/floatz-1.2.0/scripts/floatz.mobile.js")
   .script("./styles/floatz-1.2.0/scripts/floatz.skiplink.js")
   .wait(function() {
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

Now your project environment is up and running and you can start to layout your web pages using floatz.

# Start layouting #

Have a look at the following wiki articles to see how to use floatz:

  * [Basic Concepts](BasicConcepts.md)
  * [Layouting Pages](LayoutingPages.md)
  * [Layouting Forms](LayoutingForms.md)
  * [Layouting Content - tbd.](LayoutingContent.md)
  * [Class Reference](ClassReference.md)

You'll find additional information and sources at

  * [Templates](http://code.google.com/p/floatz/source/browse/#svn/trunk/floatz.dev.kit/templates)
  * [Test pages](http://code.google.com/p/floatz/source/browse/#svn/trunk/floatz.dev.kit/tests)