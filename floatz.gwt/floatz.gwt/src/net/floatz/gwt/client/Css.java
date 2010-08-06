package net.floatz.gwt.client;

import net.floatz.gwt.client.resource.Floatz;

import com.google.gwt.core.client.EntryPoint;

/**
 * Module entry point for resource bundle
 * 
 * Copyright (c) 1998-2010 by :humml:design
 * http://design.humml.eu/toolbox/floatz Licensed under Apache License 2.0
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * @see http://code.google.com/p/floatz/
 * @author Harald Humml
 * @version 1.1.1
 */

public class Css implements EntryPoint {

	// Entry point method
	public void onModuleLoad() {

		// Load all floatz css bundles in the necessary order
		Floatz.INSTANCE.resetMeyer().ensureInjected();
		Floatz.INSTANCE.reset().ensureInjected();
		Floatz.INSTANCE.layout().ensureInjected();
		Floatz.INSTANCE.form().ensureInjected();
		Floatz.INSTANCE.nav().ensureInjected();
	}
}
