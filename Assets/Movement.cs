using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Settings")]
    public float speed = 0.01f;
    public float rotation = 10f;
    public SpriteRenderer spriteRen;

    [Header("Keys")]
    public KeyCode KeyUp;
    public KeyCode KeyDown;
    public KeyCode KeyLeft;
    public KeyCode KeyRight;

    public KeyCode KeyLeftRotation;
    public KeyCode KeyRightRotation;
    public KeyCode KeyRandomColor;

    private void Awake()
    {
        if(spriteRen == null)
        {
            spriteRen = GetComponent<SpriteRenderer>();
        }
    }


    // Metodo Update es llamado una vez por frame
    void Update()
    {
        if (Input.GetKey(KeyUp))
        {
            transform.position = transform.position + new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(KeyDown))
        {
            transform.position = transform.position + new Vector3(0, -speed, 0);
        }
        if (Input.GetKey(KeyLeft))
        {
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyRight))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        //Movimiento básico con Transform.Translate() o transform.position
        //Input.GetKey(KeyCode.W) → mientras se mantenga presionada


        if (Input.GetKeyDown(KeyLeftRotation))
        {
            //error anterior: transform.rotation = transform.rotation + new Vector3(0, 0, -speedRotation);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, -rotation));
        }
        else if (Input.GetKeyDown(KeyRightRotation))
        {
            //error anterior: transform.rotation = transform.rotation + new Vector3(0, 0, speedRotation);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, rotation));

        }

        if (Input.GetKeyUp(KeyRandomColor))
        {
            spriteRen.color = Random.ColorHSV();
        }
    }
}
