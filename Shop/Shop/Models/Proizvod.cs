using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models;

public class Proizvod
{
    public Guid Id { get; set; }

    public string Naziv { get; set; }

    public string Opis { get; set; }

    public string Kategorija { get; set; }

    public Guid ProizvodjacId { get; set; }

    public Guid DobavljacId { get; set; }

    public float Cena { get; set; }

    [ForeignKey(DobavljacId)]
    public virtual Dobavljac Dobavljac { get; set; }

    [ForeignKey(ProizvodjacId)]
    public virtual Proizvodjac Proizvodjac { get; set; }
}
