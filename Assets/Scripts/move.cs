using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public float speed = 1; //Variable für Geschwindigkeit

    void Update()
	{
		//Auf Koordinaten des GameObjects wird der Vector (-1,0,0) addiert
		//Dieser Vektor wird multipliziert mit speed und Time.deltaTime für Unabhängikeit von Framerate
	    transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
