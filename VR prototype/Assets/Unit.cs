using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 0.005f;
    public float ttl = 5;

    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ttl -= Time.deltaTime;
        if (ttl < 0)
            Destroy(this.gameObject);
        moveDirection = Camera.main.transform.position - transform.position;
        moveDirection.Normalize();
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection = moveDirection * speed;
        moveDirection *= Time.deltaTime;

        transform.Translate(moveDirection.x, 0, moveDirection.z);
    }
}
