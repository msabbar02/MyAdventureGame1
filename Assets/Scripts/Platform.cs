using System.Collections;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float dropTime = 0.3f; // tiempo que estará "atravesable"

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        // Bajar al mantener la flecha hacia abajo o 'S'
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(DropDown());
        }

        // Espacio solo para saltar (por si quieres reset manual)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effector.rotationalOffset = 0f;
        }
    }

    IEnumerator DropDown()
    {
        effector.rotationalOffset = 180f;   // activa el paso hacia abajo
        yield return new WaitForSeconds(dropTime);
        effector.rotationalOffset = 0f;     // vuelve a bloquear desde abajo
    }
}