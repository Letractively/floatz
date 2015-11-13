Last Update: July 17th, 2012

**This page is currently under construction and thus not finished.**

> 
---

> Note: this wiki page covers version 1.1.2.
> 
---


**Supposed readings**

It is recommended to read the following articles before starting with the current wiki article

  * [Basic Concepts](BasicConcepts.md)
  * [Layouting Pages](LayoutingPages.md)

**Table of content**



# Introduction #
Navigation is one of the most important concepts in web application. The appropriate means to that purpose are hyperlinks. But in practice the requirements on the look & feel of our navigation goes far beyond hyplinks: we need nice looking menus, tabboxes, toolbars with hover effects, highlighting and so on. The following wiki article shows a way how you can meet most of those requirements, without Javascript and multi-nested HTML tables - only with CSS and simple list elements. And if you need more, you can add additional effects to that light weight navigation solution with javascript based effects libraries like jQuery.

# Layouting list navigations #
## Defining a list navigation ##
Let´s start with the most basic navigation solution that is available in floatz: list navigation. The following code is based on example 5 of [Layouting pages](LayoutingPages.md). Because we want to focus on navigation only, first of all we delete all content from that sample page thats within the content box. The content box should look like this:

```
...
<!-- content -->
<div class="flz_box flz_r80 content">
   Content
</div>
...
```

Now we add a list of hyperlinks to the menu container. The list starts with an `UL` tag, followed by `LI` tags that contain hyperlinks as `A` tags for the navigation. Usually we will add URLs to the hyperlinks, but in our example we use "#" as placeholder.

```
...
<!-- menu -->
<div class="flz_box menu">
   <ul>
      <li><a href="#">Menu 1</a></li>
      <li><a href="#">Menu 2</a></li>
      <li><a href="#">Menu 3</a></li>
      <li><a href="#">Menu 4</a></li>
   </ul>
</div>
...
```

**Example 1 - Defining a list of hyperlinks** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_01.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01.jpg)

The result shows a simple list that isn't completely visible, because the menu container is not high enough. To transform the list into a list navigation we only have to add the CSS class `flz_listnav` to the class attribute of the `UL` tag.

```
<!-- menu -->
...
<div class="flz_box menu">
   <ul class="flz_listnav">
      <li><a href="#">Menu 1</a></li>
      <li><a href="#">Menu 2</a></li>
      <li><a href="#">Menu 3</a></li>
      <li><a href="#">Menu 4</a></li>
   </ul>
</div>
...
```

**Example 1b - Transforming the list to a list navigation** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_01b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01b.jpg)

Now the result is much better. The navigation elements are listed side by side. To make the navigation perfect, we add separators between the navigation items as well as tooltips that are shown when the mouse cursor moves over the items. Last but not least, we want to highlight the current navigation item. To get this, we add `flz_selected` to the class attribute of the desired navigation item´s `LI` tag.

```
...
<div class="flz_box menu">
   <ul class="flz_listnav">
      <li class="flz_selected"><a href="#" title="Goto Menu 1">Menu 1</a> |</li>
      <li><a href="#" title="Goto Menu 2">Menu 2</a> |</li>
      <li><a href="#" title="Goto Menu 3">Menu 3</a> |</li>
      <li><a href="#" title="Goto Menu 4">Menu 4</a></li>
   </ul>
</div>
...
```

**Example 1c - Finishing the list navigation example** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_01c.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01c.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01c.jpg)

### Changing the alignment of the list navigation ###
To change the alignment of the list navigation, we simply have to customize the list navigation in the context of the menu container within our CSS file. In the following example the alignment is changed from left (default) to center.

**CSS code:**

```
...
.menu .flz_listnav {
   text-align: center;
}
...
```
**Example 1d - Customizing the list navigation to centered alignment** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_01d.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01d.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01d.jpg)

If the alignment should be right instead, we change the CSS file again:

**CSS code**

```
...
.menu .flz_listnav {
   text-align: right;
...
}
```
**Example 1e - Customizing the list navigation to right alignment** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_01e.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01e.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_01e.jpg)

