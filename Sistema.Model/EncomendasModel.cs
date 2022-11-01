using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
  public  class EncomendasModel
    {
        private int idencomenda;
        private int idorigem;
        private int idveiculo;
        private int identregador;
        private string nomeveiculo;
        private string placa;
        private string entregador;
        private string peso;
        private string numpacote;
        private string estentrega;
        private string cpf;
        private string destinatario;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private DateTime dataentrega;
        private DateTime datarota;
        private DateTime dataentrada;
        private string idsaida;

        public EncomendasModel()
        {

        }

        public int Idencomenda { get => idencomenda; set => idencomenda = value; }
        public int Idorigem { get => idorigem; set => idorigem = value; }
        public int Idveiculo { get => idveiculo; set => idveiculo = value; }
        public int Identregador { get => identregador; set => identregador = value; }
        public string Nomeveiculo { get => nomeveiculo; set => nomeveiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Entregador { get => entregador; set => entregador = value; }
        public string Peso { get => peso; set => peso = value; }
        public string Numpacote { get => numpacote; set => numpacote = value; }
        public string Estentrega { get => estentrega; set => estentrega = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
        public DateTime Dataentrega { get => dataentrega; set => dataentrega = value; }
        public DateTime Datarota { get => datarota; set => datarota = value; }
        public DateTime Dataentrada { get => dataentrada; set => dataentrada = value; }
        public string Idsaida { get => idsaida; set => idsaida = value; }

        public override bool Equals(object obj)
        {
            return obj is EncomendasModel model &&
                   idencomenda == model.idencomenda &&
                   idorigem == model.idorigem &&
                   idveiculo == model.idveiculo &&
                   identregador == model.identregador &&
                   nomeveiculo == model.nomeveiculo &&
                   placa == model.placa &&
                   entregador == model.entregador &&
                   peso == model.peso &&
                   numpacote == model.numpacote &&
                   estentrega == model.estentrega &&
                   cpf == model.cpf &&
                   destinatario == model.destinatario &&
                   logradouro == model.logradouro &&
                   complemento == model.complemento &&
                   bairro == model.bairro &&
                   cidade == model.cidade &&
                   uf == model.uf &&
                   cep == model.cep &&
                   dataentrega == model.dataentrega &&
                   datarota == model.datarota &&
                   dataentrada == model.dataentrada &&
                   idsaida == model.idsaida;
        }

        public override int GetHashCode()
        {
            int hashCode = 1186573959;
            hashCode = hashCode * -1521134295 + idencomenda.GetHashCode();
            hashCode = hashCode * -1521134295 + idorigem.GetHashCode();
            hashCode = hashCode * -1521134295 + idveiculo.GetHashCode();
            hashCode = hashCode * -1521134295 + identregador.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeveiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(placa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(entregador);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(peso);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(numpacote);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estentrega);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(destinatario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(logradouro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(uf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cep);
            hashCode = hashCode * -1521134295 + dataentrega.GetHashCode();
            hashCode = hashCode * -1521134295 + datarota.GetHashCode();
            hashCode = hashCode * -1521134295 + dataentrada.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(idsaida);
            return hashCode;
        }
    }

}
