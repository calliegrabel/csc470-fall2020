using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class submarineController : MonoBehaviour
{
    float speed = 10;
    float forwardSpeed = 1;

    public Rigidbody rb;

    float pitchSpeed = 80;
    float pitchModSpeedRate = 8f;
    float rollSpeed = 80;

    public GameObject missilePrefab;

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
        float yRot = hAxis * rollSpeed / 4 * Time.deltaTime;
        float zRot = -hAxis * rollSpeed * Time.deltaTime;
        transform.Rotate(xRot, yRot, zRot, Space.Self);

        forwardSpeed += -transform.forward.y * pitchModSpeedRate * Time.deltaTime;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 0, 5f);
        transform.Translate(transform.forward * speed * forwardSpeed * Time.deltaTime, Space.World);
        if (forwardSpeed <= 0.1f)
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }


        float terrainHeight = Terrain.activeTerrain.SampleHeight(transform.position);
        if(transform.position.y < terrainHeight)
        {
            //make scubadiver appear
            transform.position = new Vector3(transform.position.x, terrainHeight, transform.position.z);
        }

        Vector3 cameraPosition = transform.position - transform.forward * 36 + Vector3.up * 15;
        Camera.main.transform.position = cameraPosition;
        Vector3 lookAtPos = transform.position + transform.forward * 24;
        Camera.main.transform.LookAt(lookAtPos, Vector3.up);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject missile = Instantiate(missilePrefab, transform.position + transform.forward * 3, Quaternion.identity);
            Rigidbody missileRB = missile.GetComponent<Rigidbody>();
            missileRB.AddForce(transform.forward * 8000);
            Destroy(missile, 5);
        }
    }
    
}
