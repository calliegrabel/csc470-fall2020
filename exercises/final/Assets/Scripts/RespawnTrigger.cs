using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public Transform playerPos;
    public Transform targetPos;

    // Start is called before the first frame update
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Fell Down!");
            playerPos.transform.position = targetPos.transform.position;

        }
    }
}
