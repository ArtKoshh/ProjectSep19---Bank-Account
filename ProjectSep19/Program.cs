using ProjectSep19;

var acc = new Bank(100,"Artur");
var acc2 = new Bank(75, "Arr");

Console.WriteLine(acc.Saldo);

acc.Transfer(50, acc2);
Console.WriteLine($"konto 1: {acc.Saldo} , konto 2: {acc2.Saldo}");