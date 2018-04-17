using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

    #region Variables

    public GameObject[] obj; //Vector del gameobject que vamos a instanciar
    public float TiempoMin = 1.25f;
    public float TiempoMax = 2.75f; //Creamos los intervalos de tiempo en los que se crearan las plataformas


    #endregion
    // Use this for initialization
    void Start () {
        
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        //Cuando el centro de notificaciones reciba el evento por parte del observador (Nosotros) de que el "PersonajeEmpiezaACorrer"...
        //...El centro de notificaciones recibirá el evento
        Generar();    
    }

    void PersonajeEmpiezaACorrer(Notification notificacion)
    {
        Generar();
    }

    // Update is called once per frame
    void Update () {
        transform.position += new Vector3(0.1f, 0, 0);
    }

    void Generar()
    {
        Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
        //El Random.Range nos elige un numero aleatorio entre 0 y (obj.lenght - 1)


        Invoke("Generar", Random.Range(TiempoMin, TiempoMax));
        //Invoke me genera de nuevo la funcion "Generar", cada cierto tiempo (Entre Tiempomin y Tiempomax)


    }
}
