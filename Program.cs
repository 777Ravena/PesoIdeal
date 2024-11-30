Console.Clear();
 
double Altura, PesoIdeal;
string Sexo;
 
Console.Write("Digite sua altura em m......: ");
Altura = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Sexo [M]asculino / [F]eminino...: ");
Sexo = Console.ReadLine()!.ToUpper().Trim();
 
if (Sexo != "M" && Sexo != "F")
{
    Console.WriteLine("Não possuo fórmula para cálculo.");
}
else
{
    if (Sexo == "M")
    {
        PesoIdeal = Altura * 72.7 - 58.0;
    }
    else
    {
        PesoIdeal = Altura * 62.1 - 44.7;
    }
 
    Console.WriteLine($"Seu peso ideal é {PesoIdeal:N1}kg.");
}
 
 