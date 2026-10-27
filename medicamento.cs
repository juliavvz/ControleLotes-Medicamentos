using System.Collections.Generic;

public class Medicamento
{
    private int id;
    private string nome;
    private string laboratorio;
    private Queue<Lote> lotes;

    public Medicamento()
    {
        lotes = new Queue<Lote>();
    }

    public Medicamento(int id, string nome, string laboratorio)
    {
        this.id = id;
        this.nome = nome;
        this.laboratorio = laboratorio;
        this.lotes = new Queue<Lote>();
    }

    public int GetId() => id;

    public int qtdeDisponivel()
    {
        int total = 0;
        foreach (var l in lotes)
        {
            total += l.GetQtde();
        }
        return total;
    }

    public void comprar(Lote lote)
    {
        lotes.Enqueue(lote);
    }

    public bool vender(int qtdeDesejada)
    {
        if (qtdeDisponivel() < qtdeDesejada) return false;

        int falta = qtdeDesejada;
        while (falta > 0 && lotes.Count > 0)
        {
            Lote atual = lotes.Peek();
            if (atual.GetQtde() > falta)
            {
                atual.SetQtde(atual.GetQtde() - falta);
                falta = 0;
            }
            else
            {
                falta -= atual.GetQtde();
                lotes.Dequeue();
            }
        }
        return true;
    }

    public Queue<Lote> GetLotes() => lotes;

    public override string ToString()
    {
        return id + "-" + nome + "-" + laboratorio + "-" + qtdeDisponivel();
    }

    public override bool Equals(object obj)
    {
        if (obj is Medicamento outro)
        {
            return this.id == outro.id;
        }
        return false;
    }

    public override int GetHashCode() => id.GetHashCode();
}
