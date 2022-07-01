using FluentMigrator;
using Serenity.Extensions;
using System;

namespace MealHisab.Migrations.MainDB
{
    [Migration(20220701_083810)]
    public class MainDB_20220701_083810_Initial : Migration
    {   
        public override void Up()
        {
            this.CreateTableWithId32("Person", "PersonId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("ContactNo").AsInt32().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));                 
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}