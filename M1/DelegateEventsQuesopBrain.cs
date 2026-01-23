using System;

public delegate void Notify();

public class PhoneCall
{
    public event Notify? PhoneCallEvent;

    public string? Message { get; private set; }

    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
    }

    private void OnUnSubscribe()
    {
        Message = "UnSubscribed to Call";
    }

    public void MakeAPhoneCall(bool notify)
    {
        // Clear previous subscriptions to avoid multiple calls
        PhoneCallEvent = null;

        if (notify)
        {
            PhoneCallEvent += OnSubscribe;
        }
        else
        {
            PhoneCallEvent += OnUnSubscribe;
        }

        // Safely invoke the event
        PhoneCallEvent?.Invoke();
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        PhoneCall call = new PhoneCall();

        call.MakeAPhoneCall(true);
        Console.WriteLine(call.Message);

        call.MakeAPhoneCall(false);
        Console.WriteLine(call.Message);
    }
}
