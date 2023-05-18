using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_produtos
{
    public class Produto
    {
        

public string Nome { get; set; }


public float Preco { get; set; }




public bool Promocao { get; set; }



public Produto(string nome,float preco, bool promocao)

{

    Nome= nome;
    Preco= preco;
    Promocao= promocao;




}


















    }
}