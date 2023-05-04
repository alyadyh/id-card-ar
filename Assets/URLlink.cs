using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLlink : MonoBehaviour
{
    public void instagramClick()
    {
        Application.OpenURL("https://instagram.com/binus_malang?igshid=YmMyMTA2M2Y=");
    }
    public void tiktokClick()
    {
        Application.OpenURL("https://www.tiktok.com/@binus_malang?_t=8c20VydX8La&_r=1");
    }
    public void youtubeClick()
    {
        Application.OpenURL("https://www.youtube.com/@binusmalang");
    }
}
