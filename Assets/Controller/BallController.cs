using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float MaxSpeed;
    [SerializeField] private float BallRotation;
    [SerializeField] private GameObject cube;
    private Rigidbody rgBody;
    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position = transform.position;
        //if (!GameController.ins.isGameOver && !GameController.ins.isPause)
        BallMove();
    }

    void BallMove()
    {
        Vector3 velocityX = cube.transform.right * Input.GetAxis("Horizontal") * Speed;
        Vector3 velocityZ = cube.transform.forward * Input.GetAxis("Vertical") * Speed;
        if (Vector3.Magnitude(velocityX + velocityZ) <= MaxSpeed)
        {
            rgBody.AddForce(velocityX + velocityZ);
            //Debug.Log(velocityX + velocityZ);

        }
        cube.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0) * BallRotation * Time.deltaTime);
    }
}
