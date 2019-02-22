﻿// <auto-generated />
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeShop.Migrations
{
    [DbContext(typeof(CoffeeShopDbContext))]
    partial class CoffeeShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeShop.Models.Coffee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("URL");

                    b.HasKey("ID");

                    b.ToTable("Coffee");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Strong or bold coffee (sometimes espresso) mixed with scalded milk",
                            Name = "Latte",
                            Price = 4.00m,
                            URL = "../coffee/latte"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Is a type of coffee drink prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from traditionally brewed coffee.",
                            Name = "Americano",
                            Price = 3.00m,
                            URL = "../coffee/americano"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Is a full-flavored, concentrated form of coffee that is served in “shots.” It is made by forcing pressurized, hot water through very finely ground coffee beans.",
                            Name = "Expresso",
                            Price = 1.00m,
                            URL = "../coffee/expresso"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Goes through a brewing process to become better",
                            Name = "Cold Brew",
                            Price = 5.00m,
                            URL = "../coffee/coldbrew"
                        },
                        new
                        {
                            ID = 5,
                            Description = "",
                            Name = "Machiatto",
                            Price = 3.50m,
                            URL = "../coffee/machiatto"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Like a caffe latte, it is typically one third espresso and two thirds steamed milk, but a portion of chocolate is added",
                            Name = "Mocha",
                            Price = 4.50m,
                            URL = "../coffee/mocha"
                        },
                        new
                        {
                            ID = 7,
                            Description = " Is a cocktail consisting of hot coffee, Irish whiskey, and sugar, stirred, and topped with cream. The coffee is drunk through the cream.",
                            Name = "Irish Coffee",
                            Price = 7.00m,
                            URL = "../coffee/irishcoffee"
                        },
                        new
                        {
                            ID = 8,
                            Description = "It is similar to an Americano, but with a stronger aroma and taste. A long black is made by pouring a double-shot of espresso or ristretto over hot water",
                            Name = "Long Black",
                            Price = 3.75m,
                            URL = "../coffee/longblack"
                        },
                        new
                        {
                            ID = 9,
                            Description = "A flat white is a coffee drink consisting of espresso with microfoam It is comparable to a latte, but smaller in volume and with less microfoam",
                            Name = "Flat White",
                            Price = 5.75m,
                            URL = "../coffee/flatwhite"
                        },
                        new
                        {
                            ID = 10,
                            Description = " cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with an espresso shot and steamed milk foam. Variations of the drink involve the use of cream instead of milk, and flavoring with cinnamon or chocolate powder",
                            Name = "Cappuccino",
                            Price = 4.00m,
                            URL = "../coffee/cappuccino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
