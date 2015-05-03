using UnityEngine;
using System.Collections;

public class ServerInitialize : MonoBehaviour {

	// Use this for initialization
	void Start () {

		bool useNat = !Network.HavePublicAddress();
		Network.InitializeServer(32, 25000, useNat);

	}
	

}
