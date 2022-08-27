Console.WriteLine("Ingrese el primer número");
var numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
var numero2 = Convert.ToInt32(Console.ReadLine());

var division = 0;

try{
    division = numero1 / numero2;
}
catch(Exception ex){
    Console.WriteLine(ex);
}

Console.WriteLine("Resultado " + division);