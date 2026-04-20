using UnityEngine;

public class MapChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] mapObjects;

    private void Start()
    {
        ChangeMap(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            ChangeMap(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
            ChangeMap(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) == true)
        {
            ChangeMap(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) == true)
        {
            ChangeMap(3);
        }
    }

    void ChangeMap(int index)
    {
        for(int i=0; i<mapObjects.Length; ++i)
        {
            if(i == index)
            {
                mapObjects[i].SetActive(true);
            }
            else
            {
                mapObjects[i].SetActive(false);
            }
        }
    }
}
