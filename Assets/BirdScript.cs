using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStr;
    public LogicScript logic;
    public bool birdAlive = true;
    public AudioSource thudSound;
    public AudioSource flap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive){
                    myRigidbody.linearVelocity = Vector2.up * flapStr;
                    flap.Play();

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        thudSound.Play();
        logic.gameDoness();
        birdAlive = false;
    }

}
