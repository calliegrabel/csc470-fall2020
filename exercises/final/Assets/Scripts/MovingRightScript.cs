using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRightScript : MonoBehaviour
{
    float freq = 2f;
    float amp = 48f;

    float theta = 0;

    Vector3 startPosition;
    Vector3 previousPosition;
    public Vector3 DistanceMoved = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        theta += Time.deltaTime;
        Vector3 newPos = startPosition + transform.right * Mathf.Sin(theta * freq) * amp;
        transform.position = newPos;

        DistanceMoved = transform.position - previousPosition;

        previousPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScriptObstacleCourse player = other.gameObject.GetComponent<PlayerScriptObstacleCourse>();
            //player.PlatformAttachedTo = this;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScriptObstacleCourse player = other.gameObject.GetComponent<PlayerScriptObstacleCourse>();
            player.PlatformAttachedTo = null;
        }
    }
}
