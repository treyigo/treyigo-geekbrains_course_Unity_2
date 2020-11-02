using UnityEngine;

public class FlashLight : BaseObject
{

    [SerializeField] private Light flashlightLight;

    private float timeout = 10;
    private float currTime = 0;
    private float currReloadTime = 0;

    private float maxBattery = 10;
    private float currBattery = 10;


    private KeyCode control = KeyCode.F;

    protected override void Awake()
    {
        base.Awake();
        flashlightLight = GetComponentInChildren<Light>();
    }

    private void ActiveFlashLight(bool val)
    {
        flashlightLight.enabled = val;
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(control))
        {

            if (!flashlightLight.enabled)
            {
                Debug.Log("Включение");
                Debug.Log("Заряд батареи:" + currBattery);
                ActiveFlashLight(true);
            }
            else
            {
                Debug.Log("Выключение");
                Debug.Log("Заряд батареи:" + currBattery);
                ActiveFlashLight(false);
            }
        }
        
        if (flashlightLight.enabled)
        {
            currBattery -= Time.deltaTime;
            if (currBattery <= 0)
            {
                ActiveFlashLight(false);

            }
        }

        if (!flashlightLight.enabled && currBattery <= 10)
        {
            currBattery += Time.deltaTime;
        }
    }
}
