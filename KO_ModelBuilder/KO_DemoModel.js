var KO_DemoModel = function (context) {
	var self = this;
	self.koContext = null;

	// Generated Modelobservables
	self.Prename = ko.observable();
	self.Surname = ko.observable();
	self.Birthday = ko.observable();
	// END

	// Constructor
	self.init = function (context) {

	};

	// Generated ModelMethods
	// Handling submit event
    self.Submit = function() {
		// CODE HERE
	};
	// END

	self.init();
}
