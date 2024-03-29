﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatienceShoppingPlatform.Context;

namespace PatienceShoppingPlatform.Migrations
{
    [DbContext(typeof(ShoppingItemsDbContext))]
    [Migration("20191222160433_ShoppingItemsContext")]
    partial class ShoppingItemsContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatienceShoppingPlatform.DataAccess.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRemoved")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Nondumiso Lunga",
                            DateCreated = new DateTime(2019, 11, 26, 18, 4, 32, 763, DateTimeKind.Local).AddTicks(7050),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "V-Neck man t-shirt",
                            ModifiedBy = "System Administrator",
                            Name = "Plain white summer T-shirt",
                            Status = "Instock"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Prince Lunga",
                            DateCreated = new DateTime(2019, 10, 28, 18, 4, 32, 772, DateTimeKind.Local).AddTicks(2391),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Young boys blue jeans",
                            ModifiedBy = " ",
                            Name = "Blue Jeams Short",
                            RemovedBy = " ",
                            Status = "Instock"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Prince Lunga",
                            DateCreated = new DateTime(2019, 10, 18, 18, 4, 32, 772, DateTimeKind.Local).AddTicks(2518),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Young girls blue jeans",
                            ModifiedBy = " ",
                            Name = "Blue Jeams Short skirrt",
                            RemovedBy = " ",
                            Status = "Instock"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
