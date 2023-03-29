using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Control : MonoBehaviour
{
    GameObject obj;
    public float FlyPower;
    public GameObject gameController1;
    public AudioClip flyClip;
    public AudioClip overClip;
    private AudioSource audioSource;
    private Animator animator1;
    // Start is called before the first frame update
    void Start()
    {

        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
        animator1 = obj.GetComponent<Animator>();
        animator1.SetFloat("flypower",0);
        animator1.SetBool("Is dead?", false);
        if (gameController1 == null)
        {
            gameController1 = GameObject.FindGameObjectWithTag("GameController");
        }
        
        audioSource.clip = flyClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!gameController1.GetComponent<GameControler>().isEndGame)//  !true
            {
                audioSource.Play();
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FlyPower));
                animator1.SetFloat("flypower", 5);
            }
            
        }
        else
            animator1.SetFloat("flypower", 0);
    }
    //3 Hàm Collision này thể hiên sự tương tác Colider(Khung va chạm).3 hàm lần lượt dc Tự động gọi khi :
    //Enter:Bắt đầu va chạm,Stay:Đi xuyên vào trong,Exit:Kết thúc va chạm 
    private void OnCollisionEnter2D(Collision2D collision)
    {

        animator1.SetBool("Is dead?", true);
        EndGame();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController1.GetComponent<GameControler>().GetPoint();
    }
    void EndGame()
    {
        audioSource.clip = overClip;
            audioSource.Play();
        gameController1.GetComponent<GameControler>().endGame();
    }
}
