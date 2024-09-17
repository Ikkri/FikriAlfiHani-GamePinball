using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button creditsButton;

    private void Start()
    {
        creditsButton.onClick.AddListener(Credits);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
