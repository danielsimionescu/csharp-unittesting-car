using System;

namespace CarLibrary
{
    public class Owner
    {
        private string _address;
        private string _name;
        private string _phone;

        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length <= 6)
                    throw new ArgumentOutOfRangeException(
                        nameof(Address),
                        value,
                        "Address is too short");
                _address = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Name),
                        value,
                        "Name cannot be empty");
                }
                if (value.Length <= 4)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Name),
                        value,
                        "Name is too short");
                }
                _name = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length != 8)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Phone),
                        value,
                        "Phone is too short");
                }
                _phone = value;
            }
        }

        public Owner()
        {

        }

        public Owner(string address, string name, string phone)
        {
            Address = address;
            Name = name;
            Phone = phone;
        }
    }
}