using System.Configuration;
using ClosedXML;

namespace Aldeia.Mercosul.Planilhas.Infra
{
    public class RepositorioExcel
    {
        // 1. Obter o template da connection string do App.config
        private string connectionStringTemplate = ConfigurationManager.ConnectionStrings["ExcelConnection"].ConnectionString;
        private string spreadSheet = ConfigurationManager.ConnectionStrings["SheetName"].ConnectionString;
        private string filePath = string.Empty;

        public RepositorioExcel(string caminhoDoArquivo)
        {
            filePath = caminhoDoArquivo;
        }

        // TODO: CRIAR MÉTOD PARA PEGAR CADA ABA/SHEET DA PLANILHA

        // TODO: VERIFICAR COMO UTILIZAR O APP.CONFIG PARA DEIXAR O QUE FOR PRECISO DINAMICO

        // TODO: REVISAR OS MODELOS CRIADOS

        // TODO: REVISAR OS FORMULÁRIOS CRIADOS PARA ATENNDER DUAS PLANILHAS: GRUPOS E INDIVIDUAIS

        // TODO: CONCEITO DO SISTEMA: TEREMOS SOMENTE DUAS PLANILHAS, GRUPOS E INDIVIDUAIS

        // TODO: GRUPOS TERÃO OS SEGUINTES CAMPOS: CTG; CIDADE; RT; RESPONSÁVEL; E-MAIL; CONTATO; DANÇAS

        // TODO: INDIVIDUAIS TERÃO OS SEGUINTES CAMPOS: PARTICIPANTE; ENTIDADE; CIDADE 


    }
}

