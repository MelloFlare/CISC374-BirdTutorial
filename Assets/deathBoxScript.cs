using UnityEngine;

public class deathBoxScript : MonoBehaviour
{
    public Transform spawnpoint;
    public LogicScript logic;
    public BirdScript bird;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.layer == 3)
      {
        logic.gameDoness();
        bird.birdAlive = false;
         Destroy(bird);
      }   
    }
}
