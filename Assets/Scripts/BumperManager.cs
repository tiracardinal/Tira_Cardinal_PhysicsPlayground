using UnityEngine;

public class BumperManager : MonoBehaviour
{
    public BumperController bumperA;
    public BumperController bumperB;

    void Start()
    {
        SetActiveBumper(bumperA, true);
        SetActiveBumper(bumperB, false);
    }

    public void SwitchBumpers()
    {
        bool isANowActive = !bumperA.isActive;

        SetActiveBumper(bumperA, isANowActive);
        SetActiveBumper(bumperB, !isANowActive);
    }

    private void SetActiveBumper(BumperController bumper, bool state)
    {
        bumper.isActive = state;
        bumper.UpdateVisualsAndPhysics();
    }
}