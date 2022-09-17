using System;
using System.Collections;

namespace TodoList
{
    class Task
    {
        string _name, _description;
        bool _isDone;
        public Task()
        {
            _name = "";
            _description = "";
            _isDone = false;
        }
        public Task(string name, string descroption)
        {
            _name = name;
            _description = descroption;
            _isDone = false;
        }
        public void setName(string name)
        {
            if (name == null)
            {
                Console.WriteLine("Is empty!");
                return;
            }
            _name = name;
        }
        public void setDescription(string description)
        {
            if (description == null)
            {
                Console.WriteLine("Is empty!");
                return;
            }
            _description = description;
        }
        public void setStatus(bool status)
        {
            _isDone = status;
        }
        public string getName() { return _name; }
        public string getDescription() { return _description; }
        public bool getStatus() { return _isDone; }
        public void Show()
        {
            Console.WriteLine("-----{0}-----", _name);
            Console.WriteLine(_description);
        }
    }
    class TodoList
    {
        static List<Task> tasks = new List<Task>();
        static void Main()
        {
            int ch;
            //menu
            while (true)
            {
                Console.WriteLine("1.Add new task\n2.Show all\n0.Exit");
                ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Add(ref tasks);
                        break;
                    case 2:
                        Show(tasks);
                        break;
                    case 0:
                        return;
                }
                Console.Clear();
            }
        }
        static void Show(List<Task> tasks)
        {
            foreach(Task i in tasks)
            {
                i.Show();
            }
            Console.ReadKey();
        }
        static void Add(ref List<Task> tasks)
        {
            string name, description;
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Descripton:");
            description = Console.ReadLine();

            tasks.Add(new Task(name, description));
            Console.Clear();
        }
    }
}