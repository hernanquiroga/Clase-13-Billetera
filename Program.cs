//Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  

//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)

using Clase_13_Billetera.Modelo;

var billetera1 = new Billetera(2,4,8,9,4,3,1); // Instanciado desde el constructor

var billetera2 = new Billetera(5,8,9,6,7,8,1);


Console.Write("Billetera 1 suma :");
Console.WriteLine("$" + billetera1.Total() + " Pesos");

Console.Write("Billetera 2 suma :");
Console.WriteLine("$" + billetera2.Total() + " Pesos");

var billetera3 = billetera1.Total() + billetera2.Total();

Console.Write("Billetera 3 suma :");
Console.WriteLine(billetera3);

Console.WriteLine("Ahora billetera 1 tiene :" + billetera1.BorrarBilleteras());
Console.WriteLine("Ahora billetera 2 tiene :" + billetera2.BorrarBilleteras());










