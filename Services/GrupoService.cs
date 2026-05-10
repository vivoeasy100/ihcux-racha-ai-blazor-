using RachaAiBlazor.Models;

namespace RachaAiBlazor.Services
{
    public class GrupoService
    {
        private List<Grupo> _grupos = new()
        {
            new Grupo { Nome = "República Central", Categoria = "Casa", ValorPendente = 450.50m, NoVermelho = true },
            new Grupo { Nome = "Churrasco de Domingo", Categoria = "Lazer", ValorPendente = 85.00m, NoVermelho = false },
            new Grupo { Nome = "Viagem Floripa", Categoria = "Viagem", ValorPendente = 1200.00m, NoVermelho = false },
            new Grupo { Nome = "Netflix & Internet", Categoria = "Contas", ValorPendente = 35.90m, NoVermelho = true }
        };

        public List<Grupo> GetGrupos() => _grupos;

        public decimal GetTotalAReceber() => _grupos.Where(g => !g.NoVermelho).Sum(g => g.ValorPendente);
        
        public decimal GetTotalAPagar() => _grupos.Where(g => g.NoVermelho).Sum(g => g.ValorPendente);

        public decimal GetSaldoGeral() => GetTotalAReceber() - GetTotalAPagar();
    }
}
