Last Update: August 10th, 2013

> 
---

> Note: this wiki page covers version 1.2.0
> 
---


**Supposed readings**

It is recommended to read the following articles before starting with the current wiki article:

  * [Getting started](GettingStarted.md)
  * [Basic Concepts](BasicConcepts.md)

**Table of content**


# Creating the basic page structure #
Layouting pages is really easy and straightforward in floatz. The following wiki article describes how to set up a basic page layout, customize the page elements, change the layout mode of the page and explains more advanced techniques like combining different layout modes.

## Defining the page container ##
First of all we need a page container. The page container must be the first element within the `BODY` of the HTML page. As you can see in the code example, the page container is a `DIV` element with the CSS id `flz_page`. Using an id assures, that the page container can occur only once on the HTML page. While the `BODY` element is used as background for the viewport of the browser, the page container defines the visual edges of our page. As we will see later in this article, the width of the page container is influenced by the layout mode that is used. In this article we start with a fixed layout.

**CSS Code**
```
/* Loads floatz CSS framework */
@import url(floatz-1.1.2/floatz.fixed.css);

/* Project specific styles */
```

**HTML code**
```
<body>
   <!-- page -->
   <div id="flz_page">
      page
   </div>
</body>
```
**Example 1 - Defining the page container** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_01.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_01.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_01.jpg)

## Defining the basic page elements ##
Next we want to create a classic page layout structure with a header, a horizontal menu, a vertical submenu on the left, a content container on the right and and last but not least a footer. Therefore we add a box for each of the page´s layout elements within the page container. A box is a `DIV` element with an associated CSS class named `flz_box`.

```
<!-- page -->
<div id="flz_page">
   <!-- header -->
   <div class="flz_box">
      Header
   </div>
   <!-- menu -->
   <div class="flz_box">
      Menu
   </div>
   <!-- submenu -->
   <div class="flz_box">
      Submenu
   </div>
   <!-- content -->
   <div class="flz_box">
      Content
   </div>
   <!-- footer -->
   <div class="flz_box">
      Footer
   </div>
</div>
```
**Example 2 - Defining the basic page elements** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_02.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_02.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_02.jpg)

When you run the sample code and look at the result, you will see that each of the boxes is shown in a separate row. The reason is that a box element has a width of 100% by default.

To change that, we add layouters to the submenu and the content container, because they should appear side by side. We use a left oriented layouter with a width of 20% (`flz_l20`) for the submenu and a right oriented layouter with a width of 80% (`flz_r80`) for the content container. To fix a bug in Internet Explorer, it is also necessary to add a right oriented layouter to the last box element in a sequence of boxes on the same level (see [Browser Hacks](BrowserHacks.md) for more details). In our case the footer is the last box in the sequence and thus must be marked with `flz_r100`. floatz ships with a list of predefined layouters to support most common layouts (see [Class Reference](ClassReference.md)).

```
<!-- page -->
<div id="flz_page">
   <!-- header -->
   <div class="flz_box">
      Header
   </div>
   <!-- menu -->
   <div class="flz_box">
      Menu
   </div>
   <!-- submenu -->
   <div class="flz_box flz_l20">
      Submenu
   </div>
   <!-- content -->
   <div class="flz_box flz_r80">
      Content
   </div>
   <!-- footer -->
   <div class="flz_box flz_r100">
      Footer
   </div>
</div>
```
**Example 3 - Adding layouters** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_03.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_03.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_03.jpg)

## Customizing the page elements ##
As you can see in the previous example, floatz does not dictate you any kind of class names for your page elements. All you need are boxes and layouters. Next we create our own project specific CSS classes for each page element and attach them to the `class` attribute of the appropriate boxes in the HTML markup.

Now we are able to do some customization of the page elements using CSS. In this example we add background colors for the `BODY` (viewport background), the page container and all of our boxes. We also set `em` based heights for the header, the menu and the footer, which lets our layout resize proportional to the used font size.

Especially the submenu and the content box should resize with their content, thus do not get any height declarations. To see this in action we add some dummy text to the content container.

**CSS code**
```
/* Project specific styles */
body {
   background: #eeeccc;
}

#flz_page {
   background: #cccccc;
}

.header {
   background: #aaaccc;
   height: 5em;
}

.menu {
   background: #bbbccc;
   height: 2em;
}

.submenu {
   background: inherit;
}

.content {
   background: inherit;
}

.footer {
   background: #dddccc;
   height: 2em;
}
```

