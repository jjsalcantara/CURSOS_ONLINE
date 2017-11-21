namespace CURSOS_ONLINE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodigoCurso = c.String(),
                        Descricao = c.String(),
                        DataInscricao = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        NomeSite = c.String(),
                        Usuario = c.String(),
                        senha = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Curso");
        }
    }
}
