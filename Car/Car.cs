using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        private int _doors;
        private string _make;
        private string _regNo;

        public Colors Color { get; set; }

        public Owner Owner { get; set; }

        public int Doors
        {
            get => _doors;
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Doors),
                        value,
                        "The number of doors is wrong");
                }
                _doors = value;
            }
        }

        public string Make
        {
            get => _make;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Make),
                        value,
                        "Manufacturer cannot be empty");
                }
                _make = value;
            }
        }

        public string RegistrationNo
        {
            get => _regNo;
            set
            {
                if (value.Length != 7)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(RegistrationNo),
                        value,
                        "Registration number must be 7 characters long");
                }
                _regNo = value;
            }
        }

        public Car(string registrationNo, string make, int doors, Colors color)
        {
            RegistrationNo = registrationNo;
            Make = make;
            Doors = doors;
            Color = color;
        }

        public Car()
        {
        }

        public enum Colors
        {
            Black,
            White,
            Blue
        }
    }
}
