using UnityEngine;

public class Player : MonoBehaviour
{

    [field: Header("Animations")]
    public PlayerAnimationData AnimationData;


    public Animator Animator { get; private set; }
    public PlayerController Input { get; private set; }
    public CharacterController Controller { get; private set; }


    private void Awake()
    {
        AnimationData.Initalize();
        Animator = GetComponent<Animator>();
        Input = GetComponent<PlayerController>();
        Controller = GetComponent<CharacterController>();
    }


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }


}
