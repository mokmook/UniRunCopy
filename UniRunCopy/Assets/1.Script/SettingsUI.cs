using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SettingsUI : MonoBehaviour
{
    [SerializeField]string[] data;
    [SerializeField] Button settingButton;
    [SerializeField] Transform settingPanel;
    Button[] settingButtons;
    private void OnEnable()
    {
        Time.timeScale = 0;
    }
    void Start()
    {
        settingButtons=new Button[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            settingButtons[i] = Instantiate(settingButton, settingPanel);
            settingButtons[i].GetComponent<RectTransform>().anchoredPosition += new Vector2(0, i * -100);
            int idx=i;
            settingButtons[i].onClick.AddListener(() => SettingsNum(idx));
            settingButtons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = data[i];
        }
    }
    void SettingsNum(int dataindex)
    {
        switch (dataindex)
        {
           case 0:
                gameObject.SetActive(false);break;
           case 1:
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);break;
            case 2:
                SceneManager.LoadScene(2);break;               
        }
    }


    private void OnDisable()
    {
        Time.timeScale = 1;
    }
}
