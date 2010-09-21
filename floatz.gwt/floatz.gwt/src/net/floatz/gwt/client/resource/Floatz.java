package net.floatz.gwt.client.resource;

import com.google.gwt.core.client.GWT;
import com.google.gwt.resources.client.ClientBundle;
import com.google.gwt.resources.client.ImageResource;

/**
 * Resource bundle of floatz CSS framework for GWT (2.0.1 and above)
 * 
 * Copyright (c) 1998-2010 by :humml:design
 * http://design.humml.eu/toolbox/floatz Licensed under Apache License 2.0
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * @see http://code.google.com/p/floatz/
 * @author Harald Humml
 * @version 1.1.1
 */

public interface Floatz extends ClientBundle {

	// Get and create instance of resource bundle
	public Floatz INSTANCE = GWT.create(Floatz.class);

	@Source("net/floatz/gwt/client/resource/css/floatz.reset.meyer.css")
	ResetMeyer resetMeyer();

	@Source("net/floatz/gwt/client/resource/css/floatz.reset.css")
	Reset reset();

	@Source("net/floatz/gwt/client/resource/css/floatz.layout.css")
	Layout layout();

	@Source("net/floatz/gwt/client/resource/css/floatz.layout.center.css")
	LayoutCenter layoutCenter();

	@Source("net/floatz/gwt/client/resource/css/floatz.layout.liquid.css")
	LayoutLiquid layoutLiquid();

	@Source("net/floatz/gwt/client/resource/css/floatz.form.css")
	Form form();

	@Source("net/floatz/gwt/client/resource/css/floatz.nav.css")
	Nav nav();

	@Source("net/floatz/gwt/client/resource/image/htabmenu_bottom_active.gif")
	ImageResource htabmenu_bottom_active();

	@Source("net/floatz/gwt/client/resource/image/htabmenu_bottom_hover.gif")
	ImageResource htabmenu_bottom_hover();

	@Source("net/floatz/gwt/client/resource/image/htabmenu_bottom_inactive.gif")
	ImageResource htabmenu_bottom_inactive();

	@Source("net/floatz/gwt/client/resource/image/htabmenu.gif")
	ImageResource htabmenu();
}
