using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMazeScript : MonoBehaviour
{
    public Color orange;
    public Color blue;
    public Color yellow;
    public Color pink;

    public Renderer rendRightLeg;
    public Renderer rendLeftLeg;
    public Renderer rendLeftArm;
    public Renderer rendRightArm;
    public Renderer rendBody;

    float moveSpeed = 50;
    float rotateSpeed = 100;
    public CharacterController cc;

    bool prevIsGrounded = true;

    float yVelocity = 0;
    float jumpForce = 0.7f;
    float gravityModifier = 0.2f;

   

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();

        if (GameManager.instance.saveColor == 0)
        {
            rendRightLeg.material.color = orange;
            rendLeftLeg.material.color = orange;
            rendRightArm.material.color = orange;
            rendLeftArm.material.color = orange;
            rendBody.material.color = orange;
        }
        if (GameManager.instance.saveColor == 1)
        {
            rendRightLeg.material.color = blue;
            rendLeftLeg.material.color = blue;
            rendRightArm.material.color = blue;
            rendLeftArm.material.color = blue;
            rendBody.material.color = blue;
        }
        if (GameManager.instance.saveColor == 2)
        {
            rendRightLeg.material.color = yellow;
            rendLeftLeg.material.color = yellow;
            rendRightArm.material.color = yellow;
            rendLeftArm.material.color = yellow;
            rendBody.material.color = yellow;
        }
        if (GameManager.instance.saveColor == 3)
        {
            rendRightLeg.material.color = pink;
            rendLeftLeg.material.color = pink;
            rendRightArm.material.color = pink;
            rendLeftArm.material.color = pink;
            rendBody.material.color = pink;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.Self);
        if (!cc.isGrounded)
        {
            yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0)
            {
                yVelocity = 0;
            }
        }

        else
        {
            if (prevIsGrounded)
            {
                yVelocity = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpForce;
            }
        }
        Vector3 amountToMove = transform.forward * vAxis * moveSpeed * Time.deltaTime;

        amountToMove.y = yVelocity;

        cc.Move(amountToMove);


        prevIsGrounded = cc.isGrounded;
    }
}

