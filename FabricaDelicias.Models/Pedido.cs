﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaDelicias.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        
        public class Item
        {
            public int Ordem { get; set; }
            public Produto Produto { get; set; }
            public double Quantidade { get; set; }
            public decimal Preco { get; set; }
        }
    }
}