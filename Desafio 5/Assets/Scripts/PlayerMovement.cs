
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAxis();
    }

    private void MoveAxis()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(ejeHorizontal, 0, ejeVertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
