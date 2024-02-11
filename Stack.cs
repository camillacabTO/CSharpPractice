using System.Collections;

namespace Practice;

public class MyStack
{
    private readonly ArrayList _elements = new();

    public void Push(object item)
    {
        _elements.Add(item);
    }

    public object Pop()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        object item = _elements[^1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public void Clear()
    {
        _elements.Clear();
    }
}