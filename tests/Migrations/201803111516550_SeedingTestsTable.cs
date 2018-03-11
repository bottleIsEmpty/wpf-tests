namespace tests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using tests.Persistence;

    public partial class SeedingTestsTable : DbMigration
    {
        

        public override void Up()
        {
            Sql("INSERT INTO Tests VALUES ('�������, 10 �����', '�������', '11.03.2018')");
            Sql("INSERT INTO Questions VALUES (1, 1, '� ����� ���� ���� ������� �������� ����?', '1988', '988', '1112', '2015', 2)");
            Sql("INSERT INTO Questions VALUES (1, 2, '� ����� ���� ������� �����?', '1780', '1919', '1921', '1870', 4)");
            Sql("INSERT INTO Questions VALUES (1, 3, '��� ����� ������� ��������� ����?', '�������� �����', '������ ������', '�������� �����', '������ ��������', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
