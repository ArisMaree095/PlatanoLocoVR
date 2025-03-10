using UnityEngine;

public class Cuchara : MonoBehaviour
{//Dos puntos al lado del nombre de la clase significa herencia

    //Acceso tipo nombre
    public int capacidad;
    public Material CMaterial;
    public float tamano;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum Material
    { //enum es la lista que coloca texto de un lado y numeros de otro

        madera,
        plastico,
        aceroInoxidable,
    }
}
