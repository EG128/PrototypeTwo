using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed;
    public float rangeX = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);



        if(transform.position.x < -rangeX)
        {
         transform.position = new Vector3(-rangeX, transform.position.y, transform.position.z);   
        }

        if(transform.position.x > rangeX)
        {
         transform.position = new Vector3(rangeX, transform.position.y, transform.position.z);   
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
