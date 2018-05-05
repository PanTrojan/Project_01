using UnityEngine;
using System.Collections;

public class GeneralSaveAndLoad : MonoBehaviour
{

    public static Transform player;

    public GameObject obj_01;
    public GameObject obj_02;
    public GameObject obj_03;
    public GameObject obj_04;
    public GameObject obj_05;

    private void Start()
    {
        player = gameObject.GetComponent<Transform>();
    }

    void Update()
    {

        if (obj_01.activeInHierarchy == (true)) {
            Datebase.salv.obj_01 = true;
        }else if (obj_01.activeInHierarchy == (false))
        {
            Datebase.salv.obj_01 = false;
        }

        if (obj_02.activeInHierarchy == (true))
        {
            Datebase.salv.obj_02 = true;
        }
        else if (obj_02.activeInHierarchy == (false))
        {
            Datebase.salv.obj_02 = false;
        }

        if (obj_03.activeInHierarchy == (true))
        {
            Datebase.salv.obj_03 = true;
        }
        else if (obj_03.activeInHierarchy == (false))
        {
            Datebase.salv.obj_03 = false;
        }

        if (obj_04.activeInHierarchy == (true))
        {
            Datebase.salv.obj_04 = true;
        }
        else if (obj_04.activeInHierarchy == (false))
        {
            Datebase.salv.obj_04 = false;
        }

        if (obj_05.activeInHierarchy == (true))
        {
            Datebase.salv.obj_05 = true;
        }
        else if (obj_05.activeInHierarchy == (false))
        {
            Datebase.salv.obj_05 = false;
        }

        Datebase.salv.positionPlayerX = player.position.x;
        Datebase.salv.positionPlayerY = player.position.y;
        Datebase.salv.positionPlayerZ = player.position.z;
        Datebase.salv.mission_01 = QuestCurrent.mission_01;
        Datebase.salv.mission_02 = QuestCurrent.mission_02;
        Datebase.salv.mushroomQuantity = MushroomItem.items;
    }
}
