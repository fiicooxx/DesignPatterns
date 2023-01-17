using AbstractFactory;

var uiWinApp = new Application(new WindowsFactory());
uiWinApp.RwnderUI();

Console.WriteLine();

var uiMacApp = new Application(new MacFactory());
uiMacApp.RwnderUI();