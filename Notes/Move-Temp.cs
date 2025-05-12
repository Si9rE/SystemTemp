public class Notes : MonoBehaiviour
{
    // Notes speed adjust
    int value = 3.0;
    int NoteSpeed = value ;
    void update()
    {
        // Notes Moving
        transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}