using System;
using System.Collections.Generic;
using UnityEngine;

namespace mScripts
{
    public struct Planet
    {
        public String pName;
        public String pDetails;
        public float pRadius;
        public float pAxisRotaion;
        public float pOrbitRotation;
        public float pDistanceFromCenter;
        public String pLengthOfDay;
        public String pTemperatue;
        public String pNoOfMoons;
        public String pMass;
        public String pTimeForAxis;
        public String pTimeForSun;

        public Planet(string pName, string pDetails, float pRadius, float pAxisRotaion, float pOrbitRotation, float pDistanceFromCenter, string pLengthOfDay, string pTemperatue, string pNoOfMoons, string pMass, string pTimeForAxis, string pTimeForSun)
        {
            this.pName = pName;
            this.pDetails = pDetails;
            this.pRadius = pRadius;
            this.pAxisRotaion = pAxisRotaion;
            this.pOrbitRotation = pOrbitRotation;
            this.pDistanceFromCenter = pDistanceFromCenter;
            this.pLengthOfDay = pLengthOfDay;
            this.pTemperatue = pTemperatue;
            this.pNoOfMoons = pNoOfMoons;
            this.pMass = pMass;
            this.pTimeForAxis = pTimeForAxis;
            this.pTimeForSun = pTimeForSun;
        }


