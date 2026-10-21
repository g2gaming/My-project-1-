using UnityEngine;

public class Clones : MonoBehaviour
{

    public GameObject mother;

    int numberofCollectibles = 5;
    void Start()
    {
        for(int i = 0; i < numberofCollectibles; i++)
        {
            GameObject Clones = GameObject.Instantiate(mother);
            Clones.transform.position = new Vector3(0, 2, i);
        }
    }

}
