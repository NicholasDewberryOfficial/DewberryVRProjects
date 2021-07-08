using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//VR ADDITION
using Valve.VR;


public class UIPOP : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject prefab;
    public Slider slider1;
    public GameObject clone;
    //public GameObject rb;
    public bool pause;
    //public FirstPersonController FirstPersonController;
    public InputField iField;
    public Toggle togglebox;
    private string ballColor;
    public GameObject cube;
    public GameObject RewindSpheres;

    public GameObject RewindCubes;



    public void spawnRewindCubes(){
        Instantiate(RewindCubes, new Vector3(2.0F, 0, 0), Quaternion.identity);
    }

    public void spawnRewindSpheres(){
        Instantiate(RewindSpheres, new Vector3(2.0F, 0, 0), Quaternion.identity);
    }

    public void spawnALot(){
        if(togglebox.isOn){
            Instantiate(clone, new Vector3(2.0F, 0, 0), Quaternion.identity);
        }

    }

    public void AcubeSpawnTime(){
        Instantiate(cube, new Vector3(2.0F, 0, 0), Quaternion.identity);

    }

    public void AFiftycubesSpawn(){
        for(int i = 0; i < 50; i++){
            Instantiate(cube, new Vector3(2.0F, 0, 0), Quaternion.identity);
        }
    }
    

    public void SubmitSliderWeight(){
        float mMass;
        mMass = slider1.value;
        clone.GetComponent<Rigidbody>().mass = (int)mMass;
    }
    private void SphereReset(){
    clone = prefab;
    }    

    //, new Vector3(8, 2, 1), Quaternion.identity);
    public void onClose(){
        Canvas.SetActive(false);
        unpauseScene();
    }

    public void onBallSpawn(){
        Instantiate(clone, new Vector3(2.0F, 0, 0), Quaternion.identity);
    }

    public void uFiftyBallsSpawn(){
        for(int i = 0; i < 50; i++){
            Instantiate(clone, new Vector3(2.0F, 0, 0), Quaternion.identity);
        }
    }

    public void uFiveHunderedBallsSpawn(){
        for(int i = 0; i < 500; i++){
            Instantiate(clone, new Vector3(2.0F, 0, 0), Quaternion.identity);
    }}
    public void colorChange(){
        clone.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void inputColorChange(){
        //clone.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
        //ballColor = iField.text;
        //var BC = UnityEngine.Color(ballColor);
        //clone.GetComponent<Renderer>().sharedMaterial.color = ballColor;

    }


    // Start is called before the first frame update
    void Start()
    {
        unpauseScene();
        Canvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Space")){
        pausedScene();
        //spawnALot();
        }
        // if (Input.GetKeyDown("Space")){
        // pausedScene();
        // //spawnALot();
        // }
    }
    
    public void pausedScene(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Canvas.SetActive(true);
        Debug.Log("Space button pressed");
      //FirstPersonController.playerCanMove = false;
       // FirstPersonController.cameraCanMove = false;

        pause = true;
    }

    public void unpauseScene(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Canvas.SetActive(false);
       //FirstPersonController.playerCanMove = true;
       //FirstPersonController.cameraCanMove = true;
        pause = false;
    }   



}
