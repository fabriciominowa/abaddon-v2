using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float moveSpeed = 20.0f;
    private Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pos = transform.position;
        Pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        Pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = Pos;
    }
}
