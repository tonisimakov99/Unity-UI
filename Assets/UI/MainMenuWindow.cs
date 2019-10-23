using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : Window
{
    private StartGameWindow startGameWindow;
    private SettingsWindow settingsWindow;
    private TutorialWindow tutorialWindow;
    public void Start()
    {
        startGameWindow = UIManager.Instance.GetWindow<StartGameWindow>();
        settingsWindow = UIManager.Instance.GetWindow<SettingsWindow>();
        tutorialWindow = UIManager.Instance.GetWindow<TutorialWindow>();
        startGameWindow.OnOpen += ChangeCurrentWindow;
        settingsWindow.OnOpen += ChangeCurrentWindow;
        tutorialWindow.OnOpen += ChangeCurrentWindow;       
    }
    protected override void SelfOpen()
    {
        this.gameObject.SetActive(true);
    }
    protected override void SelfClose()
    {
        this.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        startGameWindow.Open();
    }

    public void Settings()
    {
        settingsWindow.Open();
    }

    public void Tutorial()
    {
        tutorialWindow.Open();
    }
    public void Exit()
    {
        Application.Quit();
    }
}
