// Tom Ellner NET23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Geometri
    {
        // The Geometri class is the base class for various geometric shapes.
        public double _pi = 3.141f; // A field to store the value of pi.
        public double _area; // A field to store the area of the geometric shape.
        public virtual double Area()
        {
            // This is a virtual method for calculating the area of the shape.
            // It returns the _area field, which is calculated in derived classes.
            return _area;
        }
    }
    public class Cirkel : Geometri
    {
        // The Cirkel class represents a circle and inherits from Geometri.
        public double _radius; // Field to store the radius of the circle.
        public Cirkel()
        {
            // Constructor for Cirkel, setting a default radius.
            _radius = 4;
        }
        public override double Area()
        {
            // Overrides the Area method to calculate the area of a circle.
            // The area is calculated using the formula for a circle.
            _area = _radius * _radius * _pi;
            return _area;
        }
    }
    public class Kvadrat : Geometri
    {
        // The Kvadrat class represents a square and inherits from Geometri.
        public double _side; // Field to store the side length of the square.
        public Kvadrat()
        {
            // Constructor for Kvadrat, setting a default side length.
            _side = 2;
        }
        public override double Area()
        {
            // Overrides the Area method to calculate the area of a square.
            // The area is calculated by squaring the side length.
            _area = _side * _side;
            return _area;
        }
    }
    public class Rektangel : Geometri
    {
        // The Rektangel class represents a rectangle and inherits from Geometri.
        public double _sideA; // Field to store the length of one side.
        public double _sideB; // Field to store the length of the other side.
        public Rektangel()
        {
            // Constructor for Rektangel, setting default side lengths.
            _sideA = 5;
            _sideB = 7.5f;
        }
        public override double Area()
        {
            // Overrides the Area method to calculate the area of a rectangle.
            // The area is calculated by multiplying the two side lengths.
            _area = _sideA * _sideB;
            return _area;
        }
    }
    public class Paralellogram : Geometri
    {
        // The Paralellogram class represents a parallelogram and inherits from Geometri.
        public double _base; // Field to store the length of the base.
        public double _height; // Field to store the height.
        public Paralellogram()
        {
            // Constructor for Paralellogram, setting default base and height.
            _base = 10;
            _height = 3;
        }
        public override double Area()
        {
            // Overrides the Area method to calculate the area of a parallelogram.
            // The area is calculated by multiplying the base and the height.
            _area = _base * _height;
            return _area;
        }
    }
    public class Ellips : Geometri
    {
        // The Ellips class represents an ellipse and inherits from Geometri.
        public double _base; // Field to store the semi-major axis.
        public double _height; // Field to store the semi-minor axis.
        public Ellips()
        {
            // Constructor for Ellips, setting default semi-major and semi-minor axes.
            _base = 2.5f;
            _height = 5.5f;
        }
        public override double Area()
        {
            // Overrides the Area method to calculate the area of an ellipse.
            // The area is calculated using the formula for the area of an ellipse.
            _area = _base * _height * _pi;
            return _area;
        }
    }
}
