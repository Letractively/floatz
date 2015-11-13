Last Update: July 17th, 2012

> 
---

> Note: this wiki page covers version 1.1.2.
> 
---


#### Supposed readings ####
It is recommended to read the following articles before starting with the current wiki article:

  * [Getting started](GettingStarted.md)

**Table of content**


# Basics #
This wiki page contains basic information about the key elements and concepts of floatz. It also covers some advanced topics in conjunction with boxes that are also worth to know to use them in your projects.

## Page ##
The **page** is the underlying container for your page layouts. It is implemented as a `DIV` element and is decorated with a CSS id named `flz_page`. The page container is the first element within the `BODY` tag and can occur only once on a web page. All of your markup must be put into the page container. The page container is also used to define if the web page should appear in a fixed, a centered or a liquid layout. See [Layouting Pages](LayoutingPages.md) for more information. The following sample shows the use of the page container.

```
<body>
   <div id="flz_page">
      Page container
   </div>
</body
```
**Example 1 - Page container** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_01.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_01.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_01.jpg)

## Boxes ##
The **box** is the most elementary layout element in floatz. It is used whenever something has to be layouted on web pages, be it the whole page layout, the micro structure of page content or even the visualization of a web form. A box is implemented as a left floating `DIV` element (that's where to name of floatz comes from) with an attached CSS class named `flz_box`. By default a box is as wide as its parent container and as high as its content.

The following sample shows the default behavior of boxes. Each box is shown in a separate row and is as wide as its parent container. In this sample, the parent container is the page container.

```
<div class="flz_box">
   box 1
</div>
<div class="flz_box">
   box 2
</div>
```
**Example 2 - Default boxes** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_02.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_02.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_02.jpg)

## Layouters ##

To change the width and the adjustment of boxes, floatz uses so called **layouters**. Layouters are marker classes and are attached to boxes. The name of a layouter contains information about the orientation (l=left, m=mid, r=right) and the width (in%) of its underlying box.

> 
---

> Note: In contrast to the width declaration, the orientation is only for information and does not affect the appearance of the underlying box. Boxes are always left floating, unless you specify something different during customization. But it is very important to use the correct orientations, because they also fix some issues in conjunction with Internet Explorer (see [Browser Hacks](BrowserHacks.md) for more details).
> 
---


To see the layouters in action, let's add some to the boxes in the previous example. A left oriented layouter to the box that appears on the left side and a right oriented for the box on the right side, each with a width of 50%. The example also shows the float behavior of the boxes. Because the first box now takes only half of the parent containers width, the second box floats to its right edge into the same row.

```
<div class="flz_box flz_l50">
   box 1
</div>
<div class="flz_box flz_r50">
   box 2
</div>
```
**Example 3 - Boxes and layouters** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_03.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_03.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_03.jpg)

You can combine as many layouters you need to gain your desired layout. floatz ships with a set of predefined layouters for the most common layout scenarios (see [Class Reference](ClassReference.md) for an overview). If you need additional layouters for special cases, have a look at the original layouter CSS and build your own in your project stylesheet. You only have to take care that you consider also the bug fixes for Internet Explorer to make them work in all browsers.

The following example uses a four column layout, where each box has a width of 25%. You see that the first box is attached with a left oriented layouter, followed by two mid oriented boxes and finally a box with a right oriented layouter.

```
<div class="flz_box flz_l25">
   box 1
</div>
<div class="flz_box flz_m25">
   box 2
</div>
<div class="flz_box flz_m25">
   box 3
</div>
<div class="flz_box flz_r25">
   box 4
</div>
```
**Example 4 - Boxes and multiple layouters** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_04.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_04.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_04.jpg)

When you attach layouters to boxes, you should take care that the sum of all layouters results in 100%. Otherwise the chance is high that the boxes will not float as you would expect. Means: if the available space after a box in a row is sufficient, the subsequent box floats into the same row, if not it floats into the next row to left edge of the parent container. In some cases it is necessary to influence the default float. The advanced topic chapter below covers how to clear the float of boxes.

## Spacers ##
Now we are getting to the last of the basic concepts of floatz: **Spacers**. They are used to add whitespace to boxes. A spacer is implemented as a `DIV` element with an attached spacer CSS class (see [Class Reference](ClassReference.md) for an overview) and is nested within a box. Each spacer has a default padding of 0.5em to 1em, depending on the kind of spacer that is used. The following example shows the use of a basic spacer that adds a padding of 1em to the top, left, bottom and right edge of the box.

