using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace Backend.DataContext;
public class BiblioContext : DbContext
{
    public BiblioContext()
    {
    }

    public BiblioContext(DbContextOptions<BiblioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autores { get; set; }
    public virtual DbSet<Carrera> Carreras { get; set; }
    public virtual DbSet<Editorial> Editoriales { get; set; }
    public virtual DbSet<Ejemplar> Ejemplares { get; set; }
    public virtual DbSet<Genero> Generos { get; set; }
    public virtual DbSet<Libro> Libros { get; set; }
    public virtual DbSet<LibroAutor> LibroAutores { get; set; }
    public virtual DbSet<LibroGenero> LibroGeneros { get; set; }
    public virtual DbSet<Prestamo> Prestamos { get; set; }
    public virtual DbSet<Usuario> Usuarios { get; set; }
    public virtual DbSet<UsuarioCarrera> UsuarioCarreras { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddEnvironmentVariables()
        .Build();
        var cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

        optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region
        //datos semillas autores
        modelBuilder.Entity<Autor>().HasData(
            new Autor { Id = 1, Nombre = "Gabriel García Márquez" },
            new Autor { Id = 2, Nombre = "Isabel Allende" },
            new Autor { Id = 3, Nombre = "Mario Vargas Llosa" },
            new Autor { Id = 4, Nombre = "Jorge Luis Borges" },
            new Autor { Id = 5, Nombre = "Pablo Neruda" },
            new Autor { Id = 6, Nombre = "Julio Cortázar" }
        );

        //datos semillas carreras
        //modelBuilder.Entity<Carrera>().HasData(
        //    new Carrera { Id = 1, Nombre = "Ingeniería en Sistemas" },
        //    new Carrera { Id = 2, Nombre = "Administración de Empresas" },
        //    new Carrera { Id = 3, Nombre = "Derecho" },
        //    new Carrera { Id = 4, Nombre = "Medicina" },
        //    new Carrera { Id = 5, Nombre = "Arquitectura" }
        //);

        //datos semillas editoriales
        modelBuilder.Entity<Editorial>().HasData(
            new Editorial { Id = 1, Nombre = "Penguin Random House" },
            new Editorial { Id = 2, Nombre = "HarperCollins" },
            new Editorial { Id = 3, Nombre = "Simon & Schuster" },
            new Editorial { Id = 4, Nombre = "Hachette Livre" },
            new Editorial { Id = 5, Nombre = "Macmillan Publishers" }
        );

        //datos semillas ejemplares


        //datos semillas generos
        modelBuilder.Entity<Genero>().HasData(
            new Genero { Id = 1, Nombre = "Ficción" },
            new Genero { Id = 2, Nombre = "No Ficción" },
            new Genero { Id = 3, Nombre = "Ciencia Ficción" },
            new Genero { Id = 4, Nombre = "Fantasia" },
            new Genero { Id = 5, Nombre = "Misterio" },
            new Genero { Id = 6, Nombre = "Romance" },
            new Genero { Id = 7, Nombre = "Terror" }
        );

        //datos semillas libro
        //modelBuilder.Entity<Libro>().HasData(
        //    new Libro { Id = 1, Titulo = "Cien Años de Soledad", Descripcion = "Novela emblemática del realismo mágico", EditorialId = 1, Paginas = 417, AnioPublicacion = 1967, Portada = "", Sinopsis = "La historia de la familia Buendía en el pueblo ficticio de Macondo." },
        //    new Libro { Id = 2, Titulo = "La Casa de los Espíritus", Descripcion = "Novela que mezcla lo real y lo fantástico", EditorialId = 2, Paginas = 448, AnioPublicacion = 1982, Portada = "", Sinopsis = "La saga de la familia Trueba a lo largo de varias generaciones." },
        //    new Libro { Id = 3, Titulo = "La Ciudad y los Perros", Descripcion = "Novela sobre la vida en un colegio militar", EditorialId = 3, Paginas = 320, AnioPublicacion = 1963, Portada = "", Sinopsis = "Las experiencias de un grupo de cadetes en un colegio militar en Lima." },
        //    new Libro { Id = 4, Titulo = "Ficciones", Descripcion = "Colección de cuentos fantásticos y filosóficos", EditorialId = 4, Paginas = 224, AnioPublicacion = 1944, Portada = "", Sinopsis = "Una serie de relatos que exploran temas como la realidad y la identidad." },
        //    new Libro { Id = 5, Titulo = "Veinte Poemas de Amor y una Canción Desesperada", Descripcion = "Colección de poemas románticos", EditorialId = 5, Paginas = 80, AnioPublicacion = 1924, Portada = "", Sinopsis = "Poemas que expresan el amor y la pasión." }
        //);

        //datos semillas libroautor
        //modelBuilder.Entity<LibroAutor>().HasData(
        //    new LibroAutor { Id = 1, LibroId = 1, AutorId = 1 },
        //    new LibroAutor { Id = 2, LibroId = 2, AutorId = 2 },
        //    new LibroAutor { Id = 3, LibroId = 3, AutorId = 3 },
        //    new LibroAutor { Id = 4, LibroId = 4, AutorId = 4 },
        //    new LibroAutor { Id = 5, LibroId = 5, AutorId = 5 }
        //);

        //datos semillas librogenero
        //modelBuilder.Entity<LibroGenero>().HasData(
        //    new LibroGenero { Id = 1, LibroId = 1, GeneroId = 1 },
        //    new LibroGenero { Id = 2, LibroId = 2, GeneroId = 1 },
        //    new LibroGenero { Id = 3, LibroId = 3, GeneroId = 1 },
        //    new LibroGenero { Id = 4, LibroId = 4, GeneroId = 4 },
        //    new LibroGenero { Id = 5, LibroId = 5, GeneroId = 6 }
        //);

        //datos semillas prestamo
        #endregion

        //configuramos los quety filters para que no trigan los registros marcados como eliminados
        modelBuilder.Entity<Autor>().HasQueryFilter(a => !a.IsDeleted);
        modelBuilder.Entity<Carrera>().HasQueryFilter(c => !c.IsDeleted);
        modelBuilder.Entity<Editorial>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Ejemplar>().HasQueryFilter(ej => !ej.IsDeleted);
        modelBuilder.Entity<Genero>().HasQueryFilter(g => !g.IsDeleted);
        modelBuilder.Entity<Libro>().HasQueryFilter(l => !l.IsDeleted);
        modelBuilder.Entity<LibroAutor>().HasQueryFilter(la => !la.IsDeleted);
        modelBuilder.Entity<LibroGenero>().HasQueryFilter(lg => !lg.IsDeleted);
        modelBuilder.Entity<Prestamo>().HasQueryFilter(p => !p.IsDeleted);
        modelBuilder.Entity<Usuario>().HasQueryFilter(u => !u.IsDeleted);
        modelBuilder.Entity<UsuarioCarrera>().HasQueryFilter(uc => !uc.IsDeleted);

    }
}

