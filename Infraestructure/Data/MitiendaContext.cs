using microsoft.entityFrameworkCore;



namespace  Infraestructure.Data;

public class Mitieinda : DbContext
{
public tieindaContext (DbContextOptions <TiendaContext> options) : base (options)
{

}

public Dbset <producto> productos { get; set; }
}
    
