using Campeonato.Dominio;
using Campeonato.RepositorioADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato.Business.Logics
{
    public class PartidaBusiness
    {

        public List<Partida_Web> ObterPartida(string campeonato, string dataInicio, string dataFim, string rodada)
        {
            return PartidaDAO.ObterPartida(campeonato, dataInicio, dataFim, rodada);
        }

        public List<ResultadoPartida_Web> ObterPartidaResultado(string campeonato, string dataInicio, string dataFim, string rodada)
        {
            return PartidaDAO.ObterPartidaResultado(campeonato, dataInicio, dataFim, rodada);
        }

        public void InserirPartida(Partida_Web item)
        {
            PartidaDAO.InserirPartida(item);
        }

        public void RemovePartida(Partida_Web item)
        {
            PartidaDAO.RemovePartida(item);
        }

        public void AtualizaPartida(Partida_Web item)
        {
            PartidaDAO.AtualizaPartida(item);
        }

        public Partida_Web ObterPartidaId(int id)
        {
            return PartidaDAO.ObterPartidaId(id);
        }

    }
}
