using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

    public void SceneToChangeTo(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void EndApplication()
    {
        Application.Quit();
    }
}
