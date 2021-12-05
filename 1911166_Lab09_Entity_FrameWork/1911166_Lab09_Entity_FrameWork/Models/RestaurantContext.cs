﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_Lab09_Entity_FrameWork.Models
{
	 public class RestaurantContext : DbContext
	 {
		  public DbSet<Category> Categories { get; set; }
		  public DbSet<Food> Foods { get; set; }
		  protected override void OnModelCreating(DbModelBuilder modelBuilder)
		  {
				modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

				modelBuilder.Entity<Food>()
					 .HasRequired(x => x.Category)
					 .WithMany()
					 .HasForeignKey(x => x.FoodCategoryId)
					 .WillCascadeOnDelete(true);

		  }
	 }
}
