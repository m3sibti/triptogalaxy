# Trip to Galaxy
A Student Trip to Galaxy in Virtual Reality by Sibti Malik

A Solar System for Educational Purpose of Students

## User Perspective:
	- A VR View of Solar System
	- On interactin name of planet appears on it top
	- Contains 9 Planets, Earth with it's moon, And a Sun
	- A button also appears on top of planet
	- on interaction with that button it shows you the the information/detail of that planet

## Developer Perspective:
	Contain 3 Scripts
		* Planet ( Model Class for the Planet and Create list of planet (properties and methods for planet) )
		* planetRotator ( for setting position and rotation of planet )
		* gameController ( for gameController events and many GUI functions)
	Prefabs
		* Sun
		* Planets
		* Box (Button on Top of Planet)
		* Game Controller
	GvrEventSystem
		* To handle the pointerEnter and pointerExit
	Canvas
		* For Information in 2d text 
	Planet Model Class
		* String pName, pDetails pLengthOfDay pTemperatue pNoOfMoons pMass pTimeForAxis pTimeForSun
            * float pRadius pAxisRotaion pOrbitRotation pDistanceFromCenter 
		* Methods -createList, getPlanetbyIndex, getPlanetbyName
	My Measurements
		    * pRadius 		        => Radius(real/1000) & Diameter is 2xR 
                * pAxisRotaion 		=> Axis Rotaion using mi/s => 10.892 km/h (0.018 mi/s)  //Equator Moves at that speed
                * pOrbitRotation 		=> Orbital Rotation r=(km/s) r/10 
                * pDistanceFromCenter	=> Distance from center (miles/10,000,000)
                * pLengthOfDay		=> length of day in hrs
                * pTemperatue 		=> mean temp in c
                * pNoOfMoons		=> no of known moons
                * pMass			=> mass * 10^24kg
                * pTimeForAxis		=> time to spin own axis (days)
                * pTimeForSun		=> time to orbit  (days or hrs)

### Note:
  This Trip to galaxy is almost complete but i am thinking for taking it to next level and release it's android version
  on playstore (using my account). If it's beta mode developers expected results

### References
 1 - https://www.theplanetstoday.com/planets_information_basic_facts.html <br>
 2 - https://www.bobthealien.co.uk/solarsystem/table.htm <br>
 3 - http://planetfacts.org/orbital-speed-of-planets-in-order/ <br>
 4 - https://en.wikipedia.org/wiki/Planet_Name <br>
 5 - Asset Store : Asset of Nebula Volume 2 Sky-Box <br>
 
 
