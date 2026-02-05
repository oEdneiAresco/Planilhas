using Aldeia.Mercosul.Planilhas.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using IContainer = QuestPDF.Infrastructure.IContainer;
using Aldeia.Mercosul.Planilhas.Domain;

namespace Aldeia.Mercosul.Planilhas.Infra
{
    public class PdfGruposGenerator : IGeradorPdfGrupos<GrupoGridViewModel>
    {
        public void Gerar(IEnumerable<GrupoGridViewModel> grupos, string caminhoArquivo)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header().Text("LISTA DE GRUPOS").Bold().FontSize(16);

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(120); // CTG
                            columns.ConstantColumn(80);  // Cidade
                            columns.ConstantColumn(30);  // RT
                            columns.ConstantColumn(120); // Responsável
                            columns.ConstantColumn(140); // Email
                            columns.ConstantColumn(80);  // Contato
                            columns.RelativeColumn();    // Danças
                        });

                        table.Header(header =>
                        {
                            HeaderCell(header, "CTG");
                            HeaderCell(header, "CIDADE");
                            HeaderCell(header, "RT");
                            HeaderCell(header, "RESP.");
                            HeaderCell(header, "E-MAIL");
                            HeaderCell(header, "CONTATO");
                            HeaderCell(header, "DANÇAS");
                        });

                        foreach (var g in grupos)
                        {
                            Cell(table, g.Nome);
                            Cell(table, g.Cidade);
                            Cell(table, g.RT);
                            Cell(table, g.Responsavel);
                            Cell(table, g.Email);
                            Cell(table, g.Contato);
                            Cell(table, g.Dancas);
                        }
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text($"Gerado em {DateTime.Now:dd/MM/yyyy HH:mm}");
                });
            }).GeneratePdf(caminhoArquivo);
        }

        private static void HeaderCell(TableCellDescriptor header, string text)
            => header.Cell().Element(CellStyle).Text(text).Bold();

        private static void Cell(TableDescriptor table, string text)
            => table.Cell().Element(CellStyle).Text(text);

        private static IContainer CellStyle(IContainer container)
            => container.Border(1).Padding(4);
    }

}
