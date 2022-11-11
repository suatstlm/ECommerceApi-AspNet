namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime  UpdateDate { get; set; }

    public Entity()
    {
    }

    public Entity(int id, DateTime createDate, DateTime updateDate) : this()
    {
        Id = id;
        CreateDate = createDate;
        UpdateDate = updateDate;
    }
}