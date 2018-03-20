using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager
{
    private static ScreenManager _instance;

    private List<AppScreen> _screens = new List<AppScreen>();
    private int _currentScreen;

    public static ScreenManager instance { get { return Instance(); } }


    private ScreenManager() { }


    public void LoadScreens(AppScreen[] screens)
    {
        for (int i = 0; i < screens.Length; i++)
        {
            _screens.Add(screens[i]);
        }
    }


    private static ScreenManager Instance()
    {
        if (_instance == null)
            _instance = new ScreenManager();

        return _instance;
    } 


    public void ChangeScreen(int screenId)
    {
        if(_currentScreen != screenId)
        {
            _screens[_currentScreen].gameObject.SetActive(false);
            _screens[screenId].gameObject.SetActive(true);
            _screens[screenId].anim.Play();
            _screens[screenId].OnEnabledScreen();

            _currentScreen = screenId;
        }
    }
}