## Defining a top navigation ##
Next we add a navigation element to our example that is based on the list navigation. Its called top navigation and is normally used for secondary navigation that should occur on every page of the web site, but should not be part of the main navigation. Therefor we add a list navigation to the header container (as described in the previous section). Then we add `flz_topnav` after `flz_listnav` to the `class` attribute of the surrounding `UL` element.

> 
---

> Note: It is important that you first add `flz_listnav` to the class attribute and then `flz_topnav`. The top navigation class does not work on its on and only extends the behaviour of the list navigaton class.
> 
---


```
...
<!-- header -->
<div class="flz_box header">
   <ul class="flz_listnav flz_topnav">
      <li class="flz_selected"><a href="#" title="Goto Homepage">Home</a> |</li>
      <li><a href="#" title="Goto Sitemap">Sitemap</a> |</li>
      <li><a href="#" title="Goto Contact">Contact</a></li>
   </ul>
   Header
</div>
...
```
**Example 2 - Adding a top navigation to the header** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_02.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_02.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_02.jpg)

As you can see when you run the example, the top navigation container floats to the right corner of the header container. The reason for this is, because the page container is a relative positioned element and the `flz_topnav` annotation makes the list navigation to an absolute positioned element. See [basic concepts](BasicConcepts.md) for a description about using relative and absolute positioned elements.

## Defining a breadcrumb ##
Breadcrumbs are one of the most useful navigation concepts in web sites and applications. They show users where they currently are in the context of the sitemap and give them the possibility to navigate back to a specific page in this path. floatz also provides a CSS class for breadcrumb support.

To see how to get a breadcrumb, first we add a simple list navigation to the content container, then we add the `flz_breadcrumb` annotation after `flz_listnav` to the `UL` element. To extend the example, we also add some content to the content container.

```
<!-- content -->
...
<div class="flz_box flz_r80 content">
   <ul class="flz_listnav flz_breadcrumb">
      <li><a href="#" title="Goto Homepage">Home</a> &gt;</li>
      <li class="flz_selected"><a href="#" title="Goto Menu 1">Menu 1</a></li>
   </ul>
   <div class="flz_spacer">
      <h1>Content</h1>
      <p>
         Lorem ipsum dolor sit amet, consetetur sadipscing elitr ...
      </p>
   </div>
</div>
...
```

**Example 3 - Adding a breadcrumb navigation to the content container** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_03.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03.jpg)

The result is, that the breadcrumb floats to the top left corner of the whole page. Other than for the top navigation in the previous example, this is not what we want. The reason is, that the breadcrumb is an absolute positioned navigation element and thus needs a relative positioned container. In our case, the page is a relative positioned container by default but not the content container. To get the breadcrumb flowing within the content container, we make the content container a releative positioned element, by adding `flz_relative` to it. See [basic concepts](BasicConcepts.md) to get more information about relative and absolute positioned elements.

```
...
<!-- content -->
<div class="flz_box flz_r80 flz_relative content">
   <ul class="flz_listnav flz_breadcrumb">
      ...
   </ul>
</div>
...
```

**Example 3b - Making the content container relative positioned** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_03b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03b.jpg)

The result is a little bit better, but now the breadcrumb overlaps the text of the content container. To fix this, we have to add a padding at the top of our content container. We do this directly in the CSS file:

```
...
.content {
   background: inherit;
   padding-top: 2em;
}
...
```

**Example 3c - Making the content container relative positioned** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_03c.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03c.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_03c.jpg)

Now the breadcrumb works as expected and floats within the content container, above the text.

## Defining a toolbar ##
Last but not least, floatz provides also a list navigation type for toolbars. While the other examples were text based navigation elements, sometimes you may want to have an image based navigation in form of a toolbar for executing actions on your web page. The way to get a toolbar in floatz is as easy as for the top navigation and the breadcrumb.

To see the toolbar in action, we add an additional list navigation to the content container and extend its `class` attribute with `flz_toolbar`.

