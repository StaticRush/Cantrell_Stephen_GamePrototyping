using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject gameOverText, restartButton;

	// Use this for initialization
	void Start ()
    {
        gameOverText.SetActive(false);
        restartbutton.setActvie(false);
        speed = 3;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(axisX, axisY)*Time.deltaTime*speed);
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            gameOver.Text.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
