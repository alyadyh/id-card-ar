using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void startScene()
    {
        SceneManager.LoadScene("AR_card");
        // UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene())
    }
}
