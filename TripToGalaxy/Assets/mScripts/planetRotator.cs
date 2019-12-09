using System;
using System.Collections;
using System.Collections.Generic;
using mScripts;
using UnityEngine;
using Random = UnityEngine.Random;

public class planetRotator : MonoBehaviour {
	
	public Transform centerObject;

	private List<Planet> mPlanetList;
	private Planet currentPlanet;
	private String cPlanetName;
	//private int checkVar = 0;
	
	// Use this for initialization
	void Start () {
		
		//Set Planet Details From List
		mPlanetList = new Planet().createPlanets();
		//Debug.Log("Total Planets : "+mPlanetList.Count);
		cPlanetName = this.gameObject.name;
		currentPlanet = getCurrentPlanetByName(cPlanetName);
		//Debug.Log(currentPlanet.pName);
		//Debug.Log(currentPlanet.pDetails);
		
		/// change the distance size if change the sun size etc (x*sizeOfSun)
		setPlanetPosition(currentPlanet.pRadius/10, currentPlanet.pDistanceFromCenter); 
	}
	
	// Update is called once per frame
	void Update () {
		setPlanetRoation(currentPlanet.pOrbitRotation, currentPlanet.pAxisRotaion);
	}

	void setPlanetPosition(float radiusPlanet, float distanceCenter)
	{
		if (centerObject == null)
		{
			this.centerObject = this.transform;
		}
		Vector2 randomPosition = Random.insideUnitCircle;
		transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y)*distanceCenter; //TODO Moon distance issue
		transform.localScale = Vector3.one *radiusPlanet;
	}

	void setPlanetRoation(float orbitRotationSpeed, float axisRotationSpeed)
	{
		this.transform.RotateAround(this.centerObject.position,Vector3.up, orbitRotationSpeed*Time.deltaTime);
		this.transform.Rotate(Vector3.up,axisRotationSpeed*Time.deltaTime);

	}

	Planet getCurrentPlanetByName(String planetName)
	{
		switch (cPlanetName)
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
