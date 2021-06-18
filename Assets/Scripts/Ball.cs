using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Transform obstacle;
    public float ballSpeed;
    Vector3 inVelocity;
    void Start()
    {
        inVelocity = Vector3.up * ballSpeed;
    }

    
    void FixedUpdate()
    {
        
        transform.Translate(inVelocity * Time.deltaTime);
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 0.5f))
		{
			if (hit.collider.gameObject.CompareTag("obstacle"))
            {
                //inVelocity = 2 * Vector3.Dot(inVelocity, hit.normal.normalized) * hit.normal.normalized - inVelocity;
                obstacle = hit.collider.gameObject.transform;
                float angleToRotate = Vector3.SignedAngle(transform.up, hit.normal, Vector3.forward);
                if(angleToRotate < 0)
				{
                    transform.Rotate(-Vector3.forward * ((360 - (4 * angleToRotate))) / 2);
                }
				else
				{
                    transform.Rotate(Vector3.forward * ((360 - (4 * angleToRotate))) / 2);
                }
                print(angleToRotate);
            }
		}
    }

}
