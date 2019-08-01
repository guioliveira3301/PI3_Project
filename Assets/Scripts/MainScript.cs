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
    public GameObject Tutorial1;
    public GameObject Tutorial2;
    public GameObject ChamarFuncionario;
    public string SceneSelect;


public void MetodoTutorial()
{
    Tutorial1.SetActive(false);
    Tutorial2.SetActive(true);

}
public void MetodoTutorial2()
{
    Tutorial2.SetActive(false);
    ChamarFuncionario.SetActive(true);
}
public void MetodoTutorialFinal()
{
    ChamarFuncionario.SetActive(false);
}
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
