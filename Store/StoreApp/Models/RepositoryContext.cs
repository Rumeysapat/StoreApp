using Microsoft.EntityFrameworkCore;

public class RepositoryContext:DbContext{

public DbSet<Product> Products {get; set;}



}