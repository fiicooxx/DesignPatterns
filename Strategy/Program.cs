using Strategy;

var strategy = new BikeStrategy();

var map = new Map(strategy);

var start = new Cordinate();
var end = new Cordinate();

map.CreateRoute(start, end);