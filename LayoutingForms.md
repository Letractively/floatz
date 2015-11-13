Last Update: July 17th, 2012

> 
---

> Note: this wiki page covers version 1.1.2.
> 
---


**Supposed readings**

It is recommended to read the following articles before starting with the current wiki article:

  * [Getting started](GettingStarted.md)
  * [Basic Concepts](BasicConcepts.md)
  * [Layouting Pages](LayoutingPages.md)

**Table of content**


# Introduction #
Layouting well designed accessible web forms that come with a great user experience, is a difficult and often annoying topic in web development compared to traditional desktop based applications. Especially the creation of complex CSS based web forms for business applications that go far beyond the simple registration form examples that you find in several discussion forums, can be a real challenge. Perform a google search for creating complex forms with CSS and you will be disappointed: more questions than answers and only really simple form examples. No wonder, that we still find HTML table based form layouts in most solutions as well as current frameworks. The following wiki article gives you an insight how easy and straightforward it is to create CSS based forms using floatz that has been built with the clear goal to layout complex web forms in mind.

# Getting started #
In this wiki article we build up a web page with a customer data form from scratch. To concentrate on layouting the form, we use the example 5 from [Layouting Pages](LayoutingPages.md) as our starting point. First we remove everything that's inside the spacer of the content box. The code should look like this:

```
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
   <head>
      <title>floatz - Layout.Empty</title>
      <meta http-equiv="content-type" content="text/html; CHARSET=utf-8" />
      <meta http-equiv="content-script-type" content="text/javascript" />
      <meta http-equiv="content-style-type" content="text/css" />
      <meta http-equiv="content-language" content="en" />
      <meta name="author" content="" />
      <meta name="robots" content="index,follow" />
      <meta name="description" content="" />
      <link rel="stylesheet" type="text/css" href="styles/project2.css" />
      <script type="text/javascript" src="styles/floatz-1.1.2/scripts/jquery-1.7.2.min.js"></script>
      <script type="text/javascript" src="styles/floatz-1.1.2/scripts/floatz.js"></script>
      <script type="text/javascript" src="scripts/project.js"></script>
   </head>
   <body>
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
            </div>
         </div>
         <!-- footer -->
         <div class="flz_box flz_r100 footer">
            Footer
         </div>
      </div>
   </body>
</html>
```
**Example 1 - The page template as starting point** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_01.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_01.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_01.jpg)

# Creating a basic form #
Now we are ready to start with our basic web form that will accompany us in the whole wiki article. As mentioned before we will build a customer data web form. First of all we add a `FORM` tag inside the spacer of the context box of our page. Then we add `LABEL` and `INPUT` tags for customer number, first name, last name, birthday, street, zip code and city, a `SELECT` tag for country selection, a multiline `TEXTAREA` for adding additional information and `INPUT` tags that act as checkboxes for news subscriptions. Last but not least we add two `INPUT` tags that act as action buttons for saving or canceling the form input. The image after the birthday field is for special use and will be covered later. The example does not include radio buttons, but their behavior is the same as for checkboxes, so they are omitted here.

```
<body>
   <!-- page -->
   <div id="flz_page">
      ...
      <!-- content -->
      <div class="flz_box flz_r80 content">
         <div class="flz_spacer">
            <form action="">
               <label for="custno">Customer Number</label>
               <input id="custno" type="text" />
               <label for="firstname">First Name</label>
               <input id="firstname" type="text" />
               <label for="lastname">Last Name</label>
               <input id="lastname" type="text" />
               <label for="birthday">Birthday</label>
               <input id="birthday" type="text" />
               <img src="images/datepicker.gif" alt="Pick a date" />
               <label for="street">Street</label>
               <input id="street" type="text" />
               <label for="zip">Zip</label>
               <input id="zip" type="text" />
               <label for="city">City</label>
               <input id="city" type="text" />
               <label for="country">Country</label>
               <select id="country">
                  <option>Austria</option>
                  <option>France</option>
                  <option>Germany</option>
                  <option>Italy</option>
                  <option>Spain</option>
               </select>
               <label for="info">Additional information</label>
               <textarea id="info" cols="1" rows="5"></textarea>
               <input id="press" type="checkbox" />
               <label for="press">Press news</label>
               <input id="products" type="checkbox" />
               <label for="products">Product news</label>
               <input id="save" type="button" value="Save" />
               <input id="cancel" type="button" value="Cancel" />
            </form>
         </div>
      </div>
      ...
   </div>
</body>
```
**Example 2 - The basic form** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_02.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_02.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_02.jpg)

