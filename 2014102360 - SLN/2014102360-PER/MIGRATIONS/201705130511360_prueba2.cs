namespace _2014102360.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carro", new[] { "Asiento_AsientoId", "Asiento_CarroId" }, "dbo.Asiento");
            DropForeignKey("dbo.Carro", new[] { "Llanta_LlantaId", "Llanta_CarroId" }, "dbo.Llanta");
            DropIndex("dbo.Carro", new[] { "Asiento_AsientoId", "Asiento_CarroId" });
            DropIndex("dbo.Carro", new[] { "Llanta_LlantaId", "Llanta_CarroId" });
            DropColumn("dbo.Carro", "Asiento_AsientoId");
            DropColumn("dbo.Carro", "Asiento_CarroId");
            DropColumn("dbo.Carro", "Llanta_LlantaId");
            DropColumn("dbo.Carro", "Llanta_CarroId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carro", "Llanta_CarroId", c => c.Int());
            AddColumn("dbo.Carro", "Llanta_LlantaId", c => c.Int());
            AddColumn("dbo.Carro", "Asiento_CarroId", c => c.Int());
            AddColumn("dbo.Carro", "Asiento_AsientoId", c => c.Int());
            CreateIndex("dbo.Carro", new[] { "Llanta_LlantaId", "Llanta_CarroId" });
            CreateIndex("dbo.Carro", new[] { "Asiento_AsientoId", "Asiento_CarroId" });
            AddForeignKey("dbo.Carro", new[] { "Llanta_LlantaId", "Llanta_CarroId" }, "dbo.Llanta", new[] { "LlantaId", "CarroId" });
            AddForeignKey("dbo.Carro", new[] { "Asiento_AsientoId", "Asiento_CarroId" }, "dbo.Asiento", new[] { "AsientoId", "CarroId" });
        }
    }
}
