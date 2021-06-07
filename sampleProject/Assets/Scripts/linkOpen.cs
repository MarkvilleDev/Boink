using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkOpen: MonoBehaviour
{
    public string about;
    public string privacy;

    public void openAbout ()
    {
        Application.OpenURL(about);
    }

    public void openPrivacy()
    {
        Application.OpenURL(privacy);
    }
}
