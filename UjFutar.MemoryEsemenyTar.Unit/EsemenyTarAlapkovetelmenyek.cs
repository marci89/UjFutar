using UjFutar.EsemenyTar.Api;

namespace UjFutar.MemoryEsemenyTar.Unit;

using DeepEqual.Syntax;
using NUnit.Framework;

[TestFixture(typeof(MemoryEsemenyTar))]
public class EsemenyTarAlapkovetelmenyek<TEsemenyTar> where TEsemenyTar : IEsemenyTar, new()
{
    private readonly IEsemenyTar _esemenyTar = new TEsemenyTar();

    [Test]
    public void EsemenyTarbaEsemenytLehetMenteni()
    {
        var esemeny = new TesztEsemeny1() { Azonosito = "123" };

        _esemenyTar.Ment(new List<Esemeny>() { esemeny });
    }

    [Test]
    public void EsemenyTarbaMentettEsemenyReszleteiMegegyeznekAMenteniKivantEsemenyReszleteivel()
    {
        var azonosito = "E456";
        var esemeny = new TesztEsemeny2()
        {
            Azonosito = azonosito,
            Tartalom = "EsemenyReszletekTartalomÁrvíztűrőTükörFútógép",
        };

        _esemenyTar.Ment(new List<Esemeny>() { esemeny });

        var mentettEsemeny = _esemenyTar.Esemenyek(azonosito).Single();
        mentettEsemeny.Reszletek.ShouldDeepEqual(esemeny);
    }

    [Test]
    public void EsemenyekSorszamozasaEgyAzonositohozNullavalKezdodoEgyesevelNovekvo()
    {
        var azonositok = new[] { "a98456", "f65489" };
        var esemeny1 = new TesztEsemeny1() { Azonosito = azonositok[0] };
        var esemeny2 = new TesztEsemeny1() { Azonosito = azonositok[1] };

        _esemenyTar.Ment(new List<Esemeny>() { esemeny1, esemeny2, esemeny2, esemeny1, esemeny2, esemeny1 });

        foreach (var azonosito in azonositok)
        {
            NullatolNovekvo(_esemenyTar.Esemenyek(azonosito));
        }

        void NullatolNovekvo(IReadOnlyList<MentettEsemeny> esemenyek)
        {
            for (var i = 0; i < esemenyek.Count; i++)
            {
                Assert.That(esemenyek[i].EsemenyPozicio.Sorszam, Is.EqualTo(i));
            }
        }
    }

    [Test]
    public void OsszesEsemenyGlobalisPozicioSzerintNovekvoSorrendbenMentodikEsIgyIsKapjukVissza()
    {
        var esemeny1 = new TesztEsemeny1() { Azonosito = "a98456" };
        var esemeny2 = new TesztEsemeny1() { Azonosito = "f65489" };

        _esemenyTar.Ment(new List<Esemeny>() { esemeny1, esemeny2, esemeny2, esemeny1, esemeny2, esemeny1 });

        var osszesEsemeny = _esemenyTar.OsszesEsemeny();

        foreach (var par in osszesEsemeny.Skip(1).Zip(osszesEsemeny))
        {
            Assert.That(par.First.EsemenyPozicio.GlobalisPozicio, Is.GreaterThan(par.Second.EsemenyPozicio.GlobalisPozicio));
        }
    }
}