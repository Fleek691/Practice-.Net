using System;

public class Door
{
    // 1. Event declaration
    public event Action<string> DoorOpened;

    // 2. Method that raises the event
    public void OpenDoor()
    {
        // Event is raised on THE SAME object
        DoorOpened?.Invoke("Door opened");
    }
}

public class EventUsage
{
    public static void Main()
    {
        Door door = new Door();

        // 3. Subscribing methods to the event
        door.DoorOpened += OpenedDoor;
        door.DoorOpened += ClosedDoor;

        // 4. Triggering the event
        door.OpenDoor();
    }

    public static void OpenedDoor(string message)
    {
        Console.WriteLine("Listener 1: " + message);
    }

    public static void ClosedDoor(string message)
    {
        Console.WriteLine("Listener 2: " + message);
    }
}
