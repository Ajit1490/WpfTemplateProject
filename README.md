# WpfTemplateProject
Template to start building application in WPF. 


It comes with :

1. BaseViewModel.cs - that implements INotifyPropertyChanged interface.
2. DelegateCommandAsync.cs - that implements ICommand interface.
3. MainMenuView where, there are 2 Menu options 'Home' and 'Binding Demo'. Binding Demo demonstrates a simple example of Property binding to a textbox 
and a Command binding to a button click (Button Command in WPF), that displays a message box to user when clicked.

To display message box, ViewModel (Business logic/ Model layer should not depend on UI/WPF dependencies. This template project comes with a sample example of IMessageBoxService,
that is exposed by View Model layer and is implemented by Views. Using, dependency injection, this interface will be passed by MainMenuViewModel (which manages all other view models)
to each required View Model.

As most of this stuff is required by every native WPF application, using this template as a start, users can start building WPF application easily and without spending time in writing all the boiler plate code.

Screenshots:

https://github.com/Ajit1490/WpfTemplateProject/blob/main/Screenshots/HomeScreen.png?raw=true

https://github.com/Ajit1490/WpfTemplateProject/blob/main/Screenshots/BindingDemoScreen.png?raw=true

https://github.com/Ajit1490/WpfTemplateProject/blob/main/Screenshots/BindingDemoScreen%20MessageBox.png?raw=true
