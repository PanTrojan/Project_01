using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Datebase : MonoBehaviour {

    public static SaveAndLoadVariable salv;

    public string SAVE_FILE = "/SAVEGAME";
    public string FILE_EXTENSION = ".WTF";

    public Vector3 playerPos;

    public GameObject obj_01;
    public GameObject obj_02;
    public GameObject obj_03;
    public GameObject obj_04;
    public GameObject obj_05;

    public GameObject loadObj;
    public GameObject saveObj;

    public float time1;
    public float time2;
    public float timeEnd1;
    public float timeEnd2;
    public float timeEnd3;

    public static bool LoadActive;
    public static bool SaveActive;

    public MonoBehaviour fpc;
    public MonoBehaviour camera;
    public MonoBehaviour cameraEffect;

    private void Awake()
    {
        salv = new SaveAndLoadVariable();
    }

    public void Update()
    {
        if (LoadActive) {
            time1 += Time.deltaTime;
            loadObj.SetActive(true);
            fpc.enabled = false;
            camera.enabled = false;
            cameraEffect.enabled = false;
            if (time1 >= timeEnd1 && time1 < timeEnd1+0.1f) {
                Stream stream = File.Open(Application.dataPath + SAVE_FILE + FILE_EXTENSION, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                salv = (SaveAndLoadVariable)bf.Deserialize(stream);
                stream.Close();

                //mushroomActive
                if (!salv.obj_01)
                {
                    obj_01.SetActive(false);
                }
                else
                {
                    obj_01.SetActive(true);
                }

                if (!salv.obj_02)
                {
                    obj_02.SetActive(false);
                }
                else
                {
                    obj_02.SetActive(true);
                }

                if (!salv.obj_03)
                {
                    obj_03.SetActive(false);
                }
                else
                {
                    obj_03.SetActive(true);
                }

                if (!salv.obj_04)
                {
                    obj_04.SetActive(false);
                }
                else
                {
                    obj_04.SetActive(true);
                }

                if (!salv.obj_05)
                {
                    obj_05.SetActive(false);
                }
                else
                {
                    obj_05.SetActive(true);
                }



                playerPos = new Vector3(salv.positionPlayerX, salv.positionPlayerY, salv.positionPlayerZ);

                GeneralSaveAndLoad.player.position = playerPos;

                QuestCurrent.mission_01 = salv.mission_01;
                QuestCurrent.mission_02 = salv.mission_02;
                MushroomItem.items = salv.mushroomQuantity;

            }
            if (time1 >= timeEnd2)
            {
                loadObj.SetActive(false);
                LoadActive = false;
                time1 = 0;
                fpc.enabled = false;
                camera.enabled = false;
                cameraEffect.enabled = false;
            }
        }

        if (SaveActive) {
            saveObj.SetActive(true);
            time2 += Time.deltaTime;
            if (time2 >= timeEnd3) {
                saveObj.SetActive(false);
                SaveActive = false;
                time2 = 0f;
            }
        }

    }

    public void SaveGame() {
        Stream stream = File.Open(Application.dataPath + SAVE_FILE + FILE_EXTENSION, FileMode.OpenOrCreate);
        BinaryFormatter bf = new BinaryFormatter();

        bf.Serialize(stream, salv);
        stream.Close();

        SaveActive = true;
    }

    public void LoadGame() {
        LoadActive = true;
        MenuGameplayActive.menuActive = !MenuGameplayActive.menuActive;
        MenuGameplayActive.time_01 = 0;
    }

}