```
<div class="flz_box">
   <div class="flz_spacer">
      box 1
   </div>
</div>
```
**Example 5 - Box and spacer** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_05.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_05.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_05.jpg)

You may ask why floatz is using spacers and is adding additional markup to the boxes, when you could also add margins and paddings directly to them. The reason for this is the standard box model of CSS2: if you add margins, paddings or even borders to an element that is sized in percent, the width of the added margins, paddings and borders is added to the width of the element. That means, the element is getting wider as you have specified. floatz is designed to work also for liquid layouts and therefore uses widths in percent. To avoid unpredictable results when adding whitespace directly to boxes, floatz provides the concept of spacers.

> 
---

> Note: If adding additional markup is not an option for you, please have a have a look at [Avoiding obtrusive markup and CSS](AvoidingObtrusiveMarkupAndCss.md).
> 
---


floatz offers a set of predefined spacers as well as subspacers to support as much as possible layout combinations of boxes and layouters to let nothing to be desired. The following sample shows a single row / multi column scenario. The spacers are adding a padding of 1em at the edges and between the boxes (columns).

```
<div class="flz_box flz_l25">
   <div class="flz_lspacer">
      col1
   </div>
</div>
<div class="flz_box flz_m25">
   <div class="flz_mspacer">
      col2
   </div>
</div>
<div class="flz_box flz_m25">
   <div class="flz_mspacer">
      col3
   </div>
</div>
<div class="flz_box flz_r25">
   <div class="flz_rspacer">
      col4
   </div>
</div>
```
**Example 6 - Boxes and spacers, single row / multi column scenario** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_06.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_06.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_06.jpg)

The next example demonstrates spacers that are best for a multi row / single column scenario, where you get a padding of 1em at the edges and between the boxes (rows).

```
<div class="flz_box">
   <div class="flz_spacer_mrsc_top">
      Row 1
   </div>
</div>
<div class="flz_box">
   <div class="flz_spacer_mrsc_mid">
      Row 2
   </div>
</div>
<div class="flz_box">
   <div class="flz_spacer_mrsc_bottom">
      Row 3
   </div>
</div>
```
**Example 7 - Boxes and spacers, multi row / single column scenario** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_07.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_07.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_07.jpg)

The last example shows a more complex scenario with multi rows / multi columns where a constant padding of 1em is needed around and between all boxes.

```
<div class="flz_box flz_l33">
   <div class="flz_lspacer_mrmc_top">
      row1 col1
   </div>
</div>
<div class="flz_box flz_m33">
   <div class="flz_mspacer_mrmc_top">
      row1 col2
   </div>
</div>
<div class="flz_box flz_r33">
   <div class="flz_rspacer_mrmc_top">
      row1 col3
   </div>
</div>
<div class="flz_box flz_l33">
   <div class="flz_lspacer_mrmc_mid">
      row2 col1
   </div>
</div>
<div class="flz_box flz_m33">
   <div class="flz_mspacer_mrmc_mid">
      row2 col2
   </div>
</div>
<div class="flz_box flz_r33">
   <div class="flz_rspacer_mrmc_mid">
      row2 col3
   </div>
</div>
<div class="flz_box flz_l33">
   <div class="flz_lspacer_mrmc_bottom">
      row3 col1
   </div>
</div>
<div class="flz_box flz_m33">
   <div class="flz_mspacer_mrmc_bottom">
      row3 col2
   </div>
</div>
<div class="flz_box flz_r33">
   <div class="flz_rspacer_mrmc_bottom">
      row3 col3
   </div>
</div>
```
**Example 8 - Boxes and spacers, multi row / multi column scenario** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_08.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_08.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_08.jpg)

## Subspacers ##
To support also scenarios of nested boxes with spacers, floatz offers a set of predefined subspacers for the same single / multi row / column scenarios as for spacers - see [Class Reference](ClassReference.md) for an overview. The following sample shows such a nested scenario. The first box contains already a spacer with whitespace. To avoid doubling the whitespace in the nested boxes, let's use subspacers instead.

