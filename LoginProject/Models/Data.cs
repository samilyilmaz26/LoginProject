namespace LoginProject.Models
{
    public static class Data
    {
        
        public static List<Products> Products { get; set; }
        public static List<Users> Users { get; set; }
        public static Users LoginUser  { get; set; }
        static Data()
        {
            Products = new List<Products>()
            {
                new Products()
                {
                    Id= 1,
                    Name = "telefon",
                    Price = 10000,
                    Stock = 10
                },
                new Products()
                {
                    Id= 2,
                    Name = "laptop",
                    Price = 12000,
                    Stock = 17
                },
                 new Products()
                {
                    Id= 3,
                    Name = "Tv",
                    Price = 16000,
                    Stock = 16
                }
            };

            Users = new List<Users>()
            {
                new Users()
                {
                    Id= 1,
                    Username = "samil",
                    Email = "samil@gmail.com",
                    Password = "1234"
                },
                 new Users()
                {
                    Id= 2,
                    Username = "ibrahim",
                    Email = "ibrahim@gmail.com",
                    Password = "123"
                }
            };
        }

    }
}
 
