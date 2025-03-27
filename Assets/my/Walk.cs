using UnityEngine;

public class Walk : MonoBehaviour
{
    
         public float moveSpeed = 5f;
         public float turnSpeed = 60f;
         public Transform turret; 
     
         private Rigidbody rb;
     
         void Start()
         {
             rb = GetComponent<Rigidbody>();
         }

         void Update()
         {
             float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
             float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

             transform.Translate(0, 0, move);
             transform.Rotate(0, turn, 0);
         }



}
