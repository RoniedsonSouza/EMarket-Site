// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public partial class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime DataTransacao { get; set; }
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QtdAnterior { get; set; }
        public int QuantidadeVendida { get; set; }
        public string NomeCaixa { get; set; }
    }
}