using Microsoft.EntityFrameworkCore;
using TechChallengeFase1.Entities;

namespace TechChallengeFase1.Repository
{
    // Herdamos de DbContext obtido através do EFCore
    public class ApplicationDbContext : DbContext
    {
        // Atributo para recebermos nossa string de conexão via construtor
        private readonly string? _connectionString;

        private static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ApplicationDbContext()
        {
            _connectionString = configuration.GetConnectionString("ConnectionString");
        }

        // Criamos nossos DbSets de cada entidade como props
        public DbSet<Contact> Contact { get; set; }
        public DbSet<DDD> DDD { get; set; }

        // Precisamos sobreescrever esse método para utilizar nossa string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        // Vamos definir nossas entidades para o EFCore
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chamamos o nosso construtor de modelos (modelBuilder) para nossa entidade DDD
            //passando uma função que recebe um construtor de tipo de modelo (EntityTypeBuilder<DDD> ou ETB)
            //onde iremos configurar nossa tabela e nossas colunas assim como outras necessidades
            //de uma tabela sql
            modelBuilder.Entity<DDD>(etb =>
            {
                // Criamos o nome da tabela que irá representar nossa entidade DDD
                etb.ToTable("ddd");

                // Nosso etb recebe uma função que irá chamar nossa entidade DDD esperando retornar
                //qual propriedade será nossa primary key da tabela
                etb.HasKey(ddd => ddd.Id);

                // Através de uma função criamos uma propriedade e definimos mais informações sobre ela com métodos
                etb.Property(ddd => ddd.Id)
                .HasColumnType("INTEGER")
                .ValueGeneratedNever() // Desabilita por parte do EFCore a geração de Id automaticamente
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); // Passa a responsabilidade de criação do Id para o Postgres

                // Agora iremos criar nosso número para representar nosso DDD de fato
                etb.Property(ddd => ddd.Number)
                .HasColumnType("INTEGER")
                .IsRequired(); // Não permite que a coluna tenha valores nulos

                

            });

            // Agora para nossa entidade Contato
            modelBuilder.Entity<Contact>(etb =>
            {
                etb.ToTable("contato"); // Tabela

                etb.HasKey(contact => contact.Id); // Primary Key

                etb.Property(contact => contact.Id) // Propriedade id
                .HasColumnType("INTEGER")
                .ValueGeneratedNever()
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

                etb.Property(contact => contact.Name)
                .HasColumnType("TEXT")
                .IsRequired();

                etb.Property(contact => contact.PhoneNumber)
                .HasColumnType("TEXT")
                .IsRequired();

                etb.Property(contact => contact.Email)
                .HasColumnType("TEXT")
                .IsRequired();

                // Foreign key
                etb.Property(contact => contact.DDDId)
                .HasColumnType("INTEGER").IsRequired();

                etb.HasOne(contact => contact.Ddd)
                .WithMany(ddd => ddd.Contacts)
                .HasPrincipalKey(ddd => ddd.Id);
                              
            });
        }
    }
}
