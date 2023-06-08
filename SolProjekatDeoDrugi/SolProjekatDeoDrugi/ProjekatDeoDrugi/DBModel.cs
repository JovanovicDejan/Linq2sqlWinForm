using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ProjekatDeoDrugi
{
    public class DBModel : DbContext
    {
        // Your context has been configured to use a 'DBModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProjekatDeoDrugi.DBModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBModel' 
        // connection string in the application configuration file.
        public DBModel()
            : base("name=DBModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }


        public DbSet<Klijent> klijents { get; set; }
        public DbSet<Servis> servisis { get; set; }
    }

    [Table("Klijenti", Schema = "dbo")]
    public class Klijent
    {
        public Klijent()
        {
            Servis = new List<Servis>();
        }

        [Key]
        [Required]
        public int KlijentID { get; set; }

        [MaxLength(40), Required]
        public string NazivKlijenta { get; set; }

        [MaxLength(20), Required]
        public string RegistarskiBroj { get; set; }

        [MaxLength(40), Required]
        public string Kontakt { get; set; }

        [MaxLength(200)]
        public string DodatniKomentar { get; set; }

        public virtual IEnumerable<Servis> Servis { get; set; }
    }

    [Table("Servisi", Schema = "dbo")]
    public class Servis
    {

        [Key]
        [Required]
        public int ServisID { get; set; }

        public int KlijentID { get; set; }

        [Required]
        public DateTime DatumServisa { get; set; }

        [MaxLength(400), Required]
        public string OpisUsluge { get; set; }

        public Klijent Klijent { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}