```
...
<!-- content -->
<div class="flz_box flz_r80 flz_relative content">
   <ul class="flz_listnav flz_breadcrumb">
      ...
   </ul>
   <div class="flz_spacer">
      <ul class="flz_listnav flz_toolbar">
         <li><a href="#"><img src="images/print.gif" alt="" title="Print page" /></a></li>
         <li><a href="#"><img src="images/favorite.gif" alt="" title="Add to favorites" /></a></li>
         <li><a href="#"><img src="images/mail.gif" alt="" title="Tell a friend" /></a></li>
      </ul>
      <h1>Content</h1>
      <p>
         ...
      </p>
   </div>
</div>
...
```

**Example 4 - Adding a toolbar to the content container** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_04.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_04.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_04.jpg)

The example shows a toolbar floating to the top right corner of the content container. This is an example how you can create a page wide toolbar. Sometimes you need a separate toolbar for each content block on your web page (e.g. for a blog page). To get this, we have to surround each content with a `DIV` element that is annotated with `flz_box` and `flz_relative`. Than we add a separate toolbar to each of the content boxes.

```
...
<!-- content -->
<div class="flz_box flz_r80 flz_relative content">
   <ul class="flz_listnav flz_breadcrumb">
      ...
   </ul>
   <div class="flz_spacer">
      <div class="flz_box flz_relative">
         <ul class="flz_listnav flz_toolbar">
            <li><a href="#"><img src="images/print.gif" alt="" title="Print page" /></a></li>
            <li><a href="#"><img src="images/favorite.gif" alt="" title="Add to favorites" /></a></li>
            <li><a href="#"><img src="images/mail.gif" alt="" title="Tell a friend" /></a></li>
         </ul>
         <h1>Content</h1>
         <p>
            Lorem ipsum dolor sit amet, consetetur sadipscing elitr ...
         </p>
      </div>
      <div class="flz_box flz_relative">
         <ul class="flz_listnav flz_toolbar">
            <li><a href="#"><img src="images/print.gif" alt="" title="Print page" /></a></li>
            <li><a href="#"><img src="images/favorite.gif" alt="" title="Add to favorites" /></a></li>
            <li><a href="#"><img src="images/mail.gif" alt="" title="Tell a friend" /></a></li>
         </ul>
         <h1>Content</h1>
         <p>
            Lorem ipsum dolor sit amet, consetetur sadipscing elitr ...
         </p>
      </div>
   </div>
</div>
...
```

**Example 4b - Adding a toolbar to each content box** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_04b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_04b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_04b.jpg)

# Layouting menus #
As you have seen in the previous chapters, unsorted lists are an easy way to structure navigation items for different usage scenarios. The list navigation, top navigation, breadcrumb and toolbar are text and/or image based navigation elements. But sometimes you need a more sophisticated way to visualize navigation elements on your web site: menus.

floatz ships with a horizontal menu as well as a vertical menu that are also based on the powerful concept of unsorted lists. The following chapters show you how easy it is to create menus and how you can customize them for your own needs.

## Defining a horizontal menu ##
To get a horizontal menu, we transform the current list navigation in the menu container of our example to a menu. Therefor we remove `flz_listnav` from the `UL` element and add `flz_hmenu` to the surrounding `DIV` container.

> 
---

