using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //public GameObject avatarImage;
    //public GameObject myNameText;
    //public Image myImage;
    //public bool Active = false;

    //public void Components()
    //{
    //    avatarImage.SetActive(Active);

    //    myNameText.SetActive(Active);
    //    Active = !Active;
    //}
    //public void ChangeColor()
    //{
    //    myImage.color = Color.red;
    //}

    [SerializeField]
    private Button startBtn;
    [SerializeField]
    private Button optionsBtn;
    [SerializeField]
    private GameObject startPanel;
    [SerializeField]
    private GameObject optionPanel;
    private void Start()
    {
        startBtn.onClick.AddListener(OnStartBtnClick);
        optionsBtn.onClick.AddListener(OnOptionBtnClick);
    }

    private void OnStartBtnClick()
    {
        SceneManager.LoadScene(0);
    }
    private void OnOptionBtnClick()
    {
        startPanel.SetActive(false);
        optionPanel.SetActive(true);
    }
}
