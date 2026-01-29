using System;

namespace Core.Entities;

public class Product : BaseEntity
{
        // public (accessible everywhere), private (accessible only inside the class), 
        // protected accessible by the class and related( herited classes)
        // int kind of return , { get; set; } getters and setters
        // required to get rid of non-nullable error on strings
        
        public required string Name  {get;set;}
        public required string Description  {get;set;}

        public decimal Price { get; set; }

         public required string PictureUrl  {get;set;}
         public  required string Type  {get;set;}
         public required string Brand  {get;set;}
         public int QuantityInStock  {get;set;}

        

}
