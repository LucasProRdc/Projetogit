using System;
namespace Series
{
    public class Serie :Base
    {


private int Ano { get; set; }
private string Titulo { get; set; }
private string Descricao { get; set; }
private Genero Generoo { get; set; }
private bool Excluido {get; set;}

public Serie(int id, Genero genero, string titulo, string descricao, int ano)
{
    this.Ano=ano;
this.Titulo=titulo;
this.Descricao=titulo;
this.Generoo= genero;
this.Id=id;
 this.Excluido = false;


}
public override string ToString()
{
   string retorno="";

retorno += "Genêro: " + this.Generoo + Environment.NewLine;
retorno += "Titulo: " + this.Titulo + Environment.NewLine;
retorno += "Descrição: " + this.Descricao + Environment.NewLine;
retorno += "Ano: " + this.Ano + Environment.NewLine;
 retorno += "Excluido: " + this.Excluido;
return retorno;

}
           public string reTitulo(){
             return this.Titulo;
         }

          public int reId(){
             return this.Id;
         }

          public void Excluir() {
            this.Excluido = true;
        }

         public bool retornaExcluido()
		{
			return this.Excluido;
		}  
         
    }

}