using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.SceneManagment;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void restartScene()
    {
        SceneManager.LoadScene("Scene01");
    }
}
