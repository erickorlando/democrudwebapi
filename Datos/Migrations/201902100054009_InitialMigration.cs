namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoCurso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlumnoId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.AlumnoId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 60),
                        Apellidos = c.String(nullable: false, maxLength: 60),
                        Edad = c.Int(nullable: false),
                        CorreoElectronico = c.String(maxLength: 200),
                        FechaNacimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCurso = c.String(nullable: false, maxLength: 60),
                        FechaInicio = c.DateTime(nullable: false),
                        NombreProfesor = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlumnoCurso", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.AlumnoCurso", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.AlumnoCurso", new[] { "CursoId" });
            DropIndex("dbo.AlumnoCurso", new[] { "AlumnoId" });
            DropTable("dbo.Curso");
            DropTable("dbo.Alumno");
            DropTable("dbo.AlumnoCurso");
        }
    }
}
