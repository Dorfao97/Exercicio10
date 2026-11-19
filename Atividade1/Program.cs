var dinheiro = new Money(200);
var dinheiro2 = new Money();
var felicidade = new Pilha();

int x = 10;

do
{
    var m = new Money(Random.Shared.Next(1,100));
    Console.WriteLine(m);

    felicidade.AddElement(m);
    Thread.Sleep(1000);
    Console.Clear();

    x--;
}while(x > 0);

Console.WriteLine("Mostarando a pilha criada...\n");
felicidade.ShowStack();

Console.Clear();

while(felicidade.ElementCount() != 0)
{
    felicidade.RemoveElement();
    if (felicidade.IsEmpty())
        break;
    felicidade.ShowStack();
    Thread.Sleep(1000);
    Console.Clear();
}