        public List<Planet> createPlanets()
        {
            List<Planet> mPlanets = new List<Planet>();
            mPlanets.Add(new Planet(
                "Mercury", //Name
                "Mercury is the smallest of all of the eight regular planets in the Solar System. It has a cratered surface resembling that of Earth's Moon, and not a great deal of atmosphere. Not the kind of place you'd like to take your family out for lunch", // Details
                2.4f, // Radius(real/1000) & Diameter is 2xR 
                0.018f, //Axis Rotaion using mi/s => 10.892 km/h (0.018 mi/s)  //Equator Moves at that speed
                4.7f, //Orbital Rotation r=(km/s) r/10 
                3.6f, //Distance from center (miles/10,000,000)
                "4222.6", //length of day in hrs
                "167", //mean temp in c
                "0", //no of known moons
                "0.330", //mass * 10^24kg
                "59 days", // time to spin own axis
                "88 days" // time to orbit 
                ));
            mPlanets.Add(new Planet(
                "Venus", //Name
                "Venus is the second closest planet to the Sun and the sixth largest of all of the Solar System's planets. It is the brightest object in the sky after the Sun and the Moon, appearing to be a beautiful and tranquil world from a distance.", // Details
                6.0f, // Radius & Diameter is 2xR 
                0.011f, //Axis Rotaion
                3.5f, //Rotation
                6.7f, //Distance from center
                "2808",
                "464",
                "0",
                "4.87",
                "243 days",
                "224 days"
                ));
            mPlanets.Add(new Planet(
                "Earth", //Name
                "Earth is the next planet in order of distance from the Sun. It is the largest of the Inner Planets, and fifth largest of all of the Solar System's planets. Earth is quite a special little world, being the only place in the Solar System where life is known to exist. It is your home planet.", // Details
                6.3f, // Radius & Diameter is 2xR 
                0.2f, //Axis Rotaion
                2.9f, //Rotation
                9.2f, //Distance from center
                "24",
                "15",
                "1",
                "5.97",
                "23 hrs 56 min",
                "365.25 days"
                ));
            mPlanets.Add(new Planet(
                "Mars", //Name
                "Mars is the final of the four Inner Planets and the second smallest of all planets. It is about a quarter of the size of Earth and is a popular destination for unmanned space missions from Earth. ", // Details
                3.3f, // Radius & Diameter is 2xR 
                0.14f, //Axis Rotaion
                2.4f, //Rotation
                14.1f, //Distance from center
                "24.7",
                "-65",
                "2",
                "0.642",
                "24 hrs 37 min",
                "687 days"
                ));
            mPlanets.Add(new Planet(
                "Jupiter", //Name
                "Jupiter is the first of the Outer Planets and is the largest planet in the Solar System. It is mostly made up of hydrogen and helium gas, but contains a load of other gasses too. ", // Details
                69.9f, // Radius & Diameter is 2xR 
                7.8f, //Axis Rotaion
                1.3f, //Rotation
                48.3f, //Distance from center
                "9.9",
                "-110",
                "67",
                "1898",
                "9 hrs 55 min",
                "11.86 years"
                ));
            mPlanets.Add(new Planet(
                "Saturn", //Name
                "Saturn is the second largest planet in the Solar System. It is similar in make-up to Jupiter, but isn't quite as stormy. What makes Saturn stand out though are its rather splendid rings.", // Details
                58.2f, // Radius & Diameter is 2xR 
                6.13f, //Axis Rotaion
                0.9f, //Rotation
                88.8f, //Distance from center
                "10.7",
                "-140",
                "62",
                "568",
                "10 hrs 39 min",
                "29 years"
                ));
            mPlanets.Add(new Planet(
                "Uranus", //Name
                "Uranus is the third largest planet, a featureless world which orbits on its side. It has 27 moons which are mostly named after characters in Shakespeare's plays. Uranus was the first planet to be discovered as all of the other closer planets have been observed from Earth for thousands of years.", // Details
                25.3f, // Radius & Diameter is 2xR 
                1.6f, //Axis Rotaion
                0.68f, //Rotation
                178.3f, //Distance from center
                "17.2",
                "-195",
                "27",
                "86.8",
                "17 hrs 14 min",
                "84 years"
                ));
            mPlanets.Add(new Planet(
                "Neptune", //Name
                "Neptune is the most distant of the eight planets in the Solar System. It was discovered in 1846 by German astonomer, Johann Gottfried Galle", // Details
                24.6f, // Radius & Diameter is 2xR 
                1.7f, //Axis Rotaion
                0.54f, //Rotation
                279.7f, //Distance from center
                "16.1",
                "-200",
                "14",
                "102",
                "16 hrs 7 min",
                "164.8 years"
                ));
            mPlanets.Add(new Planet(
                "Pluto", //Name
                "Pluto, the largest of the dwarf planets, was discovered in 1929 by American astronomer Clyde Tombaugh. It was initially classified as a planet and remained the ninth planet in the Solar System until 2006 when it was reclassified as a dwarf planet", // Details
                1.18f, // Radius & Diameter is 2xR 
                0.008f, //Axis Rotaion
                0.4f, //Rotation
                366.6f, //Distance from center //Avg of 275 and 258
                "153", // in hours
                "-229",
                "5",
                "0.013",
                "6 days 9 hrs",
                "248 years"
                ));
            mPlanets.Add(new Planet(
                "Moon", //Name
                "The Moon is an astronomical body that orbits planet Earth and is Earth's only permanent natural satellite. It is the fifth-largest natural satellite in the Solar System,", // Details
                1.7f, // Radius & Diameter is 2xR //
                0.004f, //Axis Rotaion
                4.0f, //Rotation
                0.01f, //Distance from center //Avg of 275 and 258
                "153", // in hours
                "-229",
                "5",
                "0.013",
                "6 days 9 hrs",
                "248 years"
                ));
            mPlanets.Add(new Planet(
                "Sun", //Name
                "The Sun is the star at the center of the Solar System. It is a nearly perfect sphere of hot plasma, with internal convective motion that generates a magnetic field via a dynamo process. It is by far the most important source of energy for life on Earth.",
                1.7f, // Radius & Diameter is 2xR //
                0.004f, //Axis Rotaion
                4.0f, //Rotation
                0.01f, //Distance from center //Avg of 275 and 258
                "153", // in hours
                "-229",
                "5",
                "0.013",
                "6 days 9 hrs",
                "248 years"
                ));
            return mPlanets;
        }

        public Planet getPlanetByIndex(int i)
        {
            return createPlanets()[i];
        }

        public Planet getPlanetByName(String pName)
        {
            List<Planet> mPlanetList = createPlanets();
                switch (pName)
                {
                    case "Mercury":
                        return mPlanetList[0];
                    case "Venus":
                        return mPlanetList[1];
                    case "Earth":
                        return mPlanetList[2];
                    case "Mars":
                        return mPlanetList[3];
                    case "Jupiter":
                        return mPlanetList[4];
                    case "Saturn":
                        return mPlanetList[5];
                    case "Uranus":
                        return mPlanetList[6];
                    case "Neptune":
                        return mPlanetList[7];
                    case "Pluto":
                        return mPlanetList[8];
                    case "Moon":
                        return mPlanetList[9];
                    default:
                        return mPlanetList[2];
                }
        }
        
        
    }
    
}

/* References
 1 - https://www.theplanetstoday.com/planets_information_basic_facts.html
 2 - https://www.bobthealien.co.uk/solarsystem/table.htm
 3 - http://planetfacts.org/orbital-speed-of-planets-in-order/
 4 - https://en.wikipedia.org/wiki/Planet_Name
 5 - Asset Store : Asset of Nebula Volume 2 Sky-Box
 */