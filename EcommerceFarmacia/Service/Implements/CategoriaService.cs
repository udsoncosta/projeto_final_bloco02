﻿using EcommerceFarmacia.Data;
using Microsoft.EntityFrameworkCore;
using EcommerceFarmacia.Model;

namespace EcommerceFarmacia.Service.Implements
{
    public class CategoriaService : ICategoriaService
    {
        public readonly AppDbContext _context;

        public CategoriaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _context.Categorias
                .Include(c => c.Produto)
                .ToListAsync();

        }

        public async Task<Categoria?> GetById(long id)
        {
            try
            {
                var Categoria = await _context.Categorias
                     .Include(c => c.Produto)
                     .FirstAsync(i => i.Id == id);

                return Categoria;
            }
            catch
            {
                return null;
            }

        }
        public async Task<IEnumerable<Categoria>> GetByTipo(string tipo)
        {
            var Categoria = await _context.Categorias
                .Include(c => c.Produto)
                .Where(c => c.Tipo.Contains(tipo))
                .ToListAsync();

            return Categoria;
        }


        public async Task<Categoria?> Update(Categoria categoria)
        {
            var CategoriaUpdate = await _context.Categorias.FindAsync(categoria.Id);

            if (CategoriaUpdate is null)
                return null;

            _context.Entry(CategoriaUpdate).State = EntityState.Detached;
            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return categoria;
        }

        public async Task<Categoria?> Create(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return categoria;
        }

        public async Task Delete(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }

    }
}