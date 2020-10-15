using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scubaDiverScript : MonoBehaviour
{
    float speed = 8f;
    float rotateSpeed = 120f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        if (speed > 0)
        {
            speed -= 4 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 5;
        }
        speed = Mathf.Clamp(speed, 0, 15);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("door"))
        {
            Destroy(other.gameObject);
            
        }
    }

}