## Adding floatz specific styles ##
Well, when you run the example and look at the result, this is definitely nothing you can give to your customer. Usually this is the point where you have to make a momentous decision: should you add additional markup like `BR` tags and customize every single form element ending up with obtrusive `STYLE` tags or should you style every single form element with CSS and end up in countless CSS classes within your markup? Nothing of both in floatz: You only have to add `flz_form` to the `FORM` tag and floatz does everything for you.

```
<!-- content -->
<div class="flz_box flz_r80 content">
   <div class="flz_spacer">
      <form class="flz_form" action="">
         ...
      </form>
   </div>
</div>
```
**Example 3a - Adding flz\_form to the basic form** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_03a.html))

Run the example and you will see that each label and input field is in its own row and each input field is as wide as its surrounding container. Only the checkboxes and the buttons behave differently to the other form elements. That's all for this simple example.

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_03a.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_03a.jpg)

### Supporting Internet Explorer 6 ###
If you have to support IE6 as well, some additional effort is necessary. The major problem of IE6 is, that it does not support CSS2 attribute selectors to distinguish between textboxes, buttons, radiobuttons and checkboxes that are all `INPUT` tags in HTML, with different `TYPE` attribute values like `TEXT`, `BUTTON`, `SUBMIT`, `RADIO` and `CHECKBOX`. Because floatz needs to differentiate between those types, you have to add specific CSS classes to the according form elements to get this functionaliy also in IE6. Otherwise the form would behave like we have seen in example 1, without any CSS. Thus let's add CSS class `flz_textbox` to each input tag of type `TEXT` and `flz_button` to all input tags of type `BUTTON`. The labels of the checkboxes must be annotated with `flz_inline` to stay next to the checkboxes. Otherwise they would appear in a separate row as all other labels. In the case of checkboxes and radiobuttons that's not what we want.

```
<!-- content -->
<div class="flz_box flz_r80 content">
   <div class="flz_spacer">
      <form class="flz_form" action="">
         <label for="custno">Customer Number</label>
         <input class="flz_textbox" id="custno" type="text" />
         <label for="firstname">First Name</label>
         <input class="flz_textbox" id="firstname" type="text" />
         <label for="lastname">Last Name</label>
         <input class="flz_textbox" id="lastname" type="text" />
         <label for="birthday">Birthday</label>
         <input class="flz_textbox" id="birthday" type="text" />
         <img src="images/datepicker.gif" alt="Pick a date" />
         <label for="street">Street</label>
         <input class="flz_textbox" id="street" type="text" />
         <label for="zip">Zip</label>
         <input class="flz_textbox" id="zip" type="text" />
         <label for="city">City</label>
         <input class="flz_textbox" id="city" type="text" />
         <label for="country">Country</label>
         <select id="country">
            <option>Austria</option>
            <option>France</option>
            <option>Germany</option>
            <option>Italy</option>
            <option>Spain</option>
         </select>
         <label for="info">Additional information</label>
         <textarea id="info" cols="1" rows="5"></textarea>
         <input id="press" type="checkbox" />
         <label class="flz_inline" for="press">Press news</label>
         <input id="products" type="checkbox" />
         <label class="flz_inline" for="products">Product news</label>
         <input class="flz_button" id="save" type="button" value="Save" />
         <input class="flz_button" id="cancel" type="button" value="Cancel" />
      </form>
   </div>
```
**Example 3b - Adding additional CSS classes to support IE6** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_03b.html))

If you run the sample again in IE6 and in all other browsers, you will see that the page now behaves the same in all of them. The additional classes have no negative impact on the CSS2 compliant browsers and we get our web form working in all browsers inluding IE6.

> 
---

> Rule of thumb: it is no failure when you always add those additional CSS classes to your markup even if you think you don’t need to support IE6 ... until one of your customers told you so. The effort will be much higher, when you have to change and test again all of your already finished web forms. See [class reference](ClassReference.md) and [browser hacks](BrowserHacks.md) for more information about IE6 support.
> 
---


![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_03b.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_03b.jpg)

## Defining mandatory and readonly fields ##
Next let's hilite the mandatory fields in our customer form: first name, last name, street, zip, city and country. The only thing we have to do is adding the CSS class `flz_mandatory` to the `CLASS` attribute for each of them. It's a common practice to add a `*` next to the label of the mandatory fields, so we change that as well. Because the customer number should not be filled out by the user itself, we make that field readonly by inserting the HTML `READONLY` attribute and adding `flz_readonly` to it's `CLASS` attribute.

