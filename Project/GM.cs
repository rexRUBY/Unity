using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    int lives = 3;
    int bricks = 20;
    float resetDelay = 2f;
    GameObject clonePaddle;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instance = null; 

    void Awake()
    {
        //Singleton pattern
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }
    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0.2f; //세상의 시간을 5분의 1로 흐르게 세팅함
            Invoke("Reset", resetDelay); //Invoke(텍스트,몇초 뒤에 실행 시킬 건지) 여기선 죽었다는 사실을 인식시키려고 사용함.
        }
    }
    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }
    public void DestroyBrick()
    {
        bricks--;
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = 0.2f;
            Invoke("Reset", resetDelay);
        }
    }
    
    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("main");  //restart
    }
}
