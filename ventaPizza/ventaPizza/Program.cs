using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaPizza
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Elija el sabor de pizza: Napolitana, Hawaiana, Criolla");
            var tipo = Console.ReadLine();
            Console.WriteLine(tipo);
            Console.WriteLine("Elija el tamaño de su pizza: Grande, Mediano , Pequeña");
            var tamanio = Console.ReadLine();
            Console.WriteLine(tamanio);
            if(tipo=="Hawaiana")
            {
                string pizza = crearHawaiana(tamanio);
                Console.WriteLine(pizza);
            }
            else
            {
                if(tipo=="Napolitana")
                {
                    string pizza = crearNapolitana(tamanio);
                    Console.WriteLine(pizza);
                }
                else
                {
                    string pizza = crearCriolla(tamanio);
                    Console.WriteLine(pizza);
                }
            }

            Console.Read();

        }

        static string crearHawaiana( string tam)
        {
            if (tam == "Pequeña")
            {
                var peq = new hawaiana() { cantidadPinia = 4, porciones = 4, precio = 45, Promo = "sin soda", tamanio = "pequeña", tipo = "Hawaina", tipoQueso = "mozzarella" };
                return "Su orden es Pizza: " + peq.tipo + ", porciones : " + peq.porciones + " tamaño: " + peq.tamanio + " Queso: " + peq.tipoQueso + " Promo: " + peq.Promo + " Costo total= " + peq.precio + "Bs";
            }
            else
            {
                if (tam == "Mediano")
                {
                    var med = new hawaiana() { cantidadPinia = 6, porciones = 6, precio = 60, Promo = "soda popular", tamanio = "mediano", tipo = "Hawaina", tipoQueso = "mozzarella" };
                    return "Su orden es Pizza: " + med.tipo + ", porciones : " + med.porciones + " tamaño: " + med.tamanio + " Queso: " + med.tipoQueso + " Promo: " + med.Promo + " Costo total= " + med.precio + "Bs";
                }
                else
                {
                    var gran = new hawaiana() { cantidadPinia = 8, porciones = 8, precio = 75, Promo = "soda familiar", tamanio = "grande", tipo = "Hawaina", tipoQueso = "mozzarella" };
                    return "Su orden es Pizza: " + gran.tipo + ", porciones : " + gran.porciones +  " tamaño: " + gran.tamanio + " Queso: " + gran.tipoQueso + " Promo: " + gran.Promo + " Costo total= " + gran.precio + "Bs";
                }
            } 
        }

        static string crearNapolitana(string tam)
        {
            if (tam == "Pequeña")
            {
                var peq = new Napolitana() { porciones = 4, precio = 45, Promo = "sin soda", tamanio = "pequeña", tipo = "Napolitana", tipoQueso = "mozzarella" , aceituna="No", tomate=false};
                return "Su orden es Pizza: " + peq.tipo + ", porciones : " + peq.porciones + " tamaño: " + peq.tamanio + " Queso: " + peq.tipoQueso + " Promo: " + peq.Promo + "Sin Aceituna ni Tomate" + " Costo total= " + peq.precio + "Bs";
            }
            else
            {
                if (tam == "Mediano")
                {
                    var med = new Napolitana() {porciones = 6, precio = 60, Promo = "soda popular", tamanio = "mediano", tipo = "Napolitana", tipoQueso = "mozzarella", aceituna="Si", tomate=false};
                    return "Su orden es Pizza: " + med.tipo + ", porciones : " + med.porciones + " tamaño: " + med.tamanio + " Queso: " + med.tipoQueso + " Promo: " + med.Promo + "Sin aceituna, Con tomate" + " Costo total= " + med.precio + "Bs";
                }
                else
                {
                    var gra = new Napolitana() {porciones = 8, precio = 75, Promo = "soda familiar", tamanio = "grande", tipo = "Napolitana", tipoQueso = "mozzarella" , aceituna="Si", tomate=true};
                    return "Su orden es Pizza: " + gra.tipo + ", porciones : " + gra.porciones + " tamaño: " + gra.tamanio + " Queso: " + gra.tipoQueso + " Promo: " + gra.Promo + "Con Aceituna y Tomate" + " Costo total= " + gra.precio + "Bs";
                }
            }
        }

        static string crearCriolla(string tam)
        {
            if (tam == "Pequeña")
            {
                var peq = new criolla() { porciones = 4, precio = 45, Promo = "sin soda", tamanio = "pequeña", tipo = "Criolla", tipoQueso = "mozzarella", cebolla=false, choclo= true, tipoCarne="molida"};
                return "Su orden es Pizza: " + peq.tipo + ", porciones : " + peq.porciones + " tamaño: " + peq.tamanio + " Queso: " + peq.tipoQueso + " Promo: " + peq.Promo + " Carne"+peq.tipoCarne+ " Con choclo" + " Costo total= " + peq.precio + "Bs";
            }
            else
            {
                if (tam == "Mediano")
                {
                    var med = new criolla() { porciones = 6, precio = 60, Promo = "soda popular", tamanio = "mediano", tipo = "Criolla", tipoQueso = "mozzarella", cebolla = true, choclo = true, tipoCarne = "molida", ColorPimenton="rojo" };
                    return "Su orden es Pizza: " + med.tipo + ", porciones : " + med.porciones + " tamaño: " + med.tamanio + " Queso: " + med.tipoQueso + " Promo: " + med.Promo + " Carne" +med.tipoCarne + " Con choclo, Cebolla y pimenton rojo" + " Costo total= " + med.precio + "Bs";
                }
                else
                {
                    var gra = new criolla() { porciones = 8, precio = 75, Promo = "soda familiar", tamanio = "grande", tipo = "Criolla", tipoQueso = "mozzarella", cebolla = false, choclo = true, tipoCarne = "molida" , ColorPimenton="verde"}; 
                    return "Su orden es Pizza: " + gra.tipo + ", porciones : " + gra.porciones + " tamaño: " + gra.tamanio + " Queso: " + gra.tipoQueso + " Promo: " + gra.Promo + gra.tipoCarne + " Con choclo, Cebolla y pimenton verde" + " Costo total= "+gra.precio +"Bs";
                }
            }
        }

    }
}