```
<!-- content -->
<div class="flz_box flz_r80 content">
   <div class="flz_spacer">
      <form class="flz_form" action="">
         <label for="custno">Customer Number</label>
         <input class="flz_textbox flz_readonly" id="custno" type="text" readonly="readonly" />
         <label for="firstname">First Name*</label>
         <input class="flz_textbox flz_mandatory" id="firstname" type="text" />
         <label for="lastname">Last Name*</label>
         <input class="flz_textbox flz_mandatory" id="lastname" type="text" />
         ...
         <label for="street">Street*</label>
         <input class="flz_textbox flz_mandatory" id="street" type="text" />
         <label for="zip">Zip*</label>
         <input class="flz_textbox flz_mandatory" id="zip" type="text" />
         <label for="city">City*</label>
         <input class="flz_textbox flz_mandatory" id="city" type="text" />
         <label for="country">Country*</label>
         <select class="flz_mandatory" id="country">
            ...
         </select>
         ...
      </form>
   </div>
</div>
```
**Example 4 - Highlighting mandatory and readonly fields** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_04.html))

Run the sample code and voilà, every mandatory field is highlighted.

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_04.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_04.jpg)

## Adding a combobox ##
Now let's pay some attention on the birthday field and the datepicker icon. Unfortunately HTML doesn't support the UI element combobox by default, which is a combination of a textbox and a selectbox. In our example the birthday textbox and the image should appear like a combobox. floatz does not implement the whole functionality that would be necessary for a combobox, but it provides the visual baseline to show the textbox and the image side by side in one row, with full support to liquid layouts. To get that behavior, we have to change the HTML code for the combobox as shown in the sample code:

First we create a `DIV` element with the CSS class `flz_combobox`. Next we place our input field and the clickable image within that `DIV` container. As noted in the following code snippet, it is important to place the image within the anchor into a separate line of code. Otherwise Internet Explorer adds unexpected whitespace to the combobox.

> 
---

> Note: In previous versions, the combobox was named `flz_combifield`. Since version 1.1.1 its name has been changed to `flz_combobox` for consistence with well known UI elements. The necessary markup and CSS has also changed significant, so please check and change your existing code.
> 
---


```
<form class="flz_form" action="">
   ...
   <label for="birthday">Birthday</label>
   <div class="flz_combobox">
      <input class="flz_textbox" id="birthday" type="text" />
      <!-- Image must be in next line - otherwise unnecessary whitespace in IE -->
      <a href="#">
         <img src="images/datepicker.gif" alt="Pick a date" />
      </a>
   </div>
   ...
</form>

```

**Example 5 - Adding a combobox** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_05.html))

As you can see when you run the code, the datepicker image appears as intended next to the birthday textbox. Now it's on you to implement the "business logic" of the combobox.

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_05.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_05.jpg)

## Adding a buttonbar ##
When you look at the result of the previous examples, the buttons are floating to the right side of the checkboxes. Let's change that and add a buttonbar below the input fields of the web form. For this purpose we simply surround the buttons with a box element that forces them to appear in a separate row.

```
<form class="flz_form" action="">
   ...
   <div class="flz_box">
      <input class="flz_button" id="save" type="button" value="Save" />
      <input class="flz_button" id="cancel" type="button" value="Cancel" />
   </div>
</form>
```
**Example 6 - Adding a button bar** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_06.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_06.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_06.jpg)

# Customizing the form #
Now we have finished our basic layout of the customer form. But to be honest, the default styling of the form elements does not really fit to the look & feel of the page layout that is used. So, the next step will be the customization of the form elements. First we change the border color of the textboxes, textareas and selectboxes as then the background color of the mandatory fields. For the former we partly use CSS2 based attribute selectors and constrain them to the context of the floatz form within the content container by using relative addressing. For the latter we directly change the background color of the `flz_mandatory` class. Because we want to support IE6 as well, we have to add a CSS hack for the textbox and the textarea that only affects IE6.

**CSS code**
```
...

.content .flz_form input[type="text"], 
.content .flz_form textarea, 
.content .flz_form select {
   border-color: #aaaccc;
}
* html .content .flz_textbox,
* html .content .flz_form textarea {
   border-color: #aaaccc;
}
.content .flz_mandatory {
   background: #ffffcc;
}

...
```

In the markup we add a header and an introduction text prior to the form, to get a more realistic real world scenario.

```
<!-- content -->
<div class="flz_box flz_r80 content">
   <div class="flz_spacer">
      <h1>Sample form</h1>
      <p>
         Lorem ipsum dolor sit amet, consetetur sadipscing elitr, ...
      </p>              
      <form class="flz_form" action="">
         ...
      </form>
   </div>
</div>
```
**Example 7 - Customizing the web form** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_07.html))

