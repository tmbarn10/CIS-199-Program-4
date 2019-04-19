// Program 4
// CIS 199-02
// Due: 4/25/2017
// Grading ID: B3049

// The GroundPackage class contains properties that are used to hold information that can be used in the form application.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage
    {
        public const int MINIMUM_ZIP = 00000; // Minimum zip code
        public const int MAXIMUM_ZIP = 99999; // Maximum zip code
        public const int MINIMUM_LENGTH = 0; // Minimum Length
        public const int MINIMUM_WIDTH = 0; // Minimum Width
        public const int MINIMUM_HEIGHT = 0; // Minimum Height
        public const int MINIMUM_WEIGHT = 0; // Minimum Weight

        private int originZip; // Origin Zip code
        private int destinationZip; // Destination Zip Code
        private double lengthInches; // Length of package (inches)
        private double widthInches; // Width of package (inches)
        private double heightInches; // Height of package (inches)
        private double weightPounds; // Weight of package (pounds)
        private double cost; // Cost of packaging (dollars)

        // Preconditions: None
        // Postconditions: GroundPackage has information stored
        public GroundPackage(int zipOrigin, int zipDestination, double lengthIn, double widthIn, double heightIn, double weightLb)
        {
            OriginZip = zipOrigin;
            DestinationZip = zipDestination;
            Length = lengthIn;
            Width = widthIn;
            Height = heightIn;
            Weight = weightLb;
        }
        
        // Preconditions: Zip must be within the required zip range
        // Postconditions: origin zip is returned
        public int OriginZip
        {
            get
            {
                return originZip;
            }
            set
            {
                if ((value > MINIMUM_ZIP) && (value < MAXIMUM_ZIP))
                    originZip = value;
            }
        }
        // Preconditions: Zip must be within the required zip range
        // Postconditions: Destination zip is returned
        public int DestinationZip
        {
            get
            {
                return destinationZip;
            }
            set
            {
                if ((value > MINIMUM_ZIP) && (value < MAXIMUM_ZIP))
                    destinationZip = value;
            }
        }

        // Preconditions: Must be greater than minimum length
        // Postconditions: Length is returned

        public double Length
        {
            get
            {
                return lengthInches;
            }
            set
            {
                if (value > MINIMUM_LENGTH)
                    lengthInches = value;
            }
        }

        // Preconditions: Must be greater than minimum width
        // Postconditions: Width is returned

        public double Width
        {
            get
            {
                return widthInches;
            }
            set
            {
                if (value > MINIMUM_WIDTH)
                    widthInches = value;
            }
        }

        // Preconditions: Height must be greater than minimum height
        // Postconditions: Height is returned

        public double Height
        {
            get
            {
                return heightInches;
            }
            set
            {
                if (value > MINIMUM_HEIGHT)
                    heightInches = value;
            }
        }

        // Preconditions: Weight must be greater than minimum
        // Postconditions: Weight is returned
        public double Weight
        {
            get
            {
                return weightPounds;
            }
            set
            {
                if (value > MINIMUM_WEIGHT)
                    weightPounds = value;
            }
        }

        // Preconditions: None
        // Postconditions: Returns the calculation of zonedistance

        public int ZoneDistance
        {
            get
            {
                return (originZip / 10000) - (destinationZip / 10000);
            }
        }

        // Preconditions: Varaibles must be declared and return valid values
        // Postcondition: Cost is calculated and returned
        public double CalcCost()
        {
            return cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
        }

        // Preconditions: None
        // Postcondition: Returns a string of information of the desired package
        public override string ToString()
        {
            return "Origin zip = " + originZip.ToString() + System.Environment.NewLine +
                "Destination Zip = " + destinationZip.ToString() + System.Environment.NewLine +
                "Length = " + lengthInches.ToString() + " inches" + System.Environment.NewLine +
                "Width = " + widthInches.ToString() + " inches" + System.Environment.NewLine +
                "Height = " + heightInches.ToString() + " inches" + System.Environment.NewLine +
                "Weight = " + weightPounds.ToString() + " pounds" + System.Environment.NewLine +
                "Cost = " + cost.ToString("c");
        }
    }
}
