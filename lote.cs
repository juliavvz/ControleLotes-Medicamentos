using System;

public class Lote
{
    private int id;
    private int qtde;
    private DateTime venc;

    public Lote() { }

    public Lote(int id, int qtde, DateTime venc)
    {
        this.id = id;
        this.qtde = qtde;
        this.venc = venc;
    }

    public int GetId() => id;
    public int GetQtde() => qtde;
    public void SetQtde(int qtde) => this.qtde = qtde;

    public override string ToString()
    {
        return id + "-" + qtde + "-" + venc.ToShortDateString();
    }
}
