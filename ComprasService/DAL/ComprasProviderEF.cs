﻿using ComprasService.Data;
using ComprasService.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprasService.DAL
{
    public class ComprasProviderEF : IComprasProvider
    {
        readonly DesignTimeOrderContextFactory factoriaDeContextos = new();
        private readonly OrderContext _context;

        public ComprasProviderEF()
        {
            string[] args = new string[1];
            _context = factoriaDeContextos.CreateDbContext(args);
        }
        public async Task<ICollection<Order>?> GetAsync(int proveedorId)
        {
            var orders = _context.Orders.Include("Items").Where(x=>x.ProveedoresId==proveedorId).ToList();
            if (orders is not null)
            {
                return await Task.Run(()=>orders);
            }
            return null;
        }
    }
}
