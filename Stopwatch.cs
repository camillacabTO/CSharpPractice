namespace Practice;

// public class Stopwatch
// {
//     public DateTime StartedTime { get; private set; }
//     public DateTime StoppedTime { get; private set; }
//     private bool _started;
//     private bool _stopped;
//     
//     public void Start()
//     {
//         if(_started)
//             throw new InvalidOperationException("StartedTme already initialized");
//         
//         StartedTime = DateTime.Now;
//         _started = true;
//         _stopped = false;
//     }
//     
//     public void Stop()
//     {
//         if(_started && !_stopped)
//             StoppedTime = DateTime.Now;
//         _stopped = true;
//         _started = false;
//     }
// }

using System;

public class Stopwatch
{
    private DateTime _startTime;
    private DateTime _stopTime;
    private bool _isRunning;

    public void Start()
    {
        if (_isRunning)
            throw new InvalidOperationException("The stopwatch is already started.");

        _startTime = DateTime.Now;
        _isRunning = true;
    }

    public void Stop()
    {
        if (!_isRunning)
            throw new InvalidOperationException("The stopwatch is not running.");

        _stopTime = DateTime.Now;
        _isRunning = false;
    }

    public TimeSpan Duration
    {
        get
        {
            if (_isRunning)
                throw new InvalidOperationException("The stopwatch is still running. Stop it to get the duration.");
            return _stopTime - _startTime;
        }
    }

    // Method to display the duration on the console
    public void DisplayDuration()
    {
        if (_isRunning)
            throw new InvalidOperationException("The stopwatch is still running.");

        Console.WriteLine("Duration: " + Duration);
    }
}