Yet, the result is much better. With a few changes of the CSS we have got a much more consistent form layout in combination with the page layout.

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_07.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_07.jpg)

# Structuring the form #
The following subchapters illustrate, how we can increase the readability and thus the usability of our customer form, by structuring it into contextual related pieces using fieldsets and by adopting the layout.

## Adding fieldsets ##
Let's add three fieldsets to our web form. The first fieldset is "personal data" and contains customer number, first name, last name and birthday. The second fieldset is "address data" and contains street, zip, city and country. The last fieldset is "additional data" and contains the rest of our form, the textarea and the checkboxes. Because we have customized the border colors of our form fields before, we have to customize the border color of the fieldset in our CSS file too.

**CSS code**
```
...
.content fieldset {
   border-color: #888ccc;
   margin-bottom: 0.5em;
}
...
```

**HTML Code**
```
<!-- content -->
<div class="flz_box flz_r80 content">
   <div class="flz_spacer">
      <h1>Sample form</h1>
      <p>
         Lorem ipsum dolor sit amet, consetetur sadipscing elitr ...
      </p>              
      <form class="flz_form" action="">
         <fieldset>
            <legend>Personal data</legend>
            <label for="custno">Customer Number</label>
            <input class="flz_textbox flz_readonly" id="custno" type="text" readonly="readonly" />
            <label for="firstname">First Name*</label>
            <input class="flz_textbox flz_mandatory" id="firstname" type="text" />
            <label for="lastname">Last Name*</label>
            <input class="flz_textbox flz_mandatory" id="lastname" type="text" />
            <label for="birthday">Birthday</label>
            <div class="flz_combobox">
               <input class="flz_textbox" id="birthday" type="text" />
               <a href="#">
                  <img src="images/datepicker.gif" alt="Pick a date" />
               </a>
            </div>
         </div>
         </fieldset>
         <fieldset>
            <legend>Address data</legend>
            <label for="street">Street*</label>
            <input class="flz_textbox flz_mandatory" id="street" type="text" />
            <label for="zip">Zip*</label>
            <input class="flz_textbox flz_mandatory" id="zip" type="text" />
            <label for="city">City*</label>
            <input class="flz_textbox flz_mandatory" id="city" type="text" />
            <label for="country">Country*</label>
            <select class="flz_mandatory" id="country">
               <option>Austria</option>
               <option>France</option>
               <option>Germany</option>
               <option>Italy</option>
               <option>Spain</option>
            </select>
         </fieldset>
         <fieldset>
            <legend>Additional data</legend>
            <label for="info">Additional information</label>
            <textarea id="info" cols="1" rows="5"></textarea>
            <input id="press" type="checkbox" />
            <label class="flz_inline" for="press">Press news</label>
            <input id="products" type="checkbox" />
            <label class="flz_inline" for="products">Product news</label>
         </fieldset>
         <div class="flz_box buttonbar">
            <input class="flz_button" id="save" type="button" value="Save" />
            <input class="flz_button" id="cancel" type="button" value="Cancel" />
         </div>
      </form>
   </div>
</div>
```
**Example 8 - Adding fieldsets** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_08.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_08.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_08.jpg)

## Using multiple column layout ##
We can save a little vertical space by slightly changing the layout of our one-column form layout into a multi-column layout. As described in [basic concepts](BasicConcepts.md), floatz ships with a layout system that can of course be used for layouting forms as well. Now we surround the personal data fieldset with a left oriented box and the address data fieldset with a right oriented box element. Within the boxes we are using appropriate subspacers to get some whitespace between the fieldsets. See [basic concepts](BasicConcepts.md) for more information about spacers.

```
<form class="flz_form" action="">
   <div class="flz_box flz_l50">
      <div class="flz_lsubspacer">
         <fieldset>
            <legend>Personal data</legend>
            <label for="custno">Customer Number</label>
            ...
         </fieldset>
      </div>
   </div>
   <div class="flz_box flz_r50">
      <div class="flz_rsubspacer">
         <fieldset>
            <legend>Address data</legend>
            <label for="street">Street*</label>
            ...
         </fieldset>
      </div>
   </div>
   ...
</form>
```
**Example 9 - Using multiple column layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_09.html))

The result is, that the two fieldsets now appear side by side in our customer form.

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_09.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_09.jpg)