```
<div class="flz_box">
   <div class="flz_spacer">
      <div class="flz_box flz_l25">
         <div class="flz_lsubspacer">
            col1
         </div>
      </div>
      <div class="flz_box flz_m25">
         <div class="flz_msubspacer">
            col2
         </div>
      </div>
      <div class="flz_box flz_m25">
         <div class="flz_msubspacer">
            col3
         </div>
      </div>
      <div class="flz_box flz_r25">
         <div class="flz_rsubspacer">
            col4
         </div>
      </div>
   </div>
</div>
```
**Example 9 - Nested boxes with spacers and subspacers** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_09.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_09.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_09.jpg)

The combination of boxes, layouters and spacers as well as subspacers makes almost any layout scenario possible. They give you the ability to create cross-browser compatible, liquid or fixed layouts and the choice to switch between them, also afterwards when your layout is already finished - without any change.

See also: [Nesting Boxes](BasicConcepts#Nesting_boxes.md) below

# Advanced topics #
## Customizing boxes ##
Customizing boxes is very easy. All you have to do is, create a CSS class within your projects CSS file, define your custom box styles and append that CSS class to the class attribute of the box. To reduce the amount of CSS classes it's a good practice, to use relative addressing within your box CSS to constrain styles to the desired box. The following example shows how to customize a box and how to use relative addressing to adopt the appearance of default HTML tags within that box, without affecting other boxes.

Content of the project CSS file:
```
.mybox {
   background: #aaaccc;
}
.mybox h1 {
   color: #fff;
   margin-bottom: 0.5em;
}
.mybox p {
   margin-bottom: 1em;
}
```

Content of the HTML file:
```
<div class="flz_box mybox">
   <div class="flz_spacer">
      <h1>My Header</h1>
      <p>
         My paragraph 1
      </p>
      <p>
         My paragraph 2
      </p>
   </div>
</div>
```

**Example 10 - Customizing boxes** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_10.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_10.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_10.jpg)

## Nesting boxes ##
Nesting boxes is possible and very easy to achieve.

> 
---

