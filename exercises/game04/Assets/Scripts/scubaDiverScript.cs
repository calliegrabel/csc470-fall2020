using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scubaDiverScript : MonoBehaviour
{ 
    float speed = 10;
    float forwardSpeed = 1;

    public Rigidbody rb;

    float pitchSpeed = 80;
    float pitchModSpeedRate = 8f;
    float rollSpeed = 80;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        float xRot = vAxis * pitchSpeed * Time.deltaTime;
        float yRot = hAxis * rollSpeed * Time.deltaTime;
        
        transform.Rotate(xRot, yRot, 0, Space.Self);
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);

     

        if (speed > 0)
        {
            speed -= 4 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 5;
        }

        Vector3 cameraPosition = transform.position - transform.forward * 12 + Vector3.up * 5;
        Camera.main.transform.position = cameraPosition;
        Vector3 lookAtPos = transform.position + transform.forward * 8;
        Camera.main.transform.LookAt(lookAtPos, Vector3.up);

        float terrainHeight = Terrain.activeTerrain.SampleHeight(transform.position);
        if (transform.position.y < terrainHeight)
        {
            transform.position = new Vector3(transform.position.x, terrainHeight, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("door"))
        {
            Debug.Log("Entered door");
            SceneManager.LoadScene("castleScene");

        }
    }

}
