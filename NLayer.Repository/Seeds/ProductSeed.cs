using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
	public class ProductSeed : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData(new Product
			{
				Id = 1,
				CategoryId = 1,
				Name = "product-1",
				Stock = 20,
				Price = 20,
				CreatedDate = DateTime.Now,

			},
			new Product
			{
				Id = 1,
				CategoryId = 2,
				Name = "product-2",
				Stock = 20,
				Price = 60,
				CreatedDate = DateTime.Now,

			},
			new Product
			{
				Id = 1,
				CategoryId = 1,
				Name = "product-3",
				Stock = 20,
				Price = 50,
				CreatedDate = DateTime.Now,

			},
			new Product
			{
				Id = 1,
				CategoryId = 3,
				Name = "product-4",
				Stock = 20,
				Price = 20,
				CreatedDate = DateTime.Now,

			}
			);
		}
	}
}
