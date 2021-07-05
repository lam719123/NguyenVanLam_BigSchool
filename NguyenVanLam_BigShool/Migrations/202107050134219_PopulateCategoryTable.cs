namespace NguyenVanLam_BigShool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME ) VALUES (1, 'development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME ) VALUES (2, 'business')");
            Sql("INSERT INTO CATEGORIES (ID,NAME ) VALUES (3, 'marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
