decimal VC; //valor da compra
decimal VP; //valor pago
decimal VT; //valor do troco
Console.WriteLine("Insira as informações sobre a sua compra:");

Console.Write("Valor da compra (R$): ");
VC = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago (R$): ");
VP = Convert.ToDecimal(Console.ReadLine());

VT = VP - VC;

Console.WriteLine($"Troco: {VT:C}");