**HTML code**
```
<!-- page -->
<div id="flz_page">
   <!-- header -->
   <div class="flz_box header">
      Header
   </div>
   <!-- menu -->
   <div class="flz_box menu">
       Menu
   </div>
   <!-- submenu -->
   <div class="flz_box flz_l20 submenu">
      Submenu
   </div>
   <!-- content -->
   <div class="flz_box flz_r80 content">
      <div class="flz_spacer">
         <h1>Header 1</h1>
         <p>
            Lorem ipsum dolor sit amet ...
         </p>
         <h2>Header 2</h2>
         <p>
            Lorem ipsum dolor sit amet ...
         </p>
         <h2>Header 2</h2>
         <p>
            Lorem ipsum dolor sit amet ...
         </p>
      </div>
   </div>
   <!-- footer -->
   <div class="flz_box flz_r100 footer">
      Footer
   </div>
</div>
```
**Example 4 - Customizing the page elements** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_04.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_04.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_04.jpg)

The custom CSS classes for the page elements also give us the possibility to style default HTML tags in the context of specific layout elements (relative styling). In our case, we add some margins to the header and paragraph tags within the content container for an example.

**CSS Code**
```
...

.content {
   background: inherit;
}
.content h1, h2 {
   margin-bottom: 0.5em;
}
.content p {
   margin-bottom: 1em;

...
}
```

**Example 5 - Contextual customization with relative styles** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_05.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_05.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_05.jpg)

## Changing the layout mode ##
Now we are finished with our basic page layout. But what if we want to change the layout afterwards? Nothing is easier than that. As long as we follow the [basic concepts](BasicConcepts.md), floatz gives us the flexibility to switch to another layout mode for already finished pages, without any change to our HTML markup. In the current example, we started with a fixed layout. To change to e.g. a centered (and fixed) layout mode, we only have to change the `@import` statement in our project CSS file.

**CSS code**
```
/* Loads floatz CSS framework */
@import url(floatz-1.1.2/floatz.center.css);

/* Project specific styles */
...
```
**Example 6 - Changing to centered layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_06.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_06.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_06.jpg)

For the rest of our article we switch to the last of the three layout modes that are supported by floatz: liquid layout.

**CSS code**
```
/* Loads floatz CSS framework */
@import url(floatz-1.1.2/floatz.liquid.css);

/* Project specific styles */
...
```
**Example 7 - Changing to liquid layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_07.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_07.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_07.jpg)

To avoid problems with floating elements, especially with too small viewports in liquid layouts, floatz adds by default a `min-width` of 985 pixels to the page container when the layout mode is switched to liquid layout. If you also plan to support Internet Explorer 6, the `min-width` style does not work. In that case you have to add some extra markup directly under the page container and before the first layout element, in our example the header container.

```
<!-- page -->
<div id="flz_page">
   <!-- min width containers -->
   <div id="flz_minwidth">
      <div id="flz_minwidthcontent">
         <!-- header -->
         <div class="flz_box header">
            Header
         </div>

         ...

      </div>
   </div>
</div>
```
**Example 8 - Adding extra markup to support min-width in IE6** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_08.html))

The extra min-width containers have no negative impact on the other browsers, so you are on the save side, if you generally add the min-width containers to your pages in a liquid layout scenario.

# Advanced topics #
The following subsections give you some insight how you can improve the page layout in some special situations.

## Combining fixed and liquid layouts ##
There may be situations, where we need one or more layout container with a fixed width, instead of a liquid width based on a percentage declaration. When we take a look at our current layout, the submenu on the left side of our page has a liquid width of 20%. When we resize the browser window in its width, the submenu is resized. How can we change it to a fixed width without affecting the container on its right side that should still be liquid?

First we are fixing the width of our submenu container by adding a width of 20em to its CSS class. Then we are adding a left margin of 20em to the content containers CSS class. Finally we remove `flz_box` and `flz_r80` from the content container in our HTML markup. That causes the content container to return to the document flow instead of floating to the right side of the submenu container. Because we have removed the layouter, the content container becomes a simple `DIV` block element with a width of 100%. The submenu floats over the content container and overlaps the left margin of the content container. The impression is that they are placed side-by-side.

