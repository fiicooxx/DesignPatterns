using State;

var context = new Context();

context.EjectCard();
context.InsertCard();
context.EjectCard();
context.InsertCard();
context.InsertPin(1111);
context.InsertCard();
context.InsertPin(9999);
context.WithdrawCash(500);
context.InsertCard();
context.InsertPin(9999);
context.WithdrawCash(550);
context.WithdrawCash(500);