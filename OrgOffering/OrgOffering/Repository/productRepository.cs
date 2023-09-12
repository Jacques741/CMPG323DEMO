using Microsoft.AspNetCore.Mvc;
using OrgOffering.Data;
using OrgOffering.Models;
using System.Threading.Channels;

namespace OrgOffering.Repository
{
    public class ProductRepository
    {
        protected readonly Demo323Context _context = new Demo323Context();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }


}
