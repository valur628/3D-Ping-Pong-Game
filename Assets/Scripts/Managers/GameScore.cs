using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour
{
    public float Three_Timer = 0.0f;
    public int Count_Timer = 0;
    public Text Timer_Text;
    public GameObject Timer_GameObject;

    public Text Player1_ScoreText;
    public Text Player2_ScoreText;
    public GameObject Player_1;
    public GameObject Player_2;
    public int Player1_Score;
    public int Player2_Score;
    public int Player1_Score_Previous;
    public int Player2_Score_Previous;

    public Text Player1_Goal_Text;
    public Text Player2_Goal_Text;
    public GameObject Player1_Goal_GameObject;
    public GameObject Player2_Goal_GameObject;

    public AudioClip GoalSound;
    private AudioSource SoundSource;
    void Start()
    {
        Player1_ScoreText.text = Player1_Score.ToString();
        Player2_ScoreText.text = Player2_Score.ToString();
        Timer_Text.text = Count_Timer.ToString();
        Timer_GameObject.SetActive(false);
        Player1_Goal_GameObject.SetActive(false);
        Player2_Goal_GameObject.SetActive(false);
        Timer_check = true;

        SoundSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Timer_check == true)
        {
            Timers();
            
        }
        Three_Timer += Time.deltaTime / 2;
    }
    void OnCollisionEnter(Collision Walltrigger)
    {
        if (Walltrigger.gameObject.name == "Wall_Player1")
        {
           
            SoundSource.clip = GoalSound;
            SoundSource.volume = 0.1f;
            SoundSource.Play();
            Three_Timer = 0;
            Timer_check = true;
            if (Three_Timer <= 6)
            {
                Timer_GameObject.SetActive(false);
                Player2_Score += 1;
                Player2_ScoreText.text = Player2_Score.ToString();
                PositionSet();
            }
        }
        else if (Walltrigger.gameObject.name == "Wall_Player2")
        {
            SoundSource.clip = GoalSound;
            SoundSource.volume = 0.1f;
            SoundSource.Play();
            Three_Timer = 0;
            Timer_check = true;
            if (Three_Timer <= 6)
            {
                Timer_GameObject.SetActive(false);
                Player1_Score += 1;
                Player1_ScoreText.text = Player1_Score.ToString();
                PositionSet();
            }
        }
    }
    public bool Timer_check=false;
    void Timers()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<SphereCollider>().enabled = false;
        Player_1.GetComponent<Player_1Move>().enabled = false;
        Player_2.GetComponent<Player_2Move>().enabled = false;
        if(Three_Timer <= 2)
        {
            if(Player1_Score > Player1_Score_Previous)
            {
                Player1_Goal_GameObject.SetActive(true);
            }
            else if(Player2_Score > Player2_Score_Previous)
            {
                Player2_Goal_GameObject.SetActive(true);
            }
            Player2_Score_Previous = Player2_Score;
            Player1_Score_Previous = Player1_Score;
        }
        else if (Three_Timer > 2 && Three_Timer <= 3)
        {
            Timer_GameObject.SetActive(true);
            Count_Timer = 3;
            Timer_Text.text = Count_Timer.ToString();
        }
        else if (Three_Timer > 3 && Three_Timer <= 4)
        {
            Count_Timer = 2;
            Timer_Text.text = Count_Timer.ToString();
        }
        else if (Three_Timer > 4 && Three_Timer < 5)
        {
            Count_Timer = 1;
            Timer_Text.text = Count_Timer.ToString();
        }
        else if (Three_Timer > 5 && Three_Timer < 6)
        {
            Count_Timer = 1;
            Timer_Text.text = "Game Start";
        }
        else
        {
            Timer_check = false;
            Timer_GameObject.SetActive(false);
            Player1_Goal_GameObject.SetActive(false);
            Player2_Goal_GameObject.SetActive(false);
            PositionSet();
        }
        Three_Timer += Time.deltaTime/2;
    }
    void PositionSet ()
    {
        Player_1.transform.position = new Vector3(0, 0, -130);
        Player_2.transform.position = new Vector3(0, 0, 130);
        transform.position = new Vector3(0, 0, 25);
        Player_1.GetComponent<Player_1Move>().enabled = true;
        Player_2.GetComponent<Player_2Move>().enabled = true;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<SphereCollider>().enabled = true;
    }
    public void BallPositionResets()
    {
        Three_Timer = 0;
        Timer_check = true;
    }
}
