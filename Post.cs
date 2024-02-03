namespace Practice;

public class Post
{
    public int Votes { get; private set; }
    public string? Title { get; private set; }
    public string? Description { get; private set; }
    public DateTime CreatedAt = DateTime.Now;
    
    public Post(){}
    
    public Post(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public void VoteUp()
    {
        Votes += 1;
    }
    
    public void VoteDown()
    {
        Votes -= 1;
    }
    
}

// public class ExampleClass
// {
//     public int IntegerProperty { get; set; } // Default is 0
//     public double DoubleProperty { get; set; } // Default is 0.0
//     public bool BooleanProperty { get; set; } // Default is false
//     public char CharProperty { get; set; } // Default is '\0'
//     public DateTime DateTimeProperty { get; set; } // Default is DateTime.MinValue
//     public string StringProperty { get; set; } // Default is null
//     public ExampleClass ObjectProperty { get; set; } // Default is null
//     public int? NullableIntProperty { get; set; } // Default is null
// }
