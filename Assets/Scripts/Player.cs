using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left * 2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right * 2);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up * 2) ;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down * 2);
        }
    }
    
    void OnTriggerEnter2D (Collider2D col) 
    {
        if (col.tag == "Car")
        {
            Debug.Log("U Lus");
            Score.currentScore = 0 ;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
