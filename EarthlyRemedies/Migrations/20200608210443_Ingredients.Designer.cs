﻿// <auto-generated />
using EarthlyRemedies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EarthlyRemedies.Migrations
{
    [DbContext(typeof(EarthlyRemediesContext))]
    [Migration("20200608210443_Ingredients")]
    partial class Ingredients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EarthlyRemedies.Models.Remedy", b =>
                {
                    b.Property<int>("RemedyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ailment")
                        .HasMaxLength(30);

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Details")
                        .IsRequired();

                    b.Property<string>("Ingredients");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RemedyId");

                    b.ToTable("Remedies");

                    b.HasData(
                        new
                        {
                            RemedyId = 10,
                            Ailment = "chest congestion",
                            Category = "respiratory",
                            Details = "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.",
                            Ingredients = "L-Acetyl Cysteine",
                            Name = "Mucus Melter"
                        },
                        new
                        {
                            RemedyId = 11,
                            Ailment = "dandruff",
                            Category = "skin",
                            Details = "Castor oil rubbed into the scalp, every night before bed, for one week.",
                            Ingredients = "castor oil",
                            Name = "Dandruff Buster"
                        },
                        new
                        {
                            RemedyId = 3,
                            Ailment = "dry eyes",
                            Category = "eyes",
                            Details = "Mega doses of Omega 3s for LIFE!!!!",
                            Ingredients = "Omega 3",
                            Name = "Dry Eye Relief"
                        },
                        new
                        {
                            RemedyId = 4,
                            Ailment = "foot fungus",
                            Category = "skin",
                            Details = "Soak the affected area in apple cider vinegar twice a day until cured",
                            Ingredients = "apple cider vinegar",
                            Name = "Fungus Foiler"
                        },
                        new
                        {
                            RemedyId = 5,
                            Ailment = "digestive illness",
                            Category = "GI",
                            Details = "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.",
                            Ingredients = "ginger, vodka",
                            Name = "Polish Tummy Cure"
                        },
                        new
                        {
                            RemedyId = 6,
                            Ailment = "sunburn",
                            Category = "skin",
                            Details = "apply earl grey tea to the affected area 5 times a day until burn goes away",
                            Ingredients = "tea",
                            Name = "Sunburn salve"
                        },
                        new
                        {
                            RemedyId = 7,
                            Ailment = "heartburn",
                            Category = "GI",
                            Details = "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.",
                            Ingredients = "lemon",
                            Name = "Heartburn Helper"
                        },
                        new
                        {
                            RemedyId = 8,
                            Ailment = "cough",
                            Category = "respiratory",
                            Details = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.",
                            Ingredients = "tea tree oil, peppermint, eucalyptus",
                            Name = "Nighttime Salve"
                        },
                        new
                        {
                            RemedyId = 9,
                            Ailment = "eye obstruction",
                            Category = "eyes",
                            Details = "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction",
                            Ingredients = "",
                            Name = "Eye obsruction removal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}