public class PersonRepository
{
    private readonly List<Person> persons = new()
    {
        new Person(){Id=1, Name="Poornima", HasAPetUnicorn=true},
        new Person(){Id=2, Name="Rachel", HasAPetUnicorn=true},
        new Person(){Id=3, Name="Wilmur", HasAPetUnicorn=true},
        new Person(){Id=4, Name="Kavya", HasAPetUnicorn=false},
        new Person(){Id=5, Name="Paul", HasAPetUnicorn=true},
        new Person(){Id=6, Name="Shanice", HasAPetUnicorn=true}
    };

    public void Create(Person? person)
    {
        if(person is null)
        {
            return;
        }

      persons.Add(person);
    }

    public List<Person> GetAll()
    {
        return persons;
    }

    public Person? GetById(int id)
    {
        return persons.FirstOrDefault(p => p.Id == id);
    }

    //code for demo only, lazy me!!!!
    public List<Person> GetByIds(int[] ids)
    {
        return persons.Where(p => ids.Contains(p.Id)).ToList();
    }

    public void Update(Person person)
    {
        var existingPerson = GetById(person.Id);
        if(existingPerson is null)
        {
            return;
        }

        existingPerson.Name = person.Name;
        existingPerson.HasAPetUnicorn = person.HasAPetUnicorn;
    }

    public void Delete(int id)
    {
        var existingPerson = GetById(id);
        if (existingPerson is null)
        {
            return;
        }
        persons.Remove(existingPerson);
    }
   

}