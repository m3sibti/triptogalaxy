using System.Collections;
using System.Collections.Generic;
using mScripts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{

	//public GameObject SunSphere;
	//public Planet selectedPlanet;
	//public GameObject player; 

	//public float radiusSun = 65.0.5f;
	// Use this for initialization
	void Start () {
		//SunSphere.transform.localScale = Vector3.one * radiusSun;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void morePointerEnter(int planetIndex)
	{
		//Debug.Log("Hello Buddy");
		//if (planetIndex == 15)
		//	return;
		var mPlanet = new Planet().getPlanetByIndex(planetIndex);
		//Debug.Log(mPlanet.pName);
		toggleViewPanel(true, mPlanet);
	}

	public void morePointerExit()
	{
		toggleViewPanel(false, new Planet());
	}
	
	public void pointerEnter(GameObject gameObject)
	{
		//Debug.Log("Hello Planet :"+gameObject.name);
		toggleText(gameObject, true);
		//specialFeatures(gameObject);
	}

	public void pointerExit(GameObject gameObject)
	{
		toggleText(gameObject, false);
		toggleViewPanel(false, new Planet());
	}

	void toggleViewPanel(bool a, Planet p)
	{
		
		GameObject holder = GameObject.FindGameObjectWithTag("MyHolder");
		GameObject canvas = holder.transform.Find("Canvas").gameObject;
		Text mPanelText = canvas.transform.Find("text").GetComponent<Text>();
		Text mPanelDetails = canvas.transform.Find("details").GetComponent<Text>();
		if (a)
		{
			mPanelText.text = p.pName;
			mPanelDetails.text = p.pDetails;
		}
		canvas.SetActive(a);
	}

	void toggleText(GameObject gObj, bool a)
	{
		GameObject x = gObj.transform.GetChild(0).gameObject;
		GameObject y = gObj.transform.GetChild(1).gameObject;
		x.SetActive(a);
		y.SetActive(a);
	}
}
