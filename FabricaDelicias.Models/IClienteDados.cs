using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaDelicias.Models
{
    public interface IClienteDados
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(string Id);
        List<Cliente> ObterTodos();
        Cliente ObterPorId(string id);
        Cliente ObterPorCPF(string cpf);
    }
}
