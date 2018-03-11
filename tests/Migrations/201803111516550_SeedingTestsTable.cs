namespace tests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using tests.Persistence;

    public partial class SeedingTestsTable : DbMigration
    {
        

        public override void Up()
        {
            Sql("INSERT INTO Tests VALUES ('История, 10 класс', 'История', '11.03.2018')");
            Sql("INSERT INTO Questions VALUES (1, 1, 'В каком году была крещена Киевская Русь?', '1988', '988', '1112', '2015', 2)");
            Sql("INSERT INTO Questions VALUES (1, 2, 'В каком году родился Ленин?', '1780', '1919', '1921', '1870', 4)");
            Sql("INSERT INTO Questions VALUES (1, 3, 'Как звали первого прездента СССР?', 'Владимир Путин', 'Никита Хрущёв', 'Владимир Ленин', 'Михаил Горбачев', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
