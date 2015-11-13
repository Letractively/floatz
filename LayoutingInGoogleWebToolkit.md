Last Update: December 2nd, 2014

> 
---

> Note: this wiki page covers version 1.2.0hotfix01.
> 
---


**Supposed readings**
  * [Getting started](GettingStarted.md)
  * [Basic Concepts](BasicConcepts.md)

**Table of content**


# Adding floatz to a GWT project #

Integrating floatz into Google Web Toolkit projects is really easy. These are the necessary steps:

## Adding the JAR file ##

First of all you must copy the [http://code.google.com/p/floatz/downloads/list latest version of the floatz JAR file to the `WEB-INF/lib` folder of your web application and add it to the projects class path.

## Updating the module descriptor ##

At last add a reference to floatz into your module descriptor by adding the following `inherits` tag.

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

Finished. Now you can style your application using floatz.

# Overview of the client and CSS bundles #

The floatz GWT module provides a CSS bundle for each available [floatz module](WhatsInside.md) as well as a central client bundle from where you can easily access [all CSS classes](ClassReference.md) using a self-explanatory namespace.

The following bundles are available:

| **Class name** | **Bundle type** | **Description** | **Loaded by default** |
|:---------------|:----------------|:----------------|:----------------------|
| `Floatz`       | Client bundle   | Floatz bundle that holds everything together | Yes                   |
| `ResetMeyer`   | CSS bundle      | Reset module that implements floatz.reset.meyer.css |  Yes                  |
| `Reset`        | CSS bundle      | Reset module that implements floatz.reset.css | Yes                   |
| `Layout`       | CSS bundle      | Layout module that implements floatz.layout.css | Yes                   |
| `Form`         | CSS bundle      | Layout module that implements floatz.form.css | Yes                   |
| `Nav`          | CSS bundle      | Layout module that implements floatz.nav.css | Yes                   |
| `LayoutCenter` | CSS bundle      | Layout module that implements floatz.layout.center.css | No                    |
| `LayoutLiquid` | CSS bundle      | Layout module that implements floatz.layout.liquid.css | No                    |

You do not have to care about loading the CSS files in the correct order, as when you use them natively. The floatz GWT module itself takes care of that instead. Thanks to GWT only CSS classes that are used are compiled into CSS and javascript code.

# Layouting the application #

In contrast do classic web pages, a GWT based application has only one page. So lets prepare the application page for using floatz.

## Preparing the application page ##

Floatz based layouts start with a surrounding page container directly below the BODY tag. To achieve this, create a page container within the `onModuleLoad` method of our applications entry point class. Because GWT CSS bundles only support CSS classes (and `flz_page` is a CSS id) you must attach the ID natively to the page container. Then add it to the root panel of the GWT application.

```
   package com.floatzcss.demo.client;

   import com.google.gwt.core.client.EntryPoint;
   import com.google.gwt.user.client.ui.HTMLPanel;
   import com.google.gwt.user.client.ui.RootPanel;

   public class FloatzTest implements EntryPoint {

      public void onModuleLoad() {

         HTMLPanel pageContainer = new HTMLPanel("<p>Hello world</p>");
         pageContainer.getElement().setId("flz_page");
         RootPanel.get().add(pageContainer);
      }
   }
```

## Changing the layout mode ##

By default floatz uses a fixed layout. If you want to change to another supported layout (e.g. center or fluid) you must inject the according CSS bundle to our application. For this example switch to fixed centered layout.

> ---
> Note: The stylesheet injection must be the first operation within your modules load method.
> ---
```
   public class FloatzTest implements EntryPoint {

      private static final Floatz FLOATZ = Floatz.INSTANCE;

      public void onModuleLoad() {

         FLOATZ.layoutCenter().ensureInjected();
         ...
      }
   }
```

## Loading Javascript modules ##

To load javascript modules from within code, you must add the following to the entry point of your GWT application.

```
   public void onModuleLoad() {

      ...

      // Start floatz modules
      ModuleManager.start(false, LogLevel.INFO, "floatz.browser", "floatz.mobile");
      ...
   }
```

# Layouting from code #

As you may have already noticed in the previous example, it is very comfortable to access the floatz CSS classes via the central `Floatz CSS bundle`, especially when you are using an IDE with support for inline code suggestions. In the slightly changed example you use floatz directly from Java code.

```
   package com.floatzcss.demo.client;

   import com.floatzcss.gwt.client.resource.Floatz;
   import com.floatzcss.gwt.client.module.ModuleManager;
   import com.google.gwt.core.client.EntryPoint;
   import com.google.gwt.user.client.ui.FlowPanel;
   import com.google.gwt.user.client.ui.HTMLPanel;
   import com.google.gwt.user.client.ui.RootPanel;

   public class FloatzTest implements EntryPoint {

      private static final Floatz FLOATZ = Floatz.INSTANCE;

      public void onModuleLoad() {

         FLOATZ.layoutCenter().ensureInjected();

         ModuleManager.start(false, LogLevel.INFO, "floatz.browser", "floatz.mobile");

         FlowPanel pageContainer = new FlowPanel();
         pageContainer.getElement().setId("flz_page");

         HTMLPanel box = new HTMLPanel("");
         box.setStyleName(FLOATZ.layout().box());

         HTMLPanel spacer = new HTMLPanel("<p>Hello world</p>");
         spacer.setStyleName(FLOATZ.layout().spacer());
         box.add(spacer);

         pageContainer.add(box);
         RootPanel.get().add(pageContainer);
      }
   }
```

# Layouting from UI binders #

Structuring your markup from Java code may be become very hard to maintain. Thanks to the UI binder mechanism of GWT you can move all your markup into UI binder XML. The following sample shows how to use floatz within UI binders.

```
   <!DOCTYPE ui:UiBinder SYSTEM "http://dl.google.com/gwt/DTD/xhtml.ent">
   <ui:UiBinder xmlns:ui="urn:ui:com.google.gwt.uibinder"
      xmlns:g="urn:import:com.google.gwt.user.client.ui">
      <ui:with field="FLOATZ" type="com.floatzcss.gwt.client.resource.Floatz" />
      <ui:style>
      </ui:style>
      <g:HTMLPanel styleName="{FLOATZ.layout.box}">
         <div class="{FLOATZ.layout.spacer}">
            <p>
               Hello World2!
            </p>
         </div>
      </g:HTMLPanel>
   </ui:UiBinder>
```

To finish the example you have to change the previous code in the entry point module to use the newly created content panel via UI binder.

```
   package com.floatzcss.demo.client;

   import com.floatzcss.gwt.client.resource.Floatz;
   import com.floatzcss.gwt.client.module.ModuleManager;
   import com.google.gwt.core.client.EntryPoint;
   import com.google.gwt.user.client.ui.FlowPanel;
   import com.google.gwt.user.client.ui.RootPanel;

   public class FloatzTest implements EntryPoint {

      private static final Floatz FLOATZ = Floatz.INSTANCE;

      public void onModuleLoad() {

         FLOATZ.layoutCenter().ensureInjected();		

         ModuleManager.start(false, LogLevel.INFO, "floatz.browser", "floatz.mobile");
	
         FlowPanel pageContainer = new FlowPanel();
         pageContainer.getElement().setId("flz_page");
         pageContainer.add(new ContentPanel());
         RootPanel.get().add(pageContainer);
      }
   }
```

# Changes for GWT 2.7.0 #

Since GWT 2.7.0 it is not possible anymore to load script files from within the module descriptor using script tags. Instead of this the script files must be loaded manually in the onLoadModule method of the GWT application using ScriptInjector.

```
   public void onModuleLoad() {
      ...

      // Load necessary floatz css & javascript resources
      res.floatz().layoutLiquid().ensureInjected();
      loadFloatzModules(new Callback<Void, Exception>() {
         @Override
         public void onSuccess(Void result) {
            boolean debug = !GWT.isProdMode();

            // Start floatz javascript modules
            ModuleManager.start(debug, debug ? LogLevel.DEBUG : LogLevel.INFO, "floatz.browser");

            // Load mobile styles only if user agent is mobile webkit
            if (Browser.isMobileWebkit()) {
               Floatz.INSTANCE.mobile().ensureInjected();
            }
         }

         @Override
         public void onFailure(Exception reason) {
            throw new RuntimeException("Some script files can not be loaded. Please restart again.", reason);
         }
      });

      ...
   }

   private void loadFloatzModules(final Callback<Void, Exception> finishCallback) {
      // @formatter:off
      ScriptInjector.fromUrl("webapp/floatz-1.2.0/scripts/jquery-1.8.2.min.js")
         .setWindow(ScriptInjector.TOP_WINDOW)
         .setCallback(new Callback<Void, Exception>() {
            @Override
            public void onSuccess(Void result) {
               ScriptInjector.fromUrl("webapp/floatz-1.2.0/scripts/floatz.js")					
                  .setWindow(ScriptInjector.TOP_WINDOW)
                  .setCallback(new Callback<Void, Exception>() {
                     @Override
                     public void onSuccess(Void result) {								
                        ScriptInjector.fromUrl("webapp/floatz-1.2.0/scripts/floatz.browser.js")									  
                          .setWindow(ScriptInjector.TOP_WINDOW)						 
                          .setCallback(finishCallback).inject();
                     }

                     @Override
                     public void onFailure(Exception reason) {								 
                        finishCallback.onFailure(reason);
                     }
               }).inject();
            }

            @Override
            public void onFailure(Exception reason) { 
               finishCallback.onFailure(reason);
            }
         }).inject();
      }
   }
```

> 
---

> Note: Because now it is not guaranteed anymore that the JavaScript files are loaded before the floatz GWT module, it is not possible to access Javascript functionality with onModuleLoad of the floatz GWT module. To prevent any loading errors due to missing Javascript methods you must use the provided [hotfix](https://github.com/floatzcss/floatz/blob/master/download/floatz.gwt-1.2.0hotfix01.jar) and execute additional loading code your self.
> 
---


# Summary #
Now you know everything you need to use floatz within GWT. Read the recommended wiki articles to get more information about the great possibilities you get with floatz.

#### Further readings ####
The following wiki articles contain further information about how to use the basic concepts in practice:

  * [Layouting Pages](LayoutingPages.md)
  * [Layouting Content](LayoutingContent.md)
  * [Layouting Forms](LayoutingForms.md)