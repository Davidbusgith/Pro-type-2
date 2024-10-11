






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float horizontalInput;
    public float xRange = 10;
    public float speed = 15;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
  
    void Update()
    {
        // Get the player's horizontal Input
         horizontalInput = Input.GetAxis ( "Horizontal");
        // Move the player on the x-axis using horizontal input
        transform.Translate ( Vector3.right * speed * Time.deltaTime * horizontalInput);
           
         if (transform.position. x > xRange)
         {
            transform.position = new Vector3 ( xRange, transform.position.y ,transform.position.z);
        
         }
         if (transform.position. x < -xRange)
         {
            transform.position = new Vector3 ( -xRange, transform.position.y ,transform.position.z);
        
         }
         
         if ( Input.GetKeyDown ( KeyCode.Space))
         {
            // Launch a projectile from the player 
            Instantiate ( projectilePrefab, transform.position , projectilePrefab.transform.rotation);
         }
   }
}
 