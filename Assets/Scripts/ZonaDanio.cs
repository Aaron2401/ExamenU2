
using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    public Transform nave;
    public Transform nave2;

    private Vector3 inicioNave;
    private Vector3 inicioNave2;

    void Start()
    {
        inicioNave = nave.position;
        inicioNave2 = nave2.position;
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject == nave.gameObject ||
            otro.gameObject == nave2.gameObject)
        {
            nave.position = inicioNave;
            nave2.position = inicioNave2;
        }
    }
}
