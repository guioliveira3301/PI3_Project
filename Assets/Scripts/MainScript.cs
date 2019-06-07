using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public Image cdCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;
    public GameObject objectToInteract;
    public string SceneSelect;




public void SceneChanger()
{
    SceneManager.LoadScene(SceneSelect);
}

public void GvrOn()
{
    gvrStatus = true;
}

public void GvrOff()
{
    gvrStatus = false;
    gvrTimer = 0;
    cdCircle.fillAmount = 0;
}

public void Input()
{
    objectToInteract.SetActive(true);
}
public void Output()
{
    objectToInteract.SetActive(false);
    gvrStatus = false;
    gvrTimer = 0;
    cdCircle.fillAmount = 0;
}
    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            cdCircle.fillAmount = gvrTimer/totalTime;
        }

        if(gvrTimer > totalTime)
        {
            GVRClick.Invoke();
        }
    }

}
