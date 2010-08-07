package net.floatz.gwt.client;

import net.floatz.gwt.client.resource.Floatz;

import com.google.gwt.core.client.EntryPoint;
import com.google.gwt.user.client.ui.FlowPanel;
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
		RootPanel.get().add(box);
	}
}
