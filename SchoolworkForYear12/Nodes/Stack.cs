public class Stack<T>
{
    private Node<T> head;

    public Stack()
    {
        this.head = null;
    }
       
    public void Push(T x)
    {
        Node<T> temp = new Node<T>(x);
        temp.SetNext( head);
        head = temp;
    }
        
    public T Pop()
    {
        T x =  head.GetValue();    
        head = head.GetNext();
        return  x;
    }        
        
    public T Top()
    {
        return  head.GetValue();
    }

    public bool IsEmpty()
    {             
        return head == null;                 
    }

    // This method was added to use for printing Stack
    public override string ToString()
    {
        Node<T> pos = head;
        string st = "Stack[";
        while (pos!=null)
        {
            st += pos.ToString();
            pos = pos.GetNext();
            if (pos!=null)
                st += ",";
        }
        return st + "]";
    }

}