> Note: Please keep in mind that boxes should only be used as layouting containers and not as containers for everything in your markup. It is strongly recommended to use a semantically correct HTML tags instead of boxes, whenever possible (e.g. use paragraphs `P` for structuring your content instead of creating paragraph-like structures with `DIV`s. Otherwise you are creating meaningless markup salad and thus hamper the semantically correct interpretation of your web pages. HTML provides a set of semantic tags to structure content correctly (see [Grouping Content](http://dev.w3.org/html5/spec/Overview.html#grouping-content) in the HTML5 specification).
> 
---


The following example shows how you can nest boxes. If you need an example how to use subspacers instead of spacers when nesting boxes, please see the [subspacers](BasicConcepts#Subspacers.md) chapter above.

Content of the project CSS file:
```
.box1 {
  background: #cccccc;
}  
.box2 {
   background: #aaaccc;
}
.box3 {
   background: #bbbccc;
}
.box4 {
   background: #cccccc;
}
.box5 {
   background: #dddccc;
}
.box6 {
   background: #eeeccc;
}
.box7 {
   background: #fffccc;
}
```

Content of the HTML file:
```
<div class="flz_box box1">
   <div class="flz_spacer">
      <h1>Box 1</h1>
      <p>
         Box content
      </p>
      <div class="flz_box flz_l50 box2">
         <div class="flz_spacer">
            <h1>Box 2</h1>
            <p>
               Box content
            </p>
            <div class="flz_box flz_l50 box4">
               <div class="flz_spacer">
                  <h1>Box 4</h1>
                  <p>
                     Box content
                  </p>
               </div>
            </div>
            <div class="flz_box flz_r50 box5">
               <div class="flz_spacer">
                  <h1>Box 5</h1>
                  <p>
                     Box content
                  </p>
               </div>
            </div>
         </div>
      </div>
      <div class="flz_box flz_r50 box3">
         <div class="flz_spacer">
            <h1>Box 3</h1>
            <p>
               Box content
            </p>
            <div class="flz_box flz_l50 box6">
               <div class="flz_spacer">
                  <h1>Box 6</h1>
                  <p>
                     Box content
                  </p>
               </div>
            </div>
            <div class="flz_box flz_r50 box7">
               <div class="flz_spacer">
                  <h1>Box 7</h1>
                  <p>
                     Box content
                  </p>
               </div>
            </div>
         </div>
      </div>
   </div>
</div>
```
**Example 11 - Nesting boxes** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_11.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_11.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_11.jpg)

## Clearing the float of boxes ##
When working with boxes, you will sometimes run into situations where you need a way to abort the default float of a box. To achieve this, floatz provides a marker CSS class named `flz_clear`, that must be attached to the box that should float into the next row, regardless if there is enough space beside the preceding box.

The following example shows how you can clear the float of a subsequent box by adding `flz_clear` to its class attribute.

```
<h1>Normal float</h1>
<div class="flz_box flz_l50">
   box 1
</div>
<div class="flz_box flz_r50">
   box 2
</div>

<h1>Cleared float</h1>
<div class="flz_box flz_l50">
   box 1
</div>
<div class="flz_box flz_r50 flz_clear">
   box 2
</div>
```
**Example 12 - Clearing the float of a box** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_12.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_12.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_12.jpg)

While the previous example shows a scenario where you are consciously clearing the float of a box, there may be situations where the float of a box is affected by other parameters than its width. One such a case is, when you are arranging boxes side by side and they contain a different amount of content. Because of the fact, that the height of a box depends on the amount of its content, such boxes will have different heights. That could cause subsequent boxes to float to the right edge of those boxes instead of into the next row.

The following example demonstrates this behavior. The first row contains four boxes, each with a different amount of content. The next row contains two boxes that should appear in the next row. Because of the different heights of the boxes in the first row, the first box of the second row floats into the first row.

```
<!-- row 1 -->
<div class="flz_box flz_l25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr.
</div>
<div class="flz_box flz_r25">
   Lorem ipsum dolor sit amet.
</div>
<!-- row 2 -->
<div class="flz_box flz_l50 box2">
   box 1
</div>
<div class="flz_box flz_r50 box2">
   box 2
</div>
```
**Example 13 - Float behaviour with different box heights, default** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_13.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13.jpg)

In the next example, we clear the float of the first box in the second row by adding `flz_clear`. As you can see, the boxes in the second row are now floating as expected to the next row.

```
<!-- row 1 -->
<div class="flz_box flz_l25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr.
</div>
<div class="flz_box flz_r25">
   Lorem ipsum dolor sit amet.
</div>
<!-- row 2 -->
<div class="flz_box flz_l50 flz_clear box2">
   box 1
</div>
<div class="flz_box flz_r50 box2">
   box 2
</div>
```
**Example 13a - Float behaviour with different box heights, using `flz_clear`** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_13a.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13a.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13a.jpg)

### Clearing the float in IE6,7 ###
While the previous solution works perfectly in all browsers, the behavior is different in Internet Explorer 6 and 7. The first box (with `flz_clear`) floats to the next row, but now the second box floats into the first row. The reason is that the float is not cleared for all subsequent boxes in that versions.

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13a_IE6,7.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13a_IE6,7.jpg)

Now you have two options to clear the float of all subsequent boxes. First can you add a `BR` tag after the first row and decorate it with `flz_clear`. The following example shows this. All boxes in the second row are floating as expected.

```
<!-- row 1 -->
<div class="flz_box flz_l25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr.
</div>
<div class="flz_box flz_r25">
   Lorem ipsum dolor sit amet.
</div>
<!-- row 2 -->
<br class="flz_clear" />
<div class="flz_box flz_l50 box2">
   box 1
</div>
<div class="flz_box flz_r50 box2">
   box 2
</div>
```
**Example 13b - Float behaviour with different box heights, using `BR` and `flz_clear` in IE6,7** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_13b.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13b_IE6,7.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13b_IE6,7.jpg)

Second you can surround the boxes in the second row with a box that is 100% wide. The last example demonstrates this solution.

```
<!-- row 1 -->
<div class="flz_box flz_l25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor.
</div>
<div class="flz_box flz_m25">
   Lorem ipsum dolor sit amet, consetetur sadipscing elitr.
</div>
<div class="flz_box flz_r25">
   Lorem ipsum dolor sit amet.
</div>
<!-- row 2 -->
<div class="flz_box">
   <div class="flz_box flz_l50 box2">
      box 1
   </div>
   <div class="flz_box flz_r50 box2">
      box 2
   </div>
</div>
```
**Example 13c - Float behaviour with different box heights, using surrounding box in IE6,7** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_13c.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13c_IE6,7.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_13c_IE6,7.jpg)

