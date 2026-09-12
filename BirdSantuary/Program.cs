// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BirdSantuary;

Sparrow sp1 = new Sparrow(1,"flying bird",Gender.MALE);
Sparrow sp2 = new Sparrow(1, "flying bird", Gender.MALE);
Ostrich os1 = new Ostrich(2, "Land bird", Gender.FEMALE);
Duck d1 = new Duck(3, "Water Bird", Gender.MALE);
Duck d2 = new Duck(4, "Water bird", Gender.FEMALE);

Santuary s1 = new Santuary();

s1.Add(sp1);
s1.Add(sp2);
s1.Add(os1);
s1.Add(d1);
s1.Add(d2);
s1.Add(d1);

s1.Remove(sp2,"Transfering to another santuary");
s1.Remove(d1, "Bird died");

s1.DisplayBirds();
s1.DisplayRemovedBirds();