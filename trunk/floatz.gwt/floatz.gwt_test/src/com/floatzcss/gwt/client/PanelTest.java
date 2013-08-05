package com.floatzcss.gwt.client;

import com.google.gwt.core.client.GWT;
import com.google.gwt.uibinder.client.UiBinder;
import com.google.gwt.user.client.ui.Composite;
import com.google.gwt.user.client.ui.Widget;

public class PanelTest extends Composite {

	private static PanelTestUiBinder uiBinder = GWT
			.create(PanelTestUiBinder.class);

	interface PanelTestUiBinder extends UiBinder<Widget, PanelTest> {
	}

	public PanelTest() {
		initWidget(uiBinder.createAndBindUi(this));
	}
}
