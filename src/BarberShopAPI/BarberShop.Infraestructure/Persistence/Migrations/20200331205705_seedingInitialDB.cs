using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Infraestructure.Persistence.Migrations
{
    public partial class seedingInitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Roles VALUES ('aclavijo','03-31-2020', null, null,'Manager','Business Manager')");            
            migrationBuilder.Sql("INSERT INTO Roles VALUES ('aclavijo', '03-31-2020',null, null,'Employee','')");
            migrationBuilder.Sql("INSERT INTO Roles VALUES ('aclavijo', '03-31-2020',null, null,'Administrator','Platform Administrator')");
            
            migrationBuilder.Sql("INSERT INTO Clasifications VALUES ('aclavijo', '03-31-2020',null, null,'Beaty Studio','Salon de belleza')");
            migrationBuilder.Sql("INSERT INTO Clasifications VALUES ('aclavijo', '03-31-2020',null, null,'Barber Shop','Barberia')");
            
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('aclavijo', '03-31-2020',null, null,'Cabello','Barberia')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('aclavijo', '03-31-2020',null, null,'Manos','Barberia')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('aclavijo', '03-31-2020',null, null,'Pies','Barberia')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('aclavijo', '03-31-2020',null, null,'Facial','Barberia')");
            
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Cepillado','',1,40000)");
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Corte','',1,10000)");
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Pedicure','',2,20000)");
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Manicure','',1,7000)");
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Depilado cejas','',0.5,8000)");
            migrationBuilder.Sql("INSERT INTO Services VALUES ('aclavijo', '03-31-2020',null, null,'Depilado facial','',0.5,10000)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Roles");
            migrationBuilder.Sql("TRUNCATE TABLE Clasifications");
            migrationBuilder.Sql("TRUNCATE TABLE Categories");
            migrationBuilder.Sql("TRUNCATE TABLE Services");
        }
    }
}