## Using free layout ##
Especially in business applications it is often necessary to create complex web forms containing a huge amount of fields. The next example illustrates how floatz can help you to achieve that. Therefor we remove the boxes that surround the personal and address data fieldsets from our previous example, then we remove the personal and address data fieldsets and use one "contact data" fieldset instead. Now we add some box elements with layouters and spacers to surround single fields in our form. This leads to a much more complicated form markup, but gives us full freedom of choice, how we can structure our web forms. See [basic concepts](BasicConcepts.md) for more details on using boxes, layouters and spacers.

```
<form class="flz_form" action="">
   <fieldset>
      <legend>Customer data</legend>
      <div class="flz_box flz_l25">
         <div class="flz_lsubspacer">
            <label for="custno">Customer Number</label>
            <input class="flz_textbox flz_readonly" id="custno" type="text" readonly="readonly" />
         </div>
      </div>
      <div class="flz_box flz_m25">
         <div class="flz_msubspacer">
            <label for="firstname">First Name*</label>
            <input class="flz_textbox flz_mandatory" id="firstname" type="text" />
         </div>
      </div>
      <div class="flz_box flz_m25">
         <div class="flz_msubspacer">
            <label for="lastname">Last Name*</label>
            <input class="flz_textbox flz_mandatory" id="lastname" type="text" />
         </div>
      </div>
      <div class="flz_box flz_r25">
         <div class="flz_rsubspacer">
            <label for="birthday">Birthday</label>
            <div class="flz_combobox">
               <input class="flz_textbox" id="birthday" type="text" />
               <a href="#">
                  <img src="images/datepicker.gif" alt="Pick a date" />
               </a>
            </div>
         </div>
      </div>
      <div class="flz_box flz_l75">
         <div class="flz_lsubspacer">
            <label for="street">Street*</label>
            <input class="flz_textbox flz_mandatory" id="street" type="text" />
         </div>
      </div>
      <div class="flz_box flz_r25">
         <div class="flz_rsubspacer">
            <label for="zip">Zip*</label>
            <input class="flz_textbox flz_mandatory" id="zip" type="text" />
         </div>
      </div>
      <div class="flz_box flz_l50">
         <div class="flz_lsubspacer">
            <label for="city">City*</label>
            <input class="flz_textbox flz_mandatory" id="city" type="text" />
         </div>
      </div>
      <div class="flz_box flz_r50">
         <div class="flz_rsubspacer">
            <label for="country">Country*</label>
            <select class="flz_mandatory" id="country">
               <option>Austria</option>
               <option>France</option>
               <option>Germany</option>
               <option>Italy</option>
               <option>Spain</option>
            </select>
         </div>
      </div>
   </fieldset>
   ...
</form>
```
**Example 10 - Using free layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_10.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_10.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_10.jpg)

# Switching to liquid layout #
To show you that the layout of our form also works in liquid layout without any code changes, we change the import statement of our CSS file from floatz.fixed.css to floatz.liquid.css. Run the sample again and resize the browser window. Our web form is still working and resizes accordingly with the browser.

**CSS code**
```
/* Loads floatz CSS framework */
@import url(floatz-1.1.2/floatz.liquid.css);

/* Project specific styles */
...
```
**Example 11 - Switching to liquid layout** ([Live Demo](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/Layouting_Forms_11.html))

![http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_11.jpg](http://design.humml.eu/toolbox/floatz/samples/LayoutingForms/images/Layouting_Forms_11.jpg)

# Summary #
What you have learned in this wiki article:

  * Creating well designed web forms is difficult and often annoying
  * It is hard to find solutions for complex CSS based web forms today
  * Customizing every single form element with pure CSS leads to obtrusive CSS in markup or countless CSS classes
  * Only add `flz_form` to your `FORM` tag and floatz does everything for you
  * Use `flz_textbox` for input elements of type `TEXT` to support IE6
  * Use `flz_button` for input elements of type `BUTTON` or `SUBMIT` to support IE6
  * Use `flz_inline` for `LABEL` tags in combination with checkboxes or radionbuttons to support IE6
  * Use `flz_mandatory` to annotate mandatory fields
  * Use `flz_readonly` to annotate readonly fields
  * Use `flz_combobox` to visually combine input fields and images to comboboxes
  * Customize form elements by overloading the appropriate CSS styles in your project CSS file
  * Use fieldsets to structure your forms into contextual releated pieces
  * Use boxes, layouters and spacers for multicolumn form layouts
  * Use boxes, layouters and spacers for free / complex form layouts
  * floatz form layouts work in fixed, centered and liquid layout modes as well

#### Further readings ####
The following wiki articles contain further information about how to add content to your basic page layout:

  * [Layouting Content](LayoutingContent.md)