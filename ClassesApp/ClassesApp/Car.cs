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
        // private string _model = ""; // 시샵에서는 언더바 붙이는게 관례라는듯
        private string _brand = "";
        private bool _isLuxury;


        // Property
        //public string Model { get => _model; set => _model = value; }

        public string Model { get; set; }
        public string Brand { 
            
            get
            {
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
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

        // public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury { get; set; }

        // Constructor
        public Car(string model, string brand, bool isLuxury) {
            Model = model;
            Brand = brand;
            
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
            
            IsLuxury = isLuxury;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} driving");
        }
    }
}
