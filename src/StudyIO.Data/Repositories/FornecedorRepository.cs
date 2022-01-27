using Microsoft.EntityFrameworkCore;
using StudyIO.Business.Interfaces;
using StudyIO.Business.Models;
using StudyIO.Data.Context;
using System;
using System.Threading.Tasks;

namespace StudyIO.Data.Repositories
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                 .Include(f => f.Produtos)
                 .Include(f => f.Endereco).FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}