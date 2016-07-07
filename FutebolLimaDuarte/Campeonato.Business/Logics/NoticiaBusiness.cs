using Campeonato.Dominio;
using Campeonato.RepositorioADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato.Business.Logics
{
    public class NoticiaBusiness
    {

        public List<Noticia_Web> ObterNoticia()
        {
            return NoticiaDAO.ObterNoticia();
        }

        public void InserirNoticia(Noticia_Web item)
        {
            NoticiaDAO.InserirNoticia(item);
        }

        public void RemoveNoticia(Noticia_Web item)
        {
            NoticiaDAO.RemoveNoticia(item);
        }

        public void AtualizaNoticia(Noticia_Web item)
        {
            NoticiaDAO.AtualizaNoticia(item);
        }

    }
}
