
namespace Core.Entities
{
    public class Owner : EntityBase
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
