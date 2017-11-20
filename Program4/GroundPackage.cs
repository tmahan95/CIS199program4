using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage
    {
        //PACKAGE FIELDS
        private int _originZip;
        private int _destZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //CONSTRUCTOR:

        //Preconditions: 
        // 1) originZip >= 0 and <= 99999
        // 2) destZip >=0 and <= 99999
        // 3) length > 0
        // 4) width > 0
        // 5) height > 0
        // 6)weight > 0
                           
        //Postconditions:
        //new groundpackage will be created with the data user entered

        public GroundPackage(int originZip, int destZip, double weight,
            double length, double width, double height)
        {
            _originZip = originZip;
            _destZip = destZip;
            _length = length;
            _width = width;
            _height = height;
            _weight = weight;
        }

        //PROPERTIES:

        //Preconditions: originZip >= 0 and <= 99999
        //Postconditions: the OriginZip Property will be set to originZip and return that value
        public int OriginZip
        {
            //Preconditions: none
            //Postconditions: returns OriginZip
            get { return _originZip; }
            //Preconditions: originZip >= 0 and <= 99999
            //Postconditions: value of OriginZip property will be set to originZip variable
            set
            {
                if (value >= 0 && value <= 99999)
                    _originZip = value;
            }
        }
        //Preconditions: destZip >=0 and <= 99999
        //Postconditions: DestZip property will be set to destZip variable and return that value
        public int DestZip
        {
            //Preconditions: none
            //Postconditions: returns DestZip
            get { return _destZip; }
            //Preconditions: destZip >=0 and <= 99999
            //Postconditions: DestZip will be set to destzip variable
            set
            {
                if (value >= 0 && value <= 99999)
                    _destZip = value;
            }
        }
        //Preconditions: length > 0
        //Postconditions: Length will be set to length variable and return that value
        public double Length
        {
            //Preconditions: none
            //Postconditions: returns Length
            get { return _length; }
            //Preconditions: length > 0
            //Postconditions: Length will be set to length variable
            set
            {
                if (value > 0)
                    _length = value;
            }
        }
        //Preconditions: width > 0
        //Postconditions: Width will be set to width variable and return that value
        public double Width
        {
            //Preconditions: none
            //Postconditions: returns Width
            get { return _width; }
            //Preconditions: width > 0
            //Postconditions: sets Width to width variable
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        //Preconditions: height > 0
        //Postconditions: sets Heigh to height variable
        public double Height
        {
            //Preconditions: None
            //Postconditions: returns Height
            get { return _height; }
            //Preconditions: height > 0
            //Postconditions: sets Height to height variable
            set
            {
                if (value > 0)
                    _height = value;
            }
        }
        //Preconditions: weight > 0
        //Postconditions:Weight will be set to weight variable
        public double Weight
        {
            //Preconditions: none
            //Postconditions: returns Weight
            get { return _weight; }
            set
            //Preconditions: weight > 0
            //Postconditions: sets Weight to weight
            {
                if (value > 0)
                    _weight = value;
            }
        }

        // METHODS:

        //Preconditions: must have valid origin and destination zip codes between 00000 and 99999
        //Postconditions: Distance between zip codes wil be calculated and returned as an integer.
        public int ZoneDistance
         {
             //Preconditions: none
             //Postconditions: returns absolute zone distance as an integer.
             get
             {
                 return Math.Abs(_destZip / 10000 - _originZip / 10000);
             }
            
         }
        //Preconditions: none
        //Postconditions: 
        //A text string of originZip, destZip, length, width, height, and weight will be created and returned as a string.
        //each property of the package will be displayed on its own line of text.
        public override string ToString()
        {
            string result = "Origin Zip: " + OriginZip.ToString() + System.Environment.NewLine + "Dest Zip: " + DestZip.ToString() + System.Environment.NewLine
                + "Weight: " + Weight.ToString() + System.Environment.NewLine + "Length: " + Length.ToString() + System.Environment.NewLine + "Width: " + Width.ToString()
                + System.Environment.NewLine + "Height: " + Height.ToString();
            return result;
        }
        //Preconditions:
        // 1) must have valid zip codes between 0 and 99999
        // 2) must have valid length, width, height and weight all > 0.
        //Postconditions: the absolute value of the cost to ship a package will be calculated and returned as a double.
        public double CalcCost()
        {
            double cost = Math.Abs(.2 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * Weight);
            return cost;
        }
    }
}
