using Observer;

var sub1 = new Subscriber("Filip");
var sub2 = new Subscriber("Kacper");
var sub3 = new Subscriber("Seba");
var sub4 = new Subscriber("Bartek");

var publisher = new Publisher();

publisher.Subscribe(sub1);
publisher.Subscribe(sub3);

publisher.Notify("PlayStation 5");

publisher.Unsubscribe(sub1);