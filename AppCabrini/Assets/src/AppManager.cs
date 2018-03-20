using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AppMode { None, Upload, Edit, View}

public class AppManager : MonoBehaviour
{
    private static AppManager _instance;

    private ScreenManager _screenManager;
    private FundManager _fundManager;
    private MembersManager _membersManager;

    public static AppManager instance { get { return _instance; } }

    public AppScreen[] screens;
    public AppMode mode;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            throw new System.Exception("There are two or more AppManager instances");
    }


    public void ChangeMode(int mode)
    {
        this.mode = (AppMode)mode;
    }


    public void ChangeMode(AppMode mode)
    {
        this.mode = mode;
    }


    public static string GetModeName(AppMode mode)
    {
        switch(mode)
        {
            case AppMode.None:
                return "";

            case AppMode.Upload:
                return "Cargar";

            case AppMode.Edit:
                return "Editar";

            case AppMode.View:
                return "Ver";
        }
        return "null";
    }


    private void Start()
    {
        _screenManager = ScreenManager.instance;
        _fundManager = FundManager.instance;
        _membersManager = MembersManager.instance;

        _screenManager.LoadScreens(screens);
    }
}
