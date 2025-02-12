// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa la cantidad de dias");
var cantidadDias = int.Parse(Console.ReadLine());
int[] aliensInicial = { 3, 4, 3, 1, 2 };
var lsInicial = new List<int>();
var lsNuevoAlien = new List<int>();
var lsFinal = new List<int>();
int cantidadAliens = 0; 

Console.Clear();
for (int i = 0; i < cantidadDias; i++)
{
   aliensInicial = i ==0 ? aliensInicial: lsNuevoAlien.ToArray();
   for (int j = 0; j < aliensInicial.Length; j++)
   {
      var statusAlien = false;
      var valor = aliensInicial[j] - 1;
      if (valor < 0)
      {
         valor = 6;
         lsFinal.Add(8);
      }
      lsInicial.Add(valor);
   }
   lsNuevoAlien.Clear();
   lsNuevoAlien.AddRange(lsInicial);
   lsNuevoAlien.AddRange(lsFinal);
   lsInicial.Clear();
   lsFinal.Clear();
   Console.WriteLine($"dia {i+1} : " + string.Join(",",lsNuevoAlien));
   cantidadAliens = lsNuevoAlien.Count;

}

Console.WriteLine($"Cantidad de aliens: {cantidadAliens} en el dia: {cantidadDias}" );




