using UnityEngine;
using System.Collections;

public class Main_Screen : MonoBehaviour {

	void OnGUI () {

			
		if (GUI.Button(new Rect(10,10,200,200),"Create Server"))
		{
			//Loads the Server Scene
			Application.LoadLevel(1);
		}
		
		
		
		if (GUI.Button(new Rect(10,220,200,200),"Play Game"))
		{
			//Loads the Character Loading Screen
			Application.LoadLevel(2);
		}  



	}

	

}