When you resize the browser window again now, you will see that the layout is still liquid, but the submenu no longer resizes.

**CSS code**
...

```
.submenu {
   background: inherit;
   width: 20em;
}

.content {
   background: inherit;
   margin-left: 20em;
}

...
```

**HTML code**
```
...

<!-- submenu -->
<div class="flz_box flz_l20 submenu">
   Submenu
</div>
<!-- content -->
<div class="content">

   ...

</div>

...
```
**Example 9 - Combining fixed and liquid layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_09.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_09.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_09.jpg)

The previous example showed the easiest way to change the markup for a combination of fixed and liquid layout. The downside of removing `flz_box` from the content box is, that it can not act as container for absolute positioned elements anymore - even when you assign `flz_relative` to it. In that case you have to add a subordinate `flz_box` element with `flz_relative` between the content container and the spacer.

```
<!-- content -->
<div class="content">
   <div class="flz_box flz_relative">
      <ul class="flz_listnav flz_toolbar">
         <li><a href="#"><img src="images/print.gif" alt="" title="Print page" /></a></li>
         <li><a href="#"><img src="images/favorite.gif" alt="" title="Add to favorites" /></a></li>
         <li><a href="#"><img src="images/mail.gif" alt="" title="Tell a friend" /></a></li>
      </ul>
      <div class="flz_spacer">
         ...
      </div>
   </div>
</div>
```
**Example 9b - Using content box as container for absolute positioned element** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_09b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_09b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_09b.jpg)

The example uses `flz_toolbar` that is an absolute positined element by default, to show  this behavior in action. See [basic concepts](BasicConcepts.md) for more information about using relative and absolute positioning.

## Combining centered and liquid layout ##
The centered layout mode of floatz uses a fixed width design. If you want to have a liquid layout that is centered, use the CSS files for liquid layout mode and add a left and right margin to the `body` tag in your CSS file.

```
/* Loads floatz CSS framework */
@import url(floatz-1.1.2/floatz.liquid.css);

/* Project specific styles */
body {
   margin: 0 10em;
}
```

The demo puts everything together: a centered design that combines fixed and liquid layout containers.

**Example 10 - Combining fixed and liquid layout containers** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_10.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_10.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_10.jpg)

# Layouting with panels #
Since version 1.2.0 floatz provides a new layout mechanism based on absolute positioning called panels. In contrast to the traditional float based mechanism this gives you the possibility to create desktop like fluid web applications that always leverage the full available screen. This kind of layout is a very powerful tool and it solves some common problems in traditional layouting approaches:

  * Full leverage of the available screen size
  * Equal heights of vertical panels
  * Fixed positioned panels without the need for old-school iframes

> 
---

> Note: I´m not sure who invented this kind of layout, how ever the first time I got in touch with it was in [Google Web Toolkit](http://www.gwtproject.org/). Panel based layouts are supported for all major browsers as well as IE7 and above.
> 
---


Enough of the words, lets have a look how this works in practice.

## Switching from box to panel layout ##
Lets change the markup and css of example 7 we have created in the previous chapter "Changing the layout mode". First we change the markup as follows:

```
<body>
  <!-- header -->
    <div class="flz_panel header">Header</div>
    <!-- menu -->
    <div class="flz_panel menu">Menu</div>
    <!-- submenu -->
    <div class="flz_panel submenu">Submenu</div>
    <!-- content -->
    <div class="flz_panel content">
      <div class="flz_spacer">
         ...
      </div
    </div>
    <!-- footer -->
    <div class="flz_panel footer">Footer</div>
</body>
```

We removed the surrounding `flz_page` container because it is not necessary anymore. Then we changed all containers from `flz_box` to `flz_panel` and removed the layouters `flz_l20`, `flz_r80` and `flz_r100` from the submenu, the content and the footer. This is all from the markup side. Now lets have a look at the preliminary result:

**Example 11 - Changing the markup to panel layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_11.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11.jpg)

Well this is not what you would have expected. But it shows the default behavior of panels. Each panel is an absolute positioned layout container starting at top:0, bottom:100%, left: 0, right: 100%. This is why all containers are sticking at the top of the page. Next we also have to change the according styles to show the panel containers at their desired positions.

