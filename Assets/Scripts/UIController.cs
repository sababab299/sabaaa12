using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject avatarImage;
    public GameObject myNameText;
    public Image myImage;
    public bool Active = false;

    public void Components()
    {
        avatarImage.SetActive(Active);
        
        myNameText.SetActive(Active);
        Active = !Active;
    }
    public void ChangeColor()
    {
        myImage.color = Color.red;
    }
}
