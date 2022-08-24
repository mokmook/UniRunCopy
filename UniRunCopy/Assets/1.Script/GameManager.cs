using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoverText;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] GameObject gameSettingPanel;

    [SerializeField] Image heratImage;
    Image[] heratImages;
    [SerializeField] Image DieheratImage;
    Image[] DieheratImages;

    float LastActive;
    [SerializeField] int scoreTime;
    public int score { get; private set; }

    [SerializeField] Player player;
    private void OnEnable()
    {
        LastActive = Time.time;
        score = 0;
        scoreTime = 1;
    }
    private void Awake()
    {        
        heratImages = new Image[3];
        DieheratImages = new Image[3];
    }
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            heratImages[i]=Instantiate(heratImage,transform);
            heratImages[i].GetComponent<RectTransform>().anchoredPosition += new Vector2(i * -70, 0);
            DieheratImages[i] = Instantiate(DieheratImage, transform);
            DieheratImages[i].GetComponent<RectTransform>().anchoredPosition += new Vector2(i * -70, 0);
            DieheratImages[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Time.time > LastActive + scoreTime && !Player.isDead)
        {
            score++;
            LastActive = Time.time;
        }
        scoreText.text = "½ºÄÚ¾î : " + score;


        if (Player.isDead)
        {
            gameoverText.gameObject.SetActive(true);
            for (int i = 0; i < 3; i++)
            {
                Hit(i);
            }
        }
        if (gameoverText.activeSelf&&Input.anyKeyDown)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gameoverText.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameSettingPanel.SetActive(!gameSettingPanel.activeSelf);
        }


        switch (player.cur_hp)
        {
            case 0:
                Hit(0); break;
            case 1:
                Hit(1); break;
            case 2:
                Hit(2); break;
        }
        if (score>=20)
        {
            SceneManager.LoadScene("Stage2");
        }
    }
    void Hit(int idx)
    {
        heratImages[idx].gameObject.SetActive(false);
        DieheratImages[idx].gameObject.SetActive(true);
    }
    public void AddScore(int v)
    {
        score += v;
    }
}
