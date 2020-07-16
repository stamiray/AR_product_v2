using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
public class gameController : MonoBehaviour
{
    public static string currentSelectedCar = "myLamboConvert";
    private bool onOff = false;
    private string theScene;
    // Start is called before the first frame update
    void Start()
    {
        theScene = SceneManager.GetActiveScene().name;
    }
    public void showNewCar(string nextCar)
    {
        GameObject.Find(colourSwitcher.instance.getCurrentTracked().name + "/activeItems/" + gameController.currentSelectedCar).SetActive(false);
        currentSelectedCar = nextCar;
        GameObject.Find(colourSwitcher.instance.getCurrentTracked().name + "/activeItems/" + gameController.currentSelectedCar).SetActive(true);
    }
    // Update is called once per frame
    public void quit()
    {
        Application.Quit();
    }
    public void changeLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void toggleFlash()
    {
        if (onOff)
        {
            CameraDevice.Instance.SetFlashTorchMode(false);
            onOff = false;
        }
        else
        {
            CameraDevice.Instance.SetFlashTorchMode(true);
            onOff = true;
        }
    }
}
