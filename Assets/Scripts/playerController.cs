using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using EZCameraShake;
public class playerController : MonoBehaviour
{

    private Vector2 targetPos;
    public float yIncrememt = 5f;
    public float speed;

    public float maxHeight;
    public float minHeight;

    public int health = 3;
    public GameObject effect;

    public Text healthText;

    public GameObject popSound;
    public GameObject restartPanel;
    public scoreTrigger score;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();

        if (health <= 0)
        {
            restartPanel.SetActive(true);
            Destroy(gameObject);
            Destroy(score.gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y <maxHeight)
        {
            CameraShaker.Instance.ShakeOnce(2, 5,0.1f,1);
            Instantiate(popSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrememt);
           
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y>minHeight)
        {
            CameraShaker.Instance.ShakeOnce(2, 5, 0.1f, 1);
            Instantiate(popSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrememt);
        }
    }
}
