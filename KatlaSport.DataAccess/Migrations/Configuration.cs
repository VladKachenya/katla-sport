﻿using System;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using KatlaSport.DataAccess.CustomerCatalogue;
using KatlaSport.DataAccess.EmployeeCatalogue;
using KatlaSport.DataAccess.ProductCatalogue;
using KatlaSport.DataAccess.ProductStore;
using KatlaSport.DataAccess.ProductStoreHive;

namespace KatlaSport.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        /*
        drop table dbo.product_store_items
        drop table dbo.product_hive_section_categories
        drop table dbo.catalogue_products
        drop table dbo.product_categories
        drop table dbo.product_hive_sections
        drop table dbo.product_hives
        drop table dbo.customer_records
        drop table dbo.employee_records
        drop table dbo.__MigrationHistory

        select * from dbo.catalogue_products
        select * from dbo.product_categories

        select * from dbo.product_hive_sections
        select * from dbo.product_hives
        */

        public Configuration()
        {
            ContextKey = "ApplicationData";
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedDatabase(context);
        }

        [Conditional("DEBUG")]
        private void SeedDatabase(ApplicationDbContext context)
        {
            var timestamp = DateTime.UtcNow;
            var creatorId = 1;

            context.ProductCategories.AddOrUpdate(
                i => i.Id,
                new ProductCategory
                {
                    Id = 1,
                    Name = "Running shoes",
                    Code = "RUNSH",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new ProductCategory
                {
                    Id = 2,
                    Name = "Running clothing",
                    Code = "RUNCL",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new ProductCategory
                {
                    Id = 3,
                    Name = "Bicycling",
                    Code = "BICYC",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                });

            context.CatalogueProducts.AddOrUpdate(
                i => i.Id,
                new CatalogueProduct
                {
                    Id = 1,
                    Name = "Kyak Men Shoes",
                    Code = "KYME1",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new CatalogueProduct
                {
                    Id = 2,
                    Name = "Top-top Men Shoes",
                    Code = "TTME1",
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new CatalogueProduct
                {
                    Id = 3,
                    Name = "Abibas T-Shirt",
                    Code = "ABIT1",
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new CatalogueProduct
                {
                    Id = 4,
                    Name = "Pedali 360 Bicycle",
                    Code = "PBYC1",
                    CategoryId = 3,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new CatalogueProduct
                {
                    Id = 5,
                    Name = "Pedali 120",
                    Code = "PBYC2",
                    CategoryId = 3,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                });

            context.StoreHives.AddOrUpdate(
                i => i.Id,
                new StoreHive
                {
                    Id = 1,
                    Name = "Gorka Minsk",
                    Address = "Minsk, Chaveza-30",
                    Code = "HIVE1",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHive
                {
                    Id = 2,
                    Name = "Shabany Minsk",
                    Address = "Minsk, Zarechnaya-47",
                    Code = "HIVE2",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHive
                {
                    Id = 3,
                    Name = "Tugolitsa Bobruisk",
                    Address = "Bobruisk, Vanceti-99",
                    Code = "HIVE3",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                });

            context.HiveSections.AddOrUpdate(
                i => i.Id,
                new StoreHiveSection
                {
                    Id = 1,
                    Name = "MSQ #1",
                    StoreHiveId = 1,
                    Code = "HSE11",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHiveSection
                {
                    Id = 2,
                    Name = "MSQ #2",
                    StoreHiveId = 1,
                    Code = "HSE12",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHiveSection
                {
                    Id = 3,
                    Name = "MSQ #3",
                    StoreHiveId = 2,
                    Code = "HSE21",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHiveSection
                {
                    Id = 4,
                    Name = "MSQ #4",
                    StoreHiveId = 2,
                    Code = "HSE22",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHiveSection
                {
                    Id = 5,
                    Name = "BBR #1",
                    StoreHiveId = 3,
                    Code = "HSE31",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreHiveSection
                {
                    Id = 6,
                    Name = "BBR #2",
                    StoreHiveId = 3,
                    Code = "HSE32",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                });

            context.SectionCategories.AddOrUpdate(
                i => new { i.ProductCategoryId, i.StoreHiveSectionId },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 1,
                    StoreHiveSectionId = 1
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 1,
                    StoreHiveSectionId = 3
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 1,
                    StoreHiveSectionId = 5
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 2,
                    StoreHiveSectionId = 1
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 2,
                    StoreHiveSectionId = 3
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 2,
                    StoreHiveSectionId = 5
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 3,
                    StoreHiveSectionId = 2
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 3,
                    StoreHiveSectionId = 4
                },
                new StoreHiveSectionCategory
                {
                    ProductCategoryId = 3,
                    StoreHiveSectionId = 6
                });

            context.StoreItems.AddOrUpdate(
                i => i.Id,
                new StoreItem // #1
                {
                    Id = 1,
                    Quantity = 10,
                    HiveSectionId = 1,
                    ProductId = 1
                },
                new StoreItem
                {
                    Id = 2,
                    Quantity = 1,
                    HiveSectionId = 3,
                    ProductId = 1
                },
                new StoreItem
                {
                    Id = 3,
                    Quantity = 0,
                    HiveSectionId = 5,
                    ProductId = 1
                },
                new StoreItem // #2
                {
                    Id = 4,
                    Quantity = 5,
                    HiveSectionId = 1,
                    ProductId = 2
                },
                new StoreItem
                {
                    Id = 5,
                    Quantity = 100,
                    HiveSectionId = 3,
                    ProductId = 2
                },
                new StoreItem
                {
                    Id = 6,
                    Quantity = 10,
                    HiveSectionId = 5,
                    ProductId = 2
                },
                new StoreItem // #3
                {
                    Id = 7,
                    Quantity = 10,
                    HiveSectionId = 1,
                    ProductId = 3
                },
                new StoreItem
                {
                    Id = 8,
                    Quantity = 10,
                    HiveSectionId = 3,
                    ProductId = 3
                },
                new StoreItem
                {
                    Id = 9,
                    Quantity = 10,
                    HiveSectionId = 5,
                    ProductId = 3
                },
                new StoreItem // #4
                {
                    Id = 13,
                    Quantity = 4,
                    HiveSectionId = 2,
                    ProductId = 4
                },
                new StoreItem
                {
                    Id = 14,
                    Quantity = 0,
                    HiveSectionId = 4,
                    ProductId = 4
                },
                new StoreItem
                {
                    Id = 15,
                    Quantity = 0,
                    HiveSectionId = 6,
                    ProductId = 4
                });

            context.Customers.AddOrUpdate(
                i => i.Id,
                new Customer
                {
                    Id = 1,
                    Name = "Oleg Alexandrov",
                    Address = "Minsk, Goretskogo-31",
                    Phone = "+37529-4345834"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Gleb Pavlov",
                    Address = "Minsk, Cechota-21",
                    Phone = "+37529-3282943"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Sergey Tatarinov",
                    Address = "Borisov, 100 let BSSR",
                    Phone = "+37529-9834782"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Alexander Alexandrov",
                    Address = "Brest, Repina-7",
                    Phone = "+37529-9832872"
                });

            context.Positions.AddOrUpdate(
                i => i.Id,
                new EmployeePosition // #1
                {
                    Id = 1,
                    Name = "Head of company"
                },
                new EmployeePosition // #2
                {
                    Id = 2,
                    Name = "Head of sales"
                },
                new EmployeePosition // #3
                {
                    Id = 3,
                    Name = "Head of hives"
                },
                new EmployeePosition // #4
                {
                    Id = 4,
                    Name = "Head of product"
                },
                new EmployeePosition // #5
                {
                    Id = 5,
                    Name = "Loader"
                });

            context.Employees.AddOrUpdate(
                i => i.Id,
                new StoreEmployee // #1
                {
                    Id = 1,
                    FirstName = "Arkady",
                    LastName = "Tropkin",
                    EmployeePositionId = 1,
                    Email = "Tropkin@email.com",
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #2
                {
                    Id = 2,
                    FirstName = "Sergey",
                    LastName = "Pobegimov",
                    EmployeePositionId = 2,
                    Email = "Pobegimov@email.com",
                    BossId = 1,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #3
                {
                    Id = 3,
                    FirstName = "Gennady",
                    LastName = "Tsvetkov",
                    EmployeePositionId = 3,
                    Email = "Tsvetkov@email.com",
                    BossId = 1,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #4
                {
                    Id = 4,
                    FirstName = "Arthur",
                    LastName = "Pies",
                    EmployeePositionId = 4,
                    Email = "Pies@email.com",
                    BossId = 1,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #5
                {
                    Id = 5,
                    FirstName = "Sergey",
                    LastName = "Petrovich",
                    EmployeePositionId = 5,
                    Email = "Petrovich@email.com",
                    BossId = 3,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #6
                {
                    Id = 6,
                    FirstName = "Sergey",
                    LastName = "Stepanyuk",
                    EmployeePositionId = 5,
                    Email = "Petrovich@email.com",
                    BossId = 3,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                },
                new StoreEmployee // #7
                {
                    Id = 7,
                    FirstName = "Sergey",
                    LastName = "Ulyukayev",
                    EmployeePositionId = 5,
                    Email = "Ulyukayev@email.com",
                    BossId = 3,
                    IsDeleted = false,
                    CreatedBy = creatorId,
                    LastUpdatedBy = creatorId,
                    LastUpdated = timestamp
                });
        }
    }
}
