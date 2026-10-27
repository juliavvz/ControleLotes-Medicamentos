using System.Collections.Generic;

public class Medicamentos
{
    private List<Medicamento> listaMedicamentos;

    public Medicamentos()
    {
        listaMedicamentos = new List<Medicamento>();
    }

    public void adicionar(Medicamento medicamento)
    {
        listaMedicamentos.Add(medicamento);
    }

    public bool deletar(Medicamento medicamento)
    {
        Medicamento m = pesquisar(medicamento);
        if (m.GetId() != 0 && m.qtdeDisponivel() == 0)
        {
            listaMedicamentos.Remove(m);
            return true;
        }
        return false;
    }

    public Medicamento pesquisar(Medicamento medicamento)
    {
        foreach (var m in listaMedicamentos)
        {
            if (m.Equals(medicamento)) return m;
        }
        return new Medicamento(); // Objeto vazio
    }

    public List<Medicamento> GetLista() => listaMedicamentos;
}
