using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    // Its' Internal. which means that
    // it can only be accessed from
    // within the same assembly
    internal class Car
    {
        // meber variable
        // private hides the variable from other classes
        private string _model = ""; // 시샵에서는 언더바 붙이는게 관례라는듯
        private string _brand = "";


        // Property
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand;
            set {
                    if(string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("You entered NOTHING");
                        _brand = "DEFAULTVALUE";
                    }
                    else
                    {
                        _brand = value;
                    }
                } 
        }


        // Constructor
        public Car(string model, string brand) {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }
    }
}
