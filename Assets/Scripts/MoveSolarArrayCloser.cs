using UnityEngine;

public class MoveSolarArrayCloser : MonoBehaviour
{
    // Set the variables, move this is the array and the boundary is as far as its allowed to go to
    public float speed;
    public bool leverActivated;
    public Transform moveThisThanks;
    public Transform boundary;


    // These are pretty self evident, turn the lever on or off
    public void TurnOnLever()
    {
        leverActivated = true;
    }

    public void TurnOffLever()
    {
        leverActivated = false;
    }

    void FixedUpdate()
    {

        if (leverActivated == true)
        {
            // Moves solar array away from the station
            speed = 1f;
            moveThisThanks.position = Vector3.MoveTowards(moveThisThanks.position, boundary.position, speed * Time.deltaTime);

        }
        else
        {
            // Solar array stops moving by setting the speed to zero. 
            speed = 0f;
            moveThisThanks.position = Vector3.MoveTowards(moveThisThanks.position, boundary.position, speed * Time.deltaTime);
        }
    }
}
