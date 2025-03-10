using UnityEngine;

public class ElCucharador : MonoBehaviour
{

    public Cuchara cuchara;

    [ContextMenu("detalles")]
    public void Detalles() 
    {
        print($"La cuchara tiene {cuchara.capacidad} de capacidad.");
        print($"{cuchara.CMaterial}");
        print($"{(int)cuchara.CMaterial}");

    }
}
