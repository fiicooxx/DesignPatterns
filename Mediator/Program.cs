using Mediator;

Button submitButton = new Button();
Checkbox clientType = new Checkbox();

new RegisterClientView(clientType, submitButton);

submitButton.Click();
clientType.Select();