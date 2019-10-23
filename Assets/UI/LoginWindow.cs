using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginWindow : Window
{
    private MainMenuWindow mainMenuWindow;
    public void Start()
    {
        mainMenuWindow = UIManager.Instance.GetWindow<MainMenuWindow>();
    }

    protected override void SelfOpen()
    {
        this.gameObject.SetActive(true);
    }
    protected override void SelfClose()
    {
        this.gameObject.SetActive(false);
    }

    public void Login()
    {
        mainMenuWindow.Open();
        this.Close();
    }
}
