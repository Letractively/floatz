package com.floatzcss.gwt.client;

import com.floatzcss.gwt.client.resource.Floatz;
import com.google.gwt.core.client.EntryPoint;
import com.google.gwt.dom.client.StyleInjector;

// @formatter:off
/**
 * Module entry point for resource bundle.
 * <p>
 * Copyright (c) 1998-2012 by :humml:design,
 * http://design.humml.eu/toolbox/floatz Licensed under Apache License 2.0,
 * http://www.apache.org/licenses/LICENSE-2.0
 * </p>
 * <p>
 * See: http://code.google.com/p/floatz/
 * </p>
 *
 * @author Harald Humml
 * @version 1.2.0
 */
// @formatter:on
public class Css implements EntryPoint {

	// Entry point method
	public void onModuleLoad() {

		// Load all floatz css bundles in the necessary order
		Floatz.INSTANCE.resetMeyer().ensureInjected();
		Floatz.INSTANCE.reset().ensureInjected();
		Floatz.INSTANCE.layout().ensureInjected();
		Floatz.INSTANCE.form().ensureInjected();
		Floatz.INSTANCE.nav().ensureInjected();

		// Workaround for injecting media relevant styles (does not work when
		// defined directly in css file because CSS bundles currently do not
		// support @media
		StyleInjector.inject("@media print { "
				+ Floatz.INSTANCE.layoutPrint().getText() + " }");

		// TODO Check if mobile webkit on iOS, if so inject css
		// Floatz.INSTANCE.mobile().ensureInjected();
	}
}
