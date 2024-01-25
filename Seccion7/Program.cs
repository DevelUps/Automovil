using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Local variable
            bool accelerate;

            //Instantiating the Car class
            Automovil automovil1 = new Automovil();

            //Asignation
            //automovil1.Color = "Rojo";
            automovil1.Fuel = "Diesel";

            //Displaying private field
            //Console.WriteLine("The color type is: {0} ", automovil1.Color);

            //Assigning a value to a private field and displaying it
            //Console.WriteLine("The fuel type is: {0} ", automovil1.Fuel);

            Console.WriteLine(automovil1.ToString());
            
            //accelerate = automovil1.Accelerate();
            //if (accelerate)
            //{
            //    Console.WriteLine("we are Accelerating correctly");
            //}

            //Automovil.prueba();



        }
    }

        //[Accses modify] [class] [identificator]
        public class Automovil
        {
        
        //Fields
        private string color = "Blue", model ="XYZ43", fuel, year = "1985";
        private int ccMotor = 1500;
        private byte numOfDoors;


        // Example for initializing a field with a constructor
        private string seats, dashboardColor;
        private bool rearCamera;

        // constructor
        public Automovil()
        {
            seats = "Coofee";
            dashboardColor = "Black";
            rearCamera = true;
        }

        //Properties
        //Access ][Type] [Name]
        public string Color
        {
            //Descriptor access get
            get => color;//get { return color; }
            set => color = value;
        }
        public string Fuel
        {
            //Descriptor access get-set
            //Accesors
            //get { return fuel; }
            get => fuel;

            //set { fuel = value; }
            set => fuel = value;
        }
        //Methods
        public bool Accelerate()
        {
            bool accelerate = true;
            Console.WriteLine("The car is Accelerate");
            prueba();
            return accelerate;
        }     
        public void Speed(ref byte speedPR)
        {
            speedPR++;
            Console.WriteLine("Change of speedy");    
        }
         //Static method
        public static void prueba()
        {
            Console.WriteLine("I am static method");
        }

        //Invalidating tostring method
        public override string ToString()
        {
            string mensaje;

            mensaje = "Model:" + model + "\nColor :" + color + "\nYear :" + year + "\nDoors :" + numOfDoors + "\nFuel :" + fuel + "\nMotor :" + ccMotor + "\nSeats : " + seats + "\nDashboard Color: " + dashboardColor + "\nRear Camera :" +rearCamera;
            
            return mensaje;
        }
    }
}
