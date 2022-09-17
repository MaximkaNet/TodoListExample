using System;
using System.Collections;

namespace TodoList
{
    class Task
    {
        string _name, _description;
        bool _status;
        public Task()
        {
            _name = "";
            _description = "";
            _status = false;
        }
        public Task(string name, string descroption)
        {
            _name = name;
            _description = descroption;
            _status = false;
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value;}
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value == null)
                    Console.WriteLine("Is empty!");
                else
                    _name = value;
            }
        }

        public string Description { 
            get { return _description; }
            set {
                if (value == null)
                    Console.WriteLine("Is empty!");
                else
                    _description = value;
            }
        }
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