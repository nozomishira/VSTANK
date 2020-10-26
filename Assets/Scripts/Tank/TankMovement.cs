using UnityEngine;
using UnityEngine.SceneManagement;

public class TankMovement : MonoBehaviour
{
    public int m_PlayerNumber = 1;         
    public float m_Speed = 12f;            
    public float m_TurnSpeed = 180f;       
    //public AudioSource m_MovementAudio;    
    public AudioClip m_EngineIdling;       
    public AudioClip m_EngineDriving;      
    public float m_PitchRange = 0.2f;
    //Vector3 m_roatation = gameObject.transform.localEulerAngles;

    
    private string m_MovementAxisName;     
    private string m_TurnAxisName;         
    private Rigidbody m_Rigidbody;         
    private float m_MovementInputValue;    
    private float m_TurnInputValue;        
    private float m_OriginalPitch;         


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

/*
    private void OnEnable ()
    {
        m_Rigidbody.isKinematic = false;
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
    }


    private void OnDisable ()
    {
        m_Rigidbody.isKinematic = true;
    }
    */

    private void Start()
    {
        /*
        m_MovementAxisName = "Vertical" + m_PlayerNumber;
        m_TurnAxisName = "Horizontal" + m_PlayerNumber;

        m_OriginalPitch = m_MovementAudio.pitch;*/
        /*Quaternion quaternion = this.transform.rotation;
        Debug.Log(quaternion);
        float x = quaternion.eulerAngles.x;
        float y = quaternion.eulerAngles.y;
        float z = quaternion.eulerAngles.z;
        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(z);*/

    }
    

    private void Update()
    {
        // Store the player's input and make sure the audio for the engine is playing.
        /* if (Input.GetKey("up"))
         {
             transform.position += transform.forward * m_Speed * Time.deltaTime;
         }
         if (Input.GetKey("down"))
         {
             transform.position -= transform.forward * m_Speed * Time.deltaTime;
         }
         if (Input.GetAxis("Horozontal") < 0)
         {
             transform.Rotate(0, Input.GetAxis("Horozontal"), 0);
         }
         if (Input.GetAxis("Horozontal") > 0)
         {
             transform.Rotate(0, Input.GetAxis("Horozontal"), 0);
         }*/


        //m_MovementInputValue = Input.GetAxis(m_MovementAxisName);
        //m_TurnInputValue = Input.GetAxis(m_TurnAxisName);
        m_MovementInputValue = Input.GetAxis("Vertical");
        m_TurnInputValue = Input.GetAxis("Horizontal");

    }


    private void EngineAudio()
    {
        // Play the correct audio clip based on whether or not the tank is moving and what audio is currently playing.
    }


    private void FixedUpdate()
    {
        // Move and turn the tank.
        Move();
        Turn();
    }


    private void Move()
    {
        // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

        // Apply this movement to the rigidbody's position.
          m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }


    private void Turn()
    {
        // Adjust the rotation of the tank based on the player's input.
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;
        // Make this into a rotation in the y axis.
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        // Apply this rotation to the rigidbody's rotation.
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyShell")
        {
            Debug.Log("destroy");
            SceneManager.LoadScene("LoseResultScene");
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyShell")
        {
            Debug.Log("destroy");
            SceneManager.LoadScene("LoseResultScene");
           // Destroy(this.gameObject);
        }
    }
}