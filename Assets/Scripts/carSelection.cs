using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelection : MonoBehaviour
{
    private GameObject[] carList;
    private int currentCar = 0;
    // Start is called before the first frame update
    void Start()
    {
        carList = new GameObject[transform.childCount];
        for(int i=0;i<transform.childCount;++i)
        {
            carList[i] = transform.GetChild(i).gameObject;
        }
        foreach(GameObject gameObj in carList)
        {
            gameObj.SetActive(false);
        }
        if (carList[0])
        {
            carList[0].SetActive(true);
        }
    }

   public void toggleCars(string direction)
    {
        carList[currentCar].SetActive(false);
        if (direction == "Right")
        {
            currentCar++;
            if (currentCar > carList.Length-1)
            {
                currentCar = 0;
            }
        }
        else if (direction == "Left")
        {
            currentCar--;
            if (currentCar < 0)
            {
                currentCar = carList.Length - 1;
            }
        }
            carList[currentCar].SetActive(true);
        gameController.currentSelectedCar = carList[currentCar].name;
        GameObject cloudSystem = Instantiate (Resources.Load("Particle System")) as GameObject;
        ParticleSystem cloudPuff = cloudSystem.GetComponent<ParticleSystem>();
        cloudPuff.Play();
        cloudPuff.transform.position = transform.position;
        Destroy(cloudSystem, 2f);
    }
}
