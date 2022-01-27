using Microsoft.EntityFrameworkCore;
using StudyIO.Business.Interfaces;
using StudyIO.Business.Models;
using StudyIO.Data.Context;
using System;
using System.Threading.Tasks;

namespace StudyIO.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}