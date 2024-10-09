using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement2 : MonoBehaviour
{
    float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //takes in horizontal value
        float v = Input.GetAxis("Vertical");  //takes in vertical value

        Vector2 pos = transform.position; //gets the value to transform to

        pos.x +=  h * speed * Time.deltaTime;  //calculate the pace of the tranformation horizontally
        pos.y +=  v * speed * Time.deltaTime;  //calculate the pace of the transformation vertically

        transform.position = pos; //performs the movement transformation
    } 
}|
