using System;
					
public class Program
{
	public static void Main()
	{  // conteo del uno al 10i
		int opcion= 0;
		 do
		 {	 
       
        Console.WriteLine("");
		Console.WriteLine("Seleccione la opcion deseada");
		Console.WriteLine("1.Suma");
		Console.WriteLine("2.Resta");
		Console.WriteLine("3.Multiplicacion");
		Console.WriteLine("4.Division");
		opcion = int.Parse(Console.ReadLine());
	      if(opcion == 1){
				int num1 = 0;
			    int num2 = 0;
			   
				 Console.WriteLine("Escriba el primer numero");
				 num1 = int.Parse(Console.ReadLine());
				 Console.WriteLine("Escriba el segundo numero");
				 num2 = int.Parse(Console.ReadLine());
				 Console.WriteLine("");
				 Console.WriteLine("EL resultado de la suma es:"+(num1+num2));  
				 
			 }	 
              else if(opcion == 2){
				int num1 = 0;
			    int num2 = 0;
			   
				 Console.WriteLine("Escriba el primer numero");
				 num1 = int.Parse(Console.ReadLine());
				 Console.WriteLine("Escriba el segundo numero");
				 num2 = int.Parse(Console.ReadLine());
				 Console.WriteLine("");
				 Console.WriteLine("EL resultado de la suma es:"+(num1-num2));  
				 
			 }	 
			 else if(opcion == 3){
				int num1 = 0;
			    int num2 = 0;
			   
				 Console.WriteLine("Escriba el primer numero");
				 num1 = int.Parse(Console.ReadLine());
				 Console.WriteLine("Escriba el segundo numero");
				 num2 = int.Parse(Console.ReadLine());
				 Console.WriteLine("");
				 Console.WriteLine("EL resultado de la suma es:"+(num1*num2));  
				 
			 }	 
			 else if(opcion == 4){
				int num1 = 0;
			    int num2 = 0;
			   
				 Console.WriteLine("Escriba el primer numero");
				 num1 = int.Parse(Console.ReadLine());
				 Console.WriteLine("Escriba el segundo numero");
				 num2 = int.Parse(Console.ReadLine());
				 Console.WriteLine("");
				 Console.WriteLine("EL resultado de la suma es:"+(num1/num2));  
				 
			 }	 
			 
			 else{
				 Console.WriteLine("Error el numero ingresado esta fuera de rango"); 
				 
			 }	 

      } while(opcion!=9);
	}
	
	
	
}