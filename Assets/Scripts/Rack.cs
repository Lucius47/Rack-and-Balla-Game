using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rack : MonoBehaviour
{
    public float rackSpeed;
    float screenHalfWidth;
    float rackHalfWidth;
    void Start()
    {
        screenHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        rackHalfWidth = transform.localScale.x / 2;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxisRaw("Mouse X") * rackSpeed * Time.deltaTime);
        if (transform.position.x > (screenHalfWidth - rackHalfWidth))
		{
            transform.position = new Vector3((screenHalfWidth - rackHalfWidth), transform.position.y, transform.position.z);
        }
        if (transform.position.x < -(screenHalfWidth - rackHalfWidth))
        {
            transform.position = new Vector3(-(screenHalfWidth - rackHalfWidth), transform.position.y, transform.position.z);
        }
    }
}
