package com.floatzcss.gwt.client;

import com.floatzcss.gwt.client.resource.Floatz;
import com.google.gwt.core.client.EntryPoint;
import com.google.gwt.user.client.ui.FlowPanel;
import com.google.gwt.user.client.ui.HTMLPanel;
import com.google.gwt.user.client.ui.Label;
import com.google.gwt.user.client.ui.RootPanel;

public class Floatz_gwt_test implements EntryPoint {
	private Floatz floatz = Floatz.INSTANCE;
	public void onModuleLoad() {

		FlowPanel box = new FlowPanel();
		box.addStyleName(floatz.layout().box());
		FlowPanel spacer = new FlowPanel();
		spacer.addStyleName(floatz.layout().spacer());
		spacer.add(new Label("Hello World!"));
		box.add(spacer);
		
		FlowPanel tabMenu = new FlowPanel();
		tabMenu.addStyleName(floatz.nav().htabmenu());		
		StringBuffer menuItems = new StringBuffer();
		menuItems.append("<li class='flz_selected'><a href='javascript:'>Tab 1</a></li>");
		menuItems.append("<li><a href='javascript:'>Tab 2</a></li>");
		menuItems.append("<li><a href='javascript:'>Tab 3</a></li>");
		HTMLPanel ul = new HTMLPanel("ul", menuItems.toString());
		tabMenu.add(ul);
		spacer.add(tabMenu);
		
		HTMLPanel lineBreak = new HTMLPanel("<br /><br />");
		spacer.add(lineBreak);
		
		FlowPanel tabMenuBottom = new FlowPanel();
		tabMenuBottom.addStyleName(floatz.nav().htabmenu_bottom());		
		StringBuffer menuItemsButtom = new StringBuffer();
		menuItemsButtom.append("<li class='flz_selected'><a href='javascript:'>Tab 1</a></li>");
		menuItemsButtom.append("<li><a href='javascript:'>Tab 2</a></li>");
		menuItemsButtom.append("<li><a href='javascript'>Tab 3</a></li>");
		HTMLPanel ul2 = new HTMLPanel("ul", menuItemsButtom.toString());
		tabMenuBottom.add(ul2);
		spacer.add(tabMenuBottom);
		
		RootPanel.get().add(box);
	}
}
