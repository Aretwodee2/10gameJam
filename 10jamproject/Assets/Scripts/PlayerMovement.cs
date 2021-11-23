using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    private void Start()
    {
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        gameObject.transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }


}
