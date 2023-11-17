/// <summary>
/// This queue is circular.  When people are added via add_person, then they are added to the 
/// back of the queue (per FIFO rules).  When get_next_person is called, the next person
/// in the queue is displayed and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue {
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns) {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and display them.  The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error message is displayed 
    /// if the queue is empty.
    /// </summary>
        public void GetNextPerson() {
        if (_people.IsEmpty())
            Console.WriteLine("No one in the queue.");
        else {
            Person person = _people.Dequeue();
            Console.WriteLine(person.Name);
            if (person.Turns > 0) {
                person.Turns--;
                if (person.Turns > 0) {
                    _people.Enqueue(person);
                }
            }
            else if (person.Turns == 0) {
                _people.Enqueue(person);
            }
        }
    }

    public override string ToString() {
        return _people.ToString();
    }
    public class PersonQueue {
        private readonly Queue<Person> _queue = new Queue<Person>();

        public bool IsEmpty() {
            return _queue.Count == 0;
        }

        public int Length => _queue.Count;

        public void Enqueue(Person person) {
            _queue.Enqueue(person);
        }

        public Person Dequeue() {
            return _queue.Dequeue();
        }

        public override string ToString() {
            return string.Join(", ", _queue.Select(person => $"{person.Name}({person.Turns})"));
        }
    }

    public class Person {
        public string Name { get; }
        public int Turns { get; set; }

        public Person(string name, int turns) {
            Name = name;
            Turns = turns;
        }
    }
}