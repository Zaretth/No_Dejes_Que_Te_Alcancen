using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovil : MonoBehaviour {
    #region Variables

    public Transform Personaje; //Esta variable nos permite acceder al transform de nuestro personaje
    public float Retraso = 5.32f; //Lo usamos para poner la camara un poco mas adelante de nuestro personaje.


    #endregion
    // Update is called once per frame
    void Update () {
        
        transform.position = new Vector3(Personaje.position.x + Retraso, transform.position.y, transform.position.z);
	}
}
