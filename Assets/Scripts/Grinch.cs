using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
	public CanvasManager gameManager; //um die GameOver() method zu callen
	public float velocity; //Geschwindigkeit im Inspector verstellbar für Gamedesign
	private Rigidbody2D rb; 
  
    void Start()
	{
		////Variable rb wird der Rigidbody des GameObjects zugewiesen, auf dem das Script liegt
	    rb= GetComponent<Rigidbody2D>();
    }

   
	void Update()
	{
		//Die Rotation des GameObjects an der Z-Achse wird abhängig davon wie schnell es fällt verändert
	    transform.eulerAngles = new Vector3 (0, 0, rb.velocity.y * 3f);
		//Input.GetMouseButtonDown weil es sowohl für Leftclick der Maus als auch Tab auf dem Bildschirm registriert wird
		if(Input.GetMouseButtonDown(0))
		{
			//GameObject bekommt kurz eine neue Geschwindigkeit in der y-Achse in Höhe von velocity und wieder für Frameindependence mit Time.fixedDeltaTime
			rb.velocity = Vector2.up * velocity * Time.fixedDeltaTime;
			//Rotation braucht nach Oben einen viel höheren Multiplikator als nach Unten
	    	transform.eulerAngles = new Vector3 (0, 0, rb.velocity.y * 100f);
	    }
	    
    }
    
	
	//wird gecalled wenn Collider vom GameObject mit einem anderen Collider kollidiert
	protected void OnCollisionEnter2D(Collision2D collision)
	{
		//Funktion GameOver() vom gameManager wird gecalled
		gameManager.GameOver();
		//Zeit wird hier erneut angehalten um einen Bug zu fixen bei dem nicht alle GameObjects stillstehen
		Time.timeScale = 0;
	}
}
