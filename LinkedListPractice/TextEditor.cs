using System;
namespace LinkedListPractice
{
    public class TextState
    {
        public string text;
        public TextState next;
        public TextState prev;

        public TextState(string text)
        {
            this.text = text;
            this.next = null;
            this.prev = null;
        }
    }

    public class TextEditor
    {
        private TextState head;
        private TextState tail;
        private TextState current;
        private int count;
        private int maxHistory = 10;

        public TextEditor()
        {
            head = null;
            tail = null;
            current = null;
            count = 0;
        }

        public void AddState(string text)
        {
            TextState newState = new TextState(text);

            if (head == null)
            {
                head = newState;
                tail = newState;
                current = newState;
                count = 1;
                return;
            }

            if (current != tail)
            {
                TextState temp = current.next;

                while (temp != null)
                {
                    TextState next = temp.next;
                    temp.prev = null;
                    temp.next = null;
                    temp = next;
                    count--;
                }

                current.next = null;
                tail = current;
            }

            newState.prev = current;
            current.next = newState;
            current = newState;
            tail = newState;
            count++;

            if (count > maxHistory)
            {
                TextState oldHead = head;
                head = head.next;
                head.prev = null;
                oldHead.next = null;
                count--;
            }
        }

        public void Undo()
        {
            if (current == null || current.prev == null)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            current = current.prev;
        }

        public void Redo()
        {
            if (current == null || current.next == null)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            current = current.next;
        }

        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("Editor is empty");
                return;
            }

            Console.WriteLine($"Current Text: {current.text}");
        }

        public void DisplayHistory()
        {
            TextState temp = head;

            while (temp != null)
            {
                if (temp == current)
                    Console.WriteLine($"-> {temp.text}");
                else
                    Console.WriteLine($"   {temp.text}");

                temp = temp.next;
            }
        }
    }
}