## Styling the panels ##

To acchieve that we do the following changes in our stylesheet of example 7:

```
  ...

  /* Project specific styles */
  body {
    background: #eeeccc;
  }

  .header {
    background: #aaaccc;
    bottom: auto;
    height: 5em;
  }

  .menu {
    background: #bbbccc;
    bottom: auto;
    height: 2em;
    top: 5em;
  }

  .submenu {
    background: inherit;
    bottom: 2em;
    right: 20%;
    top: 7em;
  }

  .content {
    background: #cccccc;
    bottom: 2em;
    left: 20%;
    top: 7em;
  }

  .footer {
    background: #dddccc;
    height: 2em;
    top: auto;
  }

  ...
```

For the header panel we have to set the bottom position. Because we have a height set, we only have to set `bottom: auto`.

The menu should be shown below the header. Because the header has a height of 2em we have to set the menus top position to the end position of the header, thus also 2em. The bottom position also has to be set to auto because of the existing height.

The content and submenu container should start below the menu, thus we set their top position to the sum of the header height (5em) and the menu height (2em), that is 7em. The bottom position of both containers must be set to the height of the footer panel: 2em.

The footer container now gets `top: auto` because it should start at the bottom and it already has a height set.

Instead of using layouters as in the box layout based example we now set the width of the submenu and content panel by setting their right (submenu) and their left (2em) position. The content container also gets the background color, that we have used in examples 7 page container.

**Example 11b - Styling the panels** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_11b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11b.jpg)

Now the results looks good. Our panel layout spans the whole screen regardless how large or small we size the browser window. But there is one problem with the content panel when the window gets too small: The content gets cropped at the bottom but no scrollbar is available. Lets add `flz_scrollpanel` to the content panel to solve that.

```
  ...
  <div class="flz_scrollpanel content">
    <div class="flz_spacer">
      ...
    </div>
  </div>
  ...
```

This is much better now and you see one of the benefits of the panel layout: the footer always stays visible only the content panel scrolls - all without the use of the webs enemy of the first days: iframes. Panels can also be nested. So think about fixed button bars at the bottom for large input forms or web applications for mobile devices, ... The possibilities are infinite.

**Example 11c - Changing the content panel to flz\_scrollpanel** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_11c.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11c.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11c.jpg)

## Using a fixed width for the submenu ##

You don´t want to have a fixed width for the submenu and only the content container should size in a liquid manner? No problem. Simply change the right and left positions of both containers to the same fixed value instead of percentages ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_11d.html)):

```
  .submenu {
    ...
    right: 15em;
    ...
 }

  .content {
    ...
    left: 15em;
    ...
  }
```

## Adding print support ##

Floatz also comes with full print support for panels. The only thing we have to do is to tell the browser what panels we don´t want to see on our print output. We also correct the content panels left position to 0.

```
  @media print {
    .header {
      display: none;
    }
    .menu {
      display: none;
    }
    .content {
      left: 0;
    }
    .submenu {
      display: none;
    }
    .footer {
      display: none;
    }
  }
```

**Example 11e - Adding print support** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/LayoutingPages_11e.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11e.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingPages/images/Layouting_Pages_11e.jpg)

# Summary #
What you have learned in this wiki article:

  * Creating page layouts with floatz is easy and straight forward
  * Define your page container with `flz_page`
  * Use boxes (`flz_box`) for your page containers
  * Add layouters to set the width of the boxes
  * Always add a right oriented layouter to the last box in a sequence on the same level
  * Customize boxes with custom CSS classes
  * Change layout modes by using different floatz imports
  * Floatz supports to fixed layout modes (fixed and center) as well as a liquid mode
  * Liquid layout mode sets a min-width of 985px for `flz_page` by default
  * Additional markup is necessary to support min-width in Internet Explorer 6
  * Centered, fixed and liquid layouts can be combined
  * Panel based layouts allow us to create desktop like layouts without iframes
  * Panel layouts give us many new opportunities (e.g. for mobile devices)
  * Panels are not supported in IE6 and below
  * `flz_panel` and `flz_scrollpanel` are coming with full print support

#### Further readings ####
The following wiki articles contain further information about how to add content to your basic page layout:

  * [Layouting Content](LayoutingContent.md)
  * [Layouting Forms](LayoutingForms.md)