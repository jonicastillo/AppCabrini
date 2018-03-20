using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundsScreen : AppScreen {

    public Text title;
    public Image panelImage;
    public Sprite uploadSprite;
    public Sprite editSprite;
    public Sprite viewSprite;


    public override void OnEnabledScreen()
    {
        title.text = AppManager.GetModeName(AppManager.instance.mode);
        print(AppManager.instance.mode);
        panelImage.sprite = GetModeImage(AppManager.instance.mode);
        print(GetModeImage(AppManager.instance.mode));

    }


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AppManager.instance.ChangeMode(AppMode.None);
            ScreenManager.instance.ChangeScreen(K.SCREEN_MAIN);
        }  
	}


    private Sprite GetModeImage(AppMode mode)
    {
        switch(mode)
        {
            case AppMode.None:
                return null;

            case AppMode.Upload:
                return uploadSprite;

            case AppMode.Edit:
                return editSprite;

            case AppMode.View:
                return viewSprite;
        }
        return null;
    }
}
