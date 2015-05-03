using UnityEngine;
using System.Collections;

public class ConnectToServer : MonoBehaviour {

	// Use this for initialization
	void Start () {
			
		HostData[] ServerInfo; 
		//Connects to Server
		MasterServer.RequestHostList("1020");
		//Allow time to search for server.
		while ( !ServerInfo ) {
			yield return new WaitForSeconds(1);				
		}
		ServerInfo = MasterServer.PollHostList();
		//If we cant connect
		if (!Network.Connect(ServerInfo[0])){
			print ("Failure to Connect");
		}
		else {
			print ("Connected!");	
		}
		
		
		
		
	}
}