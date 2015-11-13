Last Update: July 29th, 2013

> 
---

> Note: this wiki page covers version 1.2.0.
> 
---


**Table of content**


# floatz.layout.css #

## Basic layout elements ##
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_page      | Id       | DIV     | Page container  | all     | IE6, IE7  | relative     | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |
| flz\_minwidth  | Id       | DIV     | Min-Width outer container | IE6     | IE6       |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |
| flz\_minwidthcontent | Id       | DIV     | Min-Width inner container | IE6     | IE6       |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |
| flz\_box       | Class    | DIV     | Basic layouting container | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |
| flz\_relative  | Class    | | Marks a class as container for absolute positioned elements | all     |           | relative     | [BasicConcepts](BasicConcepts.md) |
| flz\_clear     | Class    | | Clears the float of an element (starts in next row on left edge) | all     |           |              | [BasicConcepts](BasicConcepts.md) |
| flz\_panel`*`)    | Class    | DIV     | Panel layout container | all (but IE6) | IE7, 9 Chrome | absolute     | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |
| flz\_scrollpanel`*`)    | Class    | DIV     | Scrollable panel layout container | all (but IE6) | IE7, 9, Chrome | absolute     | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md) |

`*`) IE support only for version >=7

## Spacers ##
### Basic spacers ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_spacer    | Class    | DIV     | Spacer for margins and paddings in liquid layouts | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lspacer   | Class    | DIV     | Left oriented spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_mspacer   | Class    | DIV     | Mid oriented spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rspacer   | Class    | DIV     | Right oriented spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |


### Spacers for multi row single column scenario ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position**| **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:|:--------------------|
| flz\_spacer\_mrsc\_top    | Class    | DIV     | Top aligned multi row single column spacer | all     | IE6, IE7  | | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_spacer\_mrsc\_mid    | Class    | DIV     | Mid aligned multi row single column spacer | all     | IE6, IE7  | | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_spacer\_mrsc\_bottom | Class    | DIV     | Bottom aligned multi row single column spacer | all     | IE6, IE7  | | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

### Spacers for multi row multi column scenario ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_lspacer\_mrmc\_top   | Class    | DIV     | Top left oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lspacer\_mrmc\_mid   | Class    | DIV     | Mid left oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lspacer\_mrmc\_bottom| Class    | DIV     | Bottom left oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_mspacer\_mrmc\_top   | Class    | DIV     | Top mid oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_mspacer\_mrmc\_mid   | Class    | DIV     | Mid mid oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_mspacer\_mrmc\_bottom| Class    | DIV     | Bottom mid oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rspacer\_mrmc\_top   | Class    | DIV     | Top right oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rspacer\_mrmc\_mid   | Class    | DIV     | Mid right oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rspacer\_mrmc\_bottom| Class    | DIV     | Bottom mid oriented multi row multi column spacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

### Basic Subspacers ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_subspacer          | Class    | DIV     | Subspacer for margins and paddings in liquid layouts | all     |           | IE6, IE7     | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lsubspacer         | Class    | DIV     | Left oriented subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_msubspacer         | Class    | DIV     | Mid oriented subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rsubspacer         | Class    | DIV     | Right oriented subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

### Subspacers for multi row single column scenario ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_subspacer\_mrsc\_top    | Class    | DIV     | Top aligned multi row single column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_subspacer\_mrsc\_mid    | Class    | DIV     | Mid aligned multi row single column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_subspacer\_mrsc\_bottom | Class    | DIV     | Bottom aligned multi row single column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

### Subspacers for multi row multi column scenario ###
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_lsubspacer\_mrmc\_top   | Class    | DIV     | Top left oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lsubspacer\_mrmc\_mid   | Class    | DIV     | Mid left oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_lsubspacer\_mrmc\_bottom| Class    | DIV     | Bottom left oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_msubspacer\_mrmc\_top   | Class    | DIV     | Top mid oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_msubspacer\_mrmc\_mid   | Class    | DIV     | Mid mid oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_msubspacer\_mrmc\_bottom| Class    | DIV     | Bottom mid oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rsubspacer\_mrmc\_top   | Class    | DIV     | Top right oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rsubspacer\_mrmc\_mid   | Class    | DIV     | Mid right oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_rsubspacer\_mrmc\_bottom| Class    | DIV     | Bottom mid oriented multi row multi column subspacer | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

