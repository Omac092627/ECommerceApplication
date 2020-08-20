﻿using ECommerce_Application.Data;
using ECommerce_Application.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Application.Models.Services
{
    public class CartService : ICart
    {
        private readonly StoreDbContext _context;
        private readonly IProduct _product;

        public CartService(StoreDbContext context, IProduct product)
        {
            _context = context;
            _product = product;
        }
        public async Task<Cart> CreateCart(Cart cart)
        {
            _context.Entry(cart).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return cart;
        }

        public async Task DeleteCart(int id)
        {
            Cart cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == id);
            _context.Entry(cart).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Cart> GetCart(string email)
        {
            var cart = await _context.Carts
                .Where(x => x.UserEmail == email)
                .FirstOrDefaultAsync();

            return cart;
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
            var updatedCart = await _context.Carts.FindAsync(cart.Id);
            updatedCart = cart;
           

            _context.Entry(updatedCart).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return cart;
        }
    }
}