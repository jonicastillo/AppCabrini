using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAppScreen : AppScreen
{
    public void OnUploadButton()
    {
        AppManager.instance.ChangeMode(AppMode.Upload);
        ScreenManager.instance.ChangeScreen(K.SCREEN_FUNDS);
    }


    public void OnEditButton()
    {
        AppManager.instance.ChangeMode(AppMode.Edit);
        ScreenManager.instance.ChangeScreen(K.SCREEN_FUNDS);
    }


    public void OnWatchButton()
    {
        AppManager.instance.ChangeMode(AppMode.View);
        ScreenManager.instance.ChangeScreen(K.SCREEN_FUNDS);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
