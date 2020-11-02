using UnityEngine;
/// <summary>
/// Базовый класс, кторый кэширует ссылки
/// </summary>

public abstract class BaseObject : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform goTransform;
    private GameObject goInstance;
    private string GOname;

    private Rigidbody goRigidbody;

    private Material goMaterial;
    private Color goColor;
    private Animator goAnimator;
    private bool isVisible;

    protected Transform GoTransform { get => goTransform; set => goTransform = value; }
    protected GameObject GoInstance { get => goInstance; set => goInstance = value; }
    protected string GoName { get => GOname; set => GOname = value; }
    protected Rigidbody GoRigidbody {get => goRigidbody; set => goRigidbody = value; }
    protected Material GoMaterial { get => goMaterial; set => goMaterial = value; }
    protected Color GoColor { get => goColor; set => goColor = value; }
    protected Animator GoAnimator { get => goAnimator; set => goAnimator = value; }
    protected bool IsVisible { get => isVisible; set => isVisible = value; }

    protected virtual void Awake()
    {
        GoTransform = transform;
        GoName = name;
        GoInstance = gameObject;


        if(GetComponent<Animator>())
        {
            GoAnimator = GetComponent<Animator>();
        }
        else
        {
            Debug.Log("NO ANIMATOR" + GoName); 
        }
        if (GetComponent<Rigidbody>())
        {
            GoRigidbody = GetComponent<Rigidbody>();
        }
        else
        {
            Debug.Log("NO RGIDBODY" + GoName);
        }

        if (GetComponent <Renderer>())
        {
            GoMaterial = GetComponent<Renderer>().material;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
