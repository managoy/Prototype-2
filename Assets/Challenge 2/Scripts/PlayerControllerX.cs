using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTime;

    private void Start()
    {
        lastTime = Time.time;   
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - lastTime > 1.0f))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastTime = Time.time;           
        }
     
    }
}
