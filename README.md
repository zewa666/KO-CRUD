KO-CRUD
=======================

This is a simple CRUD generator of JS ViewModels and HTML Views for KnockoutJS using T4 Templates.
It's only in an initial state and serves as a demo

Usage
-----
1.) Create a new Model class in C# deriving from KO_BaseModel
2.) Create your Properties, which are mapped to observables and inputs on the view side
3.) Create Methods which are mapped to either functions or ko.computed
4.) Annote your Properties and Methods with CRUDPresentationAttribute or ModelMethodDescriber for auto-generation hints
5.) Compile your project
6.) Right click on the T4 Templates and use "Run Custom Tool"
7.) Copy the generated HTML & JS files to your project
8.) Add applyBindings() to connect the View to the ViewModel
9.) thats it ...

To Do
-----
Too much to list here