The float behavior of boxes may seem a little bit curious to you. Yes it is - welcome to the world of CSS layouts with floating elements. But don't be afraid, in practice those situations are rare and now you know everything you need to solve that kinds of issues.

## Using boxes as positioning containers ##
Boxes can also act as containers for absolute positioned markup. In this case the box must be annotated with the CSS marker class `flz_relative`. Why relative? Well, to be a container for absolute positioned markup, the element itself must be positioned relative. The next example shows how to create a relative positioned box and adds a floatz breadcrumb to it that is by default absolute positioned.

Content of the project CSS file:
```
.mybox {
   background: #aaaccc;
   height: 10em;
   width: 50%;
   padding-top: 2em;
}
.mybox h1 {
   margin-bottom: 0.5em;
}
```

Content of the HTML file:
```
<div class="flz_box flz_relative mybox">
   <div class="flz_spacer">
      <ul class="flz_listnav flz_toolbar">
         <li><a href="#"><img src="images/print.gif" alt="" title="Print page" /></a></li>
         <li><a href="#"><img src="images/favorite.gif" alt="" title="Add to favorites" /></a></li>
         <li><a href="#"><img src="images/mail.gif" alt="" title="Tell a friend" /></a></li>
      </ul>
      <h1>Header</h1>
      <p>
         Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
      </p>
   </div>
</div>
```
**Example 14 - Box as positioning container** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_14.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_14.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_14.jpg)

Instead of adding `flz_relative` to the box, you can add the necessary style (`position: relative;`) directly to the box class as well. The page container of floatz for an instance is by default a container for absolute positioned elements. floatz provides some elements that are by default absolute positioned - see [Class Reference](ClassReference.md) for details.

## Positioning boxes ##
As you have seen before, a box can act as container for absolute positioned markup. But it is also possible to absolute position a box itself. The next example shows how a box can be absolute positioned within a relative positioned container.

Content of the project CSS file:

```
.mybox {
   background: #aaaccc;
   height: 15em;
}
.mybox h1 {
   margin-bottom: 0.5em;
}
.myabsolutebox {
   background-color: #dddccc;
   position: absolute;
   top: 1em;
   right: 1em;
   width: 20%;
}
```

Content of the HTML file:

```
<div class="flz_box flz_relative mybox">
   <div class="flz_spacer">
      <div class="flz_box myabsolutebox">
         <div class="flz_spacer">
            Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
         </div>
      </div>
      <h1>Header</h1>
      <p>
         Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.
      </p>
   </div>
</div>
```
**Example 15 - Positioned box** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/BasicConcepts_15.html))

![http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_15.jpg](http://design.humml.eu/toolbox/floatz/samples/BasicConcepts/images/Basic_Concepts_15.jpg)

# Summary #
What you have learned in this wiki article:

  * Boxes are the basic layout elements in floatz
  * Boxes are by default as wide as their content
  * Use layouters to change the width of boxes
  * Pay attention to the correct layouter orientation (l=left, m=mid, r=right)
  * The sum of all layouters in one row should be 100%
  * Use spacers to add whitespace to boxes
  * Use subspacers to prevent doubling whitespace when nesting boxes
  * Customize boxes with custom CSS classes
  * Use relative addressing to reduce the amount of CSS classes
  * Use semantic HTML tags for content instead of boxes whenever possible
  * Boxes are by default as high as their content
  * Boxes are always floating from left to right as long as there is enough space
  * Clear the float of one subsequent box with `flz_clear`
  * Clear the float of all subsequent boxes with `BR` and `flz_clear` in IE6,7
  * Clear the float of all subsequent boxes with a surrounding box in IE6,7
  * Use `flz_relative` to declare a box as container for absolute positioned elements
  * Boxes can also be absolute positioned themselves

#### Further readings ####
The following wiki articles contain further information about how to use the basic concepts in practice:

  * [Layouting Pages](LayoutingPages.md)
  * [Layouting Content](LayoutingContent.md)
  * [Layouting Forms](LayoutingForms.md)