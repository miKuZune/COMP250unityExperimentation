using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject ClientGO;
    public GameObject ServerGO;

	// Use this for initialization
	void Start () {
        ClientGO.SetActive(false);
        ServerGO.SetActive(false);
	}
	
	public void ActivateServer()
    {
        ServerGO.SetActive(true);
    }
    public void ActivateClient()
    {
        ClientGO.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
