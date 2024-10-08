using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool isRelease;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !isRelease)
        {
            isRelease = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("resetIsReleaseDog", 1.5f);
        }
    }

    private void resetIsReleaseDog()
    {
        isRelease = false;
    }
}
