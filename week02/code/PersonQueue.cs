/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        // The current code uses Insert(0, person) to add a person to the start of the list, which makes it act like a stack
        // (Last-In-First-Out, or LIFO). This means the most recently added person is the first one removed, which isn't what we want. Instead, we need a queue-like behavior (First-In-First-Out, or FIFO), where the first person added is the first one removed. To fix this, we should add new people to the end of the list, not the front.
        _queue.Add(person);
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}