using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    private float leftBound = -26;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
