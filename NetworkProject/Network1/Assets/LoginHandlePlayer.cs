using UnityEngine;
using System.Collections;

public class LoginHandlePlayer : MonoBehaviour {
	
	string username = "Username";
	
	
	void OnGUI () {
		
		
		
		
		username = GUI.TextField(new Rect(10, 10, 200, 20), username, 25);
		
		
		
		
		
		if (GUI.Button(new Rect(10,40,200,200),"Login"))
		{


		}
		
		
		
		if (GUI.Button(new Rect(10,260,200,200),"Create_Account"))
		{
			

		}  
		
		
		
	}
	
	
	
}