> Note: In contrast to the list navigations, that are getting along with a simple `UL` element, the menus need an additional surrounding `DIV` container. The reason is because the menus are using CSS floats. That means each `LI` as well as the `UL` element becomes a floating element and thus must be covered by a container that holds everything together. Using this technic makes it possible to create anchors, that are enlarging the clickable area of each menu item, making it easier for users to click on them (see [Fitts law](http://en.wikipedia.org/wiki/Fitts's_law)).
> 
---


```
...
<!-- menu -->
<div class="flz_box flz_hmenu menu">
   <ul>
      <li class="flz_selected"><a href="#" title="Goto Menu 1">Menu 1</a></li>
      <li><a href="#" title="Goto Menu 2">Menu 2</a></li>
      <li><a href="#" title="Goto Menu 3">Menu 3</a></li>
      <li><a href="#" title="Goto Menu 4">Menu 4</a></li>
   </ul>
</div>
...
```
**Example 5 - Defining a horizontal menu** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_05.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05.jpg)

The result shows the horizontal menu in action. Try to move the mouse cursor over one menu item (only over the white space and not directly over the hyperlink) and you can see that the menu items white space is also clickable.

Because the height of the menu container seems a little bit to small for the contained horizontal menu, we slightly increase the height of the menu container in the CSS file to make it perfect.

```
.menu {
   background: #bbbccc;
   height: 2.20em;
}
```

**Example 5b - Increasing the height of the menu container**
([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_05b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05b.jpg)

### Changing the orientation of the horizontal menu ###
It is also possible to change the orientation of the horizontal menu from right (default) to left. The only thing that has to be changed is in the CSS file. Only add a `float:left` to your menu containers class.

```
...
.menu ul {
   float: left;
}
...
```

**Example 5c - Changing the menu orientation to left**
([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_05c.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05c.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05c.jpg)

To round the example up, we change the appearance of the vertical line at the beginning of each menu item from left to right within our CSS code:

```
...
.menu ul li a {
   border-left: none;
   border-right: 1px solid #000;
}
...
```

**Example 5d - Adjusting the menu separator for left orientation**
([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_05d.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05d.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_05d.jpg)

Now we´re done, defining a left oriented horizontal menu. If you want to see how it can be customized to your desired look & feel, see the customization section below.

## Defining a vertical menu ##
Next we add a vertical menu to example 5b. Thus we insert another unsorted list into the submenu container and annotate the surroundig `DIV` element with `flz_vmenu`.

```
<!-- submenu -->
<div class="flz_box flz_l20 flz_vmenu submenu">
   <ul>
      <li class="flz_selected"><a href="#" title="Goto Menu 1">Menu 1</a></li>
      <li><a href="#" title="Goto Menu 2">Menu 2</a></li>
      <li><a href="#" title="Goto Menu 3">Menu 3</a></li>
      <li><a href="#" title="Goto Menu 4">Menu 4</a></li>
   </ul>
</div>
```
**Example 6 - Adding a vertical menu**
([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_06.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_06.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_06.jpg)

One benefit of the vertical menu is, that it supports subordinate menus. That gives us the possibility to create a hierarchical navigation structure. To see this in action, we enhance our example by adding subordinate unsorted lists as sub menus to the vertical menu. floatz supports five levels by default.

```
<!-- submenu -->
<div class="flz_box flz_l20 flz_vmenu submenu">
   <ul>
      <li class="flz_selected"><a href="#" title="Goto Menu 1">Menu 1</a>
         <ul>
            <li><a href="#" title="Goto Menu 11">Menu 11</a>
               <ul>
                  <li><a href="#" title="Goto Menu 111">Menu 111</a>
                     <ul>
                        <li><a href="#" title="Goto Menu 1111">Menu 1111</a>
                           <ul>
                              <li><a href="#" title="Goto Menu 11111">Menu 11111</a></li>
                              <li><a href="#" title="Goto Menu 11112">Menu 11112</a></li>
                              <li><a href="#" title="Goto Menu 11113">Menu 11113</a></li>
                           </ul> 
                        </li>
                        <li><a href="#" title="Goto Menu 1112">Menu 1112</a></li>
                        <li><a href="#" title="Goto Menu 1113">Menu 1113</a></li>
                     </ul>   
                  </li>
                  <li><a href="#" title="Goto Menu 112">Menu 112</a></li>
                  <li><a href="#" title="Goto Menu 113">Menu 113</a></li>
               </ul>                     
            </li>
            <li><a href="#" title="Goto Menu 12">Menu 12</a></li>
            <li><a href="#" title="Goto Menu 13">Menu 13</a></li>
         </ul>   
      </li>
      <li><a href="#" title="Goto Menu 2">Menu 2</a></li>
      <li><a href="#" title="Goto Menu 3">Menu 3</a></li>
      <li><a href="#" title="Goto Menu 4">Menu 4</a></li>
   </ul>
</div>
```
**Example 6b - Adding subordinate menu items**
([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/LayoutingNavigation_06b.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_06b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingNavigation/images/Layouting_Navigation_06b.jpg)

## Customizing the menus ##
TBD

# Layouting tabboxes #
TBD

# Layouting skiplinks #
TBD

# Summary #

**Further readings**

The following wiki articles contain further information about how to use floatz for:

  * [Layouting Forms](LayoutingForms.md)
  * [Layouting Content](LayoutingContent.md)