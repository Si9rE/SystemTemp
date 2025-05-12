public class Notes : MonoBehaiviour
{
    // Notes speed adjust
    int NoteSpeed = 5;
    void update()
    {
        // Notes Moving
        transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}