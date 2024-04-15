using AC3;
using CsvHelper.Configuration;

public class ConsumAiguaMap : ClassMap<ConsumAigua>
{
    public ConsumAiguaMap()
    {
        Map(m => m.Any).Name("Any");
        Map(m => m.CodiComarca).Name("Codi Comarca");
        Map(m => m.Comarca).Name("Comarca");
        Map(m => m.Poblacio).Name("Població");
        Map(m => m.DomXarxa).Name("Domèstic Xarxa");
        Map(m => m.ActEcon).Name("Activitats econòmiques");
        Map(m => m.Total).Name("Total");
        Map(m => m.ConsDomPerCapita).Name("Consum domèstic per càpita");
    }
}