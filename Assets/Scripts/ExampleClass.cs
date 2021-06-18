using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform originalObject;
    public Transform reflectedObject;

    void Update()
    {
        // Makes the reflected object appear opposite of the original object,
        // mirrored along the z-axis of the world
        reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.right);
    }
}