## Layouters ##
| **Element**    | **Type** | **Tag** | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:---------------|:---------|:--------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_l10       | Class    | DIV     | Left oriented layouter with 10% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m10       | Class    | DIV     | Mid oriented layouter with 10% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r10       | Class    | DIV     | Right oriented layouter with 10% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l20       | Class    | DIV     | Left oriented layouter with 20% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m20       | Class    | DIV     | Mid oriented layouter with 20% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r20       | Class    | DIV     | Right oriented layouter with 20% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l25       | Class    | DIV     | Left oriented layouter with 25% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m25       | Class    | DIV     | Mid oriented layouter with 25% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r25       | Class    | DIV     | Right oriented layouter with 25% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l33       | Class    | DIV     | Left oriented layouter with 33.3% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m33       | Class    | DIV     | Mid oriented layouter with 33.4% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r33       | Class    | DIV     | Right oriented layouter with 33.3% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l40       | Class    | DIV     | Left oriented layouter with 40% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m40       | Class    | DIV     | Mid oriented layouter with 40% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r40       | Class    | DIV     | Right oriented layouter with 40% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l50       | Class    | DIV     | Left oriented layouter with 50% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m50       | Class    | DIV     | Mid oriented layouter with 50% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r50       | Class    | DIV     | Right oriented layouter with 50% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l60       | Class    | DIV     | Left oriented layouter with 60% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m60       | Class    | DIV     | Mid oriented layouter with 60% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r60       | Class    | DIV     | Right oriented layouter with 60% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l66       | Class    | DIV     | Left oriented layouter with 66.7% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r66       | Class    | DIV     | Right oriented layouter with 66.7% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l75       | Class    | DIV     | Left oriented layouter with 75% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r75       | Class    | DIV     | Right oriented layouter with 75% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l80       | Class    | DIV     | Left oriented layouter with 80% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_m80       | Class    | DIV     | Mid oriented layouter with 80% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r80       | Class    | DIV     | Right oriented layouter with 80% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_l90       | Class    | DIV     | Left oriented layouter with 90% width | all     |           |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r90       | Class    | DIV     | Right oriented layouter with 90% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |
| flz\_r100      | Class    | DIV     | Right oriented layouter with 100% width | all     | IE6, IE7  |              | [BasicConcepts](BasicConcepts.md), [LayoutingPages](LayoutingPages.md), [LayoutingContent](LayoutingContent.md), [LayoutingForms](LayoutingForms.md) |

# floatz.nav.css #
| **Element**      | **Type** | **Tag**   | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:-----------------|:---------|:----------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_anchor      | Class    | A         | Skip link target anchor | all     |           |              | [LayoutingNavigation](LayoutingNavigation.md), [UsingSkiplinks](UsingSkiplinks.md) |
| flz\_breadcrumb  | Class    | UL        | Breadcrumb navigation container | all     |           | absolute     | [LayoutingNavigation](LayoutingNavigation.md) |
| flz\_disabled    | Class    | LI        | Marker class for disabled navigation item | all     |           |              | [LayoutingNavigation](LayoutingNavigation.md) |
| flz\_hmenu       | Class    | DIV       | Horizontal menu container | all     |           |              | [LayoutingNavigation](LayoutingNavigation.md), [CustomizingMenus](CustomizingMenus.md) |
| flz\_htabmenu    | Class    | DIV       | Horizontal tab menu container | all     | IE6       |              | [LayoutingNavigation](LayoutingNavigation.md), [CustomizingTabboxes](CustomizingTabboxes.md) |
| flz\_htabmenubottom | Class    | DIV       | Horizontal bottom aligned tab menu container | all     | IE6       |              | [LayoutingNavigation](LayoutingNavigation.md), [CustomizingTabboxes](CustomizingTabboxes.md) |
| flz\_listnav     | Class    | UL        | List navigation container | all     |           |              | [LayoutingNavigation](LayoutingNavigation.md), [CustomizingMenus](CustomizingMenus.md) |
| flz\_selected    | Class    | LI        | Marker class for selected navigation item | all     | IE6, IE7  |              | [LayoutingNavigation](LayoutingNavigation.md) |
| flz\_skiplink    | Class    | A         | Skip link anchor | all     | IE6, IE7  | absolute     | [LayoutingNavigation](LayoutingNavigation.md), [UsingSkiplinks](UsingSkiplinks.md) |
| flz\_skipnav     | Class    | DIV, UL   | Skip link navigation container | all     |           |              | [LayoutingNavigation](LayoutingNavigation.md), [UsingSkiplinks](UsingSkiplinks.md) |
| flz\_toolbar     | Class    | UL        | Toolbar navigation container | all     |           | absolute     | [LayoutingNavigation](LayoutingNavigation.md) |
| flz\_topnav      | Class    | UL        | Top navigation container | all     |           | absolute     | [LayoutingNavigation](LayoutingNavigation.md) |
| flz\_vmenu       | Class    | DIV       | Vertical menu container | all     | IE6       |              | [LayoutingNavigation](LayoutingNavigation.md), [CustomizingMenus](CustomizingMenus.md) |

# floatz.form.css #
| **Element**      | **Type** | **Tag**   | **Description** | **For** | **Hacks** | **Position** | **Further reading** |
|:-----------------|:---------|:----------|:----------------|:--------|:----------|:-------------|:--------------------|
| flz\_combobox    | Class    | DIV, IMG  | Combifield container and marker class for combifield image | all     |           | absolute     | [LayoutingForms](LayoutingForms.md) |
| flz\_custombutton     | Class    | INPUT     | Button          | all     |           |              | [LayoutingForms](LayoutingForms.md) |
| flz\_button      | Class    | INPUT     | Button          | IE6     | IE6, IE7  |              | [LayoutingForms](LayoutingForms.md) |
| flz\_form        | Class    | FORM      | Form container  | all     |           |              | [LayoutingForms](LayoutingForms.md) |
| flz\_inline      | Class    | LABEL     | Marker class for inline label | all     |           |              | [LayoutingForms](LayoutingForms.md) |
| flz\_mandatory   | Class    | INPUT, SELECT, TEXTAREA | Marker class for mandatory input fields | all     |           |              | [LayoutingForms](LayoutingForms.md) |
| flz\_readonly    | Class    | INPUT, SELECT, TEXTAREA | Marker class for readonly input fields | all     |           |              | [LayoutingForms](LayoutingForms.md) |
| flz\_textbox     | Class    | INPUT     | Textbox         | IE6     | IE6       |              | [LayoutingForms](LayoutingForms.md) |