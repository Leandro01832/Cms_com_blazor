using business;
using business.div;
using business.Elementos.texto;
using business.Group;
using business.Join;
using demo.Shared;
using Microsoft.EntityFrameworkCore;

namespace demo.Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Pagina>? Pagina { get; set; }
        public DbSet<Produto>? Produto { get; set; }

        public DbSet<ImagemProduto>? ImagemProduto { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
        public DbSet<ItemPedido>? ItemPedido { get; set; }
        public DbSet<SubSubGrupo>? SubSubGrupo { get; set; }
        public DbSet<SubGrupo>? SubGrupo { get; set; }
        public DbSet<Grupo>? Grupo { get; set; }
        public DbSet<SubStory>? SubStory { get; set; }
        public DbSet<Story>? Story { get; set; }        
        public DbSet<DivElemento>? DivElemento { get; set; }
        public DbSet<PaginaContainer>? PaginaContainer { get; set; }       
       
        public DbSet<Telefone>? Telefone { get; set; }
        public DbSet<Div>? Div { get; set; }
        public DbSet<Container>? Container { get; set; }
        public DbSet<Texto>? Texto { get; set; }       
        public DbSet<Livro>? Livro { get; set; }

        public DbSet<DivContainer>? DivContainer { get; set; }       
                     
        public DbSet<VideoIncorporado>? VideoIncorporado { get; set; }
        public DbSet<Comentario>? Comentario { get; set; }
        public DbSet<CamadaSeis>? CamadaSeis { get; set; }
        public DbSet<CamadaSete>? CamadaSete { get; set; }
        public DbSet<CamadaOito>? CamadaOito { get; set; }
        public DbSet<CamadaNove>? CamadaNove { get; set; }
        public DbSet<CamadaDez>? CamadaDez { get; set; }
        public DbSet<Compartilhamento>? Compartilhamento { get; set; }

          protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<PaginaContainer>()
            .HasKey(p => new { p.ContainerId, p.PaginaId });
            
            builder.Entity<DivElemento>()
            .HasKey(p => new { p.DivId, p.ElementoId });
            
            builder.Entity<DivContainer>()
            .HasKey(p => new { p.DivId, p.ContainerId });
            builder.Entity<Div>().ToTable("Div");           
                      

            builder.Entity<Texto>().ToTable("Texto");
            

           // var converter = new ValueConverter<Int64, Int64>(
           //v => v,
           //v => (Int64)v,
           //new ConverterMappingHints(valueGeneratorFactory: (p, t) => new TemporaryIntValueGenerator()));

           // builder.Entity<BaseModel>()
           //     .Property("Id")
           //     .ValueGeneratedOnAdd()
           //     .UseSqlServerIdentityColumn()
           //     .HasConversion(converter);

        } 
    }
}
